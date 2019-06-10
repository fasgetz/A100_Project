﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using A100_AspNetCore.Models.A100_Models.DataBase;
using A100_AspNetCore.Models.Repositories;
using Microsoft.EntityFrameworkCore;

namespace A100_AspNetCore.Services.API.CityService
{
    public class CityService : ICityService
    {
        private ASTIContext db; // Контекст базы данных

        public CityService(ASTIContext context)
        {
            db = context;
        }


        // Метод, который добавляет город
        public async Task<bool> AddCity(string name)
        {
            return await Task.Run(() =>
            {
                try
                {
                    db.City.AddAsync(new City { CityName = name });

                    db.SaveChangesAsync();
                    return true;
                }
                catch (Exception)
                {

                }

                return false;
            });
        }


        // Метод возвращает ВЕСЬ список городов
        public async Task<List<City>> GetAllCityes()
        {
            try
            {
                return await db.City.ToListAsync();
            }
            catch (Exception)
            {
                return null;
            }
        }

        public async Task<City> GetCityId(int id)
        {
            try
            {
                return await db.City.FirstOrDefaultAsync(i => i.CityId == id);
            }
            catch (Exception)
            {
                return null;
            }
        }

        public async Task<City> GetCityName(string name)
        {
            try
            {
                return await db.City.FirstOrDefaultAsync(i => i.CityName == name);
            }
            catch (Exception)
            {
                return null;
            }
        }
    }
}
