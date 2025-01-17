﻿using DI2P5G2_Backend.EntitiesContext;
using DI2P5G2_Backend.Entity;
using DI2P5G2_Backend.Repository.Interfaces;
using Microsoft.EntityFrameworkCore;

public class ProfilRepository : IProfilRepository
{
    private readonly DI2P5G2_BackendDbContext _context;

    public ProfilRepository(DI2P5G2_BackendDbContext context)
    {
        _context = context;
    }

    public Profil GetById(int id)
    {
        return _context.Profil.FirstOrDefault(profil => profil.Id == id);
    }

    public IEnumerable<Profil> GetAll()
    {
        return _context.Profil.ToList();
    }

    public void Add(Profil profil)
    {
        _context.Profil.Add(profil);
        _context.SaveChanges();
    }

    public void Update(Profil profil)
    {
        _context.Entry(profil).State = EntityState.Modified;
        _context.SaveChanges();
    }

    public void Delete(Profil profil)
    {
        _context.Profil.Remove(profil);
        _context.SaveChanges();
    }
}