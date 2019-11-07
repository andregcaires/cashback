using Cashback.Domain.Enums;
using Cashback.Domain.Model;
using System;
using System.Collections.Generic;
using System.Text;

namespace Cashback.Service.Util
{
    public static class GenerateData
    {
        public static List<CashbackByDayOfWeek> AddRock(this List<CashbackByDayOfWeek> list)
        {
            list.AddRange(new List<CashbackByDayOfWeek>() {
                new CashbackByDayOfWeek() { DayOfWeek = DayOfWeek.Sunday, MusicStyle = AlbumStyles.rock.ToString(), Percentage = 0 }
                , new CashbackByDayOfWeek() { DayOfWeek = DayOfWeek.Monday, MusicStyle = AlbumStyles.rock.ToString(), Percentage = 0 }
                , new CashbackByDayOfWeek() { DayOfWeek = DayOfWeek.Tuesday, MusicStyle = AlbumStyles.rock.ToString(), Percentage = 0 }
                , new CashbackByDayOfWeek() { DayOfWeek = DayOfWeek.Wednesday, MusicStyle = AlbumStyles.rock.ToString(), Percentage = 0 }
                , new CashbackByDayOfWeek() { DayOfWeek = DayOfWeek.Thursday, MusicStyle = AlbumStyles.rock.ToString(), Percentage = 0 }
                , new CashbackByDayOfWeek() { DayOfWeek = DayOfWeek.Friday, MusicStyle = AlbumStyles.rock.ToString(), Percentage = 0 }
                , new CashbackByDayOfWeek() { DayOfWeek = DayOfWeek.Saturday, MusicStyle = AlbumStyles.rock.ToString(), Percentage = 0 }
            });
            return list;
        }

        public static List<CashbackByDayOfWeek> AddPop(this List<CashbackByDayOfWeek> list)
        {
            list.AddRange(new List<CashbackByDayOfWeek>() {
                new CashbackByDayOfWeek() { DayOfWeek = DayOfWeek.Sunday, MusicStyle = AlbumStyles.pop.ToString(), Percentage = 0 }
                , new CashbackByDayOfWeek() { DayOfWeek = DayOfWeek.Monday, MusicStyle = AlbumStyles.pop.ToString(), Percentage = 0 }
                , new CashbackByDayOfWeek() { DayOfWeek = DayOfWeek.Tuesday, MusicStyle = AlbumStyles.pop.ToString(), Percentage = 0 }
                , new CashbackByDayOfWeek() { DayOfWeek = DayOfWeek.Wednesday, MusicStyle = AlbumStyles.pop.ToString(), Percentage = 0 }
                , new CashbackByDayOfWeek() { DayOfWeek = DayOfWeek.Thursday, MusicStyle = AlbumStyles.pop.ToString(), Percentage = 0 }
                , new CashbackByDayOfWeek() { DayOfWeek = DayOfWeek.Friday, MusicStyle = AlbumStyles.pop.ToString(), Percentage = 0 }
                , new CashbackByDayOfWeek() { DayOfWeek = DayOfWeek.Saturday, MusicStyle = AlbumStyles.pop.ToString(), Percentage = 0 }
            });
            return list;
        }

        public static List<CashbackByDayOfWeek> AddMpb(this List<CashbackByDayOfWeek> list)
        {
            list.AddRange(new List<CashbackByDayOfWeek>() {
                new CashbackByDayOfWeek() { DayOfWeek = DayOfWeek.Sunday, MusicStyle = AlbumStyles.mpb.ToString(), Percentage = 0 }
                , new CashbackByDayOfWeek() { DayOfWeek = DayOfWeek.Monday, MusicStyle = AlbumStyles.mpb.ToString(), Percentage = 0 }
                , new CashbackByDayOfWeek() { DayOfWeek = DayOfWeek.Tuesday, MusicStyle = AlbumStyles.mpb.ToString(), Percentage = 0 }
                , new CashbackByDayOfWeek() { DayOfWeek = DayOfWeek.Wednesday, MusicStyle = AlbumStyles.mpb.ToString(), Percentage = 0 }
                , new CashbackByDayOfWeek() { DayOfWeek = DayOfWeek.Thursday, MusicStyle = AlbumStyles.mpb.ToString(), Percentage = 0 }
                , new CashbackByDayOfWeek() { DayOfWeek = DayOfWeek.Friday, MusicStyle = AlbumStyles.mpb.ToString(), Percentage = 0 }
                , new CashbackByDayOfWeek() { DayOfWeek = DayOfWeek.Saturday, MusicStyle = AlbumStyles.mpb.ToString(), Percentage = 0 }
            });
            return list;
        }

        public static List<CashbackByDayOfWeek> AddClassic(this List<CashbackByDayOfWeek> list)
        {
            list.AddRange(new List<CashbackByDayOfWeek>() {
                new CashbackByDayOfWeek() { DayOfWeek = DayOfWeek.Sunday, MusicStyle = AlbumStyles.classic.ToString(), Percentage = 0 }
                , new CashbackByDayOfWeek() { DayOfWeek = DayOfWeek.Monday, MusicStyle = AlbumStyles.classic.ToString(), Percentage = 0 }
                , new CashbackByDayOfWeek() { DayOfWeek = DayOfWeek.Tuesday, MusicStyle = AlbumStyles.classic.ToString(), Percentage = 0 }
                , new CashbackByDayOfWeek() { DayOfWeek = DayOfWeek.Wednesday, MusicStyle = AlbumStyles.classic.ToString(), Percentage = 0 }
                , new CashbackByDayOfWeek() { DayOfWeek = DayOfWeek.Thursday, MusicStyle = AlbumStyles.classic.ToString(), Percentage = 0 }
                , new CashbackByDayOfWeek() { DayOfWeek = DayOfWeek.Friday, MusicStyle = AlbumStyles.classic.ToString(), Percentage = 0 }
                , new CashbackByDayOfWeek() { DayOfWeek = DayOfWeek.Saturday, MusicStyle = AlbumStyles.classic.ToString(), Percentage = 0 }
            });
            return list;
        }
    }
}
