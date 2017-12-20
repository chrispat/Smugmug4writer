using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.IO;
using Smugmug;

namespace SmugMug4writer
{
    public partial class InsertSmugMugImageForm : Form
    {
        private SmugmugFacade smugMug = null;
        private ImageSize m_ImageSize = ImageSize.Medium;
        private bool _images = false;
        private InsertOptions insertOption = InsertOptions.Image;

        #region Public Properties
        
        public string Alignment
        {
            get { return dropDownAlignment.Text.Trim(); }
        }
        public bool EnableHyperLink
        {
            get { return checkHyperLink.Checked; }
        }
        public string CssClass
        {
            get { return textBoxCssClass.Text.Trim(); }
        }

        public string BorderThickness
        {
            get { return borderThickness.Value.ToString().Trim(); }
        }

        public string HorizontalPadding
        {
            get { return horizontalPadding.Value.ToString().Trim(); }
        }

        public string VerticalPadding
        {
            get { return verticalPadding.Value.ToString().Trim(); }
        }

        public Smugmug.Album SelectedAlbum
        {
            get
            {
                return this.albumList.SelectedItem as Smugmug.Album;
            }
        }

        public Smugmug.Image[] SelectedPhotos
        {
            get
            {
                Smugmug.Image[] images = new Smugmug.Image[this.retrievedImageList.SelectedIndices.Count];
                for (int i = 0; i < this.retrievedImageList.SelectedIndices.Count; i++)
                {
                    images[i] = (Smugmug.Image)retrievedImageList.Items[retrievedImageList.SelectedIndices[i]].Tag;
                }

                return images;
            }
        }

        public ImageSize SelectedImageSize
        {
            get { return m_ImageSize; }
        }

        public InsertOptions InsertOption
        {
            get
            {
                return insertOption;
            }
        }

        public bool UseLightBox
        {
            get
            {
                return this.cbUseLightBox.Checked;
            }
        }

        public bool IncludeCss
        {
            get
            {
                return this.cbIncludeCSS.Checked;
            }
        }
        #endregion

        public InsertSmugMugImageForm()
        {
            InitializeComponent();
        }

        private void GetSmugMugApi()
        {
            if (smugMug == null)
            {
                smugMug = Utils.GetSmugMugApi();
            }
        }

        /// <summary>
        /// Log us into SmugMug.  We do this anonymously because there is no point in inserting a 
        /// image from a private gallery into a blog.
        /// </summary>
        /// <returns></returns>
        private bool LoginUser()
        {
            bool loggedIn;
            try
            {
                UpdateStatus("Validating user...");
                smugMug.Login();
                loggedIn = true;
            }
            catch (Smugmug.SmugmugException ex)
            {
                loggedIn = false;
                UpdateStatus(String.Empty);
                ExecuteOnUIThread(delegate
                           {
                               MessageBox.Show("SmugMug could not be contacted.  The requested timed out.  \nPlease ensure your internet connection is still valid.", "SmugMug Connection Failed", MessageBoxButtons.OK, MessageBoxIcon.Error);
                           });

            }
            UpdateStatus(String.Empty);
            return loggedIn;

        }

        /// <summary>
        /// Simple method to help update the status area.
        /// 
        /// Can be called from any thread.
        /// </summary>
        /// <param name="message">The status message to display.</param>
        private void UpdateStatus(string message)
        {
            ExecuteOnUIThread(delegate
            {
                statusLabel.Text = message;
                if (message.Length < 1) // default the curser back
                {
                    Cursor.Current = Cursors.Default;
                    statusLabel.Text = "Idle";
                }
                else // we are actually doing something, let's pause the cursor
                {
                    Cursor.Current = Cursors.WaitCursor;
                }
            });
        }

        private void RefreshAlbums()
        {
            GetSmugMugApi();
            if (LoginUser())
            {
                if (albumList.Items.Count < 1)
                {
                    ExecuteOnUIThread(delegate
                    {
                        albumList.DataSource = null;
                        albumList.Items.Clear();
                    });

                    IEnumerable<Album> albums =  smugMug.GetAlbums(textNickName.Text.Trim());
          
                    ExecuteOnUIThread(delegate
                    {
                        albumList.DataSource = albums;
                        albumList.DisplayMember = "Title";
                    });
                }
            }
        }

