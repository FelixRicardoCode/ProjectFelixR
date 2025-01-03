using Microsoft.EntityFrameworkCore;
using ProjectFelixR.Models;
namespace ProjectFelixR.Services
{
    public class TemplateService : ITemplateService
    {
        private readonly ProjectDbContext _context;

        public TemplateService(ProjectDbContext context)
        {
            _context = context;
        }
        public async Task<List<Template>> GetTemplates()
        {
            return await _context.Templates.ToListAsync();
        }
        public async Task<Template> GetTemplate(int id)
        {
            var template = await _context.Templates.FindAsync(id);
            if (template == null)
            {
                throw new Exception("Template not found");
            }
            return template;
        }
        public async Task AddTemplate(Template template)
        {
            _context.Templates.Add(template);
            await _context.SaveChangesAsync();
        }
        public async Task UpdateTemplate(Template template)
        {
            _context.Entry(template).State = EntityState.Modified;
            await _context.SaveChangesAsync();
        }
        public async Task DeleteTemplate(int id) 
        {
            var template = await _context.Templates.FindAsync(id);
            if (template != null)
            {
                _context.Templates.Remove(template);
                await _context.SaveChangesAsync();
            }
        }
    }
}
