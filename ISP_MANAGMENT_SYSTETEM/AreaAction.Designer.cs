
namespace ISP_MANAGMENT_SYSTETEM
{
    partial class AreaAction
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.cnclBtn = new System.Windows.Forms.PictureBox();
            this.delBtn = new System.Windows.Forms.PictureBox();
            this.editBtn = new System.Windows.Forms.PictureBox();
            this.crssBtn = new System.Windows.Forms.PictureBox();
            this.workerName = new System.Windows.Forms.ComboBox();
            this.thirdWorkerName = new System.Windows.Forms.ComboBox();
            this.secondWorkerName = new System.Windows.Forms.ComboBox();
            this.areaName = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.cnclBtn)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.delBtn)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.editBtn)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.crssBtn)).BeginInit();
            this.SuspendLayout();
            // 
            // cnclBtn
            // 
            this.cnclBtn.BackColor = System.Drawing.Color.Transparent;
            this.cnclBtn.Location = new System.Drawing.Point(284, 212);
            this.cnclBtn.Name = "cnclBtn";
            this.cnclBtn.Size = new System.Drawing.Size(77, 25);
            this.cnclBtn.TabIndex = 0;
            this.cnclBtn.TabStop = false;
            this.cnclBtn.Click += new System.EventHandler(this.cnclBtn_Click);
            // 
            // delBtn
            // 
            this.delBtn.BackColor = System.Drawing.Color.Transparent;
            this.delBtn.Location = new System.Drawing.Point(197, 212);
            this.delBtn.Name = "delBtn";
            this.delBtn.Size = new System.Drawing.Size(77, 25);
            this.delBtn.TabIndex = 1;
            this.delBtn.TabStop = false;
            this.delBtn.Click += new System.EventHandler(this.delBtn_Click);
            // 
            // editBtn
            // 
            this.editBtn.BackColor = System.Drawing.Color.Transparent;
            this.editBtn.Location = new System.Drawing.Point(108, 212);
            this.editBtn.Name = "editBtn";
            this.editBtn.Size = new System.Drawing.Size(77, 25);
            this.editBtn.TabIndex = 2;
            this.editBtn.TabStop = false;
            this.editBtn.Click += new System.EventHandler(this.editBtn_Click);
            // 
            // crssBtn
            // 
            this.crssBtn.BackColor = System.Drawing.Color.Transparent;
            this.crssBtn.Location = new System.Drawing.Point(344, 11);
            this.crssBtn.Name = "crssBtn";
            this.crssBtn.Size = new System.Drawing.Size(22, 19);
            this.crssBtn.TabIndex = 3;
            this.crssBtn.TabStop = false;
            this.crssBtn.Click += new System.EventHandler(this.crssBtn_Click);
            // 
            // workerName
            // 
            this.workerName.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.workerName.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.workerName.FormattingEnabled = true;
            this.workerName.Location = new System.Drawing.Point(167, 80);
            this.workerName.Name = "workerName";
            this.workerName.Size = new System.Drawing.Size(163, 24);
            this.workerName.TabIndex = 4;
            // 
            // thirdWorkerName
            // 
            this.thirdWorkerName.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.thirdWorkerName.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.thirdWorkerName.FormattingEnabled = true;
            this.thirdWorkerName.Location = new System.Drawing.Point(167, 147);
            this.thirdWorkerName.Name = "thirdWorkerName";
            this.thirdWorkerName.Size = new System.Drawing.Size(163, 24);
            this.thirdWorkerName.TabIndex = 5;
            // 
            // secondWorkerName
            // 
            this.secondWorkerName.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.secondWorkerName.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.secondWorkerName.FormattingEnabled = true;
            this.secondWorkerName.Location = new System.Drawing.Point(23, 147);
            this.secondWorkerName.Name = "secondWorkerName";
            this.secondWorkerName.Size = new System.Drawing.Size(100, 24);
            this.secondWorkerName.TabIndex = 6;
            // 
            // areaName
            // 
            this.areaName.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.areaName.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.areaName.Location = new System.Drawing.Point(23, 80);
            this.areaName.Multiline = true;
            this.areaName.Name = "areaName";
            this.areaName.Size = new System.Drawing.Size(100, 23);
            this.areaName.TabIndex = 7;
            // 
            // AreaAction
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::ISP_MANAGMENT_SYSTETEM.Properties.Resources.areaAction;
            this.ClientSize = new System.Drawing.Size(383, 255);
            this.Controls.Add(this.areaName);
            this.Controls.Add(this.secondWorkerName);
            this.Controls.Add(this.thirdWorkerName);
            this.Controls.Add(this.workerName);
            this.Controls.Add(this.crssBtn);
            this.Controls.Add(this.editBtn);
            this.Controls.Add(this.delBtn);
            this.Controls.Add(this.cnclBtn);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "AreaAction";
            this.Text = "AreaAction";
            this.Load += new System.EventHandler(this.AreaAction_Load);
            ((System.ComponentModel.ISupportInitialize)(this.cnclBtn)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.delBtn)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.editBtn)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.crssBtn)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox cnclBtn;
        private System.Windows.Forms.PictureBox delBtn;
        private System.Windows.Forms.PictureBox editBtn;
        private System.Windows.Forms.PictureBox crssBtn;
        private System.Windows.Forms.ComboBox workerName;
        private System.Windows.Forms.ComboBox thirdWorkerName;
        private System.Windows.Forms.ComboBox secondWorkerName;
        private System.Windows.Forms.TextBox areaName;
    }
}