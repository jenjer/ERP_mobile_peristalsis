﻿using ERP_mobile_peristalsis.chatting;
using ERP_mobile_peristalsis.manager;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ERP_mobile_peristalsis
{
    public partial class chatting_name_pannel : UserControl
    {
        public PictureBox profile_image = new PictureBox();
        public int number = 0; // 이게 몇번째 배열에 들어있는지 체킹하는 함수
        public string chatting_room_name = "";
        public string chat_partner = "";
        Label chatting_room_label = new Label();
        
        public chatting_name_pannel()
        {
            InitializeComponent();
            chatting_room_label.Click += chatting_namming_label_Click;
        }
       /*
        public void set_chatting_profile_image()
        {
            Bitmap image;
            byte[] profile_image_byte;
            Query query = new Query().Select("Picture").From("User").Where("Name='" + chat_partner + "'");
            DB_Manager.getInstance().select(query.query);
            profile_image_byte = DB_Manager.getInstance().Image_process(query.query);
            
            if(profile_image_byte!= null)
            {
                using (MemoryStream stream = new MemoryStream(profile_image_byte))
                    image = new Bitmap(stream);
                profile_image.Image = image;
            }

        }*/
        public void set_chatting_name_label_text()
        {
            string[] sub_chatting_name = chatting_room_name.Split('/');
            foreach(string sub in sub_chatting_name)//채팅방 이름 저장할 때 /를 넣어서 저장하고, 불러올 때 /기준으로 id와 비교해서 다른거 출력
                if(sub!=Config_Manager.GetInstance().userid)
                    chatting_room_label.Text = sub;//여기서 문자열 자르기 들어가자
            chat_partner = chatting_room_label.Text;
            chatting_room_label.BringToFront();
            chatting_room_label.Dock = DockStyle.Fill;
            chatting_room_label.Font = new Font("맑은고딕", 20, FontStyle.Bold);
            this.Controls.Add(chatting_room_label);
        }
        private void chatting_name_pannel_MouseMove(object sender, MouseEventArgs e)
        {
            //this.BackColor = Color.FromArgb(192,192,192);
        }
        private void chatting_name_pannel_MouseLeave(object sender, EventArgs e)
        {
            //this.BackColor = Color.White;
        }
        public void chatting_namming_label_Click(object sender, EventArgs e)
        {
            if (Main.Chatting_form.clicked == -1) { 
                this.BackColor = Color.FromArgb(192, 192, 192);
                Main.Chatting_form.clicked = this.number;
            }
            else
            {
                Main.Chatting_form.newpanel_class[Main.Chatting_form.clicked].BackColor = Color.White;
                this.BackColor = Color.FromArgb(192, 192, 192);
                Main.Chatting_form.clicked = this.number;
            }
            chatting_name_pannel_Click(sender, e);

            return;
        }
        private void chatting_name_pannel_Click(object sender, EventArgs e)
        {
            if (Main.Chatting_form.check_chatting_log_panel == 0)
            {
                Main.Chatting_form.check_chatting_log_panel++;
                typing_pannel typping_add = new typing_pannel();
                typping_add.Size = new Size(Main.Chatting_form.splitcontainer.Panel2.Width, 100);
                typping_add.Dock = DockStyle.Bottom;
                Main.Chatting_form.splitcontainer.Panel2.Controls.Add(typping_add);

                //return;
            }

            chatting_log_pannel log = new chatting_log_pannel();
            log.Size = new Size(Main.Chatting_form.splitcontainer.Panel2.Width, Main.Chatting_form.splitcontainer.Panel2.Height - 100);
            log.Dock = DockStyle.Fill;
            Main.Chatting_form.splitcontainer.Panel2.Controls.Add(log);
            Main.Chatting_form.splitcontainer.Panel2.Controls.SetChildIndex(log, 0);
            //여기 아래부터는 for 를 통해서 자동 생성할 부분들 스크롤 처리 테스트한다고 미리 만들어둠
            //여기 하단부터 채팅 내역을 그대로 불러와서 넣는 작업이 필요하다.
            Query query = new Query().Select("*").From("Personal_Chatting_Log").Where("Title='" + chatting_room_name + "'");
            DataTable dt_chatting_log = DB_Manager.getInstance().select(query.query);

            foreach (DataRow row in dt_chatting_log.Rows)
            {
                if (row["Writter"].ToString() == Config_Manager.GetInstance().userid)
                {
                    chatting_log_column for_add1 = new chatting_log_column(true, this.Width,row["Log"].ToString(), profile_image);
                    for_add1.BackColor = Color.White;
                    log.Controls.Add(for_add1);
                    for_add1.Dock = DockStyle.Top;
                    for_add1.BorderStyle = BorderStyle.FixedSingle;
                }
                else
                {
                    chatting_log_column for_add1 = new chatting_log_column(false, this.Width, row["Log"].ToString(), profile_image);
                    for_add1.BackColor = Color.White;
                    log.Controls.Add(for_add1);
                    for_add1.Dock = DockStyle.Top;
                    for_add1.BorderStyle = BorderStyle.FixedSingle;

                }
                //st_count = row["count(*)"].ToString();
            }
            
        }
    }
}
