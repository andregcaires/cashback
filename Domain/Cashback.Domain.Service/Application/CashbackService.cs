using Cashback.Context.Interface;
using Cashback.Domain.Enums;
using Cashback.Domain.Model;
using Cashback.Service.Interface;
using System;
using System.Collections.Generic;
using System.Text;

namespace Cashback.Service.Application
{
    public class CashbackService : ICashbackService
    {
        private ICashbackRepository _repo;
        public CashbackService(ICashbackRepository repo)
        {
            _repo = repo;
        }

        public void InitializeCashbackDatabase()
        {
            throw new NotImplementedException();
        }

        private List<CashbackByDayOfWeek> GenerateData()
        {
            List<CashbackByDayOfWeek> total = new List<CashbackByDayOfWeek>();

            List<CashbackByDayOfWeek> rock = new List<CashbackByDayOfWeek>() {
                new CashbackByDayOfWeek() { DayOfWeek = DayOfWeek.Sunday, MusicStyle = AlbumStyles.rock.ToString(), Percentage = 0 }
                , new CashbackByDayOfWeek() { DayOfWeek = DayOfWeek.Monday, MusicStyle = AlbumStyles.rock.ToString(), Percentage = 0 }
                , new CashbackByDayOfWeek() { DayOfWeek = DayOfWeek.Tuesday, MusicStyle = AlbumStyles.rock.ToString(), Percentage = 0 }
                , new CashbackByDayOfWeek() { DayOfWeek = DayOfWeek.Wednesday, MusicStyle = AlbumStyles.rock.ToString(), Percentage = 0 }
                , new CashbackByDayOfWeek() { DayOfWeek = DayOfWeek.Thursday, MusicStyle = AlbumStyles.rock.ToString(), Percentage = 0 }
                , new CashbackByDayOfWeek() { DayOfWeek = DayOfWeek.Friday, MusicStyle = AlbumStyles.rock.ToString(), Percentage = 0 }
                , new CashbackByDayOfWeek() { DayOfWeek = DayOfWeek.Saturday, MusicStyle = AlbumStyles.rock.ToString(), Percentage = 0 }
            };
            total.AddRange(rock);

            List<CashbackByDayOfWeek> pop = new List<CashbackByDayOfWeek>() {
                new CashbackByDayOfWeek() { DayOfWeek = DayOfWeek.Sunday, MusicStyle = AlbumStyles.pop.ToString(), Percentage = 0 }
                , new CashbackByDayOfWeek() { DayOfWeek = DayOfWeek.Monday, MusicStyle = AlbumStyles.pop.ToString(), Percentage = 0 }
                , new CashbackByDayOfWeek() { DayOfWeek = DayOfWeek.Tuesday, MusicStyle = AlbumStyles.pop.ToString(), Percentage = 0 }
                , new CashbackByDayOfWeek() { DayOfWeek = DayOfWeek.Wednesday, MusicStyle = AlbumStyles.pop.ToString(), Percentage = 0 }
                , new CashbackByDayOfWeek() { DayOfWeek = DayOfWeek.Thursday, MusicStyle = AlbumStyles.pop.ToString(), Percentage = 0 }
                , new CashbackByDayOfWeek() { DayOfWeek = DayOfWeek.Friday, MusicStyle = AlbumStyles.pop.ToString(), Percentage = 0 }
                , new CashbackByDayOfWeek() { DayOfWeek = DayOfWeek.Saturday, MusicStyle = AlbumStyles.pop.ToString(), Percentage = 0 }
            };

            List<CashbackByDayOfWeek> mpb = new List<CashbackByDayOfWeek>() {
                new CashbackByDayOfWeek() { DayOfWeek = DayOfWeek.Sunday, MusicStyle = AlbumStyles.mpb.ToString(), Percentage = 0 }
                , new CashbackByDayOfWeek() { DayOfWeek = DayOfWeek.Monday, MusicStyle = AlbumStyles.mpb.ToString(), Percentage = 0 }
                , new CashbackByDayOfWeek() { DayOfWeek = DayOfWeek.Tuesday, MusicStyle = AlbumStyles.mpb.ToString(), Percentage = 0 }
                , new CashbackByDayOfWeek() { DayOfWeek = DayOfWeek.Wednesday, MusicStyle = AlbumStyles.mpb.ToString(), Percentage = 0 }
                , new CashbackByDayOfWeek() { DayOfWeek = DayOfWeek.Thursday, MusicStyle = AlbumStyles.mpb.ToString(), Percentage = 0 }
                , new CashbackByDayOfWeek() { DayOfWeek = DayOfWeek.Friday, MusicStyle = AlbumStyles.mpb.ToString(), Percentage = 0 }
                , new CashbackByDayOfWeek() { DayOfWeek = DayOfWeek.Saturday, MusicStyle = AlbumStyles.mpb.ToString(), Percentage = 0 }
            };

            List<CashbackByDayOfWeek> classic = new List<CashbackByDayOfWeek>() {
                new CashbackByDayOfWeek() { DayOfWeek = DayOfWeek.Sunday, MusicStyle = AlbumStyles.classic.ToString(), Percentage = 0 }
                , new CashbackByDayOfWeek() { DayOfWeek = DayOfWeek.Monday, MusicStyle = AlbumStyles.classic.ToString(), Percentage = 0 }
                , new CashbackByDayOfWeek() { DayOfWeek = DayOfWeek.Tuesday, MusicStyle = AlbumStyles.classic.ToString(), Percentage = 0 }
                , new CashbackByDayOfWeek() { DayOfWeek = DayOfWeek.Wednesday, MusicStyle = AlbumStyles.classic.ToString(), Percentage = 0 }
                , new CashbackByDayOfWeek() { DayOfWeek = DayOfWeek.Thursday, MusicStyle = AlbumStyles.classic.ToString(), Percentage = 0 }
                , new CashbackByDayOfWeek() { DayOfWeek = DayOfWeek.Friday, MusicStyle = AlbumStyles.classic.ToString(), Percentage = 0 }
                , new CashbackByDayOfWeek() { DayOfWeek = DayOfWeek.Saturday, MusicStyle = AlbumStyles.classic.ToString(), Percentage = 0 }
            };

            return new List<CashbackByDayOfWeek>().AddRange(classic);
        }

        public void Add(CashbackByDayOfWeek item)
        {
            _repo.Insert(item);
        }

        public List<CashbackByDayOfWeek> SelectAll()
        {
            return _repo.GetAll();
        }
    }
}
