﻿using Be.KhunLy.EF.Repository;
using Moodle.BLL.Interfaces;
using Moodle.Domain.entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Moodle.DAL.Repositories
{
    public class CursusRepository : BaseRepository<Cursus>, ICursusRepository
    {
        public CursusRepository(MoodleContext context) : base(context) { }

        public Cursus FindCursusByUserId(int userId)
        {
            return base.Find(userId);
        }

        public List<Cursus> GetCursusByUserCursusId(int userCursusId)
        {
            return _table.Where(cursus => cursus.Id == userCursusId).ToList();
        }

    }
}
