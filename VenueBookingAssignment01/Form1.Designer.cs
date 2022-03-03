
namespace VenueBookingAssignment01
{
    partial class VenueBooking
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
            this.richTextBoxOne = new System.Windows.Forms.RichTextBox();
            this.richTextBoxTwo = new System.Windows.Forms.RichTextBox();
            this.showReservations = new System.Windows.Forms.Button();
            this.showWaitingList = new System.Windows.Forms.Button();
            this.customerNameBox = new System.Windows.Forms.TextBox();
            this.BookTicket = new System.Windows.Forms.Button();
            this.cancelTicket = new System.Windows.Forms.Button();
            this.addToWaiting = new System.Windows.Forms.Button();
            this.exitButton = new System.Windows.Forms.Button();
            this.debugButton = new System.Windows.Forms.Button();
            this.listBoxOne = new System.Windows.Forms.ListBox();
            this.listBoxTwo = new System.Windows.Forms.ListBox();
            this.rowList = new System.Windows.Forms.Label();
            this.seatList = new System.Windows.Forms.Label();
            this.customerName = new System.Windows.Forms.Label();
            this.bookingCancellations = new System.Windows.Forms.GroupBox();
            this.bookinnsAndReservations = new System.Windows.Forms.GroupBox();
            this.labelForMessages = new System.Windows.Forms.Label();
            this.pictureBox = new System.Windows.Forms.PictureBox();
            this.bookingCancellations.SuspendLayout();
            this.bookinnsAndReservations.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox)).BeginInit();
            this.SuspendLayout();
            // 
            // richTextBoxOne
            // 
            this.richTextBoxOne.Location = new System.Drawing.Point(25, 93);
            this.richTextBoxOne.Name = "richTextBoxOne";
            this.richTextBoxOne.Size = new System.Drawing.Size(259, 294);
            this.richTextBoxOne.TabIndex = 0;
            this.richTextBoxOne.Text = "";
            this.richTextBoxOne.TextChanged += new System.EventHandler(this.richTextBoxOne_TextChanged);
            // 
            // richTextBoxTwo
            // 
            this.richTextBoxTwo.Location = new System.Drawing.Point(317, 93);
            this.richTextBoxTwo.Name = "richTextBoxTwo";
            this.richTextBoxTwo.Size = new System.Drawing.Size(259, 294);
            this.richTextBoxTwo.TabIndex = 1;
            this.richTextBoxTwo.Text = "";
            // 
            // showReservations
            // 
            this.showReservations.Location = new System.Drawing.Point(50, 37);
            this.showReservations.Name = "showReservations";
            this.showReservations.Size = new System.Drawing.Size(212, 39);
            this.showReservations.TabIndex = 2;
            this.showReservations.Text = "Show All Reservations";
            this.showReservations.UseVisualStyleBackColor = true;
            this.showReservations.Click += new System.EventHandler(this.ShowReservations_Click);
            // 
            // showWaitingList
            // 
            this.showWaitingList.Location = new System.Drawing.Point(336, 37);
            this.showWaitingList.Name = "showWaitingList";
            this.showWaitingList.Size = new System.Drawing.Size(212, 39);
            this.showWaitingList.TabIndex = 3;
            this.showWaitingList.Text = "Show Waiting List";
            this.showWaitingList.UseVisualStyleBackColor = true;
            this.showWaitingList.Click += new System.EventHandler(this.ShowWaitingList_Click);
            // 
            // customerNameBox
            // 
            this.customerNameBox.Location = new System.Drawing.Point(494, 55);
            this.customerNameBox.Name = "customerNameBox";
            this.customerNameBox.Size = new System.Drawing.Size(502, 26);
            this.customerNameBox.TabIndex = 4;
            // 
            // BookTicket
            // 
            this.BookTicket.Location = new System.Drawing.Point(494, 140);
            this.BookTicket.Name = "BookTicket";
            this.BookTicket.Size = new System.Drawing.Size(145, 42);
            this.BookTicket.TabIndex = 5;
            this.BookTicket.Text = "Book";
            this.BookTicket.UseVisualStyleBackColor = true;
            this.BookTicket.Click += new System.EventHandler(this.BookTicket_Click);
            // 
            // cancelTicket
            // 
            this.cancelTicket.Location = new System.Drawing.Point(658, 140);
            this.cancelTicket.Name = "cancelTicket";
            this.cancelTicket.Size = new System.Drawing.Size(145, 42);
            this.cancelTicket.TabIndex = 6;
            this.cancelTicket.Text = "Cancel";
            this.cancelTicket.UseVisualStyleBackColor = true;
            this.cancelTicket.Click += new System.EventHandler(this.CancelTicket_Click);
            // 
            // addToWaiting
            // 
            this.addToWaiting.Location = new System.Drawing.Point(830, 140);
            this.addToWaiting.Name = "addToWaiting";
            this.addToWaiting.Size = new System.Drawing.Size(145, 42);
            this.addToWaiting.TabIndex = 7;
            this.addToWaiting.Text = "Add To Waiting";
            this.addToWaiting.UseVisualStyleBackColor = true;
            this.addToWaiting.Click += new System.EventHandler(this.AddToWaiting_Click);
            // 
            // exitButton
            // 
            this.exitButton.ForeColor = System.Drawing.Color.Red;
            this.exitButton.Location = new System.Drawing.Point(830, 204);
            this.exitButton.Name = "exitButton";
            this.exitButton.Size = new System.Drawing.Size(145, 42);
            this.exitButton.TabIndex = 8;
            this.exitButton.Text = "Exit";
            this.exitButton.UseVisualStyleBackColor = true;
            this.exitButton.Click += new System.EventHandler(this.ExitButton_Click);
            // 
            // debugButton
            // 
            this.debugButton.BackColor = System.Drawing.SystemColors.ControlLight;
            this.debugButton.ForeColor = System.Drawing.Color.Red;
            this.debugButton.Location = new System.Drawing.Point(494, 204);
            this.debugButton.Name = "debugButton";
            this.debugButton.Size = new System.Drawing.Size(309, 42);
            this.debugButton.TabIndex = 9;
            this.debugButton.Text = "Debug - Fill All Seats";
            this.debugButton.UseVisualStyleBackColor = false;
            this.debugButton.Click += new System.EventHandler(this.DebugButton_Click);
            // 
            // listBoxOne
            // 
            this.listBoxOne.FormattingEnabled = true;
            this.listBoxOne.ItemHeight = 20;
            this.listBoxOne.Location = new System.Drawing.Point(49, 62);
            this.listBoxOne.Name = "listBoxOne";
            this.listBoxOne.Size = new System.Drawing.Size(86, 164);
            this.listBoxOne.TabIndex = 10;
            this.listBoxOne.SelectedIndexChanged += new System.EventHandler(this.ListBoxOne_SelectedIndexChanged);
            // 
            // listBoxTwo
            // 
            this.listBoxTwo.FormattingEnabled = true;
            this.listBoxTwo.ItemHeight = 20;
            this.listBoxTwo.Location = new System.Drawing.Point(168, 62);
            this.listBoxTwo.Name = "listBoxTwo";
            this.listBoxTwo.Size = new System.Drawing.Size(86, 164);
            this.listBoxTwo.TabIndex = 11;
            this.listBoxTwo.SelectedIndexChanged += new System.EventHandler(this.ListBoxTwo_SelectedIndexChanged);
            // 
            // rowList
            // 
            this.rowList.AutoSize = true;
            this.rowList.Location = new System.Drawing.Point(67, 35);
            this.rowList.Name = "rowList";
            this.rowList.Size = new System.Drawing.Size(41, 20);
            this.rowList.TabIndex = 12;
            this.rowList.Text = "Row";
            // 
            // seatList
            // 
            this.seatList.AutoSize = true;
            this.seatList.Location = new System.Drawing.Point(185, 35);
            this.seatList.Name = "seatList";
            this.seatList.Size = new System.Drawing.Size(43, 20);
            this.seatList.TabIndex = 13;
            this.seatList.Text = "Seat";
            // 
            // customerName
            // 
            this.customerName.AutoSize = true;
            this.customerName.Location = new System.Drawing.Point(345, 62);
            this.customerName.Name = "customerName";
            this.customerName.Size = new System.Drawing.Size(124, 20);
            this.customerName.TabIndex = 14;
            this.customerName.Text = "Customer Name";
            // 
            // bookingCancellations
            // 
            this.bookingCancellations.Controls.Add(this.customerName);
            this.bookingCancellations.Controls.Add(this.seatList);
            this.bookingCancellations.Controls.Add(this.rowList);
            this.bookingCancellations.Controls.Add(this.listBoxTwo);
            this.bookingCancellations.Controls.Add(this.listBoxOne);
            this.bookingCancellations.Controls.Add(this.debugButton);
            this.bookingCancellations.Controls.Add(this.exitButton);
            this.bookingCancellations.Controls.Add(this.addToWaiting);
            this.bookingCancellations.Controls.Add(this.cancelTicket);
            this.bookingCancellations.Controls.Add(this.BookTicket);
            this.bookingCancellations.Controls.Add(this.customerNameBox);
            this.bookingCancellations.Location = new System.Drawing.Point(36, 490);
            this.bookingCancellations.Name = "bookingCancellations";
            this.bookingCancellations.Size = new System.Drawing.Size(1044, 283);
            this.bookingCancellations.TabIndex = 15;
            this.bookingCancellations.TabStop = false;
            this.bookingCancellations.Text = "Bookings Cancellations";
            // 
            // bookinnsAndReservations
            // 
            this.bookinnsAndReservations.Controls.Add(this.showWaitingList);
            this.bookinnsAndReservations.Controls.Add(this.showReservations);
            this.bookinnsAndReservations.Controls.Add(this.richTextBoxTwo);
            this.bookinnsAndReservations.Controls.Add(this.richTextBoxOne);
            this.bookinnsAndReservations.Location = new System.Drawing.Point(479, 35);
            this.bookinnsAndReservations.Name = "bookinnsAndReservations";
            this.bookinnsAndReservations.Size = new System.Drawing.Size(601, 409);
            this.bookinnsAndReservations.TabIndex = 16;
            this.bookinnsAndReservations.TabStop = false;
            this.bookinnsAndReservations.Text = "Booking and Reservation";
            // 
            // labelForMessages
            // 
            this.labelForMessages.Font = new System.Drawing.Font("Arial", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelForMessages.Location = new System.Drawing.Point(32, 805);
            this.labelForMessages.Name = "labelForMessages";
            this.labelForMessages.Size = new System.Drawing.Size(1048, 103);
            this.labelForMessages.TabIndex = 17;
            this.labelForMessages.Text = "- - -";
            // 
            // pictureBox
            // 
            this.pictureBox.ErrorImage = null;
            this.pictureBox.Image = global::VenueBookingAssignment01.Properties.Resources.seatsImage;
            this.pictureBox.Location = new System.Drawing.Point(67, 46);
            this.pictureBox.Name = "pictureBox";
            this.pictureBox.Size = new System.Drawing.Size(394, 389);
            this.pictureBox.TabIndex = 18;
            this.pictureBox.TabStop = false;
            // 
            // VenueBooking
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(1144, 959);
            this.Controls.Add(this.pictureBox);
            this.Controls.Add(this.labelForMessages);
            this.Controls.Add(this.bookinnsAndReservations);
            this.Controls.Add(this.bookingCancellations);
            this.Name = "VenueBooking";
            this.Text = "Venue Booking";
            this.Load += new System.EventHandler(this.VenueBooking_Load);
            this.Click += new System.EventHandler(this.MessageForAvailableLists);
            this.bookingCancellations.ResumeLayout(false);
            this.bookingCancellations.PerformLayout();
            this.bookinnsAndReservations.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.RichTextBox richTextBoxOne;
        private System.Windows.Forms.RichTextBox richTextBoxTwo;
        private System.Windows.Forms.Button showReservations;
        private System.Windows.Forms.Button showWaitingList;
        private System.Windows.Forms.TextBox customerNameBox;
        private System.Windows.Forms.Button BookTicket;
        private System.Windows.Forms.Button cancelTicket;
        private System.Windows.Forms.Button addToWaiting;
        private System.Windows.Forms.Button exitButton;
        private System.Windows.Forms.Button debugButton;
        private System.Windows.Forms.ListBox listBoxOne;
        private System.Windows.Forms.ListBox listBoxTwo;
        private System.Windows.Forms.Label rowList;
        private System.Windows.Forms.Label seatList;
        private System.Windows.Forms.Label customerName;
        private System.Windows.Forms.GroupBox bookingCancellations;
        private System.Windows.Forms.GroupBox bookinnsAndReservations;
        private System.Windows.Forms.Label labelForMessages;
        private System.Windows.Forms.PictureBox pictureBox;
    }
}

