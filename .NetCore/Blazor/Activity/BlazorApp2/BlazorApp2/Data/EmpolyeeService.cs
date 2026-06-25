namespace BlazorApp2.Data
{
    public class EmpolyeeService
    {
        EmployeeRepository repository;

        public EmpolyeeService(EmployeeRepository empRepository)
        {
            repository = empRepository;
        }

        public void AddEmployeeList(EmployeeDetails employee)
        {
            repository.AddEmployee(employee);
        }

        public List<EmployeeDetails> GetEmployeeList()
        {
            return repository.GetEmployee();
        }

        public EmployeeDetails GetEmployeeListById(int id)
        {
            return repository.GetEmployeeById(id);
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
