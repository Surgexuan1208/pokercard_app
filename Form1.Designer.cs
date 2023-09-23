namespace WindowsFormsApp1
{
    partial class Form1
    {
        /// <summary>
        /// 設計工具所需的變數。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清除任何使用中的資源。
        /// </summary>
        /// <param name="disposing">如果應該處置受控資源則為 true，否則為 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form 設計工具產生的程式碼

        /// <summary>
        /// 此為設計工具支援所需的方法 - 請勿使用程式碼編輯器修改
        /// 這個方法的內容。
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle11 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle12 = new System.Windows.Forms.DataGridViewCellStyle();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.show_all = new System.Windows.Forms.Button();
            this.ramdom_card = new System.Windows.Forms.Button();
            this.give_card = new System.Windows.Forms.Button();
            this.bouble_sort = new System.Windows.Forms.Button();
            this.bouble_sort_hard = new System.Windows.Forms.Button();
            this.show_img = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            dataGridViewCellStyle11.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle11.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle11.Font = new System.Drawing.Font("標楷體", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            dataGridViewCellStyle11.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle11.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle11.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle11.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridView1.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle11;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle12.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle12.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle12.Font = new System.Drawing.Font("標楷體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            dataGridViewCellStyle12.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle12.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle12.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle12.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridView1.DefaultCellStyle = dataGridViewCellStyle12;
            this.dataGridView1.Location = new System.Drawing.Point(12, 270);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(776, 168);
            this.dataGridView1.TabIndex = 0;
            // 
            // show_all
            // 
            this.show_all.Font = new System.Drawing.Font("標楷體", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.show_all.Location = new System.Drawing.Point(23, 45);
            this.show_all.Name = "show_all";
            this.show_all.Size = new System.Drawing.Size(174, 46);
            this.show_all.TabIndex = 1;
            this.show_all.Text = "卡牌全數列出";
            this.show_all.UseVisualStyleBackColor = true;
            this.show_all.Click += new System.EventHandler(this.show_all_Click);
            // 
            // ramdom_card
            // 
            this.ramdom_card.Font = new System.Drawing.Font("標楷體", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.ramdom_card.Location = new System.Drawing.Point(23, 109);
            this.ramdom_card.Name = "ramdom_card";
            this.ramdom_card.Size = new System.Drawing.Size(174, 46);
            this.ramdom_card.TabIndex = 2;
            this.ramdom_card.Text = "全數洗牌";
            this.ramdom_card.UseVisualStyleBackColor = true;
            this.ramdom_card.Click += new System.EventHandler(this.ramdom_card_Click);
            // 
            // give_card
            // 
            this.give_card.Font = new System.Drawing.Font("標楷體", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.give_card.Location = new System.Drawing.Point(23, 179);
            this.give_card.Name = "give_card";
            this.give_card.Size = new System.Drawing.Size(174, 46);
            this.give_card.TabIndex = 3;
            this.give_card.Text = "4人式發牌";
            this.give_card.UseVisualStyleBackColor = true;
            this.give_card.Click += new System.EventHandler(this.give_card_Click);
            // 
            // bouble_sort
            // 
            this.bouble_sort.Font = new System.Drawing.Font("標楷體", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.bouble_sort.Location = new System.Drawing.Point(220, 45);
            this.bouble_sort.Name = "bouble_sort";
            this.bouble_sort.Size = new System.Drawing.Size(174, 46);
            this.bouble_sort.TabIndex = 4;
            this.bouble_sort.Text = "數字小排到大";
            this.bouble_sort.UseVisualStyleBackColor = true;
            this.bouble_sort.Click += new System.EventHandler(this.bouble_sort_Click);
            // 
            // bouble_sort_hard
            // 
            this.bouble_sort_hard.Font = new System.Drawing.Font("標楷體", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.bouble_sort_hard.Location = new System.Drawing.Point(220, 109);
            this.bouble_sort_hard.Name = "bouble_sort_hard";
            this.bouble_sort_hard.Size = new System.Drawing.Size(174, 46);
            this.bouble_sort_hard.TabIndex = 5;
            this.bouble_sort_hard.Text = "先花色再數字";
            this.bouble_sort_hard.UseVisualStyleBackColor = true;
            this.bouble_sort_hard.Click += new System.EventHandler(this.bouble_sort_hard_Click);
            // 
            // show_img
            // 
            this.show_img.Font = new System.Drawing.Font("標楷體", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.show_img.Location = new System.Drawing.Point(220, 179);
            this.show_img.Name = "show_img";
            this.show_img.Size = new System.Drawing.Size(174, 46);
            this.show_img.TabIndex = 6;
            this.show_img.Text = "輸出圖片";
            this.show_img.UseVisualStyleBackColor = true;
            this.show_img.Click += new System.EventHandler(this.show_img_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.show_img);
            this.Controls.Add(this.bouble_sort_hard);
            this.Controls.Add(this.bouble_sort);
            this.Controls.Add(this.give_card);
            this.Controls.Add(this.ramdom_card);
            this.Controls.Add(this.show_all);
            this.Controls.Add(this.dataGridView1);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button show_all;
        private System.Windows.Forms.Button ramdom_card;
        private System.Windows.Forms.Button give_card;
        private System.Windows.Forms.Button bouble_sort;
        private System.Windows.Forms.Button bouble_sort_hard;
        private System.Windows.Forms.Button show_img;
    }
}

