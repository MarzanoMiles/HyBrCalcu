using System;
using System.Windows.Forms;

namespace HyBrCalcu
{
    public partial class MainForm : Form
    {
        public Label[] labels;
        public int entryCount = 0;
        private int currentStep = 0; // Track the current step in the sorting process

        public MainForm()
        {
            InitializeComponent();

            // Initialize the labels array
            labels = new Label[] { label1, label2, label3, label4, label5 };

            // Add event handlers for Buttons
            button4.Click += Button4Click;
            button5.Click += Button5Click;
            button6.Click += Button6Click;
            button7.Click += Button7Click;
            button8.Click += Button8Click;
            button9.Click += Button9Click;
            button10.Click += Button10Click;

        }

        public void Button1Click(object sender, EventArgs e)
        {
            if (entryCount < 5)
            {
                int number;
                if (int.TryParse(textBox1.Text, out number))
                {
                    listBox1.Items.Add(number);
                    entryCount++;

                    // Display numbers in labels
                    DisplayNumbersInLabels();
                }
                else
                {
                    MessageBox.Show("Please enter a valid number.");
                }
            }
            else
            {
                MessageBox.Show("Maximum limit reached (5 numbers).");
            }
        }

        public void Button2Click(object sender, EventArgs e)
        {
            if (currentStep < listBox1.Items.Count - 1)
            {
                // Bubble sort one step at a time
                BubbleSortStep();

                // Display numbers in labels after sorting step
                DisplayNumbersInLabels();

                // Increment the step for the next click
                currentStep++;
            }
            else
            {
                // Sorting process completed, reset the step
                currentStep = 0;
            }
        }

        public void Button3Click(object sender, EventArgs e)
        {
            if (currentStep < listBox1.Items.Count - 1)
            {
                // Selection sort one step at a time
                SelectionSortStep();

                // Display numbers in labels after sorting step
                DisplayNumbersInLabels();

                // Increment the step for the next click
                currentStep++;
            }
            else
            {
                // Sorting process completed, reset the step
                currentStep = 0;
            }
        }

        public void Button4Click(object sender, EventArgs e)
        {
            if (currentStep < listBox1.Items.Count - 1)
            {
                // Insertion sort one step at a time
                InsertionSortStep();

                // Display numbers in labels after sorting step
                DisplayNumbersInLabels();

                // Increment the step for the next click
                currentStep++;
            }
            else
            {
                // Sorting process completed, reset the step
                currentStep = 0;
            }
        }

        public void Button5Click(object sender, EventArgs e)
        {
            // Clear all input numbers in labels
            for (int i = 0; i < 5; i++)
            {
                labels[i].Text = string.Empty;
            }

            // Clear all input numbers in listBox1
            listBox1.Items.Clear();

            // Reset entryCount and currentStep
            entryCount = 0;
            currentStep = 0;
        }

        public void Button6Click(object sender, EventArgs e)
        {
            // Initialize variables to store the values associated with checked CheckBoxes
            int value1 = 0;
            int value2 = 0;
            int value3 = 0;
            int value4 = 0;
            int value5 = 0;

            // Check if CheckBox1 is checked
            if (checkBox1.Checked)
            {
                // Parse the value from Label1 and store it in value1
                int label1Value;
                if (int.TryParse(label1.Text, out label1Value))
                {
                    value1 = label1Value;
                }
            }

            // Check if CheckBox2 is checked
            if (checkBox2.Checked)
            {
                // Parse the value from Label2 and store it in value2
                int label2Value;
                if (int.TryParse(label2.Text, out label2Value))
                {
                    value2 = label2Value;
                }
            }

            // Check if CheckBox3 is checked
            if (checkBox3.Checked)
            {
                // Parse the value from Label3 and store it in value3
                int label3Value;
                if (int.TryParse(label3.Text, out label3Value))
                {
                    value3 = label3Value;
                }
            }

            // Check if CheckBox4 is checked
            if (checkBox4.Checked)
            {
                // Parse the value from Label4 and store it in value4
                int label4Value;
                if (int.TryParse(label4.Text, out label4Value))
                {
                    value4 = label4Value;
                }
            }

            // Check if CheckBox5 is checked
            if (checkBox5.Checked)
            {
                // Parse the value from Label5 and store it in value5
                int label5Value;
                if (int.TryParse(label5.Text, out label5Value))
                {
                    value5 = label5Value;
                }
            }

            // Calculate the product of the checked CheckBox values
            int result = 1; // Initialize result to 1

            // Multiply only the values of the checked CheckBoxes
            if (checkBox1.Checked)
            {
                result *= value1;
            }

            if (checkBox2.Checked)
            {
                result *= value2;
            }

            if (checkBox3.Checked)
            {
                result *= value3;
            }

            if (checkBox4.Checked)
            {
                result *= value4;
            }

            if (checkBox5.Checked)
            {
                result *= value5;
            }

            // Display the result in Label6
            label6.Text = result.ToString();
            //n
              StoreAnswersInListBox2();
        }

        public void Button7Click(object sender, EventArgs e)
        {
            int sum = 0;

            // Add the values of checked CheckBoxes
            if (checkBox1.Checked)
            {
                sum += int.Parse(label1.Text);
            }

            if (checkBox2.Checked)
            {
                sum += int.Parse(label2.Text);
            }

            if (checkBox3.Checked)
            {
                sum += int.Parse(label3.Text);
            }

            if (checkBox4.Checked)
            {
                sum += int.Parse(label4.Text);
            }

            if (checkBox5.Checked)
            {
                sum += int.Parse(label5.Text);
            }

            // Display the sum in Label6
            label6.Text = sum.ToString();
            //n
              StoreAnswersInListBox2();
        }

