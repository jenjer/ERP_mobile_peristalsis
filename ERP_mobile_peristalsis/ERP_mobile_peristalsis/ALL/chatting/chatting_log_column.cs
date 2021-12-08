﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ERP_mobile_peristalsis.chatting
{
    public partial class chatting_log_column : UserControl
    {
        public chatting_log_column(bool my ,int width,string chatting_log, PictureBox profile_image)//생성자에 프로필 이미지와 채팅 로그, 사용자 명를 변수로 전해줘야된다.
        {
            InitializeComponent();
            this.Size = new Size(width-70,80);
            Bitmap bmp;
            PictureBox profile_picturebox = new PictureBox();
            Label textlog = new Label();

            if (my == true)
            {
                textlog.BringToFront();
                textlog.Dock = DockStyle.Fill;
                textlog.BackColor = Color.White;
                textlog.AutoSize = false;
                textlog.TextAlign = ContentAlignment.MiddleRight;
                textlog.Text = chatting_log;
                this.Controls.Add(profile_picturebox);
                this.Controls.Add(textlog);
            }
            else
            {
                profile_picturebox.Size = new Size(80, 50);
                profile_picturebox.Image = profile_image.Image;
                profile_picturebox.BorderStyle = BorderStyle.FixedSingle;
                textlog.TextAlign = ContentAlignment.MiddleLeft;
                textlog.SendToBack();
                profile_picturebox.BringToFront();
                textlog.Dock = DockStyle.Fill;
                profile_picturebox.Dock = DockStyle.Left;
                this.Controls.Add(profile_picturebox);
                this.Controls.Add(textlog);
            }
            this.Controls.SetChildIndex(textlog, 0);
                textlog.BackColor = Color.White;
                textlog.Text = chatting_log;

                
        }
    }
}