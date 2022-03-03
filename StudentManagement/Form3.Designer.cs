namespace StudentManagement
{
    partial class Form3
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.clearBtn = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.yearTextBox = new System.Windows.Forms.TextBox();
            this.nameTextBox = new System.Windows.Forms.TextBox();
            this.classIDTextBox = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.enteredClassID = new System.Windows.Forms.TextBox();
            this.viewDetailsBtn = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.listView1 = new System.Windows.Forms.ListView();
            this.viewListBtn = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.clearBtn);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.yearTextBox);
            this.panel1.Controls.Add(this.nameTextBox);
            this.panel1.Controls.Add(this.classIDTextBox);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.enteredClassID);
            this.panel1.Controls.Add(this.viewDetailsBtn);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(23, 12);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(426, 476);
            this.panel1.TabIndex = 0;
            // 
            // clearBtn
            // 
            this.clearBtn.Cursor = System.Windows.Forms.Cursors.AppStarting;
            this.clearBtn.Location = new System.Drawing.Point(138, 414);
            this.clearBtn.Name = "clearBtn";
            this.clearBtn.Size = new System.Drawing.Size(161, 33);
            this.clearBtn.TabIndex = 9;
            this.clearBtn.Text = "Clear";
            this.clearBtn.UseVisualStyleBackColor = true;
            this.clearBtn.Click += new System.EventHandler(this.clearBtn_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Yu Gothic UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label4.Location = new System.Drawing.Point(15, 339);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(50, 28);
            this.label4.TabIndex = 8;
            this.label4.Text = "Year";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Yu Gothic UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label3.Location = new System.Drawing.Point(15, 274);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(117, 28);
            this.label3.TabIndex = 7;
            this.label3.Text = "Class Name";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // yearTextBox
            // 
            this.yearTextBox.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.yearTextBox.Location = new System.Drawing.Point(138, 341);
            this.yearTextBox.Name = "yearTextBox";
            this.yearTextBox.ReadOnly = true;
            this.yearTextBox.Size = new System.Drawing.Size(233, 30);
            this.yearTextBox.TabIndex = 6;
            // 
            // nameTextBox
            // 
            this.nameTextBox.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.nameTextBox.Location = new System.Drawing.Point(138, 274);
            this.nameTextBox.Name = "nameTextBox";
            this.nameTextBox.ReadOnly = true;
            this.nameTextBox.Size = new System.Drawing.Size(233, 30);
            this.nameTextBox.TabIndex = 5;
            // 
            // classIDTextBox
            // 
            this.classIDTextBox.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.classIDTextBox.Location = new System.Drawing.Point(138, 213);
            this.classIDTextBox.Name = "classIDTextBox";
            this.classIDTextBox.ReadOnly = true;
            this.classIDTextBox.Size = new System.Drawing.Size(233, 30);
            this.classIDTextBox.TabIndex = 4;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Yu Gothic UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label2.Location = new System.Drawing.Point(15, 211);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(83, 28);
            this.label2.TabIndex = 3;
            this.label2.Text = "Class ID";
            // 
            // enteredClassID
            // 
            this.enteredClassID.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.enteredClassID.Location = new System.Drawing.Point(138, 42);
            this.enteredClassID.Name = "enteredClassID";
            this.enteredClassID.Size = new System.Drawing.Size(233, 30);
            this.enteredClassID.TabIndex = 1;
            // 
            // viewDetailsBtn
            // 
            this.viewDetailsBtn.Cursor = System.Windows.Forms.Cursors.AppStarting;
            this.viewDetailsBtn.Location = new System.Drawing.Point(26, 113);
            this.viewDetailsBtn.Name = "viewDetailsBtn";
            this.viewDetailsBtn.Size = new System.Drawing.Size(366, 47);
            this.viewDetailsBtn.TabIndex = 2;
            this.viewDetailsBtn.Text = "Details";
            this.viewDetailsBtn.UseVisualStyleBackColor = true;
            this.viewDetailsBtn.Click += new System.EventHandler(this.viewDetailsBtn_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Yu Gothic UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(26, 44);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(83, 28);
            this.label1.TabIndex = 0;
            this.label1.Text = "Class ID";
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.listView1);
            this.panel2.Controls.Add(this.viewListBtn);
            this.panel2.Location = new System.Drawing.Point(498, 12);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(524, 476);
            this.panel2.TabIndex = 1;
            // 
            // listView1
            // 
            this.listView1.Location = new System.Drawing.Point(36, 197);
            this.listView1.Name = "listView1";
            this.listView1.Size = new System.Drawing.Size(458, 250);
            this.listView1.TabIndex = 11;
            this.listView1.UseCompatibleStateImageBehavior = false;
            this.listView1.View = System.Windows.Forms.View.Details;
            // 
            // viewListBtn
            // 
            this.viewListBtn.Cursor = System.Windows.Forms.Cursors.AppStarting;
            this.viewListBtn.Location = new System.Drawing.Point(88, 113);
            this.viewListBtn.Name = "viewListBtn";
            this.viewListBtn.Size = new System.Drawing.Size(366, 47);
            this.viewListBtn.TabIndex = 10;
            this.viewListBtn.Text = "List of students";
            this.viewListBtn.UseVisualStyleBackColor = true;
            this.viewListBtn.Click += new System.EventHandler(this.viewListBtn_Click);
            // 
            // Form3
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1044, 515);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Name = "Form3";
            this.Text = "Form3";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private Panel panel1;
        private TextBox enteredClassID;
        private Button viewDetailsBtn;
        private Label label1;
        private Button clearBtn;
        private Label label4;
        private Label label3;
        private TextBox yearTextBox;
        private TextBox nameTextBox;
        private TextBox classIDTextBox;
        private Label label2;
        private Panel panel2;
        private Button viewListBtn;
        private ListView listView1;
    }
}