        public void Button8Click(object sender, EventArgs e)
        {
            int result = 0;

            // Find the first checked CheckBox
            int startIndex = -1;
            for (int i = 0; i < 5; i++)
            {
                if (labels[i].Text != string.Empty && IsCheckBoxChecked(i + 1))
                {
                    startIndex = i;
                    break;
                }
            }

            // Subtract the numbers between checked CheckBoxes
            for (int i = startIndex + 1; i < 5; i++)
            {
                if (IsCheckBoxChecked(i + 1))
                {
                    result = int.Parse(labels[i].Text) - int.Parse(labels[startIndex].Text);
                    break;
                }
            }

            // Display the result in Label6
            label6.Text = result.ToString();
            //n
              StoreAnswersInListBox2();
        }

        public void Button9Click(object sender, EventArgs e)
        {
            int numerator = 0;
            int denominator = 0;

            // Find the first and second checked CheckBoxes
            int firstIndex = -1;
            int secondIndex = -1;

            for (int i = 0; i < 5; i++)
            {
                if (labels[i].Text != string.Empty && IsCheckBoxChecked(i + 1))
                {
                    if (firstIndex == -1)
                    {
                        firstIndex = i;
                    }
                    else
                    {
                        secondIndex = i;
                        break;
                    }
                }
            }

            // Check if both CheckBoxes are found
            if (firstIndex != -1 && secondIndex != -1)
            {
                numerator = int.Parse(labels[secondIndex].Text);
                denominator = int.Parse(labels[firstIndex].Text);

                // Check if the denominator is not zero
                if (denominator != 0)
                {
                    // Perform division and display the result in Label6
                    int result = numerator / denominator;
                    label6.Text = result.ToString();
                    //n
                      StoreAnswersInListBox2();
                }
                else
                {
                    MessageBox.Show("Cannot divide by zero.");
                }
            }
            else
            {
                MessageBox.Show("Please check at least two CheckBoxes to perform division.");
            }
        }

        public bool IsCheckBoxChecked(int checkBoxNumber)
        {
            switch (checkBoxNumber)
            {
                case 1:
                    return checkBox1.Checked;
                case 2:
                    return checkBox2.Checked;
                case 3:
                    return checkBox3.Checked;
                case 4:
                    return checkBox4.Checked;
                case 5:
                    return checkBox5.Checked;
                default:
                    return false;
            }
        }

        public void SelectionSortStep()
        {
            int minIndex = currentStep;

            for (int i = currentStep + 1; i < listBox1.Items.Count; i++)
            {
                if ((int)listBox1.Items[i] < (int)listBox1.Items[minIndex])
                {
                    minIndex = i;
                }
            }

            Swap(currentStep, minIndex);
        }

        public void BubbleSortStep()
        {
            int currentIndex = currentStep;
            int nextIndex = currentStep + 1;

            int num1 = (int)listBox1.Items[currentIndex];
            int num2 = (int)listBox1.Items[nextIndex];

            // Swap if the first element is greater than the second
            if (num1 > num2)
            {
                Swap(currentIndex, nextIndex);
            }
        }

        public void InsertionSortStep()
        {
            int keyIndex = currentStep + 1;

            while (keyIndex > 0 && (int)listBox1.Items[keyIndex] < (int)listBox1.Items[keyIndex - 1])
            {
                // Swap elements to sort
                Swap(keyIndex, keyIndex - 1);
                keyIndex--;
            }
        }

        public void Swap(int index1, int index2)
        {
            // Swap items in the ListBox
            object temp = listBox1.Items[index1];
            listBox1.Items[index1] = listBox1.Items[index2];
            listBox1.Items[index2] = temp;
        }

        public void DisplayNumbersInLabels()
        {
            // Display numbers in labels
            for (int i = 0; i < 5 && i < listBox1.Items.Count; i++)
            {
                labels[i].Text = listBox1.Items[i].ToString();
            }
        }
        
        //New Line
    public void StoreAnswersInListBox2()
    {
        // Check if listBox2 already has 10 items
        if (listBox2.Items.Count >= 10)
        {
            MessageBox.Show("Maximum limit reached (10 answers).");
            return;
        }

        // Get the current answer from label6
        int currentAnswer;
        if (int.TryParse(label6.Text, out currentAnswer))
        {
            // Add the answer to listBox2
            listBox2.Items.Add(currentAnswer);
        }
        else
        {
            MessageBox.Show("Unable to store the answer in listBox2.");
        }
    }
    //new line
    public void Button10Click(object sender, EventArgs e)
{
    ArrangeInTree();
}

    //mets
    public void ArrangeInTree()
{
    // Check if there are at least 10 results in the ListBox
    if (listBox2.Items.Count >= 10)
    {
        // Create an array to store the results
        int[] results = new int[10];

        // Get the first 10 results from the ListBox
        for (int i = 0; i < 10; i++)
        {
            results[i] = (int)listBox2.Items[i];
        }

        // Sort the results in ascending order (you can use any sorting algorithm here)
        Array.Sort(results);

        // Display the sorted results in Label14 to Label23
        label14.Text = results[0].ToString();
        label15.Text = results[1].ToString();
        label18.Text = results[2].ToString();
        label16.Text = results[3].ToString();
        label17.Text = results[4].ToString();
        label19.Text = results[5].ToString();
        label20.Text = results[6].ToString();
        label21.Text = results[7].ToString();
        label22.Text = results[8].ToString();
        label23.Text = results[9].ToString();
   
    }
    else
    {
        MessageBox.Show("Insufficient results to arrange in a tree. Perform calculations first.");
    }
}


		
		
		
		
		
		
		
	
    }
}