        private void StartImageProcessor()
        {
            if (this.imageProcessor.IsBusy)
            {
                imageProcessor.CancelAsync();
            }
            while (imageProcessor.CancellationPending)
            {
                Application.DoEvents();
            }
            imageProcessor.RunWorkerAsync();
        }

        private void ClearImageList()
        {
            imageListing.Images.Clear();
            retrievedImageList.Items.Clear();
        }

        private void DrawRetrievedImages()
        {
       
            string nickname = GetValueFromUIThread<string>(delegate { return textNickName.Text.Trim(); });
            Album album = null;

            ExecuteOnUIThread(delegate
            {
               
                    album = GetValueFromUIThread<Album>(delegate { return (Album)albumList.SelectedItem; });
               
            });


            ExecuteOnUIThread(delegate
            {
                ClearImageList();
            });

            IList<Smugmug.Image> images = null;

            try
            {
                if (album != null)
                {
                     

                    if (imageProcessor.CancellationPending)
                        return;

                    images = new List<Smugmug.Image>(smugMug.GetImages(album.Id, album.Key));

                }
                else
                {
                    ExecuteOnUIThread(delegate
                    {
                        MessageBox.Show("You Must Select and Album");
                        this.albumList.Focus();
                        
                    });
                    return;
                }
                ExecuteOnUIThread(delegate
                {
                    if (imageProcessor.CancellationPending)
                        return;
                    
                        statusPictureCount.Text = string.Format("Image Count: {0}", images.Count.ToString());
                   
                });
                if (imageProcessor.CancellationPending)
                    return;
            }
            catch (Smugmug.SmugmugException ex)
            {
                
                    ExecuteOnUIThread(delegate
                    {
                        MessageBox.Show("SmugMug could not be contacted.  The requested timed out.  \nPlease ensure your internet connection is still valid.", "SmugMug Connection Failed", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    });
                    return;
                
            }

        
            ExecuteOnUIThread(delegate
            {
             
                progressBar.Maximum = images.Count;
            });

            if (images != null)
            {
                _images = true;
                int imageIndex = 0;
                foreach (Smugmug.Image image in images)
                {
                    if (imageProcessor.CancellationPending)
                        break;


                    ListViewItem item = null;

                    //Smugmug.Image imageUrls = smugMug.GetImageUrls(image.Id, image.Key);
                   

                    // HTTP request must happen on background thread
                    WindowsLive.Writer.Api.PluginHttpRequest http = new WindowsLive.Writer.Api.PluginHttpRequest(image.ThumbUrl);
                    http.AllowAutoRedirect = true;
                    http.CacheLevel = WindowsLive.Writer.Api.HttpRequestCacheLevel.BypassCache;

                    MemoryStream ms = new MemoryStream();
                    using (System.IO.Stream imageStream = http.GetResponse())
                    {
                        byte[] buf = new byte[0x1000];
                        int cnt;
                        while ((cnt = imageStream.Read(buf, 0, buf.Length)) > 0)
                            ms.Write(buf, 0, cnt);
                    }
                    ms.Seek(0, SeekOrigin.Begin);

                    if (imageProcessor.CancellationPending)
                        break;

                    

                    ExecuteOnUIThread(delegate
                    {
                        // Image that will be used on UI thread must be created on UI thread
                        System.Drawing.Image img = System.Drawing.Image.FromStream(ms);
                        img = Utils.ScaleToFixedSize(img, imageListing.ImageSize.Width, imageListing.ImageSize.Height, 0, Color.Transparent);
                        imageListing.Images.Add(img);
                        item = new ListViewItem();
                        item.Tag = image;
                        item.Text = image.Caption;
                        item.ImageIndex = imageIndex;
                        retrievedImageList.Items.Add(item);
                    });

                    imageProcessor.ReportProgress(imageIndex + 1);
                    imageIndex++;
                }
            }
        }

        #region EventHandlers

        private void imageProcessor_DoWork(object sender, DoWorkEventArgs e)
        {
            UpdateStatus("Retrieving images from Smugmug...");
            try
            {
                DrawRetrievedImages();
            }
            finally
            {
                UpdateStatus(string.Empty);
            }
        }

        private void imageProcessor_ProgressChanged(object sender, ProgressChangedEventArgs e)
        {
            if (!progressBar.IsDisposed)
            {
                progressBar.Visible = true;
                progressBar.Increment(1);

                if (e.ProgressPercentage == 100)
                {
                    UpdateStatus(string.Empty);
                }
            }
            
        }

        private void imageProcessor_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {
            if (!progressBar.IsDisposed)
            {
                progressBar.Value = 0;
                progressBar.Minimum = 0;
            }
        }

        /// <summary>
        /// Cancels the modal dialog to insert a SmugMug Image.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void buttonCancel_Click(object sender, EventArgs e)
        {
            base.DialogResult = DialogResult.Cancel;
        }

        /// <summary>
        /// The OK function of the modal dialog resulting in letting the ContentSource know the action is complete.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void buttonInsert_Click(object sender, EventArgs e)
        {
            if (retrievedImageList.SelectedIndices.Count == 0)
            {
                MessageBox.Show("No images selected.  Please choose at least one image or cancel to continue.", "No image selected", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            else
            {
                if (tabControl1.SelectedTab.Text == "Insert Image")
                {
                    this.insertOption = InsertOptions.Image;
                }
                else
                {
                    this.insertOption = InsertOptions.Gallery;
                }
                base.DialogResult = DialogResult.OK;
            }
        }

        private void buttonGet_Click(object sender, EventArgs e)
        {
            GetSmugMugApi();
            if (LoginUser())
            {
                StartImageProcessor();
            }
        }

        private void AlbumComboDropDown(object sender, EventArgs e)
        {
            if (textNickName.Text.Length > 1)
            {
                RefreshAlbums();
            }
            else
            {
                ExecuteOnUIThread(delegate
                {
                    MessageBox.Show("You must enter a Nick Name.");
                    textNickName.Focus();
                });
            }

        }


        private void ImageSizeChanged(object sender, EventArgs e)
        {
            m_ImageSize = (ImageSize)this.dropDownImageSizes.SelectedIndex;
        }

        private void smugMugSignup_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Utils.GotoUrl("https://www.smugmug.com/signup.mg");
        }
        #endregion

        #region Delegates
        private delegate void ExecuteOnUIThreadDelegate();
        /// <summary>
        /// Executes the given operation on the UI thread.  If called
        /// from the UI thread, the operation will simply be run.
        /// If called from a background thread, the operation will be
        /// Invoked on the UI thread.
        /// 
        /// This call is synchronous, it will block until the operation
        /// has finished running on the UI thread (or an exception is
        /// thrown).
        /// </summary>
        private void ExecuteOnUIThread(ExecuteOnUIThreadDelegate operation)
        {
            if (InvokeRequired)
                Invoke(operation);
            else
                operation();
        }

        private delegate T GetValueDelegate<T>();
        /// <summary>
        /// Same as ExecuteOnUIThread, but can return a value of type T.
        /// 
        /// For example:
        /// 
        /// string s = GetValueFromUIThread&lt;string&gt;(delegate { return textBox.Text; });
        /// </summary>
        private T GetValueFromUIThread<T>(GetValueDelegate<T> operation)
        {
            if (InvokeRequired)
                return (T)Invoke(operation);
            else
                return operation();
        }
        #endregion

        private void tabControl1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (tabControl1.SelectedTab.Text == "Insert Image")
            {
                this.retrievedImageList.MultiSelect = false;
                this.insertOption = InsertOptions.Image;
            }
            else
            {
                this.retrievedImageList.MultiSelect = true;
                this.insertOption = InsertOptions.Gallery;
            }
        }







    }
}
