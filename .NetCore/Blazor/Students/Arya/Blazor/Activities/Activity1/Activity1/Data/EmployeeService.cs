namespace Activity1.Data
{
    public class EmployeeService
    {
        EmployeeRepository repository;

    public EmployeeService (EmployeeRepository emprepository)
        {
            repository = emprepository;
        }
        public void AddEmployeeList(EmployeeDetails employee)
        {
            repository.AddEmployee(employee);
        }
        public List <EmployeeDetails>GetEmployeeDetails()
        {
            return repository.GetEmployee();
        }
        public EmployeeDetails GetEmployeeById(int id)
        {
            return repository.GetEmployeeById (id);
        }
        public void UpdateEmployeeList(EmployeeDetails employee)
        {
            repository.UpdateEmployee(employee);
        }

        public void DeleteEmployeeList(EmployeeDetails employee)
        {
            repository.DeleteEmployee(employee);
        }
    }
}
