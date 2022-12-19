using AutoMapper;
using MDTasks.Models;

namespace MDTasks.Mappings
{
    public class MappingProfile: Profile
    {
        public MappingProfile()
        {
            // Add as many of these lines as you need to map your objects
            CreateMap<Department, DepartmentViewModel>();
            CreateMap<DepartmentViewModel, Department>();
            CreateMap<Project, ProjectViewModel>();
            CreateMap<ProjectViewModel, Project>();
            CreateMap<EmployeeViewModel, Employee>();
            CreateMap<Employee, EmployeeViewModel>();
        }
    }
}
