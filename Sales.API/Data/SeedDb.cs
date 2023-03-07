using Sales.Shared.Entities;

namespace Sales.API.Data
{
    public class SeedDb
    {
        private readonly DataContext _context;

        public SeedDb(DataContext context)
        {
            _context = context;
        }

        public async Task SeedAsync()
        {
            await _context.Database.EnsureCreatedAsync();
            await CheckCountriesAsync();
        }

        private async Task CheckCountriesAsync()
        {
            if (!_context.Countries.Any())
            {
                _context.Countries.Add(new Country
                {
                    Name = "Colombia",
                    States = new List<State>()
                    {
                        new State()
                        {
                            Name = "Antioquia",
                            Cities = new List<City>() {
                                new City() { Name = "Medellín" },
                                new City() { Name = "Itagüí" },
                                new City() { Name = "Envigado" },
                                new City() { Name = "Bello" },
                                new City() { Name = "Rionegro" },
                            }
                        },
                        new State()
                        {
                            Name = "Bogotá",
                            Cities = new List<City>() {
                                new City() { Name = "Usaquen" },
                                new City() { Name = "Champinero" },
                                new City() { Name = "Santa fe" },
                                new City() { Name = "Useme" },
                                new City() { Name = "Bosa" },
                            }
                        },
                    }
                });
                _context.Countries.Add(new Country
                {
                    Name = "Estados Unidos",
                    States = new List<State>()
                    {
                        new State()
                        {
                            Name = "Florida",
                            Cities = new List<City>() {
                                new City() { Name = "Orlando" },
                                new City() { Name = "Miami" },
                                new City() { Name = "Tampa" },
                                new City() { Name = "Fort Lauderdale" },
                                new City() { Name = "Key West" },
                            }
                        },
                        new State()
                        {
                            Name = "Texas",
                            Cities = new List<City>() {
                                new City() { Name = "Houston" },
                                new City() { Name = "San Antonio" },
                                new City() { Name = "Dallas" },
                                new City() { Name = "Austin" },
                                new City() { Name = "El Paso" },
                            }
                        },
                    }
                });

                await _context.SaveChangesAsync();
            }

       
            if (!_context.Categories.Any())
            {
                _context.Categories.Add(new Category { Name = "Hogar y decoración" });
                _context.Categories.Add(new Category { Name = "Moda y accesorios" });
                _context.Categories.Add(new Category { Name = "Electrónica y tecnología" });
                _context.Categories.Add(new Category { Name = "Belleza y cuidado personal" });
                _context.Categories.Add(new Category { Name = "Juguetes y juegos" });
                _context.Categories.Add(new Category { Name = "Deportes y aire libre" });
                _context.Categories.Add(new Category { Name = "Alimentos y bebidas" });
                _context.Categories.Add(new Category { Name = "Salud y bienestar" });
                _context.Categories.Add(new Category { Name = "Viajes y turismo" });
                _context.Categories.Add(new Category { Name = "Artes y manualidades" });
                _context.Categories.Add(new Category { Name = "Libros y revistas" });
                _context.Categories.Add(new Category { Name = "Muebles y accesorios" });
                _context.Categories.Add(new Category { Name = "Herramientas y equipos de construcción" });
                _context.Categories.Add(new Category { Name = "Joyería y relojes" });
                _context.Categories.Add(new Category { Name = "Mascotas y accesorios para mascotas" });
                _context.Categories.Add(new Category { Name = "Instrumentos musicales" });
                _context.Categories.Add(new Category { Name = "Jardinería y exteriores" });
                _context.Categories.Add(new Category { Name = "Suministros para oficina y papelería" });
                _context.Categories.Add(new Category { Name = "Artículos de colección" });
                _context.Categories.Add(new Category { Name = "Fotografía y videografía" });
                _context.Categories.Add(new Category { Name = "Cine y televisión" });
                _context.Categories.Add(new Category { Name = "Equipos médicos y suministros" });
                _context.Categories.Add(new Category { Name = "Suministros para fiestas y eventos" });
                _context.Categories.Add(new Category { Name = "Artículos de iluminación" });
                _context.Categories.Add(new Category { Name = "Suministros de limpieza y organización" });
                _context.Categories.Add(new Category { Name = "Maletas y accesorios de viaje" });
                _context.Categories.Add(new Category { Name = "Productos para bebés y niños pequeños" });
                _context.Categories.Add(new Category { Name = "Productos de limpieza del hogar" });
                _context.Categories.Add(new Category { Name = "Suministros para la industria alimentaria" });
                _context.Categories.Add(new Category { Name = "Accesorios para automóviles" });
                _context.Categories.Add(new Category { Name = "Suministros para construcción y reparación de vehículos" });
                _context.Categories.Add(new Category { Name = "Ropa de cama y baño" });

                await _context.SaveChangesAsync();
            }
        }
    }
}