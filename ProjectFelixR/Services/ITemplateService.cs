using ProjectFelixR.Models;

namespace ProjectFelixR.Services
{
    public interface ITemplateService
    {
        Task<List<Template>> GetTemplates();
        Task<Template> GetTemplate(int id);
        Task AddTemplate(Template template);
        Task UpdateTemplate(Template template);
        Task DeleteTemplate(int id);
        
    }
}
