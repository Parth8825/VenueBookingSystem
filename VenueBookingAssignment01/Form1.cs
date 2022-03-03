/*
 * Program ID: Progarmming Concept II Assignment 01
 * 
 * Purpose: Venue booking system. Where you can book available seats and cancel it too.
 * 
 * Name: Parth Vinodhai Darji
 * 
 * Revision History
 *      Created at February 06, 2021 by Parth Darji
 *           > Edited for "Debug for All Seats" button and did some of the minor changes for label messages on Feb 08, 2021 
 *           > put comments on some parts of codes for explanation on Feb 09,2021
 */
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace VenueBookingAssignment01
{
    public partial class VenueBooking : Form
    {
        //Declaring and initializing variables
        int indexForRow = 0;
        int indexForSeat = 0;
        int countSeats = 0;
        string availableLists = "";
        string[,] twoDimArray = new string[5, 6];
        string[] waitingListArray = new string[10]; 
        public VenueBooking()
        {
            InitializeComponent();
        }

        private void VenueBooking_Load(object sender, EventArgs e)
        {

            //Adding rows in the list box 
            listBoxOne.Items.Add("A");
            listBoxOne.Items.Add("B");
            listBoxOne.Items.Add("C");
            listBoxOne.Items.Add("D");
            listBoxOne.Items.Add("E");

            //Adding seats in the list box
            listBoxTwo.Items.Add("1");
            listBoxTwo.Items.Add("2");
            listBoxTwo.Items.Add("3");
            listBoxTwo.Items.Add("4");
            listBoxTwo.Items.Add("5");
            listBoxTwo.Items.Add("6");

            


        }

        //this method for will run, when you click on "Book" button 
        private void BookTicket_Click(object sender, EventArgs e)
        {
            indexForRow = listBoxOne.SelectedIndex;
            indexForSeat = listBoxTwo.SelectedIndex;
            bool checkSeatsFull = false;
            try
            {
                //this for loop is to find out that all the seats are booked or not
                for (int k = 0; k < twoDimArray.GetLength(0); k++)
                {
                    for (int l = 0; l < twoDimArray.GetLength(1); l++)
                    {
                        if(twoDimArray[k,l] == null)
                        {
                        checkSeatsFull = true;
                        }
                    }
                }

                //If all seats are booked then this statement will occur
                if(checkSeatsFull == false)
                {
                    countSeats = 1;
                    //after all seats are reserved then this one will add the customer to the waiting list
                    for (int i = 0; i < waitingListArray.Length; i++)
                    {
                        if (waitingListArray[i] == null)
                        {  
                            if (customerNameBox.Text != "")
                            {
                                waitingListArray[i] = customerNameBox.Text;
                                labelForMessages.Text = "All seats are reserved, the Customer name is transfered to waiting lists \n You can check by clicking on \"Show Waiting List\"";
                                countSeats--;
                                customerNameBox.Clear();
                                return;
                            }
                            else
                            {
                                labelForMessages.Text = "Please enter customer name";
                                return;
                            }   
                        }        
                    }          
                    labelForMessages.Text = "All Seats are Full, also in the waiting list";
                    return;
                }

                //this statement will add a new vacent seat 
                if (twoDimArray[indexForRow, indexForSeat] == null)
                {
                    if (customerNameBox.Text != "")
                    {
                        twoDimArray[indexForRow, indexForSeat] = listBoxOne.Items[indexForRow] + listBoxTwo.Items[indexForSeat].ToString() + " - " + customerNameBox.Text;
                        labelForMessages.Text = "Seat has been booked";
                    }
                    else
                    {
                        labelForMessages.Text = "Please enter Customer name";
                    }  
                }
                else //if seat is already booked then this statement will occur
                {
                    for (int i = 0; i < twoDimArray.GetLength(0); i++)
                    {
                        for (int j = 0; j < twoDimArray.GetLength(1); j++)
                        {

                            if (twoDimArray[i, j] == null)
                            {
                                availableLists = availableLists + listBoxOne.Items[i] + listBoxTwo.Items[j].ToString() + " - ";
                                labelForMessages.Text = "The selected seat is already booked\nAvailables Seats are: " + availableLists;
                            }

                        }
                    }
                    availableLists = "";
                }
            }
            catch(IndexOutOfRangeException)
            {
                labelForMessages.Text = "Please select Row and Seat first";
            }
            

        }

        //this method will run, when you click on "Show All Reservation" button 
        //and it will provide reserved seats details into the richbox which is located at below the button
        private void ShowReservations_Click(object sender, EventArgs e)
        {
            listBoxOne.ClearSelected();
            listBoxTwo.ClearSelected();
            customerNameBox.Clear();
            richTextBoxOne.Clear();
            labelForMessages.Text = "- - -";
            for (int i = 0; i < twoDimArray.GetLength(0); i++)
            {
                for (int j = 0; j < twoDimArray.GetLength(1); j++)
                {
                    if (twoDimArray[i, j] != null)
                    {
                        richTextBoxOne.Text = richTextBoxOne.Text + twoDimArray[i, j] + "\n";
                    }
                    else 
                    {    
                        richTextBoxOne.Text = richTextBoxOne.Text + listBoxOne.Items[i] + listBoxTwo.Items[j].ToString() + " - " + "\n";
                        availableLists = availableLists + listBoxOne.Items[i] + listBoxTwo.Items[j].ToString() + " - ";
                        labelForMessages.Text = "Available Seats are: " + availableLists;
                    }
                 
                }
            }
            availableLists = "";
            
        }

        //this method simply exit the program
        private void ExitButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        // I don't know!! how can I remove this method ? because when I remove it, it gives me an error in the program.
        private void MessageForAvailableLists(object sender, EventArgs e)
        {
            
        }

        //In this mothed, it just clears message under the label section and removes customer name from the customer box
        private void ListBoxOne_SelectedIndexChanged(object sender, EventArgs e)
        {
            labelForMessages.Text = "- - -";
            customerNameBox.Clear();

        }

        //In this mothed, it just clears message under the label section and removes customer name from the customer box
        private void ListBoxTwo_SelectedIndexChanged(object sender, EventArgs e)
        {
            labelForMessages.Text = "- - -";
            customerNameBox.Clear();
        }

        //this method will just display available waiting lists in the label message section as per the instruction
        private void AddToWaiting_Click(object sender, EventArgs e)
        {
            labelForMessages.Text = "- - -";
            for (int i = 0; i < waitingListArray.Length; i++)
            {
                if (waitingListArray[i] == null)
                {
                    countSeats++;
                    labelForMessages.Text = "There are " + countSeats + " seats are available in the waiting list";
                }
            }
            countSeats = 0;
        }

        //this will provide the list of customers that are currently in the waiting list unsder the richbox which is located just below the "Show Waiting List" 
        private void ShowWaitingList_Click(object sender, EventArgs e)
        {
            listBoxOne.ClearSelected();
            listBoxTwo.ClearSelected();
            customerNameBox.Clear();
            richTextBoxTwo.Clear();
            labelForMessages.Text = "- - -";
            for (int i = 0; i < waitingListArray.Length; i++)
            {
                if (waitingListArray[i] != null)
                {
                    richTextBoxTwo.Text = richTextBoxTwo.Text + waitingListArray[i] + "\n";
                }
            }
        }

        //this will cancel the ticket which is already booked
        private void CancelTicket_Click(object sender, EventArgs e)
        {
            indexForRow = listBoxOne.SelectedIndex;
            indexForSeat = listBoxTwo.SelectedIndex;
            customerNameBox.Clear();
            labelForMessages.Text = "- - -";
            try
            {
                if (twoDimArray[indexForRow, indexForSeat] != null)
                {
                    // here it will show another pop up window to confirm the cancellation of the selected seat
                    DialogResult dr = MessageBox.Show("Customer Name: "+ twoDimArray[indexForRow, indexForSeat].Substring(5), "Are you sure!! Do you want to cancel?", MessageBoxButtons.YesNo);
                    if (dr == DialogResult.Yes)  //if you press on "Yes", this will remove the name of the customer from the booked list  
                    {
                        twoDimArray[indexForRow, indexForSeat] = null;
                        for (int i = 0; i < waitingListArray.Length; i++)
                        {
                            if(waitingListArray[i] != null)
                            {
                                twoDimArray[indexForRow, indexForSeat] = listBoxOne.Items[indexForRow] + listBoxTwo.Items[indexForSeat].ToString() + " - " + waitingListArray[i];
                                waitingListArray[i] = null;
                                labelForMessages.Text = "Seat is successfully cancelled \nThe Customer name from the waiting list is transfered to this seat. \nClick on \"Show Waiting lists\" and \"Show All Resservations\" to see the changes";
                                return;
                            }
                            else
                            {
                                labelForMessages.Text = "Seat is successfully cancelled";
     
                            }
                        }
                    }
                    else
                    {

                        labelForMessages.Text = "Seat is not cancelled";
                    }
                }
                else
                {
                    labelForMessages.Text = "Seat is not booked, please select reserved seat to cancel";
                }


                for (int i = 0; i < twoDimArray.GetLength(0); i++)
                {
                    for (int j = 0; j < twoDimArray.GetLength(1); j++)
                    {
                        if (twoDimArray[i, j] != null)
                        {
                            richTextBoxOne.Text = richTextBoxOne.Text + twoDimArray[i, j] + "\n";
                        }
                        else
                        {
                            richTextBoxOne.Text = richTextBoxOne.Text + listBoxOne.Items[i] + listBoxTwo.Items[j].ToString() + " - " + "\n";
                            availableLists = availableLists + listBoxOne.Items[i] + listBoxTwo.Items[j].ToString() + " - ";
                            labelForMessages.Text = "Available Seats are: " + availableLists;
                        }

                    }
                }
            }
            catch(IndexOutOfRangeException)
            {
                labelForMessages.Text = "Please select Row and Seat";
            }
        }

        //this method fills all the seats 
        private void DebugButton_Click(object sender, EventArgs e)
        {
            if (customerNameBox.Text != "")
            {
                for (int i = 0; i < twoDimArray.GetLength(0); i++)
                {
                    for (int j = 0; j < twoDimArray.GetLength(1); j++)
                    {
                        twoDimArray[i, j] = listBoxOne.Items[i] + listBoxTwo.Items[j].ToString() + " - " + customerNameBox.Text;
                    }
                }
                labelForMessages.Text = "All seats have been booked with same name";
                customerNameBox.Clear();
                listBoxOne.ClearSelected();
                listBoxTwo.ClearSelected();
            }
            else
            {
                labelForMessages.Text = "Please enter customer name";
            }
        }

        private void richTextBoxOne_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
