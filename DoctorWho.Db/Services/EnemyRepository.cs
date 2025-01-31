﻿
namespace DoctorWho.Db
{
    public class EnemyRepository
    {
        private DoctorWhoCoreDbContext _context;
        public EnemyRepository(DoctorWhoCoreDbContext context)
        {
            _context = context;
        }
        public async Task CreateEnemyAsync(string enemyName)
        {
            if (!string.IsNullOrEmpty(enemyName))
            {
                var enemy = new Enemy { EnemyName = enemyName };
                _context.Enemies.Add(enemy);
                await _context.SaveChangesAsync();
            }
        }

        public async Task DeleteEnemyAsync(string enemyName)
        {
            var enemy = _context.Enemies.Where(e => e.EnemyName == enemyName).FirstOrDefault();
            if (enemy != null)
            {
                _context.Enemies.Remove(enemy);
                await _context.SaveChangesAsync();
            }
        }

        public async Task UpdateEnemyAsync(Enemy enemy)
        {
            _context.Enemies.Update(enemy);
            await _context.SaveChangesAsync();
        }

        public async Task<Enemy> GetEnemyByIdAsync(int id)
        {
            var enemy = await _context.Enemies.FindAsync(id);
            if (enemy != null)
            {
                return enemy;
            }
            throw new NullReferenceException("No enemies with the provided Id !");
        }
    }
}
