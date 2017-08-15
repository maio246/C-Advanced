namespace _04.Fourth_Problem
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;

    public static class ProblemFour
    {
        public static void Main()
        {
            var departmentss = new Dictionary<string, Dictionary<int, List<string>>>();
            var doctors = new Dictionary<string, List<string>>();
            string patient;
            var counter = 1;

            while ((patient = Console.ReadLine()) != "Output")
            {
                var patientPram = patient.Split(new[] { ' ' }, StringSplitOptions.RemoveEmptyEntries).ToArray();

                var currDepartment = patientPram[0];
                var doctor = patientPram[1] + " " + patientPram[2];
                var currPatient = patientPram.Last();

                // import patients
                ImportPatients(departmentss, currPatient, counter, currDepartment);

                //move to the next room
                if (departmentss[currDepartment][counter].Count == 3) counter++;


                // asign patients to doctors
                AssingPatients(doctors, doctor, currPatient);

            }

            string commandToPrint;
            while ((commandToPrint = Console.ReadLine()) != "End")
            {
                var tokens = commandToPrint.Split(new[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);
                var firstToken = tokens[0];

                if (tokens.Length == 2)
                {
                    //input doctor
                    var room = 0;
                    var hasRoom = int.TryParse(tokens[1], out room);

                    if (hasRoom)
                    {
                        foreach (var currRoom in departmentss[firstToken][room].OrderBy(x => x).ToList())
                        {
                            Console.WriteLine(currRoom);
                        }

                    }
                    else
                    {
                        if (doctors.ContainsKey(firstToken + " " + tokens[1]))
                        {
                            Console.WriteLine(string.Join("\n", doctors[firstToken + " " + tokens[1]].OrderBy(x => x)));

                        }
                    }
                }
                else if (tokens.Length == 1 && departmentss.ContainsKey(firstToken))
                {
                    foreach (var department in departmentss[firstToken])
                    {
                        foreach (var patien in department.Value)
                        {
                            Console.WriteLine(patien);
                        }
                    }
                }
            }
        }

        public static void AssingPatients(Dictionary<string, List<string>> doctors, string doctor, string currPatient)
        {
            if (!doctors.ContainsKey(doctor))
            {
                doctors.Add(doctor, new List<string>());
            }
            if (!doctors[doctor].Contains(currPatient))
            {
                doctors[doctor].Add(currPatient);
            }
        }

        public static void ImportPatients(Dictionary<string, Dictionary<int, List<string>>> departmentss, string patient, int counter, string currDepartment)
        {
            if (!departmentss.ContainsKey(currDepartment))
            {
                departmentss.Add(currDepartment, new Dictionary<int, List<string>>());
            }
            if (!departmentss[currDepartment].ContainsKey(counter) && counter <= 20)
            {
                departmentss[currDepartment].Add(counter, new List<string>());
            }
            if (!departmentss[currDepartment][counter].Contains(patient) &&
                departmentss[currDepartment][counter].Count < 3)
            {
                departmentss[currDepartment][counter].Add(patient);
            }
            else if (!departmentss[currDepartment][counter + 1].Contains(patient))
            {
                departmentss[currDepartment][counter + 1].Add(patient);
                counter++;
            }
        }
    }
}
