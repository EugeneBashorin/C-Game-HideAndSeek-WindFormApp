namespace HideAndSeek
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
            this.exits = new System.Windows.Forms.ComboBox();
            this.goThroughTheDoor = new System.Windows.Forms.Button();
            this.goHere = new System.Windows.Forms.Button();
            this.description = new System.Windows.Forms.TextBox();
            this.hide = new System.Windows.Forms.Button();
            this.check = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // exits
            // 
            this.exits.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.exits.FormattingEnabled = true;
            this.exits.Location = new System.Drawing.Point(92, 198);
            this.exits.Name = "exits";
            this.exits.Size = new System.Drawing.Size(280, 21);
            this.exits.TabIndex = 7;
            // 
            // goThroughTheDoor
            // 
            this.goThroughTheDoor.Location = new System.Drawing.Point(13, 226);
            this.goThroughTheDoor.Name = "goThroughTheDoor";
            this.goThroughTheDoor.Size = new System.Drawing.Size(360, 21);
            this.goThroughTheDoor.TabIndex = 6;
            this.goThroughTheDoor.Text = "Go through the door";
            this.goThroughTheDoor.UseVisualStyleBackColor = true;
            this.goThroughTheDoor.Visible = false;
            this.goThroughTheDoor.Click += new System.EventHandler(this.goThroughTheDoor_Click);
            // 
            // goHere
            // 
            this.goHere.Location = new System.Drawing.Point(11, 198);
            this.goHere.Name = "goHere";
            this.goHere.Size = new System.Drawing.Size(75, 21);
            this.goHere.TabIndex = 5;
            this.goHere.Text = "Go Here:";
            this.goHere.UseVisualStyleBackColor = true;
            this.goHere.Click += new System.EventHandler(this.goHere_Click);
            // 
            // description
            // 
            this.description.Location = new System.Drawing.Point(12, 12);
            this.description.Multiline = true;
            this.description.Name = "description";
            this.description.Size = new System.Drawing.Size(360, 165);
            this.description.TabIndex = 4;
            // 
            // hide
            // 
            this.hide.Location = new System.Drawing.Point(14, 280);
            this.hide.Name = "hide";
            this.hide.Size = new System.Drawing.Size(360, 21);
            this.hide.TabIndex = 8;
            this.hide.Text = "Hide!";
            this.hide.UseVisualStyleBackColor = true;
            this.hide.Visible = false;
            this.hide.Click += new System.EventHandler(this.hide_Click);
            // 
            // check
            // 
            this.check.Location = new System.Drawing.Point(14, 253);
            this.check.Name = "check";
            this.check.Size = new System.Drawing.Size(360, 21);
            this.check.TabIndex = 9;
            this.check.Text = "Check";
            this.check.UseVisualStyleBackColor = true;
            this.check.Visible = false;
            this.check.Click += new System.EventHandler(this.check_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(386, 311);
            this.Controls.Add(this.check);
            this.Controls.Add(this.hide);
            this.Controls.Add(this.exits);
            this.Controls.Add(this.goThroughTheDoor);
            this.Controls.Add(this.goHere);
            this.Controls.Add(this.description);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox exits;
        private System.Windows.Forms.Button goThroughTheDoor;
        private System.Windows.Forms.Button goHere;
        private System.Windows.Forms.TextBox description;
        private System.Windows.Forms.Button hide;
        private System.Windows.Forms.Button check;
    }
}

