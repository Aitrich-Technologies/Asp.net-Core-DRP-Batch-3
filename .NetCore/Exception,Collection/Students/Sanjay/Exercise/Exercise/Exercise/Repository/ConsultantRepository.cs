using Exercise.Interface;
using Exercise.Models;
using System;
using System.Collections.Generic;
using System.Reflection.Metadata;
using System.Text;

namespace Exercise.Repository
{
    public class ConsultantRepository : IConsultantRepository
    {
        private static Consultant[] consultants = new Consultant[10];
        private static int count = 0;

        public void AddConsultant(Consultant consultant)
        {
            consultants[count++] = consultant;
        }
        public Consultant[] GetAllConsultant()
        {
            return consultants;
        }


        public Consultant Login(string username, string password)
        {

            for (int i = 0; i < count; i++)
            {
                //Console.WriteLine($"Stored: {consultants[i].Username} / {consultants[i].Password}");

                if (consultants[i].Username == username &&
                    consultants[i].Password == password)
                {
                    //Console.WriteLine("✅ Consultant matched!");
                    return consultants[i];
                }
            }

            //Console.WriteLine("❌ Consultant NOT matched");
            return null;
        }

        public void AssignCustomer(int consultantId, int userId)
        {
            for (int i = 0; i < consultants.Length; i++)
            {
                if (consultants[i] != null && consultants[i].ConsultantId == consultantId)
                {
                    var oldCustomers = consultants[i].AssignedCustomers;

                    int[] newCustomers = new int[oldCustomers.Length + 1];

                    for (int j = 0; j < oldCustomers.Length; j++)
                    {
                        newCustomers[j] = oldCustomers[j];
                    }

                    newCustomers[oldCustomers.Length] = userId;

                    consultants[i].AssignedCustomers = newCustomers;

                    Console.WriteLine("Customer assigned successfully!");
                    return;
                }
            }

            Console.WriteLine("Consultant not found!");
        }
    }
    }

