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

namespace PopulationData
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            String text = "";
            
            DialogResult result = openFile.ShowDialog();

            if (result == DialogResult.OK)
            {
                string file = openFile.FileName;
                try
                {
                    text = File.ReadAllText(file);
                }
                catch (IOException)
                {

                }

                String[] pops = text.Split('\r');

                int[,] population = new int[pops.Length, 2];

                int start = 1950;

                for (int i = 0; i < pops.Length; i++)
                {
                    population[i, 0] = start;
                    population[i, 1] = int.Parse(pops[i]);
                    
                    start++;
                }

                int size = population.GetLength(0);

                for (int i = 0; i < size; i++)
                {
                    Console.Write("Year: " + population[i, 0]);
                    Console.Write(" Pop: " + population[i, 1]);
                    Console.WriteLine();
                  
                }

                avgChangeText.Text = "" + averageChange(population);
                avgChangeText.Visible = true;

                biggestIncreaseText.Text = "" + highestChange(population);
                biggestIncreaseText.Visible = true;

                smallestIncreaseText.Text = "" + leastChange(population);
                smallestIncreaseText.Visible = true;

            }

            //average annual change in pop during time period
            double averageChange(int[,] pop)
            {
                double avg = 0.0;

                int count = pop.GetLength(0) - 1;
                double sum = 0;

                //get difference between each year and average it
                for (int i = pop.GetLength(0) - 1; i > 0; i--)
                {
                    int diff = pop[i, 1] - pop[i - 1, 1];

                    sum += diff;
                }

                avg = sum / count;

                return avg;
            }

            //year with the greatest increase
            int highestChange(int[,] pop)
            {
                int year = 0;
                int highest = 0;

                //loop through each year and population comparing
                for (int i = pop.GetLength(0) - 1; i > 0; i--)
                {
                    int diff = pop[i, 1] - pop[i - 1, 1];

                    if (diff > highest)
                    {
                        highest = diff;
                        year = pop[i, 0];
                    }
                }

                return year;
            }

            //year with the least increase
            int leastChange(int[,] pop)
            {
                int year = 0;
                //set lowest to first difference, compare every other diff to it
                int lowest = pop[pop.GetLength(0) - 1, 1] - pop[pop.GetLength(0) - 2, 1];

                //loop through each year and population comparing
                for (int i = pop.GetLength(0) - 2; i > 0; i--)
                {
                    int diff = pop[i, 1] - pop[i - 1, 1];

                    if (diff < lowest)
                    {
                        lowest = diff;
                        year = pop[i, 0];
                    }
                }

                return year;
            }

        }
    }
}
