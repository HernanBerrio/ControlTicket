using ControlTicket.Data.Entities;

namespace ControlTicket.Data
{
    public class SeedDb
    {
        private DataContext _context;

        public SeedDb(DataContext context)
        {
            _context = context;
        }
        public async Task SeedAsync()
        {
            await _context.Database.EnsureCreatedAsync();
            await CheckTicketsAsync();
            await CheckEntraceAsync();
        }

        private Task CheckEntraceAsync()
        {
            throw new NotImplementedException();
        }

        private Task CheckTicketsAsync()
        {
            throw new NotImplementedException();
        }
        private async Task CheckEntracesAsync()
        {
            if (!_context.Entrace.Any())
            {
                _context.Tickets.Add(new Ticket { Name = "Oriental" });
                _context.Tickets.Add(new Ticket { Name= "Preferencia" });
                _context.Tickets.Add(new Ticket { Name = "Norte" });
                _context.Tickets.Add(new Ticket { Name = "Sur" });
            }

            await _context.SaveChangesAsync();
        }

        private DataContext Get_context()
        {
            return _context;
        }

        private async Task CheckTickesAsync(DataContext _context)
        {
            if (!_context.Tickets.Any())
            {
                for (int i = 0; i < 5000; i++)
                {
                    _context.Tickets.Add(new Ticket
                    {
                        WasUsed = true,
                        Document = "",
                        Name = "",
                        Entrance = new Entrance()
                        {
                            Description = ""
                        }

                    });

                  
                }
                

            }
        }


    }
}
