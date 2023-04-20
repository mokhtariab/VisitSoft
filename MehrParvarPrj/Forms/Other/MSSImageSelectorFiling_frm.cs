using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Collections.ObjectModel;
using System.Diagnostics;
using System.Data.SqlClient;
using System.IO;
using Microsoft.VisualBasic.FileIO;

namespace MehrParvarPrj
{
    public partial class MSSImageSelectorFiling_frm : Form
    {

        
        #region For Filing


        #region Load Data

        string _persCode = "";
        string _addressPhysicPic = "", _addressPhysicFilm = "";
        string _addressPhysic = Global_Cls.AddressFile;


        public MSSImageSelectorFiling_frm(string PersCode, string AddressPhysic = "")
        {
            InitializeComponent();
            _persCode = PersCode;
            _addressPhysic = AddressPhysic == "" ? (_addressPhysic + _persCode + @"\") : (AddressPhysic + _persCode + @"\");
            if (!File.Exists(_addressPhysic))
                Directory.CreateDirectory(_addressPhysic);

            _addressPhysicPic = _addressPhysic + @"PIC\";
            if (!File.Exists(_addressPhysicPic))
                Directory.CreateDirectory(_addressPhysicPic);

            _addressPhysicFilm = _addressPhysic + @"Film\";
            if (!File.Exists(_addressPhysicFilm))
                Directory.CreateDirectory(_addressPhysicFilm);
        }


        private void MSSImageSelector_frm_Load(object sender, EventArgs e)
        {
            LoadPics_Films(_persCode);
        }

        #endregion

        #region OK Data
        private void buttonItem_OK_Click(object sender, EventArgs e)
        {
            if (Global_Cls.Message_MehrGostar(0, Global_Cls.MessageType.SConfirmation, true, "آیا مایلید فایل های مذکور ثبت شوند؟"))
                if (OkFunction())
                {
                    if (listView_Film.Items.Count > 0 || listView_Pic.Items.Count > 0)
                        this.DialogResult = DialogResult.OK;
                    else
                        this.DialogResult = DialogResult.Cancel;
                    Close();
                }
        }

        private bool OkFunction()
        {
            try
            {
                //pics & films
                SavePics_Films(_persCode);
            }
            catch (Exception ex)
            {
                Global_Cls.Message_MehrGostar(0, Global_Cls.MessageType.SError, false, "ثبت نشد!", ex.Message);
                return false;
            }
            return true;
        }        

        #endregion

        #region Pics & Films

        private int PicCounter = 0;
        private int FilmCounter = 0;
        private PictureBox ImgPic = null;

        private void LoadPics_Films(string CarFaceID)
        {
            ReadOnlyCollection<string> ROCPIC = new ReadOnlyCollection<string>(FileSystem.GetFiles(_addressPhysicPic));
            foreach (string PicFilmRoot in ROCPIC)
            {
                string FileNameExist = Path.GetFileName(PicFilmRoot);
                if (new FileInfo(FileNameExist).Extension == ".db") continue;
                try
                {
                    AddToListViewPic(FileNameExist, PicFilmRoot, PicCounter);
                    PicCounter++;
                }
                catch { }
            }

            //films
            ReadOnlyCollection<string> ROC = new ReadOnlyCollection<string>(FileSystem.GetFiles(_addressPhysicFilm));
            foreach (string PicFilmRoot in ROC)
            {
                string FileNameExist = Path.GetFileName(PicFilmRoot);
                if (new FileInfo(FileNameExist).Extension == ".db") continue;
                AddToListViewFilm(FileNameExist, PicFilmRoot, FilmCounter);
                FilmCounter++;
            }
        }


        private void SavePics_Films(string CarFaceID)
        {
            int i;

            for (i = 0; i < listView_Pic.Items.Count; i++)
            {
                if (FileSystem.FileExists(_addressPhysicPic + listView_Pic.Items[i].Text)) continue;
                else
                    FileSystem.CopyFile(listView_Pic.Items[i].Name, _addressPhysicPic + listView_Pic.Items[i].Text);
            }
            for (i = 0; i < FileDel.Count; i++)
            {
                FileSystem.RenameFile(FileDel[i], "-1delF000.jpg");
                FileSystem.DeleteFile(_addressPhysicPic + "-1delF000.jpg");
            }



            for (i = 0; i < listView_Film.Items.Count; i++)
            {
                if (FileSystem.FileExists(_addressPhysicFilm + listView_Film.Items[i].Text)) continue;
                else
                    FileSystem.CopyFile(listView_Film.Items[i].Name, _addressPhysicFilm + listView_Film.Items[i].Text);
            }

            for (i = 0; i < FileDelFilm.Count; i++)
            {
                FileSystem.RenameFile(FileDelFilm[i], "-1delF000.jpg");
                FileSystem.DeleteFile(_addressPhysicFilm + "-1delF000.jpg");
            }



        }

        //pics

        #endregion

        #region Other

       
        private void bubbleButton_PicNew_Click(object sender, DevComponents.DotNetBar.ClickEventArgs e)
        {
            OpenFileDialog ofd = new OpenFileDialog();
            ofd.Filter = "All image file|*.bmp;*.jpg;*.jpeg;*.gif;*.png;*.ico";
            ofd.Multiselect = true;
            if (ofd.ShowDialog() == DialogResult.OK)
            {
                string[] selectedFiles = ofd.SafeFileNames;
                string[] filePaths = ofd.FileNames;
                for (int i = 0; i < ofd.FileNames.Count(); i++)
                {
                    AddToListViewPic(selectedFiles[i], filePaths[i], PicCounter);

                    PicCounter++;
                }
            }
        }

        List<string> FileDel= new List<string>();
        private void bubbleButton_PicDel_Click(object sender, DevComponents.DotNetBar.ClickEventArgs e)
        {
            if (listView_Pic.SelectedItems.Count != 0)
                if (Global_Cls.Message_MehrGostar(0, Global_Cls.MessageType.SConfirmation, true, "آیا مایلید فایل (های) مورد نظر حذف شوند؟"))
                {
                    int SelCount = listView_Pic.SelectedItems.Count;
                    for (int i = 0; i < SelCount; i++)
                    {
                        string str = _addressPhysicPic + listView_Pic.SelectedItems[0].Text;

                        if (File.Exists(str))
                            FileDel.Add(str);
                        listView_Pic.Items.Remove(listView_Pic.SelectedItems[0]);
                    }

                }


            
            //if (listView_Pic.SelectedItems.Count != 0)
            //    if (Global_Cls.Message_MehrGostar(0, Global_Cls.MessageType.SConfirmation, true, "آیا مایلید فایل مورد نظر حذف شود؟"))
            //    {
            //        string _addressPhysicPicDel = _addressPhysicPic + @"Del\";
            //        if (!Directory.Exists(_addressPhysicPicDel))
            //            Directory.CreateDirectory(_addressPhysicPicDel);

            //        string str = _addressPhysicPic + listView_Pic.SelectedItems[0].Text;

            //        if (File.Exists(str))
            //        {
            //            FileDel.Add(str);
            //            bool tkrr = true; int M = 0;
            //            while (tkrr)
            //            {
            //                try
            //                {
            //                    FileSystem.CopyFile(listView_Pic.SelectedItems[0].Name, _addressPhysicPicDel + listView_Pic.SelectedItems[0].Text);
            //                    tkrr = false;
            //                }
            //                catch
            //                {
            //                    try
            //                    {
            //                        FileSystem.CopyFile(listView_Pic.SelectedItems[0].Name, _addressPhysicPicDel + listView_Pic.SelectedItems[0].Text+M++.ToString());
            //                        tkrr = false;
            //                    }
            //                    catch { }
            //                }
            //            }
            //        }

            //        listView_Pic.SelectedItems[0].Remove();

            //    }
        }

        private void AddToListViewPic(string PicFileName, string ItemName, int PicCnt)
        {
            ImgPic = new PictureBox();
            //ImgPic.Load(ItemName);
            ImgPic.Image = PublicClass.resizeImage(ItemName);
            imageList_LargePic.Images.Add(ImgPic.Image);
            imageList_SmallPic.Images.Add(ImgPic.Image);
            listView_Pic.Items.Add(ItemName, PicFileName, PicCnt);
        }

        private void bubbleButton_PicView_Click(object sender, DevComponents.DotNetBar.ClickEventArgs e)
        {
            if (listView_Pic.SelectedItems.Count != 0) Process.Start(listView_Pic.SelectedItems[0].Name);
        }

        private void bubbleButton_IconPic_Click(object sender, DevComponents.DotNetBar.ClickEventArgs e)
        {
            if (listView_Pic.View == View.LargeIcon)
                listView_Pic.View = View.Tile;
            else if (listView_Pic.View == View.Tile)
                listView_Pic.View = View.SmallIcon;
            else if (listView_Pic.View == View.SmallIcon)
                listView_Pic.View = View.List;
            else listView_Pic.View = View.LargeIcon;
        }

        private void listView_Pic_DoubleClick(object sender, EventArgs e)
        {
            bubbleButton_PicView_Click(this, null);
        }


        //films

        private void AddToListViewFilm(string FilmFileName, string ItemName, int FilmCnt)
        {
            ImgPic = new PictureBox();
            ImgPic.Image = Properties.Resources.aktion;
            imageList_LargeFilm.Images.Add(ImgPic.Image);
            imageList_SmallFilm.Images.Add(ImgPic.Image);
            listView_Film.Items.Add(ItemName, FilmFileName, FilmCnt);
        }


        private void bubbleButton_FilmNew_Click(object sender, DevComponents.DotNetBar.ClickEventArgs e)
        {
            OpenFileDialog ofd = new OpenFileDialog();
            //ofd.Filter = "All Video file|*.wmv;*.avi;*.mpeg;*.3gp;*.mp4;*.mp3;*.dat;*.mov;*.divx";
            ofd.Filter = "All Other file|*.wmv;*.avi;*.mpeg;*.3gp;*.mp4;*.mp3;*.dat;*.mov;*.divx;*.doc;*.docx;*.xls;*.xlsx;*.ppt;*.pptx;";

            if (ofd.ShowDialog() == DialogResult.OK)
            {
                AddToListViewFilm(ofd.SafeFileName, ofd.FileName, FilmCounter);

                FilmCounter++;
            }

        }

        List<string> FileDelFilm = new List<string>();
        private void bubbleButton_FilmDel_Click(object sender, DevComponents.DotNetBar.ClickEventArgs e)
        {
            if (listView_Film.SelectedItems.Count != 0)
                if (Global_Cls.Message_MehrGostar(0, Global_Cls.MessageType.SConfirmation, true, "آیا مایلید فایل (های) مورد نظر حذف شود؟"))
                {
                    int SelCount = listView_Film.SelectedItems.Count;
                    for (int i = 0; i < SelCount; i++)
                    {
                        string str = _addressPhysicFilm + listView_Film.SelectedItems[0].Text;

                        if (File.Exists(str))
                            FileDelFilm.Add(str);
                    }

                    listView_Film.Items.Remove(listView_Film.SelectedItems[0]);

                }


            //if (listView_Film.SelectedItems.Count != 0)
            //    if (Global_Cls.Message_MehrGostar(0, Global_Cls.MessageType.SConfirmation, true, "آیا مایلید فایل مورد نظر حذف شود؟"))
            //    {
            //        string _addressPhysicFilmDel = _addressPhysicFilm + @"Del\";
            //        if (!Directory.Exists(_addressPhysicFilmDel))
            //            Directory.CreateDirectory(_addressPhysicFilmDel);

            //        string str = _addressPhysicFilm + listView_Film.SelectedItems[0].Text;

            //        if (File.Exists(str))
            //        {
            //            FileDelFilm.Add(str);
            //            bool tkrr = true; int M = 0;
            //            while (tkrr)
            //            {
            //                try
            //                {
            //                    FileSystem.CopyFile(listView_Film.SelectedItems[0].Name, _addressPhysicFilmDel + listView_Film.SelectedItems[0].Text);
            //                    tkrr = false;
            //                }
            //                catch
            //                {
            //                    try
            //                    {
            //                        FileSystem.CopyFile(listView_Film.SelectedItems[0].Name, _addressPhysicFilmDel + listView_Film.SelectedItems[0].Text + M++.ToString());
            //                        tkrr = false;
            //                    }
            //                    catch { }
            //                }
            //            }
            //        }

            //        listView_Film.SelectedItems[0].Remove();

            //    }
        }

        private void bubbleButton_FilmView_Click(object sender, DevComponents.DotNetBar.ClickEventArgs e)
        {
            try
            {
                if (listView_Film.SelectedItems.Count != 0) Process.Start(listView_Film.SelectedItems[0].Name);
            }
            catch { }
        }

        private void bubbleButton_FilmIcon_Click(object sender, DevComponents.DotNetBar.ClickEventArgs e)
        {
            if (listView_Film.View == View.LargeIcon)
                listView_Film.View = View.Tile;
            else if (listView_Film.View == View.Tile)
                listView_Film.View = View.SmallIcon;
            else if (listView_Film.View == View.SmallIcon)
                listView_Film.View = View.List;
            else listView_Film.View = View.LargeIcon;
        }

        private void listView_Film_DoubleClick(object sender, EventArgs e)
        {
            bubbleButton_FilmView_Click(this, null);
        }

        #endregion


        #endregion


    }

}
