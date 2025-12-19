namespace SmartTaskTracker
{
    partial class Form1
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
            this.UI_Tbx_Title = new System.Windows.Forms.TextBox();
            this.UI_Cmb_Category = new System.Windows.Forms.ComboBox();
            this.UI_Cmb_Priority = new System.Windows.Forms.ComboBox();
            this.UI_Cmb_Status = new System.Windows.Forms.ComboBox();
            this.UI_Btn_Add = new System.Windows.Forms.Button();
            this.UI_Btn_Edit = new System.Windows.Forms.Button();
            this.UI_Btn_Delete = new System.Windows.Forms.Button();
            this.UI_Btn_Save = new System.Windows.Forms.Button();
            this.UI_Btn_Load = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.UI_Lvw_Tasks = new System.Windows.Forms.ListView();
            this.UI_Btn_Sort = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // UI_Tbx_Title
            // 
            this.UI_Tbx_Title.Location = new System.Drawing.Point(30, 12);
            this.UI_Tbx_Title.Name = "UI_Tbx_Title";
            this.UI_Tbx_Title.Size = new System.Drawing.Size(734, 20);
            this.UI_Tbx_Title.TabIndex = 0;
            // 
            // UI_Cmb_Category
            // 
            this.UI_Cmb_Category.FormattingEnabled = true;
            this.UI_Cmb_Category.Location = new System.Drawing.Point(103, 57);
            this.UI_Cmb_Category.Name = "UI_Cmb_Category";
            this.UI_Cmb_Category.Size = new System.Drawing.Size(121, 21);
            this.UI_Cmb_Category.TabIndex = 1;
            // 
            // UI_Cmb_Priority
            // 
            this.UI_Cmb_Priority.FormattingEnabled = true;
            this.UI_Cmb_Priority.Location = new System.Drawing.Point(334, 61);
            this.UI_Cmb_Priority.Name = "UI_Cmb_Priority";
            this.UI_Cmb_Priority.Size = new System.Drawing.Size(121, 21);
            this.UI_Cmb_Priority.TabIndex = 2;
            // 
            // UI_Cmb_Status
            // 
            this.UI_Cmb_Status.FormattingEnabled = true;
            this.UI_Cmb_Status.Location = new System.Drawing.Point(585, 62);
            this.UI_Cmb_Status.Name = "UI_Cmb_Status";
            this.UI_Cmb_Status.Size = new System.Drawing.Size(121, 21);
            this.UI_Cmb_Status.TabIndex = 3;
            // 
            // UI_Btn_Add
            // 
            this.UI_Btn_Add.Location = new System.Drawing.Point(458, 106);
            this.UI_Btn_Add.Name = "UI_Btn_Add";
            this.UI_Btn_Add.Size = new System.Drawing.Size(306, 49);
            this.UI_Btn_Add.TabIndex = 5;
            this.UI_Btn_Add.Text = "Add";
            this.UI_Btn_Add.UseVisualStyleBackColor = true;
            this.UI_Btn_Add.Click += new System.EventHandler(this.UI_Btn_Add_Click);
            // 
            // UI_Btn_Edit
            // 
            this.UI_Btn_Edit.Location = new System.Drawing.Point(458, 161);
            this.UI_Btn_Edit.Name = "UI_Btn_Edit";
            this.UI_Btn_Edit.Size = new System.Drawing.Size(306, 49);
            this.UI_Btn_Edit.TabIndex = 6;
            this.UI_Btn_Edit.Text = "Edit";
            this.UI_Btn_Edit.UseVisualStyleBackColor = true;
            this.UI_Btn_Edit.Click += new System.EventHandler(this.UI_Btn_Edit_Click);
            // 
            // UI_Btn_Delete
            // 
            this.UI_Btn_Delete.Location = new System.Drawing.Point(458, 216);
            this.UI_Btn_Delete.Name = "UI_Btn_Delete";
            this.UI_Btn_Delete.Size = new System.Drawing.Size(306, 49);
            this.UI_Btn_Delete.TabIndex = 7;
            this.UI_Btn_Delete.Text = "Delete";
            this.UI_Btn_Delete.UseVisualStyleBackColor = true;
            this.UI_Btn_Delete.Click += new System.EventHandler(this.UI_Btn_Delete_Click);
            // 
            // UI_Btn_Save
            // 
            this.UI_Btn_Save.Location = new System.Drawing.Point(458, 271);
            this.UI_Btn_Save.Name = "UI_Btn_Save";
            this.UI_Btn_Save.Size = new System.Drawing.Size(306, 49);
            this.UI_Btn_Save.TabIndex = 8;
            this.UI_Btn_Save.Text = "Save";
            this.UI_Btn_Save.UseVisualStyleBackColor = true;
            this.UI_Btn_Save.Click += new System.EventHandler(this.UI_Btn_Save_Click);
            // 
            // UI_Btn_Load
            // 
            this.UI_Btn_Load.Location = new System.Drawing.Point(458, 326);
            this.UI_Btn_Load.Name = "UI_Btn_Load";
            this.UI_Btn_Load.Size = new System.Drawing.Size(306, 49);
            this.UI_Btn_Load.TabIndex = 9;
            this.UI_Btn_Load.Text = "Load";
            this.UI_Btn_Load.UseVisualStyleBackColor = true;
            this.UI_Btn_Load.Click += new System.EventHandler(this.UI_Btn_load_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(27, 58);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(70, 16);
            this.label1.TabIndex = 10;
            this.label1.Text = "Category";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(272, 62);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(56, 16);
            this.label2.TabIndex = 11;
            this.label2.Text = "Priority";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(529, 63);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(50, 16);
            this.label3.TabIndex = 12;
            this.label3.Text = "Status";
            // 
            // UI_Lvw_Tasks
            // 
            this.UI_Lvw_Tasks.HideSelection = false;
            this.UI_Lvw_Tasks.Location = new System.Drawing.Point(30, 106);
            this.UI_Lvw_Tasks.Name = "UI_Lvw_Tasks";
            this.UI_Lvw_Tasks.Size = new System.Drawing.Size(415, 324);
            this.UI_Lvw_Tasks.TabIndex = 13;
            this.UI_Lvw_Tasks.UseCompatibleStateImageBehavior = false;
            this.UI_Lvw_Tasks.SelectedIndexChanged += new System.EventHandler(this.UI_Lvw_Tasks_SelectedIndexChanged);
            // 
            // UI_Btn_Sort
            // 
            this.UI_Btn_Sort.Location = new System.Drawing.Point(458, 381);
            this.UI_Btn_Sort.Name = "UI_Btn_Sort";
            this.UI_Btn_Sort.Size = new System.Drawing.Size(306, 49);
            this.UI_Btn_Sort.TabIndex = 14;
            this.UI_Btn_Sort.Text = "Sort";
            this.UI_Btn_Sort.UseVisualStyleBackColor = true;
            this.UI_Btn_Sort.Click += new System.EventHandler(this.UI_Btn_Sort_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(789, 456);
            this.Controls.Add(this.UI_Btn_Sort);
            this.Controls.Add(this.UI_Lvw_Tasks);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.UI_Btn_Load);
            this.Controls.Add(this.UI_Btn_Save);
            this.Controls.Add(this.UI_Btn_Delete);
            this.Controls.Add(this.UI_Btn_Edit);
            this.Controls.Add(this.UI_Btn_Add);
            this.Controls.Add(this.UI_Cmb_Status);
            this.Controls.Add(this.UI_Cmb_Priority);
            this.Controls.Add(this.UI_Cmb_Category);
            this.Controls.Add(this.UI_Tbx_Title);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox UI_Tbx_Title;
        private System.Windows.Forms.ComboBox UI_Cmb_Category;
        private System.Windows.Forms.ComboBox UI_Cmb_Priority;
        private System.Windows.Forms.ComboBox UI_Cmb_Status;
        private System.Windows.Forms.Button UI_Btn_Add;
        private System.Windows.Forms.Button UI_Btn_Edit;
        private System.Windows.Forms.Button UI_Btn_Delete;
        private System.Windows.Forms.Button UI_Btn_Save;
        private System.Windows.Forms.Button UI_Btn_Load;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ListView UI_Lvw_Tasks;
        private System.Windows.Forms.Button UI_Btn_Sort;
    }
}

