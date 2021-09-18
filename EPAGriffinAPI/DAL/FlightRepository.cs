﻿using EPAGriffinAPI.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Web;
using System.Data.Entity;
using System.Data.Entity.Infrastructure;
using System.Net;
using EPAGriffinAPI.ViewModels;
using System.Threading;
using Newtonsoft.Json;
using System.Globalization;
using System.Data.SqlClient;
using System.Text;
using System.Drawing;
using System.Data;
using System.IO;
using System.Diagnostics;
using System.Configuration;

namespace EPAGriffinAPI.DAL
{
    public class FlightRepository : GenericRepository<Models.FlightInformation>
    {
        public FlightRepository(EPAGRIFFINEntities context)
       : base(context)
        {
        }

        public IQueryable<ViewFlightInformation> GetViewFlights()
        {
            return this.GetQuery<ViewFlightInformation>();
        }
        public IQueryable<ViewImportPlan> GetViewImportPlan()
        {
            return this.GetQuery<ViewImportPlan>();
        }
        public IQueryable<FlightInformation> GetFlights()
        {
            return this.GetQuery<FlightInformation>();
        }
        public IQueryable<FDPItem> GetFDPItems()
        {
            return this.GetQuery<FDPItem>();
        }
        public IQueryable<ViewFlightCrewX> GetViewFlightCrewXes()
        {
            return this.GetQuery<ViewFlightCrewX>();
        }
        public IQueryable<ViewFlightFDP> GetViewFlightFDPs()
        {
            return this.GetQuery<ViewFlightFDP>();
        }
        public IQueryable<ViewFlightCrewNew> GetViewFlightCrewNews()
        {
            return this.GetQuery<ViewFlightCrewNew>();
        }
        public IQueryable<ViewLegTime> GetViewLegTime()
        {
            return this.GetQuery<ViewLegTime>();
        }
        public IQueryable<ViewFDRReport> GetViewFDRReport()
        {
            return this.GetQuery<ViewFDRReport>();
        }
        public IQueryable<ViewLegCrew> GetViewLegCrew()
        {
            return this.GetQuery<ViewLegCrew>();
        }
        public IQueryable<ViewFlightCrewNewX> GetViewFlightCrewNewXs()
        {
            return this.GetQuery<ViewFlightCrewNewX>();
        }
        public IQueryable<ViewFDPLog> GetViewFDPLog()
        {
            return this.GetQuery<ViewFDPLog>();
        }

        public IQueryable<Coord> GetCoords()
        {
            return this.GetQuery<Coord>();
        }
        public IQueryable<ViewFlightChangeHistory> GetViewFlightChangeHistories()
        {
            return this.GetQuery<ViewFlightChangeHistory>();
        }
        public IQueryable<ViewFlightCrewArchive> GetViewFlightCrewArchives()
        {
            return this.GetQuery<ViewFlightCrewArchive>();
        }
        public IQueryable<ViewFlightCrewNewXTime> GetViewFlightCrewNewXTime()
        {
            return this.GetQuery<ViewFlightCrewNewXTime>();
        }
        public IQueryable<ViewPositioning> GetViewPositioning()
        {
            return this.GetQuery<ViewPositioning>();
        }
        public IQueryable<ViewLayOver> GetViewLayOver()
        {
            return this.GetQuery<ViewLayOver>();
        }
        public IQueryable<ViewFlightDelay> GetViewFlightDelays()
        {
            return this.GetQuery<ViewFlightDelay>();
        }
        public IQueryable<ViewFlightPlan> GetViewFlightPlans()
        {
            return this.GetQuery<ViewFlightPlan>();
        }
        public IQueryable<ViewFlightPlanCalander> GetViewFlightPlansCalendar()
        {
            return this.GetQuery<ViewFlightPlanCalander>();
        }
        public IQueryable<ViewBoxCrew> GetViewBoxCrews()
        {
            return this.GetQuery<ViewBoxCrew>();
        }
        public IQueryable<ViewCrewAssignFDP> GetViewCrewAssignFDP()
        {
            return this.GetQuery<ViewCrewAssignFDP>();
        }
        public IQueryable<ViewCrewCalendar> GetViewCrewCalendar()
        {
            return this.GetQuery<ViewCrewCalendar>();
        }
        public IQueryable<EmployeeCalendar> GetEmployeeCalendar()
        {
            return this.GetQuery<EmployeeCalendar>();
        }
        public IQueryable<ViewFlightFuel> GetViewFlightFuel()
        {
            return this.GetQuery<ViewFlightFuel>();
        }
        public IQueryable<ViewRosterSheet> GetViewRosterSheet()
        {
            return this.GetQuery<ViewRosterSheet>();
        }
        public IQueryable<ViewRosterReportFP> GetViewRosterReportFP()
        {
            return this.GetQuery<ViewRosterReportFP>();
        }
        public IQueryable<ViewRosterReport> GetViewRosterReport()
        {
            return this.GetQuery<ViewRosterReport>();
        }
        public IQueryable<ViewFDPCrewDetail> GetViewFDPCrewDetail()
        {
            return this.GetQuery<ViewFDPCrewDetail>();
        }
        public IQueryable<ViewFDPCrewDetailSM> GetViewFDPCrewDetailSMS()
        {
            return this.GetQuery<ViewFDPCrewDetailSM>();
        }
        public IQueryable<ViewFlightCrew2> GetViewFlightCrew2()
        {
            return this.GetQuery<ViewFlightCrew2>();
        }
        public IQueryable<ViewCrewTimeDetail> GetViewCrewTimeDetail()
        {
            return this.GetQuery<ViewCrewTimeDetail>();
        }
        public IQueryable<ViewRotserDailyCrew> GetViewRotserDailyCrew()
        {
            return this.GetQuery<ViewRotserDailyCrew>();
        }
        public IQueryable<ViewDailyRosterFlight> GetViewDailyRosterFlight()
        {
            return this.GetQuery<ViewDailyRosterFlight>();
        }
        public IQueryable<ViewFlightSecurity> GetViewFlightSecurity()
        {
            return this.GetQuery<ViewFlightSecurity>();
        }
        public IQueryable<ViewFlightCockpit> GetViewFlightCockpit()
        {
            return this.GetQuery<ViewFlightCockpit>();
        }
        public IQueryable<ViewFlightSecurityDH> GetViewFlightSecurityDH()
        {
            return this.GetQuery<ViewFlightSecurityDH>();
        }
        public IQueryable<ViewCrew> GetViewCrew()
        {
            return this.GetQuery<ViewCrew>();
        }
        public IQueryable<ViewDispatchSMSEmployee> GetViewDispatchSMSEmployee()
        {
            return this.GetQuery<ViewDispatchSMSEmployee>();
        }
        public IQueryable<ViewCrewCode> GetViewCrewCode()
        {
            return this.GetQuery<ViewCrewCode>();
        }
        public IQueryable<ViewRoute> GetViewRoute()
        {
            return this.GetQuery<ViewRoute>();
        }
        public IQueryable<ViewFin> GetViewFin()
        {
            return this.GetQuery<ViewFin>();
        }

        public IQueryable<ViewFinMonthly> GetViewFinMonthly()
        {
            return this.GetQuery<ViewFinMonthly>();
        }

        public IQueryable<ViewFinMonthlyRoute> GetViewFinMonthlyRoute()
        {
            return this.GetQuery<ViewFinMonthlyRoute>();
        }
        public IQueryable<ViewFinYearlyRoute> GetViewFinYearlyRoute()
        {
            return this.GetQuery<ViewFinYearlyRoute>();
        }

        public IQueryable<ViewFinMonthlyPersian> GetViewFinMonthlyPersian()
        {
            return this.GetQuery<ViewFinMonthlyPersian>();
        }

        public IQueryable<ViewCrewValid> GetViewCrewValid()
        {
            return this.GetQuery<ViewCrewValid>();
        }
        public IQueryable<ViewDayDutyFlight> GetViewDayDutyFlight()
        {
            return this.GetQuery<ViewDayDutyFlight>();
        }
        public IQueryable<ViewFDP> GetViewFDP()
        {
            return this.GetQuery<ViewFDP>();
        }
        public IQueryable<ViewFDPRest> GetViewFDPRest()
        {
            return this.GetQuery<ViewFDPRest>();
        }
        public IQueryable<ViewCrewDuty> GetViewCrewDuty()
        {
            return this.GetQuery<ViewCrewDuty>();
        }
        public IQueryable<ViewFDPFlightDetail> GetViewFDPFlightDetail()
        {
            return this.GetQuery<ViewFDPFlightDetail>();
        }
        public IQueryable<ViewRegisterGround> GetViewRegisterGround()
        {
            return this.GetQuery<ViewRegisterGround>();
        }
        public IQueryable<ViewDutyFDPDetail> GetViewDutyFDPDetail()
        {
            return this.GetQuery<ViewDutyFDPDetail>();
        }
        public IQueryable<ViewFlightPlanItem> GetViewFlightPlanItems()
        {
            return this.GetQuery<ViewFlightPlanItem>();
        }
        public IQueryable<ViewPlanItem> GetViewPlanItemsBoard()
        {
            return this.GetQuery<ViewPlanItem>();
        }
        public IQueryable<ViewFlightPlanItemCalander> GetViewFlightPlanItemsCalander()
        {
            return this.GetQuery<ViewFlightPlanItemCalander>();
        }
        public IQueryable<ViewFlightPlanItemPermit> GetViewFlightPlanItemPermits()
        {
            return this.GetQuery<ViewFlightPlanItemPermit>();
        }
        public IQueryable<ViewFlightPlanCalanderCrew> GetViewFlightPlanCalanderCrew()
        {
            return this.GetQuery<ViewFlightPlanCalanderCrew>();
        }

        public IQueryable<FlightPlanCalanderCrew> GetFlightPlanCalanderCrew()
        {
            return this.GetQuery<FlightPlanCalanderCrew>();
        }
        public IQueryable<FlightPermit> GetFlightPermits()
        {
            return this.GetQuery<FlightPermit>();
        }
        public IQueryable<ViewFlighPlanAssignedRegister> GetViewFlightPlanAssignedRegisters()
        {
            return this.GetQuery<ViewFlighPlanAssignedRegister>();
        }


        public IQueryable<ViewDelayCode> GetViewDelayCodes()
        {
            return this.GetQuery<ViewDelayCode>();
        }

        public IQueryable<DelayCodeCategory> GetDelayCodeCategory()
        {
            return this.GetQuery<DelayCodeCategory>();
        }
        public IQueryable<ViewFlightsAcType> GetViewFlightsAcTypes()
        {
            return this.GetQuery<ViewFlightsAcType>();
        }
        public IQueryable<ViewFlightsRegister> GetViewFlightsRegisters()
        {
            return this.GetQuery<ViewFlightsRegister>();
        }
        public IQueryable<ViewFlightsFrom> GetViewFlightsFrom()
        {
            return this.GetQuery<ViewFlightsFrom>();
        }
        public IQueryable<ViewFlightsTo> GetViewFlightsTo()
        {
            return this.GetQuery<ViewFlightsTo>();
        }
        public IQueryable<ViewFlightRoute> GetViewFlightRoutes()
        {
            return this.GetQuery<ViewFlightRoute>();
        }
        public IQueryable<ViewRouteFromAirport> GetViewRouteFromAirport()
        {
            return this.GetQuery<ViewRouteFromAirport>();
        }
        public IQueryable<ViewFlightDelayCode> GetViewFlightDelayCode(int flightId)
        {
            var delayCodes = this.context.ViewDelayCodes.ToList();
            var flightDelays = this.context.FlightDelays.Where(q => q.FlightId == flightId).ToList();
            var result = new List<ViewFlightDelayCode>();
            foreach (var x in delayCodes)
            {
                var fd = flightDelays.FirstOrDefault(q => q.DelayCodeId == x.Id);
                var item = new ViewFlightDelayCode()
                {
                    FlightId = (fd == null) ? -1 : fd.FlightId,
                    FlighrDelayId = (fd == null) ? null : (Nullable<int>)fd.ID,
                    HH = (fd == null) ? null : fd.HH,
                    MM = (fd == null) ? null : fd.MM,
                    UserId = (fd == null) ? null : fd.UserId,
                    Category = x.Category,
                    Title = x.Title,
                    Code = x.Code,
                    DelayCategoryId = x.DelayCategoryId,
                    AirlineId = x.AirlineId,
                    DelayCodeId = x.Id,
                    Selected = (fd == null) ? 0 : 1,

                    Remark = x.Remark,

                };
                result.Add(item);
            }
            return result.AsQueryable();
            //return this.GetQuery<ViewFlightDelayCode>().Where(q => q.FlightId == flightId || q.FlightId == -1);
        }
        public IQueryable<ViewFlightPlanItem> GetViewFlightPlanItems(int pid)
        {
            return this.GetQuery<ViewFlightPlanItem>().Where(q => q.FlightPlanId == pid);
        }

        public async Task<Models.FlightPlan> GetPlanById(int id)
        {
            return await this.context.FlightPlans.FirstOrDefaultAsync(q => q.Id == id);
        }
        public async Task<Models.PlanItem> GetBoardPlanItemById(int id)
        {
            return await this.context.PlanItems.FirstOrDefaultAsync(q => q.Id == id);
        }

        public async Task<Models.EmployeeCalendar> GetEmployeeCalendarById(int id)
        {
            return await this.context.EmployeeCalendars.FirstOrDefaultAsync(q => q.Id == id);
        }
        public async Task<Models.EmployeeCalendarSplited> GetEmployeeCalendarSplitedById(int id)
        {
            return await this.context.EmployeeCalendarSpliteds.FirstOrDefaultAsync(q => q.Id == id);
        }


        public async Task<Models.EmployeeCalendar> GetEmployeeCalendar(int eid, DateTime date)
        {
            return await this.context.EmployeeCalendars.FirstOrDefaultAsync(q => q.EmployeeId == eid && q.Date == date);
        }

        public async Task<Models.FlightPlanRegister> GetFlightPlanRegisterById(int id)
        {
            return await this.context.FlightPlanRegisters.FirstOrDefaultAsync(q => q.Id == id);
        }
        public bool IsBoxCrewAllAssigned(int bid)
        {
            return this.context.ViewBoxCrewRequirements.Where(q => q.Id == bid && q.Assigned != q.Min).FirstOrDefault() == null;
        }
        public async Task<Models.FlightPlan> GetPlanByTitle(string title)
        {
            return await this.context.FlightPlans.FirstOrDefaultAsync(q => q.Title == title);
        }
        public async Task<Models.FlightPlanItem> GetPlanItemById(int id)
        {
            return await this.context.FlightPlanItems.FirstOrDefaultAsync(q => q.Id == id);
        }
        public async Task<Models.FlightInformation> GetFlightById(int id)
        {
            return await this.context.FlightInformations.FirstOrDefaultAsync(q => q.ID == id);
        }

        public async Task<Models.FlightPlanItemPermit> GetFlightPlanItemPermitById(int id)
        {
            return await this.context.FlightPlanItemPermits.FirstOrDefaultAsync(q => q.Id == id);
        }

        public async Task<Models.FlightPlanCalanderCrew> GetFlightPlanCalanderCrewById(int id)
        {
            return await this.context.FlightPlanCalanderCrews.FirstOrDefaultAsync(q => q.Id == id);
        }

        public async Task<Models.BoxCrew> GetBoxCrewById(int id)
        {
            return await this.context.BoxCrews.FirstOrDefaultAsync(q => q.Id == id);
        }


        public async Task<Models.AvgFlight> GetFlightAVG(int from, int to)
        {
            return await this.context.AvgFlights.FirstOrDefaultAsync(q => q.FromAirport == from && q.ToAirport == to);
        }


        public async Task<object> GetCrewFlights(DateTime day)
        {
            var query = await (from c in this.context.ViewFlightCrewNewXes
                               join f in this.context.ViewLegTimes on c.FlightId equals f.ID
                               where f.STDDay == day
                               select new
                               {
                                   c.CrewId,
                                   c.Name,
                                   c.ScheduleName,
                                   c.GroupId,
                                   c.JobGroup,
                                   c.JobGroupCode,
                                   c.FlightId,
                                   c.Position,
                                   c.PositionId,
                                   f.STDDay,
                                   f.Date,
                                   f.FlightNumber,
                                   f.STD,
                                   f.STDLocal,
                                   f.STA,
                                   f.STALocal,
                                   f.FromAirport,
                                   f.FromAirportIATA,
                                   f.ToAirport,
                                   f.ToAirportIATA,
                                   f.FlightTime,
                                   f.FlightTimeActual,
                                   f.ScheduledFlightTime,
                                   f.BlockTime,
                                   c.IsPositioning,
                                   f.Register,
                                   f.RegisterID,
                                   c.FDPId,
                                   c.FDPItemId



                               }).ToListAsync();
            var grps = (from x in query
                        group x by new { x.CrewId, x.Name, x.ScheduleName, x.JobGroup, x.JobGroupCode, x.GroupId } into grp
                        select new
                        {
                            grp.Key.CrewId,
                            grp.Key.Name,
                            grp.Key.ScheduleName,
                            grp.Key.JobGroup,
                            grp.Key.JobGroupCode,
                            grp.Key.GroupId,
                            flights = grp.ToList(),
                        }).ToList();
            return grps;
        }


        public async Task<ViewModels.FlightPlanDto> GetFlightPlanById(int Id)
        {
            var plan = await this.context.ViewFlightPlans.FirstOrDefaultAsync(q => q.Id == Id);
            if (plan == null)
                return null;
            var plandto = new ViewModels.FlightPlanDto();
            ViewModels.FlightPlanDto.FillDto(plan, plandto);
            plandto.Months = await this.context.FlightPlanMonths.Where(q => q.FlightPlanId == Id).Select(q => q.Month).ToListAsync();
            plandto.Days = await this.context.FlightPlanDays.Where(q => q.FlightPlanId == Id).Select(q => q.Day).ToListAsync();


            return plandto;
        }


        public async Task<FlightRoute> AddRoute(ViewModels.RouteDto dto)
        {
            FlightRoute entity = null;
            if (dto.Id != -1)
            {
                entity = await this.context.FlightRoutes.Where(q => q.Id == dto.Id).FirstOrDefaultAsync();
                if (entity == null)
                    return null;
            }
            entity = await this.context.FlightRoutes.Where(q => q.AirlineId == dto.AirlineId && q.SourceAirportId == dto.SourceAirportId && q.DestinationAirportId == dto.DestinationAirportId).FirstOrDefaultAsync();
            if (entity == null)
            {
                entity = new FlightRoute()
                {
                    SourceAirportId = dto.SourceAirportId,
                    DestinationAirportId = dto.DestinationAirportId,
                    AirlineId = dto.AirlineId,
                    FlightH = dto.FlightH,
                    FlightM = dto.FlightM,

                };
                this.context.FlightRoutes.Add(entity);
            }
            else
            {
                entity.FlightH = dto.FlightH;
                entity.FlightM = dto.FlightM;
            }
            return entity;
        }

        public async Task<bool> DeleteRoute(int id)
        {
            FlightRoute entity = await this.context.FlightRoutes.Where(q => q.Id == id).FirstOrDefaultAsync();
            if (entity == null)
                return false;
            this.context.FlightRoutes.Remove(entity);
            return true;

        }


        //=================
        public virtual CustomActionResult ValidateDelayCode(ViewModels.DelayCodeDto dto)
        {
            //var checkByName = GetByName(dto.Id, dto.Name);
            //if (checkByName != null)
            //    return Exceptions.getDuplicateException("AIRPORT-01", "Name");
            var exist = this.context.DelayCodes.FirstOrDefault(q => q.Id != dto.Id && q.Code == dto.Code);
            if (exist != null)
            {
                return Exceptions.getDuplicateException("DelayCode-01", "The code is duplicate");
            }

            return new CustomActionResult(HttpStatusCode.OK, "");
        }
        public async Task<DelayCode> AddDelayCode(ViewModels.DelayCodeDto dto)
        {

            DelayCode entity = null;
            if (dto.Id != -1)
            {
                entity = await this.context.DelayCodes.Where(q => q.Id == dto.Id).FirstOrDefaultAsync();
                if (entity == null)
                    return null;
                entity.AirlineId = dto.AirlineId;
                entity.Code = dto.Code;
                entity.DelayCategoryId = dto.DelayCategoryId;
                entity.Remark = dto.Remark;
                entity.Title = dto.Title;
            }
            else
            {
                entity = new DelayCode()
                {
                    AirlineId = dto.AirlineId,
                    Code = dto.Code,
                    DelayCategoryId = dto.DelayCategoryId,
                    Remark = dto.Remark,
                    Title = dto.Title,

                };
                this.context.DelayCodes.Add(entity);
            }

            return entity;
        }

        public async Task<bool> DeleteDelayCode(int id)
        {
            DelayCode entity = await this.context.DelayCodes.Where(q => q.Id == id).FirstOrDefaultAsync();
            if (entity == null)
                return false;
            this.context.DelayCodes.Remove(entity);
            return true;

        }


        public List<ViewCrewTime> GetOverDuty(string date, int pid, int duty, int flight)
        {
            //return this.context.GetOverDuty(date, duty, flight, pid).ToList();
            //useless
            return new List<ViewCrewTime>();
        }

        public async Task<ViewModels.FlightPlanSummary> GetFlightPlanSummary(int Id, int tzoffset)
        {
            var plan = await this.context.ViewFlightPlans.FirstOrDefaultAsync(q => q.Id == Id);
            if (plan == null)
                return null;
            var plandto = new ViewModels.FlightPlanSummary();
            ViewModels.FlightPlanSummary.FillDto(plan, plandto);
            var month = await this.context.FlightPlanMonths.Where(q => q.FlightPlanId == Id).ToListAsync();
            var day = await this.context.FlightPlanDays.Where(q => q.FlightPlanId == Id).ToListAsync();
            plandto.Months = month.Select(q => q.Month).ToList();
            plandto.Days = day.Select(q => q.Day).ToList();

            plandto.MonthsStr = string.Join(", ", month.Select(q => CultureInfo.CurrentCulture.DateTimeFormat.GetAbbreviatedMonthName(q.Month + 1)).ToList());
            plandto.DaysStr = string.Join(", ", day.Select(q => CultureInfo.CurrentCulture.DateTimeFormat.GetAbbreviatedDayName((DayOfWeek)q.Day)).ToList());

            var aregs = GetViewFlightPlanAssignedRegisters().Where(q => q.FlightPlanId == Id).ToList();
            foreach (var x in aregs)
            {
                x.STA = ((DateTime)x.STA).AddMinutes(tzoffset);
                x.STD = ((DateTime)x.STD).AddMinutes(tzoffset);
            }
            plandto.AssignedRegisters = aregs;
            return plandto;
        }
        public async Task<List<int>> GetFlightPlanMonth(int Id)
        {


            //plandto.Months = await this.context.FlightPlanMonths.Where(q => q.FlightPlanId == Id).Select(q => q.Month).ToListAsync();
            // plandto.Days = await this.context.FlightPlanDays.Where(q => q.FlightPlanId == Id).Select(q => q.Day).ToListAsync();


            return await this.context.FlightPlanMonths.Where(q => q.FlightPlanId == Id).Select(q => q.Month).ToListAsync();
        }
        public async Task<List<int>> GetFlightPlanDays(int Id)
        {


            //plandto.Months = await this.context.FlightPlanMonths.Where(q => q.FlightPlanId == Id).Select(q => q.Month).ToListAsync();
            // plandto.Days = await this.context.FlightPlanDays.Where(q => q.FlightPlanId == Id).Select(q => q.Day).ToListAsync();


            return await this.context.FlightPlanDays.Where(q => q.FlightPlanId == Id).Select(q => q.Day).ToListAsync();
        }

        public async Task<List<Models.FlightPlanItem>> GetPlanItemsByIds(List<int> Ids)
        {
            //return await this.context.FlightPlans.FirstOrDefaultAsync(q => q.Id == id);
            var query = from x in this.context.FlightPlanItems
                        where Ids.Contains(x.Id)
                        select x;
            return await query.ToListAsync();
        }

        public List<Models.FlightPlanMonth> GetPlanMonths(int Id)
        {
            //return await this.context.FlightPlans.FirstOrDefaultAsync(q => q.Id == id);
            var query = from x in this.context.FlightPlanMonths
                        where x.FlightPlanId == Id
                        select x;
            return query.ToList();
        }
        public List<Models.FlightPlanDay> GetPlanDays(int Id)
        {
            //return await this.context.FlightPlans.FirstOrDefaultAsync(q => q.Id == id);
            var query = from x in this.context.FlightPlanDays
                        where x.FlightPlanId == Id
                        select x;
            return query.ToList();
        }

        public void ClearPlanMonths(int id)
        {
            var months = GetPlanMonths(id);
            while (months.Count > 0)
            {
                var f = months.First();
                this.context.FlightPlanMonths.Remove(f);
                months.Remove(f);
            }
        }

        public void ClearPlanDays(int id)
        {
            var days = GetPlanDays(id);
            while (days.Count > 0)
            {
                var f = days.First();
                this.context.FlightPlanDays.Remove(f);
                days.Remove(f);
            }
        }

        private FlightInformation CreateFlight(FlightPlanItem item, int customer, DateTime date, int? register = null)
        {
            var STDPlan = (DateTime)item.STD;
            var STAPlan = (DateTime)item.STA;
            var STD = new DateTime(date.Year, date.Month, date.Day, STDPlan.Hour, STDPlan.Minute, STDPlan.Second);
            var STA = STD.AddHours(item.FlightH).AddMinutes(item.FlightM);
            var entity = new FlightInformation();
            entity.FlightPlanId = item.Id;
            entity.FlightStatusID = 1; //(int)item.StatusId;
            entity.CustomerId = customer;
            entity.STD = STD;
            entity.STA = STA;
            // entity.DateCreate = DateTime.Now;
            if (register != null)
                entity.RegisterID = register;


            return entity;
        }


        internal async Task<bool> CheckPlanRegister(int pid, int vid, int rid, DateTime? dfrom, DateTime? dto)
        {
            var plan = await this.context.FlightPlans.FirstOrDefaultAsync(q => q.Id == pid);
            if (plan == null)
                return false;
            if (dfrom == null)
                dfrom = plan.DateFrom;
            if (dto == null)
                dto = plan.DateTo;
            var overlaps = await (from x in this.context.ViewFlightPlanCalendarRegisters
                                  join y in this.context.FlighPlanCalendars on x.Date equals y.Date
                                  where y.FlightPlanId == pid && x.FlightPlanId != y.FlightPlanId && y.Date >= dfrom && y.Date <= dto && x.FlightPlanId != y.FlightPlanId
                                  && x.RegisterId == rid
                                  select x).CountAsync();
            if (overlaps > 0)
                return false;

            return true;
        }
        //ati  
        internal async Task<bool> ApproveFlightPlanRegisters(int pid)
        {
            var plan = await this.context.FlightPlans.SingleAsync(q => q.Id == pid);
            var flights = await this.context.ViewFlightPlanItems.Where(q => q.FlightPlanId == pid).ToListAsync();
            var plannedRegisters = flights.Select(q => q.RegisterID).Distinct().ToList();
            var registers = await this.context.ViewFlightPlanRegisters.Where(q => q.FlightPlanId == pid).ToListAsync();

            if (registers.Select(q => q.PlannedRegisterId).Distinct().Count() != plannedRegisters.Count)
                return false;
            var plannedRegistersGroups = (from x in registers
                                          group x by x.PlannedRegisterId into g
                                          select g).ToList();
            foreach (var g in plannedRegistersGroups)
            {
                var dates = g.OrderBy(q => q.DateFrom).ToList();
                if (!(dates.First().DateFrom.Date == ((DateTime)plan.DateFrom).Date && dates.Last().DateTo.Date == ((DateTime)plan.DateTo).Date))
                    return false;
            }

            var fpstatus = new FlightPlanStatu()
            {
                ApproveTypeId = 100,
                DateApproved = DateTime.Now,
                FlighPlanId = pid,

            };
            this.context.FlightPlanStatus.Add(fpstatus);
            var flightCreationResult = await InsertFlightsByPlan(plan, registers);
            if (flightCreationResult.Code != HttpStatusCode.OK)
                return false;
            return true;
        }
        private FlightInformation CreateFlight(ViewFlightPlanItem item, int customer, DateTime date, int register, FlightPlanRegister fpr)
        {
            var STDPlan = (DateTime)item.STD;
            var STAPlan = (DateTime)item.STA;
            var STD = new DateTime(date.Year, date.Month, date.Day, STDPlan.Hour, STDPlan.Minute, STDPlan.Second);
            var STA = STD.AddHours(item.FlightH).AddMinutes(item.FlightM);
            var entity = new FlightInformation();
            entity.FlightPlanId = item.Id;
            entity.FlightStatusID = 1;
            entity.CustomerId = customer;
            entity.STD = STD;
            entity.STA = STA;
            // entity.DateCreate = DateTime.Now;

            entity.RegisterID = register;
            entity.FlightPlanRegisterId = fpr.Id;

            return entity;
        }

        private FlightInformation CreateFlight(ViewFlightPlanItemCalander item, int customer, DateTime date, int register, FlightPlanRegister fpr)
        {
            var STDPlan = (DateTime)item.STD;
            var STAPlan = (DateTime)item.STA;
            var STD = new DateTime(date.Year, date.Month, date.Day, STDPlan.Hour, STDPlan.Minute, STDPlan.Second);
            var STA = STD.AddHours(item.FlightH).AddMinutes(item.FlightM);
            var entity = new FlightInformation();
            entity.FlightPlanId = item.Id;
            entity.FlightStatusID = 1;
            entity.CustomerId = customer;
            entity.STD = STD;
            entity.STA = STA;
            // entity.DateCreate = DateTime.Now;

            entity.RegisterID = register;
            entity.FlightPlanRegisterId = fpr.Id;
            entity.CalendarId = item.CalendarId;
            entity.BoxId = item.BoxId;

            return entity;
        }
        internal async Task<CustomActionResult> InsertFlightsByPlanCalander(List<ViewFlightPlanItem> planItems, FlightPlanRegister planRegsiter)
        {

            //  var planRegsiters =await this.context.FlightPlanRegisters.Where(q => q.FlightPlanId == plan.Id).ToListAsync();
            var plancrew = await (from x in this.context.FlightPlanCalanderCrews
                                  where x.CalanderId == planRegsiter.CalendarId && x.FlightPlanId == planRegsiter.FlightPlanId
                                  select x).ToListAsync();


            var planitemids = planItems.Select(q => (Nullable<int>)q.Id).ToList();
            var deletedFlights = new List<FlightInformation>();

            deletedFlights = await (from x in this.context.FlightInformations

                                    where x.FlightStatusID == 1 && x.FlightPlanRegisterId == planRegsiter.Id && planitemids.Contains(x.FlightPlanId)
                                    select x).ToListAsync();




            this.context.FlightInformations.RemoveRange(deletedFlights);


            var otherFlights = await (from x in this.context.FlightInformations

                                      where x.FlightStatusID != 1 && x.FlightPlanRegisterId == planRegsiter.Id && planitemids.Contains(x.FlightPlanId)
                                      select x).ToListAsync();
            var flights = new List<FlightInformation>();
            var flightcrews = new List<FlightCrew>();
            foreach (var item in planItems)
            {

                FlightInformation flight = CreateFlight(item, item.CustomerId, (DateTime)planRegsiter.Date, planRegsiter.RegisterId, planRegsiter);
                if (flight != null && otherFlights.FirstOrDefault(q => q.FlightPlanRegisterId == planRegsiter.Id && q.FlightPlanId == item.Id) == null)
                {
                    flights.Add(flight);
                    foreach (var x in plancrew)
                    {
                        flightcrews.Add(new FlightCrew()
                        {
                            FlightInformation = flight,
                            CreateDate = DateTime.Now,
                            Status = 1,
                            FlightPlanCrewId = x.Id,
                            EmployeeId = x.EmployeeId,

                        });
                    }
                }
            }
            this.context.FlightInformations.AddRange(flights);
            this.context.FlightCrews.AddRange(flightcrews);
            //   watch.Stop();
            //  var elapsedMs = watch.ElapsedMilliseconds;
            // this.context.Configuration.AutoDetectChangesEnabled = true;  
            return new CustomActionResult(HttpStatusCode.OK, "");
            // this.context.FlightInformations.RemoveRange(deletedFlights);
            // var months = await this.context.FlightPlanMonths.Where(q => q.FlightPlanId == plan.Id).Select(q => q.Month).ToListAsync();
            // var days = await this.context.FlightPlanDays.Where(q => q.FlightPlanId == plan.Id).Select(q => q.Day).ToListAsync();
            //// var planItems = await this.context.FlightPlanItems.Where(q => q.FlightPlanId == plan.Id).ToListAsync();
            // var errors = planItems.Count(q => q.StatusId != 1);
            // if (errors > 0)
            //     return new CustomActionResult(HttpStatusCode.NotAcceptable, "");
            // var minDate = (DateTime)plan.DateFrom;
            // var adddays = 1;
            // switch (plan.Interval)
            // {
            //     case 1:


            //         adddays = 1;
            //         break;
            //     case 2:

            //         adddays = 7;
            //         break;
            //     case 3:

            //         adddays = 10;
            //         break;
            //     case 4:

            //         adddays = 14;
            //         break;
            //     case 5:

            //         adddays = 15;
            //         break;
            //     case 100:


            //         adddays = 1;
            //         break;
            //     case 101:


            //         adddays = 1;
            //         break;
            //     default:
            //         break;
            // }

            // var watch = System.Diagnostics.Stopwatch.StartNew();
            // while (minDate <= (DateTime)plan.DateTo)
            // {
            //     bool addFlight = false;
            //     //   flight = CreateFlight(item, customer, minDate);
            //     if (plan.Interval == 100)
            //     {
            //         //if (months != null && days != null && months.Count > 0 && days.Count > 0)
            //         {
            //             var d = (int)minDate.DayOfWeek;
            //             var m = minDate.Month - 1;
            //             if (months.IndexOf(m) != -1 && days.IndexOf(d) != -1)
            //             {
            //                 addFlight = true;
            //             }
            //         }

            //     }
            //     else
            //         addFlight = true;

            //     //
            //     foreach (var item in planItems)
            //     {
            //         if (addFlight)
            //         {
            //             var register = planRegsiters.FirstOrDefault(q => minDate >= q.DateFrom && minDate <= q.DateTo && item.RegisterID == q.PlannedRegisterId);
            //             FlightInformation flight = CreateFlight(item, plan.CustomerId, minDate, register.RegisterId);
            //             if (flight != null && otherFlights.FirstOrDefault(q => q.STD == flight.STD) == null)
            //             {
            //                 flights.Add(flight);
            //             }
            //         }




            //     }
            //     minDate = minDate.AddDays(adddays);

            // }
            // this.context.FlightInformations.AddRange(flights);
            // //   watch.Stop();
            // //  var elapsedMs = watch.ElapsedMilliseconds;
            // // this.context.Configuration.AutoDetectChangesEnabled = true;  
            // return new CustomActionResult(HttpStatusCode.OK, "");
        }



        internal async Task<CustomActionResult> InsertFlightsByPlanCalander(List<ViewFlightPlanItemCalander> planItems, FlightPlanRegister planRegsiter)
        {

            //  var planRegsiters =await this.context.FlightPlanRegisters.Where(q => q.FlightPlanId == plan.Id).ToListAsync();
            var plancrew = await (from x in this.context.FlightPlanCalanderCrews
                                  where x.CalanderId == planRegsiter.CalendarId && x.FlightPlanId == planRegsiter.FlightPlanId
                                  select x).ToListAsync();


            var planitemids = planItems.Select(q => (Nullable<int>)q.Id).ToList();
            var deletedFlights = from x in this.context.FlightInformations

                                 where x.FlightStatusID == 1 && x.FlightPlanRegisterId == planRegsiter.Id && planitemids.Contains(x.FlightPlanId)
                                 select x;
            this.context.FlightInformations.RemoveRange(deletedFlights);


            var otherFlights = await (from x in this.context.FlightInformations

                                      where x.FlightStatusID != 1 && x.FlightPlanRegisterId == planRegsiter.Id && planitemids.Contains(x.FlightPlanId)
                                      select x).ToListAsync();
            var flights = new List<FlightInformation>();
            var flightcrews = new List<FlightCrew>();
            foreach (var item in planItems)
            {

                FlightInformation flight = CreateFlight(item, item.CustomerId, (DateTime)planRegsiter.Date, planRegsiter.RegisterId, planRegsiter);
                if (flight != null && otherFlights.FirstOrDefault(q => q.FlightPlanRegisterId == planRegsiter.Id && q.FlightPlanId == item.Id) == null)
                {
                    flights.Add(flight);
                    var flightcrew = plancrew.Where(q => q.BoxId == item.BoxId).ToList();
                    foreach (var x in flightcrew)
                    {
                        flightcrews.Add(new FlightCrew()
                        {
                            FlightInformation = flight,
                            CreateDate = DateTime.Now,
                            Status = 1,
                            FlightPlanCrewId = x.Id,

                        });
                    }
                }
            }
            this.context.FlightInformations.AddRange(flights);
            this.context.FlightCrews.AddRange(flightcrews);
            //   watch.Stop();
            //  var elapsedMs = watch.ElapsedMilliseconds;
            // this.context.Configuration.AutoDetectChangesEnabled = true;  
            return new CustomActionResult(HttpStatusCode.OK, "");
            // this.context.FlightInformations.RemoveRange(deletedFlights);
            // var months = await this.context.FlightPlanMonths.Where(q => q.FlightPlanId == plan.Id).Select(q => q.Month).ToListAsync();
            // var days = await this.context.FlightPlanDays.Where(q => q.FlightPlanId == plan.Id).Select(q => q.Day).ToListAsync();
            //// var planItems = await this.context.FlightPlanItems.Where(q => q.FlightPlanId == plan.Id).ToListAsync();
            // var errors = planItems.Count(q => q.StatusId != 1);
            // if (errors > 0)
            //     return new CustomActionResult(HttpStatusCode.NotAcceptable, "");
            // var minDate = (DateTime)plan.DateFrom;
            // var adddays = 1;
            // switch (plan.Interval)
            // {
            //     case 1:


            //         adddays = 1;
            //         break;
            //     case 2:

            //         adddays = 7;
            //         break;
            //     case 3:

            //         adddays = 10;
            //         break;
            //     case 4:

            //         adddays = 14;
            //         break;
            //     case 5:

            //         adddays = 15;
            //         break;
            //     case 100:


            //         adddays = 1;
            //         break;
            //     case 101:


            //         adddays = 1;
            //         break;
            //     default:
            //         break;
            // }

            // var watch = System.Diagnostics.Stopwatch.StartNew();
            // while (minDate <= (DateTime)plan.DateTo)
            // {
            //     bool addFlight = false;
            //     //   flight = CreateFlight(item, customer, minDate);
            //     if (plan.Interval == 100)
            //     {
            //         //if (months != null && days != null && months.Count > 0 && days.Count > 0)
            //         {
            //             var d = (int)minDate.DayOfWeek;
            //             var m = minDate.Month - 1;
            //             if (months.IndexOf(m) != -1 && days.IndexOf(d) != -1)
            //             {
            //                 addFlight = true;
            //             }
            //         }

            //     }
            //     else
            //         addFlight = true;

            //     //
            //     foreach (var item in planItems)
            //     {
            //         if (addFlight)
            //         {
            //             var register = planRegsiters.FirstOrDefault(q => minDate >= q.DateFrom && minDate <= q.DateTo && item.RegisterID == q.PlannedRegisterId);
            //             FlightInformation flight = CreateFlight(item, plan.CustomerId, minDate, register.RegisterId);
            //             if (flight != null && otherFlights.FirstOrDefault(q => q.STD == flight.STD) == null)
            //             {
            //                 flights.Add(flight);
            //             }
            //         }




            //     }
            //     minDate = minDate.AddDays(adddays);

            // }
            // this.context.FlightInformations.AddRange(flights);
            // //   watch.Stop();
            // //  var elapsedMs = watch.ElapsedMilliseconds;
            // // this.context.Configuration.AutoDetectChangesEnabled = true;  
            // return new CustomActionResult(HttpStatusCode.OK, "");
        }

        //kati2
        private FlightInformation CreateFlight(ViewFlightPlanItemCalander item)
        {
            var date = (DateTime)item.Date;
            var STDPlan = (DateTime)item.STD;
            var STAPlan = (DateTime)item.STA;
            var STD = STDPlan; //new DateTime(date.Year, date.Month, date.Day, STDPlan.Hour, STDPlan.Minute, STDPlan.Second);
            STD = new DateTime(date.Year, date.Month, date.Day, STD.Hour, STD.Minute, 0);
            var STA = STD.AddHours(item.FlightH).AddMinutes(item.FlightM);
            var entity = new FlightInformation();
            entity.CalendarId = item.CalendarId;
            entity.FlightPlanId = item.Id;
            entity.FlightStatusID = 1; //(int)item.StatusId;
            entity.CustomerId = item.CustomerId;
            entity.STD = STD;
            entity.STA = STA;
            // entity.DateCreate = DateTime.Now;
            entity.FlightPlanRegisterId = item.VirtualRegisterId;
            entity.RegisterID = item.RegisterID;
            /******************************************/
            entity.FlightNumber = item.FlightNumber;
            entity.FromAirportId = item.FromAirport;
            entity.ToAirportId = item.ToAirport;
            //entity.TypeID = item.TypeId;

            return entity;
        }
        internal async Task<CustomActionResult> InsertFlightsByPlanCalander(List<ViewFlightPlanItemCalander> planItems)
        {

            //  var planRegsiters =await this.context.FlightPlanRegisters.Where(q => q.FlightPlanId == plan.Id).ToListAsync();
            var planid = planItems.First().FlightPlanId;

            var excludeFlights = await this.context.UpdatedPlanFlights.Where(q => q.PlanId == planid).ToListAsync();


            var planitemids = planItems.Select(q => (Nullable<int>)q.Id).ToList();
            var deletedFlights = await (from x in this.context.FlightInformations

                                        where x.FlightStatusID == 1 && planitemids.Contains(x.FlightPlanId)
                                        select x).ToListAsync();


            deletedFlights = (from x in deletedFlights
                              where excludeFlights.FirstOrDefault(q => q.Date == ((DateTime)x.STD).Date) == null
                              select x).ToList();

            this.context.FlightInformations.RemoveRange(deletedFlights);


            var otherFlights = await (from x in this.context.FlightInformations

                                      where x.FlightStatusID != 1 && planitemids.Contains(x.FlightPlanId)
                                      select x).ToListAsync();
            var flights = new List<FlightInformation>();
            var flightcrews = new List<FlightCrew>();
            foreach (var item in planItems)
            {
                var isInExcluded = excludeFlights.FirstOrDefault(q => ((DateTime)q.Date) == ((DateTime)item.Date).Date);
                if (isInExcluded == null)
                {
                    FlightInformation flight = CreateFlight(item);
                    if (flight != null && otherFlights.FirstOrDefault(q => q.CalendarId == item.CalendarId && q.FlightPlanId == item.Id) == null)
                    {
                        flights.Add(flight);

                    }
                }

            }
            this.context.FlightInformations.AddRange(flights);

            //   watch.Stop();
            //  var elapsedMs = watch.ElapsedMilliseconds;
            // this.context.Configuration.AutoDetectChangesEnabled = true;  
            return new CustomActionResult(HttpStatusCode.OK, "");

        }

        internal async Task<CustomActionResult> InsertFlightsByPlanCalander(List<ViewFlightPlanItemCalander> planItems, bool clearAllFlights)
        {

            //  var planRegsiters =await this.context.FlightPlanRegisters.Where(q => q.FlightPlanId == plan.Id).ToListAsync();
            var planid = planItems.First().FlightPlanId;

            var excludeFlights = await this.context.UpdatedPlanFlights.Where(q => q.PlanId == planid).ToListAsync();


            var planitemids = planItems.Select(q => (Nullable<int>)q.Id).ToList();

            List<FlightInformation> deletedFlights = new List<FlightInformation>();
            if (!clearAllFlights)
            {
                deletedFlights = await (from x in this.context.FlightInformations

                                        where x.FlightStatusID == 1 && planitemids.Contains(x.FlightPlanId)
                                        select x).ToListAsync();

            }
            else
            {

                var pids = await this.context.FlightPlanItems.Where(q => q.FlightPlanId == planid).Select(q => q.Id).ToListAsync();
                var npids = pids.Select(q => (Nullable<int>)q).ToList();
                deletedFlights = await (from x in this.context.FlightInformations

                                        where x.FlightStatusID == 1 && npids.Contains(x.FlightPlanId)
                                        select x).ToListAsync();
            }


            deletedFlights = (from x in deletedFlights
                              where excludeFlights.FirstOrDefault(q => q.Date == ((DateTime)x.STD).Date) == null
                              select x).ToList();

            this.context.FlightInformations.RemoveRange(deletedFlights);


            var otherFlights = await (from x in this.context.FlightInformations

                                      where x.FlightStatusID != 1 && planitemids.Contains(x.FlightPlanId)
                                      select x).ToListAsync();
            var flights = new List<FlightInformation>();
            var flightcrews = new List<FlightCrew>();
            foreach (var item in planItems)
            {
                var isInExcluded = excludeFlights.FirstOrDefault(q => ((DateTime)q.Date) == ((DateTime)item.Date).Date);
                if (isInExcluded == null)
                {
                    FlightInformation flight = CreateFlight(item);
                    if (flight != null && otherFlights.FirstOrDefault(q => q.CalendarId == item.CalendarId && q.FlightPlanId == item.Id) == null)
                    {
                        flights.Add(flight);

                    }
                }

            }
            this.context.FlightInformations.AddRange(flights);

            //   watch.Stop();
            //  var elapsedMs = watch.ElapsedMilliseconds;
            // this.context.Configuration.AutoDetectChangesEnabled = true;  
            return new CustomActionResult(HttpStatusCode.OK, "");

        }

        internal async Task<bool> ApproveFlightPlanRegisterCalander(int id)
        {
            var flightplanregister = await this.context.FlightPlanRegisters.SingleAsync(q => q.Id == id);

            var plan = await this.context.FlightPlans.SingleAsync(q => q.Id == flightplanregister.FlightPlanId);
            // var flights = await this.context.ViewFlightPlanItems.Where(q => q.FlightPlanId == plan.Id).ToListAsync();
            var flights = await this.context.ViewFlightPlanItemCalanders.Where(q => q.FlightPlanId == plan.Id && q.CalendarId == flightplanregister.CalendarId).ToListAsync();


            flightplanregister.IsApproved = true;
            flightplanregister.DateApproved = DateTime.Now;


            var flightCreationResult = await InsertFlightsByPlanCalander(flights, flightplanregister);
            if (flightCreationResult.Code != HttpStatusCode.OK)
                return false;
            return true;
        }
        //zati2
        internal async Task<CustomActionResult> CloseFlightPlan(int pid)
        {
            var plan = await this.context.ViewFlightPlans.SingleAsync(q => q.Id == pid);
            var planitems = await this.context.ViewFlightPlanItemCalanders.Where(q => q.FlightPlanId == plan.Id).ToListAsync();



            if (plan.GapOverlaps > 0 || plan.Gaps > 0 || plan.Overlaps > 0)
                return new CustomActionResult(HttpStatusCode.NotAcceptable, "");
            var plant = await this.context.FlightPlans.SingleAsync(q => q.Id == pid);
            plant.Title = plant.Title + "_A50-" + (DateTime.Now.Year.ToString() + DateTime.Now.Month.ToString() + DateTime.Now.Day.ToString() + DateTime.Now.Hour.ToString() + DateTime.Now.Minute.ToString() + DateTime.Now.Second.ToString() + DateTime.Now.Millisecond.ToString());
            var fpstatus = new FlightPlanStatu()
            {
                ApproveTypeId = 50,
                DateApproved = DateTime.Now,
                FlighPlanId = pid,


            };
            this.context.FlightPlanStatus.Add(fpstatus);
            await InsertFlightsByPlanCalander(planitems);

            return new CustomActionResult(HttpStatusCode.OK, "");
        }

        internal async Task<CustomActionResult> UpdatePlanItemFlights(FlightPlanItem planitem)
        {
            var id = planitem.Id;
            var flights = await this.context.FlightInformations.Where(q => q.FlightPlanId == id && q.FlightStatusID == 1).ToListAsync();
            foreach (var x in flights)
            {
                if (x.RegisterID == x.FlightPlanRegisterId)
                    x.RegisterID = planitem.RegisterID;
                x.FlightPlanRegisterId = planitem.RegisterID;
                x.STD = planitem.STD;
                x.STA = planitem.STA;


            }
            return new CustomActionResult(HttpStatusCode.OK, "");
        }


        internal async Task<CustomActionResult> DeleteEmptyPlan(FlightPlan plan)
        {

            var planitems = await this.context.FlightPlanItems.Where(q => q.FlightPlanId == plan.Id).CountAsync();
            if (planitems == 0)
                this.context.FlightPlans.Remove(plan);



            return new CustomActionResult(HttpStatusCode.OK, "");
        }
        internal async Task<CustomActionResult> DeleteEmptyPlan(int planId)
        {
            var plan = await this.context.FlightPlans.FirstOrDefaultAsync(q => q.Id == planId);
            var planitems = await this.context.FlightPlanItems.Where(q => q.FlightPlanId == plan.Id).CountAsync();
            if (planitems == 0)
                this.context.FlightPlans.Remove(plan);



            return new CustomActionResult(HttpStatusCode.OK, "");
        }

        internal async Task<CustomActionResult> DeleteFlightPlanItem(FlightPlanItem planitem)
        {
            //var plan = await this.context.ViewFlightPlans.SingleAsync(q => q.Id == pid);
            //var planitems = await this.context.ViewFlightPlanItemCalanders.Where(q => q.FlightPlanId == plan.Id).ToListAsync();
            //var planitem = await this.context.FlightPlanItems.FirstOrDefaultAsync(q => q.Id == id);
            var id = planitem.Id;
            var viewitem = await this.context.ViewFlightPlanItems.FirstOrDefaultAsync(q => q.Id == id);

            var flights = await this.context.FlightInformations.Where(q => q.FlightPlanId == id).ToListAsync();
            var deletedFlights = flights.Where(q => q.FlightStatusID == 1).ToList();
            var noDeletedFlights = flights.Where(q => q.FlightStatusID != 1).ToList();

            foreach (var x in noDeletedFlights)
            {

                x.FlightPlanId = null;
                x.FlightNumber = viewitem.FlightNumber;
                if (x.ToAirportId == null)
                    x.ToAirportId = viewitem.ToAirport;
                if (x.FromAirportId == null)
                    x.FromAirportId = viewitem.FromAirport;
                x.FlightPlanRegisterId = null;
                x.CalendarId = null;

            }

            this.context.FlightInformations.RemoveRange(deletedFlights);
            this.context.FlightPlanItems.Remove(planitem);




            return new CustomActionResult(HttpStatusCode.OK, "");
        }

        internal bool DeletePlanItemBoard(PlanItem planitem)
        {
            this.context.PlanItems.Remove(planitem);
            return true;
        }

        internal async Task<CustomActionResult> CloseFlightPlanItem(int pid, int id)
        {
            var plan = await this.context.ViewFlightPlans.SingleAsync(q => q.Id == pid);
            var planitems = await this.context.ViewFlightPlanItemCalanders.Where(q => q.Id == id).ToListAsync();



            //if (plan.GapOverlaps > 0 || plan.Gaps > 0 || plan.Overlaps > 0)
            //   return new CustomActionResult(HttpStatusCode.NotAcceptable, "");



            //var plant = await this.context.FlightPlans.SingleAsync(q => q.Id == pid);
            //plant.Title = plant.Title + "_A50-" + (DateTime.Now.Year.ToString() + DateTime.Now.Month.ToString() + DateTime.Now.Day.ToString() + DateTime.Now.Hour.ToString() + DateTime.Now.Minute.ToString() + DateTime.Now.Second.ToString() + DateTime.Now.Millisecond.ToString());
            //var fpstatus = new FlightPlanStatu()
            //{
            //    ApproveTypeId = 50,
            //    DateApproved = DateTime.Now,
            //    FlighPlanId = pid,


            //};
            //this.context.FlightPlanStatus.Add(fpstatus);
            await InsertFlightsByPlanCalander(planitems);

            return new CustomActionResult(HttpStatusCode.OK, "");
        }

        internal async Task<CustomActionResult> ModifyPlanItemsSTDA(int planId, DateTime oFromDate, DateTime nFromDate)
        {
            if (oFromDate.Date == nFromDate.Date)
                return new CustomActionResult(HttpStatusCode.OK, "");
            var planitems = await this.context.FlightPlanItems.Where(q => q.FlightPlanId == planId).ToListAsync();
            var oDay = oFromDate.Day;
            var nDay = nFromDate.Day;
            foreach (var x in planitems)
            {
                //std
                var stdHour = ((DateTime)x.STD).Hour;
                var stdMinute = ((DateTime)x.STD).Minute;
                var stdDayDiff = ((DateTime)x.STD).Day - oDay;
                var std = new DateTime(nFromDate.Year, nFromDate.Month, nFromDate.Day + stdDayDiff, stdHour, stdMinute, 0);
                var sta = std.AddHours(x.FlightH).AddMinutes(x.FlightM);
                x.STD = std;
                x.STA = sta;
            }
            return new CustomActionResult(HttpStatusCode.OK, "");
        }
        internal async Task<CustomActionResult> CloseFlightPlanItems(FlightPlan plan, bool? clearAllFlight = null)
        {
            // var plan = await this.context.ViewFlightPlans.SingleAsync(q => q.Id == pid);
            var pid = plan.Id;
            var planitems = await this.context.ViewFlightPlanItemCalanders.Where(q => q.FlightPlanId == pid).ToListAsync();



            // if (plan.GapOverlaps > 0 || plan.Gaps > 0 || plan.Overlaps > 0)
            //     return new CustomActionResult(HttpStatusCode.NotAcceptable, "");

            await InsertFlightsByPlanCalander(planitems, true);

            return new CustomActionResult(HttpStatusCode.OK, "");
        }

        internal async Task<CustomActionResult> ResetFlightsRegister(int? cid)
        {
            if (cid == null)
                return new CustomActionResult(HttpStatusCode.OK, "");
            var flights = await (from x in this.context.FlightInformations
                                 where x.CalendarId == cid
                                 select x).ToListAsync();
            foreach (var x in flights)
            {
                x.RegisterID = x.FlightPlanRegisterId;
            }
            return new CustomActionResult(HttpStatusCode.OK, "");
        }

        internal async Task<CustomActionResult> ApproveFlightPlan(int pid, int type)
        {
            var plan = await this.context.ViewFlightPlans.SingleAsync(q => q.Id == pid);

            var fpstatus = new FlightPlanStatu()
            {
                ApproveTypeId = type,
                DateApproved = DateTime.Now,
                FlighPlanId = pid,


            };
            this.context.FlightPlanStatus.Add(fpstatus);

            return new CustomActionResult(HttpStatusCode.OK, "");
        }

        internal List<FlightPlanRegister> InsertFlightPlanRegisters(List<ViewFlightPlanRegister> items, List<int> deleted)
        {
            var deletedQ = from x in this.context.FlightPlanRegisters
                           where deleted.Contains(x.Id)
                           select x;
            this.context.FlightPlanRegisters.RemoveRange(deletedQ);
            var newItems = new List<FlightPlanRegister>();
            foreach (var x in items)
            {
                var df = ((DateTime)x.DateFrom).Date;
                var dt = ((DateTime)x.DateTo).Date.AddHours(23).AddMinutes(59).AddSeconds(59);
                var entity = new FlightPlanRegister()
                {
                    DateFrom = df,
                    DateTo = dt,
                    FlightPlanId = x.FlightPlanId,
                    RegisterId = x.RegisterId,
                    PlannedRegisterId = x.PlannedRegisterId,
                    Remark = x.Remark
                };
                this.context.FlightPlanRegisters.Add(entity);
                newItems.Add(entity);
            }

            return newItems;
        }
        internal FlightPlanRegister InsertFlightPlanRegister(int id, DateTime date, int planId, int registerId, int virtualId, int calanderId)
        {
            var entity = this.context.FlightPlanRegisters.FirstOrDefault(q => q.Id == id);
            if (entity == null)
            {
                entity = new FlightPlanRegister();
                this.context.FlightPlanRegisters.Add(entity);
            }
            var df = ((DateTime)date).Date;
            var dt = ((DateTime)date).Date.AddHours(23).AddMinutes(59).AddSeconds(59);
            entity.Date = df;
            entity.DateFrom = df;
            entity.DateTo = dt;
            entity.FlightPlanId = planId;
            entity.RegisterId = registerId;
            entity.PlannedRegisterId = virtualId;
            entity.CalendarId = calanderId;

            int noOfRowUpdated = this.context.Database.ExecuteSqlCommand("Update FlightInformation set RegisterID = " + registerId + " where CalendarId = " + calanderId);


            return entity;
        }
        internal async Task<CustomActionResult> InsertFlightsByPlan(FlightPlan plan, List<ViewFlightPlanRegister> planRegsiters)
        {
            //  var planRegsiters =await this.context.FlightPlanRegisters.Where(q => q.FlightPlanId == plan.Id).ToListAsync();
            plan.IsActive = true;
            plan.DateActive = DateTime.Now;
            var deletedFlights = from x in this.context.FlightInformations
                                 join y in this.context.FlightPlanItems on x.FlightPlanId equals y.Id
                                 where y.FlightPlanId == plan.Id && x.FlightStatusID == 1
                                 select x;
            var otherFlights = await (from x in this.context.FlightInformations
                                      join y in this.context.FlightPlanItems on x.FlightPlanId equals y.Id
                                      where y.FlightPlanId == plan.Id && x.FlightStatusID != 1
                                      select x).ToListAsync();

            this.context.FlightInformations.RemoveRange(deletedFlights);
            var months = await this.context.FlightPlanMonths.Where(q => q.FlightPlanId == plan.Id).Select(q => q.Month).ToListAsync();
            var days = await this.context.FlightPlanDays.Where(q => q.FlightPlanId == plan.Id).Select(q => q.Day).ToListAsync();
            var planItems = await this.context.FlightPlanItems.Where(q => q.FlightPlanId == plan.Id).ToListAsync();
            var errors = planItems.Count(q => q.StatusId != 1);
            if (errors > 0)
                return new CustomActionResult(HttpStatusCode.NotAcceptable, "");
            var minDate = (DateTime)plan.DateFrom;
            var adddays = 1;
            switch (plan.Interval)
            {
                case 1:


                    adddays = 1;
                    break;
                case 2:

                    adddays = 7;
                    break;
                case 3:

                    adddays = 10;
                    break;
                case 4:

                    adddays = 14;
                    break;
                case 5:

                    adddays = 15;
                    break;
                case 100:


                    adddays = 1;
                    break;
                case 101:


                    adddays = 1;
                    break;
                default:
                    break;
            }
            var flights = new List<FlightInformation>();
            var watch = System.Diagnostics.Stopwatch.StartNew();
            while (minDate <= (DateTime)plan.DateTo)
            {
                bool addFlight = false;
                //   flight = CreateFlight(item, customer, minDate);
                if (plan.Interval == 100)
                {
                    //if (months != null && days != null && months.Count > 0 && days.Count > 0)
                    {
                        var d = (int)minDate.DayOfWeek;
                        var m = minDate.Month - 1;
                        if (months.IndexOf(m) != -1 && days.IndexOf(d) != -1)
                        {
                            addFlight = true;
                        }
                    }

                }
                else
                    addFlight = true;

                //
                foreach (var item in planItems)
                {
                    if (addFlight)
                    {
                        var register = planRegsiters.FirstOrDefault(q => minDate >= q.DateFrom && minDate <= q.DateTo && item.RegisterID == q.PlannedRegisterId);
                        FlightInformation flight = CreateFlight(item, plan.CustomerId, minDate, register.RegisterId);
                        if (flight != null && otherFlights.FirstOrDefault(q => q.STD == flight.STD) == null)
                        {
                            flights.Add(flight);
                        }
                    }




                }
                minDate = minDate.AddDays(adddays);

            }
            this.context.FlightInformations.AddRange(flights);
            //   watch.Stop();
            //  var elapsedMs = watch.ElapsedMilliseconds;
            // this.context.Configuration.AutoDetectChangesEnabled = true;  
            return new CustomActionResult(HttpStatusCode.OK, "");
        }



        public async Task<CustomActionResult> ApplyPlan(int planId, int customer)
        {
            //  return new CustomActionResult(HttpStatusCode.OK, "");
            var plan = await this.context.FlightPlans.FirstOrDefaultAsync(q => q.Id == planId);
            if (plan == null)
                return new CustomActionResult(HttpStatusCode.NotFound, "");
            plan.IsActive = true;
            plan.DateActive = DateTime.Now;
            var deletedFlights = from x in this.context.FlightInformations
                                 join y in this.context.FlightPlanItems on x.FlightPlanId equals y.Id
                                 where y.FlightPlanId == plan.Id && x.FlightStatusID == 1
                                 select x;
            var otherFlights = await (from x in this.context.FlightInformations
                                      join y in this.context.FlightPlanItems on x.FlightPlanId equals y.Id
                                      where y.FlightPlanId == plan.Id && x.FlightStatusID != 1
                                      select x).ToListAsync();

            this.context.FlightInformations.RemoveRange(deletedFlights);


            var months = await this.context.FlightPlanMonths.Where(q => q.FlightPlanId == plan.Id).Select(q => q.Month).ToListAsync();
            var days = await this.context.FlightPlanDays.Where(q => q.FlightPlanId == plan.Id).Select(q => q.Day).ToListAsync();
            var planItems = await this.context.FlightPlanItems.Where(q => q.FlightPlanId == plan.Id).ToListAsync();
            var errors = planItems.Count(q => q.StatusId != 1);
            if (errors > 0)
                return new CustomActionResult(HttpStatusCode.NotAcceptable, "");
            var minDate = (DateTime)plan.DateFrom;
            while (minDate <= (DateTime)plan.DateTo)
            {
                bool addFlight = false;
                //   flight = CreateFlight(item, customer, minDate);
                if (plan.Interval == 100)
                {
                    if (months != null && days != null && months.Count > 0 && days.Count > 0)
                    {
                        var d = (int)minDate.DayOfWeek;
                        var m = minDate.Month - 1;
                        if (months.IndexOf(m) != -1 && days.IndexOf(d) != -1)
                        {
                            addFlight = true;
                        }
                    }

                }
                else
                    addFlight = true;

                //
                foreach (var item in planItems)
                {
                    if (addFlight)
                    {
                        FlightInformation flight = CreateFlight(item, customer, minDate);
                        if (flight != null && otherFlights.FirstOrDefault(q => q.STD == flight.STD) == null)
                        {
                            this.context.FlightInformations.Add(flight);
                        }
                    }




                }
                switch (plan.Interval)
                {
                    case 1:


                        minDate = minDate.AddDays(1);
                        break;
                    case 2:

                        minDate = minDate.AddDays(7);
                        break;
                    case 3:

                        minDate = minDate.AddDays(10);
                        break;
                    case 4:

                        minDate = minDate.AddDays(14);
                        break;
                    case 5:

                        minDate = minDate.AddDays(15);
                        break;
                    case 100:


                        minDate = minDate.AddDays(1);
                        break;
                    default:
                        break;
                }
            }

            return new CustomActionResult(HttpStatusCode.OK, "");
        }
        //zati
        //kakoli
        public List<DateTime> GetInvervalDates(int type, DateTime start, DateTime end, List<int> days = null)
        {
            List<DateTime> result = new List<DateTime>();
            var minDate = start.Date;
            var maxDate = end.Date.AddHours(23).AddMinutes(59).AddSeconds(59);
            while (minDate <= maxDate)
            {
                switch (type)
                {
                    case 1:
                        result.Add(minDate);
                        break;
                    case 2:
                        var d = (int)minDate.DayOfWeek;
                        if (days.IndexOf(d) != -1)
                            result.Add(minDate);
                        break;
                    default:
                        break;
                }
                minDate = minDate.AddDays(1);
            }
            return result;
        }
        public void CreatePlanCalendar(int id, Models.FlightPlan plan, List<int> months, List<int> days)
        {
            if (id != -1)
                this.context.FlighPlanCalendars.RemoveRange(this.context.FlighPlanCalendars.Where(q => q.FlightPlanId == plan.Id));
            // $scope.intervalTypes = [{ Id: 1, Title: 'Daily' }, { Id: 2, Title: 'Weekly' }, { Id: 3, Title: 'Every 10 days' }, { Id: 4, Title: 'Every 14 days' }, { Id: 5, Title: 'Every 15 days' }, { Id: 100, Title: 'Custom' }];
            var minDate = (DateTime)plan.DateFrom;
            while (minDate <= (DateTime)plan.DateTo)
            {
                switch (plan.Interval)
                {
                    case 1:
                    case 101:
                        plan.FlighPlanCalendars.Add(new FlighPlanCalendar() { FlightPlan = plan, Date = minDate, });
                        minDate = minDate.AddDays(1);
                        break;
                    case 2:
                        plan.FlighPlanCalendars.Add(new FlighPlanCalendar() { FlightPlan = plan, Date = minDate, });
                        minDate = minDate.AddDays(7);
                        break;
                    case 3:
                        plan.FlighPlanCalendars.Add(new FlighPlanCalendar() { FlightPlan = plan, Date = minDate, });
                        minDate = minDate.AddDays(10);
                        break;
                    case 4:
                        plan.FlighPlanCalendars.Add(new FlighPlanCalendar() { FlightPlan = plan, Date = minDate, });
                        minDate = minDate.AddDays(14);
                        break;
                    case 5:
                        plan.FlighPlanCalendars.Add(new FlighPlanCalendar() { FlightPlan = plan, Date = minDate, });
                        minDate = minDate.AddDays(15);
                        break;
                    case 100:
                        if (months != null && days != null && months.Count > 0 && days.Count > 0)
                        {
                            var d = (int)minDate.DayOfWeek;
                            var m = minDate.Month - 1;
                            if (months.IndexOf(m) != -1 && days.IndexOf(d) != -1)
                            {
                                plan.FlighPlanCalendars.Add(new FlighPlanCalendar() { FlightPlan = plan, Date = minDate, });
                            }
                        }

                        minDate = minDate.AddDays(1);
                        break;
                    default:
                        break;
                }

            }
        }
        public async Task<CustomActionResult> GetCrewSummary(int id)
        {

            var past24 = await (from x in this.context.ViewFlightCrews
                                where x.EmployeeId == id && x.FlightStatusID != null && x.PastHoursFromOffBlock <= 24
                                select x).SumAsync(q => q.TotalFlightHoursOffBlock);
            var past48 = await (from x in this.context.ViewFlightCrews
                                where x.EmployeeId == id && x.FlightStatusID != null && x.PastHoursFromOffBlock <= 48
                                select x).SumAsync(q => q.TotalFlightHoursOffBlock);
            var pastweek = await (from x in this.context.ViewFlightCrews
                                  where x.EmployeeId == id && x.FlightStatusID != null && x.PastHoursFromOffBlock <= 168
                                  select x).SumAsync(q => q.TotalFlightHoursOffBlock);
            var pastmonth = await (from x in this.context.ViewFlightCrews
                                   where x.EmployeeId == id && x.FlightStatusID != null && x.PastHoursFromOffBlock <= 720
                                   select x).SumAsync(q => q.TotalFlightHoursOffBlock);

            var p24 = past24 != null ? Math.Round(Convert.ToDouble(past24), 1) : 0;
            var p48 = past48 != null ? Math.Round(Convert.ToDouble(past48), 1) : 0;
            var pweek = pastweek != null ? Math.Round(Convert.ToDouble(pastweek), 1) : 0;
            var pmonth = pastmonth != null ? Math.Round(Convert.ToDouble(pastmonth), 1) : 0;

            dynamic summary = new
            {
                Past24 = p24,
                Past48 = p48,
                PastWeek = pweek,
                PastMonth = pmonth,
                EmployeeId = id,

            };
            return new CustomActionResult(HttpStatusCode.OK, summary);
        }
        public async Task<CustomActionResult> GetPlanBase(int customer, DateTime date, int register)
        {
            var baseid = await (from x in this.context.ViewFlightPlanItems.AsNoTracking()
                                where x.CustomerId == customer && x.DateFrom == date && x.RegisterID == register
                                select x.BaseId).FirstOrDefaultAsync();
            if (baseid == null)
                baseid = -1;
            return new CustomActionResult(HttpStatusCode.OK, baseid);
        }
        //boosk
        public async Task<ViewFlightPlanItem> GetPlanLastItem(int customer, DateTime date, int register, int offset)
        {
            var baseid = await (from x in this.context.ViewFlightPlanItems.AsNoTracking()
                                where x.CustomerId == customer && x.DateFrom == date && x.RegisterID == register
                                orderby x.STD descending
                                select x).FirstOrDefaultAsync();
            if (baseid != null)
            {
                baseid.STA = ((DateTime)baseid.STA).AddMinutes(offset);
                baseid.STD = ((DateTime)baseid.STD).AddMinutes(offset);
            }
            else
                baseid = new ViewFlightPlanItem() { Id = -1 };

            return baseid;
        }
        public async Task<ViewFlightPlanItem> GetPlanLastItem(int id, int offset)
        {
            var baseid = await (from x in this.context.ViewFlightPlanItems.AsNoTracking()
                                where x.FlightPlanId == id
                                orderby x.STD descending
                                select x).FirstOrDefaultAsync();
            if (baseid != null)
            {
                baseid.STA = ((DateTime)baseid.STA).AddMinutes(offset);
                baseid.STD = ((DateTime)baseid.STD).AddMinutes(offset);
            }
            else
                baseid = new ViewFlightPlanItem() { Id = -1 };

            return baseid;
        }
        public List<ViewFlightPlanItem> GetPlanItems(int customer, DateTime date, int register, int offset)
        {
            try
            {
                var baseid = (from x in this.context.ViewFlightPlanItems.AsNoTracking()
                              where x.CustomerId == customer && x.DateFrom == date && x.RegisterID == register
                              orderby x.STD descending
                              select x).ToList();
                foreach (var x in baseid)
                {

                    x.STA = ((DateTime)x.STA).AddMinutes(offset);
                    x.STD = ((DateTime)x.STD).AddMinutes(offset);
                }


                return baseid;
            }
            catch (Exception ex)
            {
                return null;
            }

        }

        public List<ViewFlightPlanItem> GetPlanItemsById(int id, int offset)
        {
            try
            {
                var baseid = (from x in this.context.ViewFlightPlanItems.AsNoTracking()
                              where x.FlightPlanId == id
                              orderby x.STD descending
                              select x).ToList();
                foreach (var x in baseid)
                {

                    x.STA = ((DateTime)x.STA).AddMinutes(offset);
                    x.STD = ((DateTime)x.STD).AddMinutes(offset);
                }


                return baseid;
            }
            catch (Exception ex)
            {
                return null;
            }

        }
        //09-19
        public class ShiftFlightsDto
        {
            public List<int> ids { get; set; }
            public int hour { get; set; }
            public int minute { get; set; }
            public int register { get; set; }
            public string userName { get; set; }
            public int nira { get; set; }
            public int sign { get; set; }
        }
        public async Task<CustomActionResult> ShiftFlights(ShiftFlightsDto dto)
        {
            var flights = await this.context.FlightInformations.Where(q => dto.ids.Contains(q.ID)).ToListAsync();
            var legs = await this.context.ViewLegTimes.Where(q => dto.ids.Contains(q.ID)).ToListAsync();
            foreach (var flight in flights)
            {
                var leg = legs.FirstOrDefault(q => q.ID == flight.ID);
                if (leg != null)
                {
                    var changeLog = new FlightChangeHistory()
                    {
                        Date = DateTime.Now,
                        FlightId = flight.ID,

                    };
                    changeLog.User = dto.userName + " " + (dto.nira == 1 ? "1" : "0");
                    changeLog.OldFlightNumer = leg.FlightNumber;
                    changeLog.OldFromAirportId = leg.FromAirport;
                    changeLog.OldToAirportId = leg.ToAirport;
                    changeLog.OldSTD = leg.STD;
                    changeLog.OldSTA = leg.STA;
                    changeLog.OldStatusId = leg.FlightStatusID;
                    changeLog.OldRegister = leg.RegisterID;
                    changeLog.OldOffBlock = leg.ChocksOut;
                    changeLog.OldOnBlock = leg.ChocksIn;
                    changeLog.OldTakeOff = leg.Takeoff;
                    changeLog.OldLanding = leg.Landing;

                    var mm = (dto.sign) * (dto.hour * 60 + dto.minute);
                    var dtoSTD = ((DateTime)flight.STD).AddMinutes(mm);
                    var dtoSTA = ((DateTime)flight.STA).AddMinutes(mm);
                    var tzoffset = Helper.GetTimeOffset((DateTime)dtoSTD);
                    var oldSTD = ((DateTime)flight.STD).AddMinutes(tzoffset).Date;
                    var newSTD = ((DateTime)dtoSTD).AddMinutes(tzoffset).Date;
                    if (oldSTD != newSTD)
                    {
                        flight.FlightDate = oldSTD;
                    }
                    flight.STD = dtoSTD;
                    flight.STA = dtoSTA;
                    flight.ChocksIn = null;
                    flight.ChocksOut = null;
                    flight.Takeoff = null;
                    flight.Landing = null;
                    changeLog.NewFlightNumber = flight.FlightNumber;
                    changeLog.NewFromAirportId = flight.FromAirportId;
                    changeLog.NewToAirportId = flight.ToAirportId;
                    changeLog.NewSTD = flight.STD;
                    changeLog.NewSTA = flight.STA;
                    changeLog.NewStatusId = flight.FlightStatusID;
                    changeLog.NewRegister = flight.RegisterID;
                    changeLog.NewOffBlock = flight.ChocksOut;
                    changeLog.NewOnBlock = flight.ChocksIn;
                    changeLog.NewTakeOff = flight.Takeoff;
                    changeLog.NewLanding = flight.Landing;

                    this.context.FlightChangeHistories.Add(changeLog);


                }

            }
            return new CustomActionResult(HttpStatusCode.OK, "");
        }
        //9-23
        public async Task<CustomActionResult> UpdatePlanItemFlight(ViewModels.FlightPlanningDto dto)
        {

            var flight = await this.context.FlightInformations.FirstOrDefaultAsync(q => q.ID == dto.FlightId);
            var leg = await this.context.ViewLegTimes.FirstOrDefaultAsync(q => q.ID == dto.FlightId);
            var changeLog = new FlightChangeHistory()
            {
                Date = DateTime.Now,
                FlightId = flight.ID,

            };
            changeLog.User = dto.UserName + " " + (dto.SMSNira == 1 ? "1" : "0");
            changeLog.OldFlightNumer = leg.FlightNumber;
            changeLog.OldFromAirportId = leg.FromAirport;
            changeLog.OldToAirportId = leg.ToAirport;
            changeLog.OldSTD = leg.STD;
            changeLog.OldSTA = leg.STA;
            changeLog.OldStatusId = leg.FlightStatusID;
            changeLog.OldRegister = leg.RegisterID;
            changeLog.OldOffBlock = leg.ChocksOut;
            changeLog.OldOnBlock = leg.ChocksIn;
            changeLog.OldTakeOff = leg.Takeoff;
            changeLog.OldLanding = leg.Landing;



            flight.FlightNumber = dto.FlightNumber;


            flight.FlightH = dto.FlightH;
            flight.FlightM = Convert.ToByte(dto.FlightM);


            flight.FromAirportId = dto.FromAirport;
            flight.ToAirportId = dto.ToAirport;

            var old_tzoffset = Helper.GetTimeOffset((DateTime)flight.STD);
            var new_tzoffset = Helper.GetTimeOffset((DateTime)dto.STD);

            var oldSTD = ((DateTime)flight.STD).AddMinutes(old_tzoffset).Date;
            var newSTD = ((DateTime)dto.STD).AddMinutes(new_tzoffset).Date;
            if (oldSTD != newSTD)
            {
                flight.FlightDate = oldSTD;
            }


            flight.STD = dto.STD;
            flight.STA = dto.STA;

            flight.ChocksIn = null;
            flight.ChocksOut = null;
            flight.Takeoff = null;
            flight.Landing = null;

            if (!string.IsNullOrEmpty(dto.Remark))
            {
                var pitem = await this.context.FlightPlanItems.FirstOrDefaultAsync(q => q.Id == flight.FlightPlanId);
                pitem.DepartureRemark = dto.Remark;

            }
            flight.DepartureRemark = dto.Remark;

            var plan = await (from x in this.context.FlightPlanItems
                              join y in this.context.FlightPlans on x.FlightPlanId equals y.Id
                              where x.Id == flight.FlightPlanId
                              select y).FirstOrDefaultAsync();

            if (plan != null)
            {
                var upd = new UpdatedPlanFlight() { PlanId = plan.Id, Date = ((DateTime)flight.STD).Date, Status = 1 };
                this.context.UpdatedPlanFlights.Add(upd);
            }

            changeLog.NewFlightNumber = flight.FlightNumber;
            changeLog.NewFromAirportId = flight.FromAirportId;
            changeLog.NewToAirportId = flight.ToAirportId;
            changeLog.NewSTD = flight.STD;
            changeLog.NewSTA = flight.STA;
            changeLog.NewStatusId = flight.FlightStatusID;
            changeLog.NewRegister = flight.RegisterID;
            changeLog.NewOffBlock = flight.ChocksOut;
            changeLog.NewOnBlock = flight.ChocksIn;
            changeLog.NewTakeOff = flight.Takeoff;
            changeLog.NewLanding = flight.Landing;

            this.context.FlightChangeHistories.Add(changeLog);


            return new CustomActionResult(HttpStatusCode.OK, "");
        }


        public async Task<CustomActionResult> UpdatePlanItemFlightGrouped(string username, DateTime dtfrom, DateTime dtto, string no, int fromid, int toid, DateTime std, DateTime sta, bool nira, int exid, ViewModels.FlightPlanningDto dto)
        {
            var _dfrom = dtfrom.Date;
            var _dto = dtto.Date;
            var query = from q in this.context.ViewLegTimes
                        where q.FlightNumber == no && q.STDDay >= _dfrom && q.STDDay <= _dto && q.FromAirport == fromid && q.ToAirport == toid && q.ID != exid
                        select q;
            var flightIds = await query.Select(q => q.ID).ToListAsync();

            var flights = await this.context.FlightInformations.Where(q => flightIds.Contains(q.ID)).ToListAsync();
            var legs = await this.context.ViewLegTimes.Where(q => flightIds.Contains(q.ID)).ToListAsync();

            foreach (var flight in flights)
            {
                var leg = legs.FirstOrDefault(q => q.ID == flight.ID);
                var changeLog = new FlightChangeHistory()
                {
                    Date = DateTime.Now,
                    FlightId = flight.ID,

                };
                changeLog.User = username + " " + (nira ? "1" : "0");
                changeLog.OldFlightNumer = leg.FlightNumber;
                changeLog.OldFromAirportId = leg.FromAirport;
                changeLog.OldToAirportId = leg.ToAirport;
                changeLog.OldSTD = leg.STD;
                changeLog.OldSTA = leg.STA;
                changeLog.OldStatusId = leg.FlightStatusID;
                changeLog.OldRegister = leg.RegisterID;
                changeLog.OldOffBlock = leg.ChocksOut;
                changeLog.OldOnBlock = leg.ChocksIn;
                changeLog.OldTakeOff = leg.Takeoff;
                changeLog.OldLanding = leg.Landing;



                flight.FlightNumber = dto.FlightNumber;


                flight.FlightH = dto.FlightH;
                flight.FlightM = Convert.ToByte(dto.FlightM);


                flight.FromAirportId = dto.FromAirport;
                flight.ToAirportId = dto.ToAirport;

                var oldSTD = ((DateTime)flight.STD).AddMinutes(270).Date;
                var newSTD = ((DateTime)dto.STD).AddMinutes(270).Date;
                if (oldSTD != newSTD)
                {
                    flight.FlightDate = oldSTD;
                }


                flight.STD = dto.STD;
                flight.STA = dto.STA;

                flight.ChocksIn = null;
                flight.ChocksOut = null;
                flight.Takeoff = null;
                flight.Landing = null;

                if (!string.IsNullOrEmpty(dto.Remark))
                {
                    var pitem = await this.context.FlightPlanItems.FirstOrDefaultAsync(q => q.Id == flight.FlightPlanId);
                    pitem.DepartureRemark = dto.Remark;

                }
                flight.DepartureRemark = dto.Remark;

                var plan = await (from x in this.context.FlightPlanItems
                                  join y in this.context.FlightPlans on x.FlightPlanId equals y.Id
                                  where x.Id == flight.FlightPlanId
                                  select y).FirstOrDefaultAsync();

                if (plan != null)
                {
                    var upd = new UpdatedPlanFlight() { PlanId = plan.Id, Date = ((DateTime)flight.STD).Date, Status = 1 };
                    this.context.UpdatedPlanFlights.Add(upd);
                }

                changeLog.NewFlightNumber = flight.FlightNumber;
                changeLog.NewFromAirportId = flight.FromAirportId;
                changeLog.NewToAirportId = flight.ToAirportId;
                changeLog.NewSTD = flight.STD;
                changeLog.NewSTA = flight.STA;
                changeLog.NewStatusId = flight.FlightStatusID;
                changeLog.NewRegister = flight.RegisterID;
                changeLog.NewOffBlock = flight.ChocksOut;
                changeLog.NewOnBlock = flight.ChocksIn;
                changeLog.NewTakeOff = flight.Takeoff;
                changeLog.NewLanding = flight.Landing;

                this.context.FlightChangeHistories.Add(changeLog);
            }





            return new CustomActionResult(HttpStatusCode.OK, "");
        }


        public async Task<CustomActionResult> ProcessPlanErrors(FlightPlan plan, FlightPlanItem item)
        {
            var dbitems_query = from x in this.context.ViewFlightPlanItems
                                join y in this.context.FlightPlanItems on x.Id equals y.Id
                                where x.RegisterID == item.RegisterID && x.DateFrom == plan.DateFrom
                                // orderby y.STD
                                select y;
            var dbitems = await dbitems_query.ToListAsync();
            if (item.Id == -1)
                dbitems.Add(item);
            dbitems = dbitems.OrderBy(q => q.STD).ToList();
            List<int> overlaps = new List<int>();
            List<int> gaps = new List<int>();
            if (dbitems.Count > 1)
            {
                for (int i = 0; i < dbitems.Count; i++)
                {


                    var o = dbitems[i];
                    var _overlaps = (from x in dbitems
                                     where x.Id != o.Id && (
                                     (x.STD >= o.STD && x.STD <= o.STA) || (x.STA >= o.STD && x.STA <= o.STA)
                                     || (o.STD >= x.STD && o.STD <= x.STA) || (o.STA >= x.STD && o.STA <= x.STA)
                                     )

                                     select x).Count();
                    var isoverlap = _overlaps > 0;

                    var isgap = i > 0 && dbitems[i - 1].ToAirport != o.FromAirport;
                    if (!isoverlap && !isgap)
                        o.StatusId = 1;
                    else if (isoverlap && !isgap)
                        o.StatusId = 10;
                    else if (!isoverlap && isgap)
                        o.StatusId = 11;
                    else o.StatusId = 16;



                }


            }

            // ( (STA>='2019-02-01 05:00:00.000' AND STA<='2019-02-01 06:10:00.000') or (STD>='2019-02-01 05:00:00.000' AND STD<='2019-02-01 06:10:00.000') )


            //16 gap and overlap
            //10 overlap
            //11 gap
            return new CustomActionResult(HttpStatusCode.OK, "");
        }


        public async Task<CustomActionResult> ProcessPlanErrors(FlightPlan plan)
        {
            var dbitems_query = from x in this.context.ViewFlightPlanItems
                                join y in this.context.FlightPlanItems on x.Id equals y.Id
                                where x.FlightPlanId == plan.Id
                                // orderby y.STD
                                select y;
            var dbitems = await dbitems_query.ToListAsync();

            dbitems = dbitems.OrderBy(q => q.STD).ToList();
            List<int> overlaps = new List<int>();
            List<int> gaps = new List<int>();
            //if (dbitems.Count > 1)
            {
                for (int i = 0; i < dbitems.Count; i++)
                {


                    var o = dbitems[i];
                    var _overlaps = (from x in dbitems
                                     where x.Id != o.Id && (
                                     (x.STD >= o.STD && x.STD <= o.STA) || (x.STA >= o.STD && x.STA <= o.STA)
                                     || (o.STD >= x.STD && o.STD <= x.STA) || (o.STA >= x.STD && o.STA <= x.STA)
                                     )

                                     select x).Count();
                    var isoverlap = _overlaps > 0;

                    var isgap = i > 0 && dbitems[i - 1].ToAirport != o.FromAirport;
                    if (!isoverlap && !isgap)
                        o.StatusId = 1;
                    else if (isoverlap && !isgap)
                        o.StatusId = 10;
                    else if (!isoverlap && isgap)
                        o.StatusId = 11;
                    else o.StatusId = 16;



                }


            }

            // ( (STA>='2019-02-01 05:00:00.000' AND STA<='2019-02-01 06:10:00.000') or (STD>='2019-02-01 05:00:00.000' AND STD<='2019-02-01 06:10:00.000') )


            //16 gap and overlap
            //10 overlap
            //11 gap
            return new CustomActionResult(HttpStatusCode.OK, "");
        }
        public async Task<CustomActionResult> FlightPlanEditable(int id)
        {

            var plan = await this.context.FlightPlans.FirstOrDefaultAsync(q => q.Id == id);
            var tlts = plan.Title.IndexOf("_A50");
            var title = plan.Title.Substring(0, tlts);
            plan.Title = title;

            var flights = await (from x in this.context.FlightPlanItems
                                 join y in this.context.FlightInformations on x.Id equals y.FlightPlanId
                                 where x.FlightPlanId == id
                                 select y).ToListAsync();

            var cf = flights.Where(q => q.FlightStatusID != 1).Count();
            if (cf > 0)
                return new CustomActionResult(HttpStatusCode.OK, "the plan flights cannot be updated");

            this.context.FlightInformations.RemoveRange(flights);

            var status = await this.context.FlightPlanStatus.Where(q => q.FlighPlanId == id && q.ApproveTypeId == 50).ToListAsync();
            this.context.FlightPlanStatus.RemoveRange(status);


            return new CustomActionResult(HttpStatusCode.OK, "");
        }

        public CustomActionResult UpdateDelays(ViewModels.FlightSaveDto dto)
        {
            if (!string.IsNullOrEmpty(dto.UserName) && dto.UserName.ToLower().StartsWith("aps."))
                return new CustomActionResult(HttpStatusCode.OK, "");
            var currentDelays = this.context.FlightDelays.Where(q => q.FlightId == dto.ID);
            this.context.FlightDelays.RemoveRange(currentDelays);
            foreach (var x in dto.Delays)
            {
                this.context.FlightDelays.Add(new FlightDelay()
                {
                    DelayCodeId = x.DelayCodeId,
                    FlightId = dto.ID,
                    MM = x.MM,
                    HH = x.HH,
                    Remark = x.Remark,
                    UserId = x.UserId
                });
            }

            return new CustomActionResult(HttpStatusCode.OK, "");
        }

        public async Task<CustomActionResult> UpdateEstimatedDelays(ViewModels.FlightSaveDto dto)
        {
            if (dto.EstimatedDelays == null || dto.EstimatedDelays.Count == 0)
                return new CustomActionResult(HttpStatusCode.OK, "");
            var flightIds = dto.EstimatedDelays.Select(q => q.FlightId).ToList();
            var flights = await this.context.FlightInformations.Where(q => flightIds.Contains(q.ID)).ToListAsync();
            foreach (var x in flights)
            {
                var f = dto.EstimatedDelays.FirstOrDefault(q => q.FlightId == x.ID);
                if (f != null)
                    x.EstimatedDelay = f.Delay;
            }

            return new CustomActionResult(HttpStatusCode.OK, "");
        }
        public async Task<CustomActionResult> UpdateFlightDeparture(ViewModels.FlightSaveDto dto)
        {
            var flight = await this.context.FlightInformations.FirstOrDefaultAsync(q => q.ID == dto.ID);
            if (flight == null)
                return new CustomActionResult(HttpStatusCode.NotFound, "");
            var takeOffChanged = flight.Takeoff != dto.Takeoff;
            var stids = dto.StatusLog.Select(q => q.FlightStatusID).ToList();
            var currentStatus = this.context.FlightStatusLogs.Where(q => q.FlightID == dto.ID && (q.FlightStatusID == 2 || q.FlightStatusID == 14));
            this.context.FlightStatusLogs.RemoveRange(currentStatus);
            foreach (var x in dto.StatusLog)
            {
                this.context.FlightStatusLogs.Add(new FlightStatusLog()
                {
                    FlightID = dto.ID,
                    Date = x.Date,
                    FlightStatusID = x.FlightStatusID,
                    Remark = x.Remark,
                    UserId = x.UserId
                });
            }
            if (flight.FlightStatusID != 4)
            {
                if (flight.FlightStatusID != dto.FlightStatusID)
                {
                    if (dto.StatusLog.Count > 0)
                    {
                        flight.DateCreate = dto.StatusLog.Max(q => q.Date);
                    }
                    else
                    {
                        flight.DateCreate = DateTime.UtcNow;
                    }
                    flight.FlightStatusUserId = dto.UserId;
                }
                flight.FlightStatusID = dto.FlightStatusID;
            }

            flight.ChocksOut = dto.ChocksOut;
            flight.Takeoff = dto.Takeoff;
            flight.GWTO = dto.GWTO;
            flight.FuelDeparture = dto.FuelDeparture;
            flight.PaxAdult = dto.PaxAdult;
            flight.PaxInfant = dto.PaxInfant;
            flight.PaxChild = dto.PaxChild;
            flight.CargoWeight = dto.CargoWeight;
            flight.CargoUnitID = dto.CargoUnitID;
            flight.BaggageCount = dto.BaggageCount;
            flight.CargoCount = dto.CargoCount;
            flight.BaggageWeight = dto.BaggageWeight;
            flight.FuelUnitID = dto.FuelUnitID;
            flight.DepartureRemark = dto.DepartureRemark;

            var result = UpdateDelays(dto);

            if (result.Code != HttpStatusCode.OK)
                return result;

            var result2 = await UpdateEstimatedDelays(dto);

            if (result2.Code != HttpStatusCode.OK)
                return result2;


            return new CustomActionResult(HttpStatusCode.OK, takeOffChanged);
        }

        internal async Task<CustomActionResult> SaveCPFlight(ViewModels.CPFlight dto)
        {
            var flight = await this.context.FlightInformations.FirstOrDefaultAsync(q => q.ID == dto.ID);
            if (flight == null)
            {
                flight = new FlightInformation();
                flight.DateCreate = DateTime.Now.ToUniversalTime();
                this.context.FlightInformations.Add(flight);
            }
            flight.CPCrewId = dto.CPCrewId;
            flight.CPFlightTypeId = dto.CPFlightTypeId;
            flight.CPPositionId = dto.CPPositionId;
            flight.CPRegister = dto.CPRegister;
            flight.CPDH = dto.CPDH;

            flight.TypeID = dto.TypeID;
            flight.FlightStatusID = dto.FlightStatusID;
            flight.AirlineOperatorsID = dto.AirlineOperatorsID;
            flight.FlightNumber = dto.FlightNumber;
            flight.FromAirportId = dto.FromAirportId;
            flight.ToAirportId = dto.ToAirportId;

            flight.STD = dto.STD;
            flight.STA = dto.STA;
            flight.ChocksOut = dto.ChocksOut;
            flight.ChocksIn = dto.ChocksIn;
            flight.Takeoff = dto.Takeoff;
            flight.Landing = dto.Landing;


            return new CustomActionResult(HttpStatusCode.OK, null);
        }
        class phoneNum
        {
            public string Name { get; set; }
            public string Mobile { get; set; }

        }
        //magu2-17
        public async Task<bool> UpdateFlightJLog(int id, DateTime? offblock, DateTime? onblock, DateTime? takeoff, DateTime? landing, int? pflr
            , double? _FuelArrival, double? _FuelDeparture, double? _UsedFuel, int? unitId, double? _FPFuel
            )
        {
            var flight = await this.context.FlightInformations.FirstOrDefaultAsync(q => q.ID == id);
            if (flight == null)
                return false;
            flight.JLOffBlock = offblock;
            flight.JLOnBlock = onblock;
            flight.JLTakeOff = takeoff;
            flight.JLLanding = landing;
            flight.PFLR = pflr;
            flight.FuelArrival = (decimal)_FuelArrival;
            flight.FuelDeparture = (decimal)_FuelDeparture;
            flight.UsedFuel = (decimal)_UsedFuel;
            flight.FPFuel = (decimal)_FPFuel;
            flight.FuelUnitID = unitId;

            return true;


        }
        public /*async Task<object>*/object CreateMVTMessage(int flightId, string userName)
        {
            new Thread(async () =>
           {
               using (var _context = new EPAGRIFFINEntities())
               {
                   var flight = await _context.ViewLegTimes.FirstOrDefaultAsync(f => f.ID == flightId);
                   string caoMSGEmail = ConfigurationManager.AppSettings["email_cao_message"];
                   string fnPrefix = ConfigurationManager.AppSettings["flightno"];
                   //new Thread(async () =>
                   //new Thread( () =>
                   //{

                   if (flight != null && (flight.FlightStatusID == 2 || flight.FlightStatusID == 3 || flight.FlightStatusID == 15))
                   {
                       if (flight.FlightStatusID == 2)
                       {
                           var msgAD = await _context.MVTs.OrderByDescending(q => q.Id).FirstOrDefaultAsync(q => q.FlightId == flightId && (q.Type == "AD" || q.Type == "AD COR"));
                           var delays = await _context.ViewFlightDelayCodes.Where(q => q.FlightId == flightId).OrderBy(q => q.Code).Select(q => new { q.Code, q.HH, q.MM }).ToListAsync();
                           string dl = "";
                           if (delays.Count > 0)
                           {
                               var dlcode = new List<string>();
                               var dlvalue = new List<string>();
                               foreach (var x in delays)
                               {
                                   dlcode.Add(x.Code);
                                   dlvalue.Add((x.HH ?? 0).ToString().PadLeft(2, '0') + (x.MM ?? 0).ToString().PadLeft(2, '0'));
                               }
                               dl = "DL" + string.Join("/", dlcode) + "/" + string.Join("/", dlvalue);

                           }
                           if (msgAD == null)
                           {
                               #region AD New
                               msgAD = new MVT()
                               {
                                   Bag = "BAG " + flight.BaggageWeight.ToString() + "KG",
                                   DateCreate = DateTime.Now,
                                   DayOfMonth = flight.Takeoff == null ? ((DateTime)flight.STD).Day : ((DateTime)flight.Takeoff).Day,
                                   //ETA = ((DateTime)flight.Landing).ToString("HHmm"),
                                   ETA = flight.Landing,
                                   FlightId = flight.ID,
                                   FlightNo = fnPrefix + flight.FlightNumber,
                                   FromIATA = flight.FromAirportIATA,
                                   OffBlock = flight.ChocksOut,
                                   OnBlock = flight.ChocksIn,
                                   Pax = ((flight.PaxAdult ?? 0) + (flight.PaxChild ?? 0)).ToString().PadLeft(3, '0') + "+" + (flight.PaxInfant ?? 0).ToString().PadLeft(2, '0'),
                                   Register = "EP-" + flight.Register,
                                   TakeOff = flight.Takeoff,
                                   ToIATA = flight.ToAirportIATA,
                                   Type = "AD",
                                   UserName = userName,
                                   SendTo = caoMSGEmail,




                               };
                               //if (!string.IsNullOrEmpty(dl))
                               {
                                   msgAD.DL = dl;
                               }
                               var msg = new List<string>();
                               msg.Add("MVT");
                               msg.Add(msgAD.FlightNo + "/" + msgAD.DayOfMonth.ToString().PadLeft(2, '0') + "." + msgAD.Register + "." + msgAD.FromIATA);
                               msg.Add("AD" + ((DateTime)msgAD.OffBlock).ToString("HHmm") + "/" + ((DateTime)msgAD.TakeOff).ToString("HHmm")
                                   + " EA " + ((DateTime)msgAD.ETA).ToString("HHmm") + msgAD.ToIATA);
                               if (!string.IsNullOrEmpty(msgAD.DL))
                               {
                                   msg.Add(msgAD.DL);
                               }
                               msg.Add("PX" + msgAD.Pax);
                               msg.Add(msgAD.Bag);
                               msgAD.Message = string.Join("\r\n", msg);

                               _context.MVTs.Add(msgAD);
                               await _context.SaveAsync();

                               EPAGriffinAPI.Email mail = new Email();
                               mail.SendEmailMVT(msgAD.Message, "MVT AD " + fnPrefix + " " + flight.FlightNumber + " ON " + ((DateTime)flight.Takeoff).ToString("dd MMM yyyy"));
                               #endregion
                           }
                           else
                           if (msgAD != null && (msgAD.OffBlock != flight.ChocksOut || msgAD.TakeOff != flight.Takeoff || msgAD.ETA != flight.Landing || msgAD.DL != dl))
                           {
                               //revision
                               #region AD Cor

                               msgAD.Bag = "BAG " + flight.BaggageWeight.ToString() + "KG";
                               msgAD.DateCreate = DateTime.Now;
                               msgAD.DayOfMonth = flight.Takeoff == null ? ((DateTime)flight.STD).Day : ((DateTime)flight.Takeoff).Day;
                               //ETA = ((DateTime)flight.Landing).ToString("HHmm"),
                               msgAD.ETA = flight.Landing;
                               msgAD.FlightId = flight.ID;
                               msgAD.FlightNo = fnPrefix + flight.FlightNumber;
                               msgAD.FromIATA = flight.FromAirportIATA;
                               msgAD.OffBlock = flight.ChocksOut;
                               msgAD.OnBlock = flight.ChocksIn;
                               msgAD.Pax = ((flight.PaxAdult ?? 0) + (flight.PaxChild ?? 0)).ToString().PadLeft(3, '0') + "+" + (flight.PaxInfant ?? 0).ToString().PadLeft(2, '0');
                               msgAD.Register = "EP-" + flight.Register;
                               msgAD.TakeOff = flight.Takeoff;
                               msgAD.ToIATA = flight.ToAirportIATA;
                               msgAD.Type = "AD COR";
                               msgAD.UserName = userName;
                               msgAD.SendTo = caoMSGEmail;





                               //if (!string.IsNullOrEmpty(dl))
                               {
                                   msgAD.DL = dl;
                               }
                               var msg = new List<string>();
                               msg.Add("COR");
                               msg.Add("MVT");
                               msg.Add(msgAD.FlightNo + "/" + msgAD.DayOfMonth.ToString().PadLeft(2, '0') + "." + msgAD.Register + "." + msgAD.FromIATA);
                               msg.Add("AD" + ((DateTime)msgAD.OffBlock).ToString("HHmm") + "/" + ((DateTime)msgAD.TakeOff).ToString("HHmm")
                                   + " EA " + ((DateTime)msgAD.ETA).ToString("HHmm") + msgAD.ToIATA);
                               if (!string.IsNullOrEmpty(msgAD.DL))
                               {
                                   msg.Add(msgAD.DL);
                               }
                               msg.Add("PX" + msgAD.Pax);
                               msg.Add(msgAD.Bag);
                               msgAD.Message = string.Join("\r\n", msg);

                               _context.MVTs.Add(msgAD);
                               await _context.SaveAsync();

                               EPAGriffinAPI.Email mail = new Email();
                               mail.SendEmailMVT(msgAD.Message, "MVT AD COR " + fnPrefix + " " + flight.FlightNumber + " ON " + ((DateTime)flight.Takeoff).ToString("dd MMM yyyy"));
                               #endregion
                           }
                       }


                       if (flight.FlightStatusID == 3 || flight.FlightStatusID == 15)
                       {
                           var msgAD = await _context.MVTs.OrderByDescending(q => q.Id).FirstOrDefaultAsync(q => q.FlightId == flightId && (q.Type == "AA" || q.Type == "AA COR"));

                           if (msgAD == null)
                           {
                               #region AA New
                               msgAD = new MVT()
                               {
                                   Bag = "BAG " + flight.BaggageWeight.ToString() + "KG",
                                   DateCreate = DateTime.Now,
                                   DayOfMonth = flight.Takeoff == null ? ((DateTime)flight.STD).Day : ((DateTime)flight.Takeoff).Day,
                                   //ETA = ((DateTime)flight.Landing).ToString("HHmm"),
                                   ETA = flight.Landing,
                                   FlightId = flight.ID,
                                   FlightNo = fnPrefix + flight.FlightNumber,
                                   FromIATA = flight.FromAirportIATA,
                                   OffBlock = flight.ChocksOut,
                                   OnBlock = flight.ChocksIn,
                                   Pax = ((flight.PaxAdult ?? 0) + (flight.PaxChild ?? 0)).ToString().PadLeft(3, '0') + "+" + (flight.PaxInfant ?? 0).ToString().PadLeft(2, '0'),
                                   Register = "EP-" + flight.Register,
                                   TakeOff = flight.Takeoff,
                                   ToIATA = flight.ToAirportIATA,
                                   Type = "AA",
                                   UserName = userName,
                                   SendTo = caoMSGEmail,




                               };

                               var msg = new List<string>();
                               msg.Add("MVT");
                               msg.Add(msgAD.FlightNo + "/" + msgAD.DayOfMonth.ToString().PadLeft(2, '0') + "." + msgAD.Register + "." + msgAD.ToIATA);
                               msg.Add("AA" + ((DateTime)msgAD.ETA).ToString("HHmm") + "/" + ((DateTime)msgAD.OnBlock).ToString("HHmm"));
                               msg.Add("SI NIL");

                               msgAD.Message = string.Join("\r\n", msg);

                               _context.MVTs.Add(msgAD);
                               await _context.SaveAsync();

                               EPAGriffinAPI.Email mail = new Email();
                               mail.SendEmailMVT(msgAD.Message, "MVT AA " + fnPrefix + " " + flight.FlightNumber + " ON " + ((DateTime)flight.Takeoff).ToString("dd MMM yyyy"));
                               #endregion
                           }
                           else
                           if (msgAD != null && (msgAD.OnBlock != flight.ChocksIn || msgAD.ETA != flight.Landing))
                           {
                               //revision
                               #region AD Cor

                               msgAD.Bag = "BAG " + flight.BaggageWeight.ToString() + "KG";
                               msgAD.DateCreate = DateTime.Now;
                               msgAD.DayOfMonth = flight.Takeoff == null ? ((DateTime)flight.STD).Day : ((DateTime)flight.Takeoff).Day;
                               //ETA = ((DateTime)flight.Landing).ToString("HHmm"),
                               msgAD.ETA = flight.Landing;
                               msgAD.FlightId = flight.ID;
                               msgAD.FlightNo = fnPrefix + flight.FlightNumber;
                               msgAD.FromIATA = flight.FromAirportIATA;
                               msgAD.OffBlock = flight.ChocksOut;
                               msgAD.Pax = ((flight.PaxAdult ?? 0) + (flight.PaxChild ?? 0)).ToString().PadLeft(3, '0') + "+" + (flight.PaxInfant ?? 0).ToString().PadLeft(2, '0');
                               msgAD.Register = "EP-" + flight.Register;
                               msgAD.TakeOff = flight.Takeoff;
                               msgAD.ToIATA = flight.ToAirportIATA;
                               msgAD.Type = "AA COR";
                               msgAD.UserName = userName;
                               msgAD.SendTo = caoMSGEmail;
                               msgAD.OnBlock = flight.ChocksIn;






                               var msg = new List<string>();
                               msg.Add("COR");
                               msg.Add("MVT");
                               msg.Add(msgAD.FlightNo + "/" + msgAD.DayOfMonth.ToString().PadLeft(2, '0') + "." + msgAD.Register + "." + msgAD.ToIATA);
                               msg.Add("AA" + ((DateTime)msgAD.ETA).ToString("HHmm") + "/" + ((DateTime)msgAD.OnBlock).ToString("HHmm"));
                               msg.Add("SI NIL");

                               msgAD.Message = string.Join("\r\n", msg);

                               _context.MVTs.Add(msgAD);
                               await _context.SaveAsync();

                               EPAGriffinAPI.Email mail = new Email();
                               mail.SendEmailMVT(msgAD.Message, "MVT AA COR " + fnPrefix + " " + flight.FlightNumber + " ON " + ((DateTime)flight.Takeoff).ToString("dd MMM yyyy"));
                               #endregion
                           }
                       }
                   }
                   //}).Start();

               }
           }).Start();
            return true;
        }
        //baba
        public async Task<object> GetFlightGUID(int id)
        {
            var guid = await this.context.FlightInformations.Where(q => q.ID == id).Select(q => q.GUID).FirstOrDefaultAsync();
            return guid;
        }
        public class selaDataTag
        {
            public string info { get; set; }
            public string RType { get; set; }
            public string name { get; set; }
        }
        public class selaProccess
        {
            public string name { get; set; }
            public string info { get; set; }
            public List<selaDataTag> data_tags { get; set; }

        }
        public async Task<object> CreateSela()
        {
            var logs = await this.context.LOGs.ToListAsync();
            var grouped = (from x in logs
                           group x by new { x.table } into grp
                           select new selaProccess()
                           {
                               name = "insert_" + grp.Key.table.ToLower(),
                               info = "This process responsible for " + grp.Key.table.ToLower() + " creation.",
                               data_tags = grp.Select(q => new selaDataTag() { RType = q.Rtype, name = q.name, info = q.info }).ToList(),
                               //items =grp.Select(q=>new { q.Rtype,q.name,q.info }).ToList()
                           }).ToList();
            var groupedEdit = (from x in logs
                               group x by new { x.table } into grp
                               select new selaProccess()
                               {
                                   name = "edit_" + grp.Key.table.ToLower(),
                                   info = "This process responsible for " + grp.Key.table.ToLower() + " editing.",
                                   data_tags = grp.Select(q => new selaDataTag() { RType = q.Rtype, name = q.name, info = q.info }).ToList(),
                                   //items =grp.Select(q=>new { q.Rtype,q.name,q.info }).ToList()
                               }).ToList();
            var groupedDelete = (from x in logs
                                 where x.name.ToLower() == "id"
                                 orderby x.table, x.name
                                 group x by new { x.table } into grp
                                 select new selaProccess()
                                 {
                                     name = "delete_" + grp.Key.table.ToLower(),
                                     info = "This process responsible for " + grp.Key.table.ToLower() + " deleting.",
                                     data_tags = grp.Select(q => new selaDataTag() { RType = q.Rtype, name = q.name, info = q.info }).ToList(),
                                     //items =grp.Select(q=>new { q.Rtype,q.name,q.info }).ToList()
                                 }).ToList();
            var lst = new List<string>();
            foreach (var x in grouped)
            {
                var str = "\"" + x.name + "\"";
                lst.Add(str + ":" + JsonConvert.SerializeObject(x));



            }
            foreach (var x in groupedEdit)
            {
                var str = "\"" + x.name + "\"";
                lst.Add(str + ":" + JsonConvert.SerializeObject(x));



            }
            foreach (var x in groupedDelete)
            {
                var str = "\"" + x.name + "\"";
                lst.Add(str + ":" + JsonConvert.SerializeObject(x));



            }
            using (StreamWriter _detailogwriter = new StreamWriter(HttpContext.Current.Server.MapPath("~/" + "sela.json"), true))
            {
                _detailogwriter.WriteLine("{" + "\r\n");
                _detailogwriter.WriteLine("\"" + "application" + "\"" + ":" + "{" + "\r\n");
                _detailogwriter.WriteLine("\"" + "name" + "\"" + ":" + "\"" + "amanat" + "\"" + "," + "\r\n");
                _detailogwriter.WriteLine("\"" + "version" + "\"" + ":" + "\"" + "1.1.0" + "\"" + "\r\n");
                _detailogwriter.WriteLine("}," + "\r\n");
                _detailogwriter.WriteLine("\"" + "processes" + "\"" + ":" + "{" + "\r\n");
                foreach (var str in lst)
                {
                    if (str != lst.Last())
                        _detailogwriter.WriteLine(str + "," + "\r\n");
                    else
                        _detailogwriter.WriteLine(str + "\r\n");
                }
                _detailogwriter.WriteLine("}" + "\r\n");

                _detailogwriter.WriteLine("}" + "\r\n");
            }

            return true;
        }

        public async Task<CustomActionResult> UpdateFlightLog(ViewModels.FlightSaveDto dto)
        {
            List<int?> offCrewIds = new List<int?>();
            //marmar
            // return new CustomActionResult(HttpStatusCode.OK, null);
            var flight = await this.context.FlightInformations.FirstOrDefaultAsync(q => q.ID == dto.ID);
            var notifiedDelay = flight.NotifiedDelay;
            var leg = await this.context.ViewLegTimes.FirstOrDefaultAsync(q => q.ID == dto.ID);
            if (flight == null)
                return new CustomActionResult(HttpStatusCode.NotFound, "");
            //var takeOffChanged = flight.Takeoff != dto.Takeoff;
            //var stids = dto.StatusLog.Select(q => q.FlightStatusID).ToList();
            //var currentStatus = this.context.FlightStatusLogs.Where(q => q.FlightID == dto.ID && (q.FlightStatusID == 2 || q.FlightStatusID == 14));
            //this.context.FlightStatusLogs.RemoveRange(currentStatus);
            //foreach (var x in dto.StatusLog)
            //{
            //    this.context.FlightStatusLogs.Add(new FlightStatusLog()
            //    {
            //        FlightID = dto.ID,
            //        Date = x.Date,
            //        FlightStatusID = x.FlightStatusID,
            //        Remark = x.Remark,
            //        UserId = x.UserId
            //    });
            //}
            //if (flight.FlightStatusID != 4)
            //{
            //    if (flight.FlightStatusID != dto.FlightStatusID)
            //    {
            //        if (dto.StatusLog.Count > 0)
            //        {
            //            flight.DateCreate = dto.StatusLog.Max(q => q.Date);
            //        }
            //        else
            //        {
            //            flight.DateCreate = DateTime.UtcNow;
            //        }
            //        flight.FlightStatusUserId = dto.UserId;
            //    }
            //    flight.FlightStatusID = dto.FlightStatusID;
            //}
            //////////////////////////////////////////////////////////////
            var changeLog = new FlightChangeHistory()
            {
                Date = DateTime.Now,
                FlightId = flight.ID,
                User = dto.UserName,

            };
            changeLog.OldFlightNumer = leg.FlightNumber;
            changeLog.OldFromAirportId = leg.FromAirport;
            changeLog.OldToAirportId = leg.ToAirport;
            changeLog.OldSTD = flight.STD;
            changeLog.OldSTA = flight.STA;
            changeLog.OldStatusId = flight.FlightStatusID;
            changeLog.OldRegister = leg.RegisterID;
            changeLog.OldOffBlock = flight.ChocksOut;
            changeLog.OldOnBlock = flight.ChocksIn;
            changeLog.OldTakeOff = flight.Takeoff;
            changeLog.OldLanding = flight.Landing;

            //////////////////////////////////////////////////////////////
            flight.GUID = Guid.NewGuid();
            flight.DateCreate = DateTime.Now.ToUniversalTime();
            flight.FlightStatusUserId = dto.UserId;
            flight.ChocksIn = dto.ChocksIn;
            flight.Landing = dto.Landing;
            flight.ChocksOut = dto.ChocksOut;
            flight.Takeoff = dto.Takeoff;
            flight.GWTO = dto.GWTO;
            flight.FuelDeparture = dto.FuelDeparture;
            flight.FuelArrival = dto.FuelArrival;
            flight.PaxAdult = dto.PaxAdult;
            flight.PaxInfant = dto.PaxInfant;
            flight.PaxChild = dto.PaxChild;
            flight.NightTime = dto.NightTime;
            flight.CargoWeight = dto.CargoWeight;
            flight.CargoUnitID = dto.CargoUnitID;
            flight.BaggageCount = dto.BaggageCount;
            flight.CargoCount = dto.CargoCount;
            flight.BaggageWeight = dto.BaggageWeight;
            flight.FuelUnitID = dto.FuelUnitID;
            flight.DepartureRemark = dto.DepartureRemark;
            flight.FPFlightHH = dto.FPFlightHH;
            flight.FPFlightMM = dto.FPFlightMM;
            flight.FPFuel = dto.FPFuel;
            flight.Defuel = dto.Defuel;
            flight.UsedFuel = dto.UsedFuel;
            flight.JLBLHH = dto.JLBLHH;
            flight.JLBLMM = dto.JLBLMM;
            flight.PFLR = dto.PFLR;
            if (dto.FlightStatusID != null)
                flight.FlightStatusID = dto.FlightStatusID;
            if (flight.FlightStatusID == null)
                flight.FlightStatusID = 1;
            if (flight.FlightStatusID == 4)
            {
                var cnlMsn = await this.context.Ac_MSN.Where(q => q.Register == "CNL").Select(q => q.ID).FirstOrDefaultAsync();
                flight.RegisterID = cnlMsn;
                flight.CancelDate = dto.CancelDate;
                flight.CancelReasonId = dto.CancelReasonId;
            }
            //if (flight.FlightStatusID == 17)
            if (dto.RedirectReasonId != null)
            {

                flight.RedirectDate = dto.RedirectDate;
                flight.RedirectReasonId = dto.RedirectReasonId;
                flight.RedirectRemark = dto.RedirectRemark;
                if (flight.OSTA == null)
                {
                    var vflight = await this.context.ViewFlightInformations.FirstOrDefaultAsync(q => q.ID == flight.ID);
                    flight.OSTA = flight.STA;
                    flight.OToAirportId = vflight.ToAirport;
                    flight.OToAirportIATA = vflight.ToAirportIATA;
                }

                // var airport = await this.context.Airports.FirstOrDefaultAsync(q => q.Id == flight.OToAirportId);
                flight.ToAirportId = dto.ToAirportId;
                // if (airport != null)
                //    flight.OToAirportIATA = airport.IATA;
            }
            else
            {
                flight.RedirectDate = null;
                flight.RedirectReasonId = null;
                // if (flight.FlightPlanId != null)
                //    flight.ToAirportId = null;
                flight.OSTA = null;
                flight.OToAirportId = null;
                flight.OToAirportIATA = null;

            }
            if (flight.FlightStatusID == 9)
            {
                flight.RampDate = dto.RampDate;
                flight.RampReasonId = dto.RampReasonId;
            }

            if (flight.ChocksIn != null && flight.FlightStatusID == 15)
            {
                var vflight = await this.context.ViewFlightInformations.FirstOrDefaultAsync(q => q.ID == flight.ID);
                //var flightCrew = await this.context.ViewFlightCrew2.Where(q => q.FlightId == flight.ID).ToListAsync();
                var flightCrewEmployee = await (from x in this.context.Employees
                                                join y in this.context.ViewFlightCrewNews on x.Id equals y.CrewId
                                                where y.FlightId == flight.ID
                                                select x).ToListAsync();
                //foreach (var x in flightCrew)
                //     x.Status = 15;
                foreach (var x in flightCrewEmployee)
                    x.CurrentLocationAirport = vflight.ToAirport;

            }
            if (flight.FlightStatusID != null && /*dto.UserId != null*/ !string.IsNullOrEmpty(dto.UserName))
                this.context.FlightStatusLogs.Add(new FlightStatusLog()
                {
                    FlightID = dto.ID,

                    Date = DateTime.Now.ToUniversalTime(),
                    FlightStatusID = (int)flight.FlightStatusID,

                    UserId = dto.UserId != null ? (int)dto.UserId : 128000,
                    Remark = dto.UserName,
                });
            var result = UpdateDelays(dto);

            if (result.Code != HttpStatusCode.OK)
                return result;

            var result2 = await UpdateEstimatedDelays(dto);

            if (result2.Code != HttpStatusCode.OK)
                return result2;

            if (flight.FlightStatusID == 4)
            {
                UpdateFirstLastFlights(flight.ID);
            }

            if (flight.FlightPlanId != null)
            {
                var plan = await (from x in this.context.FlightPlanItems
                                  join y in this.context.FlightPlans on x.FlightPlanId equals y.Id
                                  where x.Id == flight.FlightPlanId
                                  select y).FirstOrDefaultAsync();
                if (plan != null)
                    this.context.UpdatedPlanFlights.Add(new UpdatedPlanFlight()
                    {
                        Date = ((DateTime)flight.STD).Date,
                        FlightId = flight.ID,
                        PlanId = plan.Id,
                        PlanItemId = flight.FlightPlanId,
                        Status = 3,
                    });
            }
            ////////////////////////////////////////
            changeLog.NewFlightNumber = leg.FlightNumber;
            changeLog.NewFromAirportId = leg.FromAirport;
            changeLog.NewToAirportId = flight.ToAirportId;
            changeLog.NewSTD = flight.STD;
            changeLog.NewSTA = flight.STA;
            changeLog.NewStatusId = flight.FlightStatusID;
            changeLog.NewRegister = leg.RegisterID;
            changeLog.NewOffBlock = flight.ChocksOut;
            changeLog.NewOnBlock = flight.ChocksIn;
            changeLog.NewTakeOff = flight.Takeoff;
            changeLog.NewLanding = flight.Landing;

            this.context.FlightChangeHistories.Add(changeLog);
            ////////////////////////////////////////

            bool sendNira = false;
            try
            {
                var xdelay = (int)(((DateTime)dto.ChocksOut) - ((DateTime)leg.STD)).TotalMinutes;
                if (xdelay > 30 && (flight.FlightStatusID == 1) && notifiedDelay != xdelay && ((DateTime)flight.STD - DateTime.UtcNow).TotalHours > 1)
                {
                    flight.NotifiedDelay = xdelay;
                    sendNira = true;
                }
                if (dto.FlightStatusID == 4)
                {
                    offCrewIds = (from q in this.context.ViewFlightCrewNews
                                  where q.FlightId == dto.ID
                                  select q.CrewId).ToList();
                    //helen


                }
                if (dto.FlightStatusID == 4 && 1 == 2)
                {
                    List<phoneNum> _legCrews = // this.context.ViewFlightCrewNewXes.Where(q => q.FlightId == dto.ID).ToListAsync();
                        (from q in this.context.ViewFlightCrewNews
                         join p in this.context.ViewEmployeeLights on q.CrewId equals p.Id
                         where q.FlightId == dto.ID
                         select new phoneNum() { Name = q.Name, Mobile = p.Mobile }).ToList();
                    var strs = new List<string>() { "Cancelling Notification" };
                    strs.Add(((DateTime)leg.STDDay).ToShortDateString());
                    strs.Add(leg.FromAirportIATA + "-" + leg.FlightNumber + "-" + leg.ToAirportIATA);

                    //strs.Add("Arrival: " + ((DateTime)leg.Takeoff).Hour.ToString().PadLeft(2, '0') + ":" + ((DateTime)leg.Takeoff).Minute.ToString().PadLeft(2, '0'));
                    Magfa m = new Magfa();
                    foreach (var cr in _legCrews)
                    {
                        if (!string.IsNullOrEmpty(cr.Mobile))
                        {
                            strs.Insert(0, "Dear " + cr.Name);
                            var text = String.Join("\n", strs);
                            var smsResult = m.enqueue(1, cr.Mobile, text)[0];
                        }
                    }

                }

                // if ((dto.SendCancelSMS == 1 || dto.SendDelaySMS == 1) && 1 == 2)

                //{

                //    //var leg = await this.context.ViewLegTimes.FirstOrDefaultAsync(q => q.ID == dto.ID);
                //    // return unitOfWork.FlightRepository.GetViewFlightCrewNewXs().Where(q => q.FlightId == id).OrderBy(q => q.IsPositioning).ThenBy(q => q.GroupOrder);

                //    var delay = (((DateTime)dto.ChocksOut) - ((DateTime)leg.STD)).Minutes;
                //    List<phoneNum> legCrews = // this.context.ViewFlightCrewNewXes.Where(q => q.FlightId == dto.ID).ToListAsync();
                //        (from q in this.context.ViewFlightCrewNews
                //         join p in this.context.ViewEmployeeLights on q.CrewId equals p.Id
                //         where q.FlightId == dto.ID
                //         select new phoneNum() { Name = q.Name, Mobile = p.Mobile }).ToList();


                //    if (dto.SendDelaySMS == 1)
                //    {
                //        if (delay > 0)
                //        {
                //            var _del = (int)delay;
                //            var strs = new List<string>() { "Delay Notification" };
                //            strs.Add(((DateTime)leg.STDDay).ToShortDateString());
                //            strs.Add(leg.FromAirportIATA + "-" + leg.FlightNumber + "-" + leg.ToAirportIATA);
                //            var Hour = _del / 60;
                //            var Minute = _del % 60;
                //            var delayStr = FormatTwoDigits(Hour) + ":" + FormatTwoDigits(Minute);
                //            strs.Add("Delay: " + delayStr);
                //            strs.Add("STD: " + ((DateTime)leg.STDLocal).Hour.ToString().PadLeft(2, '0') + ":" + ((DateTime)leg.STDLocal).Minute.ToString().PadLeft(2, '0'));
                //            strs.Add("STA: " + ((DateTime)leg.STALocal).Hour.ToString().PadLeft(2, '0') + ":" + ((DateTime)leg.STALocal).Minute.ToString().PadLeft(2, '0'));
                //            //strs.Add("Arrival: " + ((DateTime)leg.Takeoff).Hour.ToString().PadLeft(2, '0') + ":" + ((DateTime)leg.Takeoff).Minute.ToString().PadLeft(2, '0'));
                //            Magfa m = new Magfa();
                //            foreach (var cr in legCrews)
                //            {
                //                if (!string.IsNullOrEmpty(cr.Mobile))
                //                {
                //                    strs.Insert(0, "Dear " + cr.Name);
                //                    var text = String.Join("\n", strs);
                //                    var smsResult = m.enqueue(1, cr.Mobile, text)[0];
                //                }
                //            }
                //        }
                //    }

                //    if (dto.SendCancelSMS == 1 && 1 == 2)
                //    {
                //        if (dto.FlightStatusID == 4)
                //        {
                //            var _del = (int)leg.DelayOffBlock;
                //            var strs = new List<string>() { "Cancelling Notification" };
                //            strs.Add(((DateTime)leg.STDDay).ToShortDateString());
                //            strs.Add(leg.FromAirportIATA + "-" + leg.FlightNumber + "-" + leg.ToAirportIATA);

                //            //strs.Add("Arrival: " + ((DateTime)leg.Takeoff).Hour.ToString().PadLeft(2, '0') + ":" + ((DateTime)leg.Takeoff).Minute.ToString().PadLeft(2, '0'));
                //            Magfa m = new Magfa();
                //            foreach (var cr in legCrews)
                //            {
                //                if (!string.IsNullOrEmpty(cr.Mobile))
                //                {
                //                    strs.Insert(0, "Dear " + cr.Name);
                //                    var text = String.Join("\n", strs);
                //                    var smsResult = m.enqueue(1, cr.Mobile, text)[0];
                //                }
                //            }
                //        }
                //    }
                //}


            }
            catch (Exception ex)
            {

            }

            //////////////////////////////////////////////
            //try
            //{
            //    //var vflight = await this.context.ViewFlightInformations.FirstOrDefaultAsync(q => q.ID == dto.ID);
            //    //var fair = await this.context.Airports.FirstOrDefaultAsync(q => q.Id == vflight.FromAirport && q.Latitude != null && q.Longitude != null);
            //    //var tair = await this.context.Airports.FirstOrDefaultAsync(q => q.Id == vflight.ToAirport && q.Latitude != null && q.Longitude != null);
            //    //if (fair != null && tair != null)
            //    //{
            //    //    await GetSun(fair.Id, ((DateTime)flight.STD).Date);
            //    //    await GetSun(tair.Id, ((DateTime)flight.STA).Date);
            //    //}
            //}
            //catch (Exception ex)
            //{

            //}

            // var qry =await this.context.ViewFlightsGantts.Where(q => q.ID==flight.ID).FirstOrDefaultAsync();
            // ViewModels.ViewFlightsGanttDto odto = new ViewFlightsGanttDto();
            // ViewModels.ViewFlightsGanttDto.FillDto(qry, odto, 0, 1);

            return new CustomActionResult(HttpStatusCode.OK, new updateLogResult()
            {
                sendNira = sendNira,
                flight = flight.ID,
                offIds = offCrewIds

            });
        }
        public class DtoLogRemark
        {
            public int ID { get; set; }
            public string UserName { get; set; }
            public string DepartureRemark { get; set; }
        }
        public async Task<CustomActionResult> UpdateFlightLogRemark(DtoLogRemark dto)
        {

            var flight = await this.context.FlightInformations.FirstOrDefaultAsync(q => q.ID == dto.ID);

            var leg = await this.context.ViewLegTimes.FirstOrDefaultAsync(q => q.ID == dto.ID);
            if (flight == null)
                return new CustomActionResult(HttpStatusCode.NotFound, "");

            //////////////////////////////////////////////////////////////
            var changeLog = new FlightChangeHistory()
            {
                Date = DateTime.Now,
                FlightId = flight.ID,
                User = dto.UserName,

            };
            changeLog.OldFlightNumer = leg.FlightNumber;
            changeLog.OldFromAirportId = leg.FromAirport;
            changeLog.OldToAirportId = leg.ToAirport;
            changeLog.OldSTD = flight.STD;
            changeLog.OldSTA = flight.STA;
            changeLog.OldStatusId = flight.FlightStatusID;
            changeLog.OldRegister = leg.RegisterID;
            changeLog.OldOffBlock = flight.ChocksOut;
            changeLog.OldOnBlock = flight.ChocksIn;
            changeLog.OldTakeOff = flight.Takeoff;
            changeLog.OldLanding = flight.Landing;

            //////////////////////////////////////////////////////////////
            flight.GUID = Guid.NewGuid();
            flight.DateCreate = DateTime.Now.ToUniversalTime();
            flight.DepartureRemark = dto.DepartureRemark;



            ////////////////////////////////////////
            changeLog.NewFlightNumber = leg.FlightNumber;
            changeLog.NewFromAirportId = leg.FromAirport;
            changeLog.NewToAirportId = flight.ToAirportId;
            changeLog.NewSTD = flight.STD;
            changeLog.NewSTA = flight.STA;
            changeLog.NewStatusId = flight.FlightStatusID;
            changeLog.NewRegister = leg.RegisterID;
            changeLog.NewOffBlock = flight.ChocksOut;
            changeLog.NewOnBlock = flight.ChocksIn;
            changeLog.NewTakeOff = flight.Takeoff;
            changeLog.NewLanding = flight.Landing;

            this.context.FlightChangeHistories.Add(changeLog);
            ////////////////////////////////////////



            return new CustomActionResult(HttpStatusCode.OK, new updateLogResult()
            {

                flight = flight.ID,


            });
        }

        public class cnlregs
        {
            public List<int> fids { get; set; }
            public int reason { get; set; }
            public string userName { get; set; }
            public int? userId { get; set; }
            public string remark { get; set; }
            public int? reg { get; set; }
            public DateTime? intervalFrom { get; set; }
            public DateTime? intervalTo { get; set; }
            public List<int> days { get; set; }
            public int? interval { get; set; }
            public DateTime? RefDate { get; set; }
            public int? RefDays { get; set; }
        }

        public class offcrew
        {
            public int? flightId { get; set; }
            public List<int?> crews { get; set; }
        }
        public async Task<CustomActionResult> CancelFlights(cnlregs dto)
        {
            // List<int?> offCrewIds = new List<int?>();
            var flights = await this.context.FlightInformations.Where(q => dto.fids.Contains(q.ID)).ToListAsync();
            var legs = await this.context.ViewLegTimes.Where(q => dto.fids.Contains(q.ID)).ToListAsync();
            foreach (var fid in dto.fids)
            {
                var flight = flights.FirstOrDefault(q => q.ID == fid);
                var leg = legs.FirstOrDefault(q => q.ID == fid);

                var changeLog = new FlightChangeHistory()
                {
                    Date = DateTime.Now,
                    FlightId = flight.ID,
                    User = dto.userName,

                };
                changeLog.OldFlightNumer = leg.FlightNumber;
                changeLog.OldFromAirportId = leg.FromAirport;
                changeLog.OldToAirportId = leg.ToAirport;
                changeLog.OldSTD = flight.STD;
                changeLog.OldSTA = flight.STA;
                changeLog.OldStatusId = flight.FlightStatusID;
                changeLog.OldRegister = leg.RegisterID;
                changeLog.OldOffBlock = flight.ChocksOut;
                changeLog.OldOnBlock = flight.ChocksIn;
                changeLog.OldTakeOff = flight.Takeoff;
                changeLog.OldLanding = flight.Landing;

                //////////////////////////////////////////////////////////////

                flight.DateCreate = DateTime.Now.ToUniversalTime();
                flight.FlightStatusUserId = dto.userId;


                flight.FlightStatusID = 4;

                var cnlMsn = await this.context.Ac_MSN.Where(q => q.Register == "CNL").Select(q => q.ID).FirstOrDefaultAsync();
                flight.RegisterID = cnlMsn;
                flight.CancelDate = DateTime.Now;
                flight.CancelReasonId = dto.reason;
                flight.DepartureRemark += (!string.IsNullOrEmpty(flight.DepartureRemark) ? "\r\n" : "") + dto.remark + "(CNL REMARK BY:" + dto.userName + ")";
                //2020-11-24




                if (flight.FlightStatusID != null && /*dto.UserId != null*/ !string.IsNullOrEmpty(dto.userName))
                    this.context.FlightStatusLogs.Add(new FlightStatusLog()
                    {
                        FlightID = flight.ID,

                        Date = DateTime.Now.ToUniversalTime(),
                        FlightStatusID = (int)flight.FlightStatusID,

                        UserId = dto.userId != null ? (int)dto.userId : 128000,
                        Remark = dto.userName,
                    });


                UpdateFirstLastFlights(flight.ID);



                ////////////////////////////////////////
                changeLog.NewFlightNumber = leg.FlightNumber;
                changeLog.NewFromAirportId = leg.FromAirport;
                changeLog.NewToAirportId = flight.ToAirportId;
                changeLog.NewSTD = flight.STD;
                changeLog.NewSTA = flight.STA;
                changeLog.NewStatusId = flight.FlightStatusID;
                changeLog.NewRegister = leg.RegisterID;
                changeLog.NewOffBlock = flight.ChocksOut;
                changeLog.NewOnBlock = flight.ChocksIn;
                changeLog.NewTakeOff = flight.Takeoff;
                changeLog.NewLanding = flight.Landing;

                this.context.FlightChangeHistories.Add(changeLog);
            }


            //var notifiedDelay = flight.NotifiedDelay;
            //var leg = await this.context.ViewLegTimes.FirstOrDefaultAsync(q => q.ID == dto.ID);
            //if (flight == null)
            //    return new CustomActionResult(HttpStatusCode.NotFound, "");

            //////////////////////////////////////////////////////////////

            ////////////////////////////////////////

            bool sendNira = false;
            var nullfids = dto.fids.Select(q => (Nullable<int>)q).ToList();

            var offCrewIds = (from q in this.context.ViewFlightCrewNews
                              where nullfids.Contains(q.FlightId)
                              group q by q.FlightId into grp
                              select new offcrew() { flightId = grp.Key, crews = grp.Select(w => w.CrewId).ToList() }

                             ).ToList();


            //hoda

            return new CustomActionResult(HttpStatusCode.OK, new updateLogResult()
            {
                sendNira = sendNira,
                flight = -1, //flight.ID,
                //offIds = offCrewIds
                offcrews = offCrewIds,

            });
        }

        public async Task<CustomActionResult> CancelFlightsGroup(cnlregs dto)
        {
            // List<int?> offCrewIds = new List<int?>();
            var intervalDays = GetInvervalDates((int)dto.interval, (DateTime)dto.intervalFrom, (DateTime)dto.intervalTo, dto.days).Select(q => (Nullable<DateTime>)q).ToList();
            var baseFlights = await this.context.FlightInformations.Where(q => dto.fids.Contains(q.ID)).ToListAsync();
            var fltNumbers = baseFlights.Select(q => q.FlightNumber).ToList();
            var fltIds = new List<int>();
            fltIds = baseFlights.Select(q => q.ID).ToList();

            var _flightIds = await (from x in this.context.ViewLegTimes
                                    where fltNumbers.Contains(x.FlightNumber) && intervalDays.Contains(x.STDDay)
                                    select x.ID).ToListAsync();
            fltIds = fltIds.Concat(_flightIds).Distinct().ToList();

            var flights = await this.context.FlightInformations.Where(q => fltIds.Contains(q.ID)).ToListAsync();
            var legs = await this.context.ViewLegTimes.Where(q => fltIds.Contains(q.ID)).ToListAsync();
            foreach (var fid in fltIds)
            {
                var flight = flights.FirstOrDefault(q => q.ID == fid);
                var leg = legs.FirstOrDefault(q => q.ID == fid);

                var changeLog = new FlightChangeHistory()
                {
                    Date = DateTime.Now,
                    FlightId = flight.ID,
                    User = dto.userName,

                };
                changeLog.OldFlightNumer = leg.FlightNumber;
                changeLog.OldFromAirportId = leg.FromAirport;
                changeLog.OldToAirportId = leg.ToAirport;
                changeLog.OldSTD = flight.STD;
                changeLog.OldSTA = flight.STA;
                changeLog.OldStatusId = flight.FlightStatusID;
                changeLog.OldRegister = leg.RegisterID;
                changeLog.OldOffBlock = flight.ChocksOut;
                changeLog.OldOnBlock = flight.ChocksIn;
                changeLog.OldTakeOff = flight.Takeoff;
                changeLog.OldLanding = flight.Landing;

                //////////////////////////////////////////////////////////////

                flight.DateCreate = DateTime.Now.ToUniversalTime();
                flight.FlightStatusUserId = dto.userId;


                flight.FlightStatusID = 4;

                var cnlMsn = await this.context.Ac_MSN.Where(q => q.Register == "CNL").Select(q => q.ID).FirstOrDefaultAsync();
                flight.RegisterID = cnlMsn;
                flight.CancelDate = DateTime.Now;
                flight.CancelReasonId = dto.reason;
                flight.DepartureRemark += (!string.IsNullOrEmpty(flight.DepartureRemark) ? "\r\n" : "") + dto.remark + "(CNL REMARK BY:" + dto.userName + ")";
                //2020-11-24




                if (flight.FlightStatusID != null && /*dto.UserId != null*/ !string.IsNullOrEmpty(dto.userName))
                    this.context.FlightStatusLogs.Add(new FlightStatusLog()
                    {
                        FlightID = flight.ID,

                        Date = DateTime.Now.ToUniversalTime(),
                        FlightStatusID = (int)flight.FlightStatusID,

                        UserId = dto.userId != null ? (int)dto.userId : 128000,
                        Remark = dto.userName,
                    });


                UpdateFirstLastFlights(flight.ID);



                ////////////////////////////////////////
                changeLog.NewFlightNumber = leg.FlightNumber;
                changeLog.NewFromAirportId = leg.FromAirport;
                changeLog.NewToAirportId = flight.ToAirportId;
                changeLog.NewSTD = flight.STD;
                changeLog.NewSTA = flight.STA;
                changeLog.NewStatusId = flight.FlightStatusID;
                changeLog.NewRegister = leg.RegisterID;
                changeLog.NewOffBlock = flight.ChocksOut;
                changeLog.NewOnBlock = flight.ChocksIn;
                changeLog.NewTakeOff = flight.Takeoff;
                changeLog.NewLanding = flight.Landing;

                this.context.FlightChangeHistories.Add(changeLog);
            }


            //var notifiedDelay = flight.NotifiedDelay;
            //var leg = await this.context.ViewLegTimes.FirstOrDefaultAsync(q => q.ID == dto.ID);
            //if (flight == null)
            //    return new CustomActionResult(HttpStatusCode.NotFound, "");

            //////////////////////////////////////////////////////////////

            ////////////////////////////////////////

            bool sendNira = false;
            var nullfids = dto.fids.Select(q => (Nullable<int>)q).ToList();

            var offCrewIds = (from q in this.context.ViewFlightCrewNews
                              where nullfids.Contains(q.FlightId)
                              group q by q.FlightId into grp
                              select new offcrew() { flightId = grp.Key, crews = grp.Select(w => w.CrewId).ToList() }

                             ).ToList();


            //hoda

            return new CustomActionResult(HttpStatusCode.OK, new updateLogResult()
            {
                sendNira = sendNira,
                flight = -1, //flight.ID,
                //offIds = offCrewIds
                offcrews = offCrewIds,
                fltIds = fltIds

            });
        }
        public async Task<CustomActionResult> ActiveFlights(cnlregs dto)
        {
            // List<int?> offCrewIds = new List<int?>();
            var flights = await this.context.FlightInformations.Where(q => dto.fids.Contains(q.ID)).ToListAsync();
            var legs = await this.context.ViewLegTimes.Where(q => dto.fids.Contains(q.ID)).ToListAsync();
            foreach (var fid in dto.fids)
            {
                var flight = flights.FirstOrDefault(q => q.ID == fid);
                var leg = legs.FirstOrDefault(q => q.ID == fid);

                var changeLog = new FlightChangeHistory()
                {
                    Date = DateTime.Now,
                    FlightId = flight.ID,
                    User = dto.userName,

                };
                changeLog.OldFlightNumer = leg.FlightNumber;
                changeLog.OldFromAirportId = leg.FromAirport;
                changeLog.OldToAirportId = leg.ToAirport;
                changeLog.OldSTD = flight.STD;
                changeLog.OldSTA = flight.STA;
                changeLog.OldStatusId = flight.FlightStatusID;
                changeLog.OldRegister = leg.RegisterID;
                changeLog.OldOffBlock = flight.ChocksOut;
                changeLog.OldOnBlock = flight.ChocksIn;
                changeLog.OldTakeOff = flight.Takeoff;
                changeLog.OldLanding = flight.Landing;

                //////////////////////////////////////////////////////////////

                flight.DateCreate = DateTime.Now.ToUniversalTime();
                flight.FlightStatusUserId = dto.userId;


                flight.FlightStatusID = 1;

                //var cnlMsn = await this.context.Ac_MSN.Where(q => q.Register == "CNL").Select(q => q.ID).FirstOrDefaultAsync();
                flight.RegisterID = dto.reg;
                flight.CancelDate = null;
                flight.CancelReasonId = null;
                flight.DepartureRemark += (!string.IsNullOrEmpty(flight.DepartureRemark) ? "\r\n" : "") + dto.remark + "(ACTV REMARK BY:" + dto.userName + ")";
                //2020-11-24




                if (flight.FlightStatusID != null && /*dto.UserId != null*/ !string.IsNullOrEmpty(dto.userName))
                    this.context.FlightStatusLogs.Add(new FlightStatusLog()
                    {
                        FlightID = flight.ID,

                        Date = DateTime.Now.ToUniversalTime(),
                        FlightStatusID = (int)flight.FlightStatusID,

                        UserId = dto.userId != null ? (int)dto.userId : 128000,
                        Remark = dto.userName,
                    });

                //kak4

                ////////////////////////////////////////
                changeLog.NewFlightNumber = leg.FlightNumber;
                changeLog.NewFromAirportId = leg.FromAirport;
                changeLog.NewToAirportId = flight.ToAirportId;
                changeLog.NewSTD = flight.STD;
                changeLog.NewSTA = flight.STA;
                changeLog.NewStatusId = flight.FlightStatusID;
                changeLog.NewRegister = leg.RegisterID;
                changeLog.NewOffBlock = flight.ChocksOut;
                changeLog.NewOnBlock = flight.ChocksIn;
                changeLog.NewTakeOff = flight.Takeoff;
                changeLog.NewLanding = flight.Landing;

                this.context.FlightChangeHistories.Add(changeLog);
            }




            bool sendNira = true;
            var nullfids = dto.fids.Select(q => (Nullable<int>)q).ToList();



            //hoda

            return new CustomActionResult(HttpStatusCode.OK, new updateLogResult()
            {
                sendNira = sendNira,
                flight = -1, //flight.ID,
                             //offIds = offCrewIds
                offIds = nullfids


            });
        }


        //magu38
        public async Task<CustomActionResult> ActiveFlightsGroup(cnlregs dto)
        {
            // List<int?> offCrewIds = new List<int?>();
            var intervalDays = GetInvervalDates((int)dto.interval, (DateTime)dto.intervalFrom, (DateTime)dto.intervalTo, dto.days).Select(q => (Nullable<DateTime>)q).ToList();
            var baseFlights = await this.context.FlightInformations.Where(q => dto.fids.Contains(q.ID)).ToListAsync();
            var fltNumbers = baseFlights.Select(q => q.FlightNumber).ToList();
            var fltIds = new List<int>();
            fltIds = baseFlights.Select(q => q.ID).ToList();

            var _flightIds = await (from x in this.context.ViewLegTimes
                                    where fltNumbers.Contains(x.FlightNumber) && intervalDays.Contains(x.STDDay)
                                    select x.ID).ToListAsync();
            fltIds = fltIds.Concat(_flightIds).Distinct().ToList();

            var flights = await this.context.FlightInformations.Where(q => fltIds.Contains(q.ID)).ToListAsync();
            var legs = await this.context.ViewLegTimes.Where(q => fltIds.Contains(q.ID)).ToListAsync();
            /////////////////////////////////
            //var flights = await this.context.FlightInformations.Where(q => dto.fids.Contains(q.ID)).ToListAsync();
            // var legs = await this.context.ViewLegTimes.Where(q => dto.fids.Contains(q.ID)).ToListAsync();
            foreach (var fid in fltIds)
            {
                var flight = flights.FirstOrDefault(q => q.ID == fid);
                var leg = legs.FirstOrDefault(q => q.ID == fid);

                var changeLog = new FlightChangeHistory()
                {
                    Date = DateTime.Now,
                    FlightId = flight.ID,
                    User = dto.userName,

                };
                changeLog.OldFlightNumer = leg.FlightNumber;
                changeLog.OldFromAirportId = leg.FromAirport;
                changeLog.OldToAirportId = leg.ToAirport;
                changeLog.OldSTD = flight.STD;
                changeLog.OldSTA = flight.STA;
                changeLog.OldStatusId = flight.FlightStatusID;
                changeLog.OldRegister = leg.RegisterID;
                changeLog.OldOffBlock = flight.ChocksOut;
                changeLog.OldOnBlock = flight.ChocksIn;
                changeLog.OldTakeOff = flight.Takeoff;
                changeLog.OldLanding = flight.Landing;

                //////////////////////////////////////////////////////////////

                flight.DateCreate = DateTime.Now.ToUniversalTime();
                flight.FlightStatusUserId = dto.userId;


                flight.FlightStatusID = 1;

                //var cnlMsn = await this.context.Ac_MSN.Where(q => q.Register == "CNL").Select(q => q.ID).FirstOrDefaultAsync();
                flight.RegisterID = dto.reg;
                flight.CancelDate = null;
                flight.CancelReasonId = null;
                flight.DepartureRemark += (!string.IsNullOrEmpty(flight.DepartureRemark) ? "\r\n" : "") + dto.remark + "(ACTV REMARK BY:" + dto.userName + ")";
                //2020-11-24




                if (flight.FlightStatusID != null && /*dto.UserId != null*/ !string.IsNullOrEmpty(dto.userName))
                    this.context.FlightStatusLogs.Add(new FlightStatusLog()
                    {
                        FlightID = flight.ID,

                        Date = DateTime.Now.ToUniversalTime(),
                        FlightStatusID = (int)flight.FlightStatusID,

                        UserId = dto.userId != null ? (int)dto.userId : 128000,
                        Remark = dto.userName,
                    });

                //kak4

                ////////////////////////////////////////
                changeLog.NewFlightNumber = leg.FlightNumber;
                changeLog.NewFromAirportId = leg.FromAirport;
                changeLog.NewToAirportId = flight.ToAirportId;
                changeLog.NewSTD = flight.STD;
                changeLog.NewSTA = flight.STA;
                changeLog.NewStatusId = flight.FlightStatusID;
                changeLog.NewRegister = leg.RegisterID;
                changeLog.NewOffBlock = flight.ChocksOut;
                changeLog.NewOnBlock = flight.ChocksIn;
                changeLog.NewTakeOff = flight.Takeoff;
                changeLog.NewLanding = flight.Landing;

                this.context.FlightChangeHistories.Add(changeLog);
            }




            bool sendNira = true;
            //var nullfids = dto.fids.Select(q => (Nullable<int>)q).ToList();

            var nullfids = fltIds.Select(q => (Nullable<int>)q).ToList();


            //hoda

            return new CustomActionResult(HttpStatusCode.OK, new updateLogResult()
            {
                sendNira = sendNira,
                flight = -1, //flight.ID,
                             //offIds = offCrewIds
                offIds = nullfids


            });
        }
        public IQueryable<ViewFlightsGantt> GetViewFlightGantts()
        {
            return this.GetQuery<ViewFlightsGantt>();
        }
        public class updateLogResult
        {
            public bool sendNira { get; set; }
            public int flight { get; set; }
            public List<int?> offIds { get; set; }
            public List<int> fltIds { get; set; }
            public List<offcrew> offcrews { get; set; }
        }
        public async Task<CustomActionResult> UpdateFlightFuelDeparture(ViewModels.FlightSaveDto dto)
        {
            var flight = await this.context.FlightInformations.FirstOrDefaultAsync(q => q.ID == dto.ID);


            flight.FuelDeparture = dto.FuelDeparture;

            flight.FuelUnitID = dto.FuelUnitID;



            return new CustomActionResult(HttpStatusCode.OK, "");
        }
        public async Task<CustomActionResult> UpdateFlightFuelArrival(ViewModels.FlightSaveDto dto)
        {
            var flight = await this.context.FlightInformations.FirstOrDefaultAsync(q => q.ID == dto.ID);
            if (flight == null)
                return new CustomActionResult(HttpStatusCode.NotFound, "");

            flight.FuelArrival = dto.FuelArrival;

            return new CustomActionResult(HttpStatusCode.OK, "");
        }
        public async Task<CustomActionResult> UpdateFlightPax(ViewModels.FlightSaveDto dto)
        {
            var flight = await this.context.FlightInformations.FirstOrDefaultAsync(q => q.ID == dto.ID);
            if (flight == null)
                return new CustomActionResult(HttpStatusCode.NotFound, "");

            flight.PaxAdult = dto.PaxAdult;
            flight.PaxInfant = dto.PaxInfant;
            flight.PaxChild = dto.PaxChild;



            return new CustomActionResult(HttpStatusCode.OK, "");
        }
        public async Task<CustomActionResult> UpdateFlightCargo(ViewModels.FlightSaveDto dto)
        {
            var flight = await this.context.FlightInformations.FirstOrDefaultAsync(q => q.ID == dto.ID);
            if (flight == null)
                return new CustomActionResult(HttpStatusCode.NotFound, "");


            flight.GWTO = dto.GWTO;


            flight.CargoWeight = dto.CargoWeight;
            flight.CargoUnitID = dto.CargoUnitID;
            flight.BaggageCount = dto.BaggageCount;
            flight.CargoCount = dto.CargoCount;
            flight.BaggageWeight = dto.BaggageWeight;



            return new CustomActionResult(HttpStatusCode.OK, "");
        }

        public async Task<CustomActionResult> UpdateFlightOffBlock(ViewModels.FlightSaveDto dto)
        {
            var flight = await this.context.FlightInformations.FirstOrDefaultAsync(q => q.ID == dto.ID);
            if (flight == null)
                return new CustomActionResult(HttpStatusCode.NotFound, "");
            var stids = dto.StatusLog.Select(q => q.FlightStatusID).ToList();
            var currentStatus = this.context.FlightStatusLogs.Where(q => q.FlightID == dto.ID);
            this.context.FlightStatusLogs.RemoveRange(currentStatus);
            foreach (var x in dto.StatusLog)
            {
                this.context.FlightStatusLogs.Add(new FlightStatusLog()
                {
                    FlightID = dto.ID,
                    Date = x.Date,
                    FlightStatusID = x.FlightStatusID,
                    Remark = x.Remark,
                    UserId = x.UserId
                });
            }
            if (flight.FlightStatusID != dto.FlightStatusID)
            {
                if (dto.StatusLog.Count > 0)
                {
                    flight.DateCreate = dto.StatusLog.Max(q => q.Date);
                }
                else
                {
                    flight.DateCreate = DateTime.UtcNow;
                }
                flight.FlightStatusUserId = dto.UserId;
            }
            flight.FlightStatusID = dto.FlightStatusID;
            flight.ChocksOut = dto.ChocksOut;

            var result2 = await UpdateEstimatedDelays(dto);

            if (result2.Code != HttpStatusCode.OK)
                return result2;


            return new CustomActionResult(HttpStatusCode.OK, "");
        }


        public async Task<CustomActionResult> UpdateReportingTime(int crewid, int fdpid, DateTime date, int offset)
        {
            var fdp = await this.context.FDPs.FirstOrDefaultAsync(q => q.Id == fdpid);
            if (fdp == null)
                return new CustomActionResult(HttpStatusCode.NotFound, "");
            date = date.AddMinutes(-offset);
            fdp.ReportingTime = date;
            fdp.UPD = fdp.UPD == null ? 1 : ((int)fdp.UPD) + 1;
            if (fdp.FDPId != null)
            {
                var relatedFdp = await this.context.FDPs.FirstOrDefaultAsync(q => q.Id == fdp.FDPId);
                relatedFdp.UPD = relatedFdp.UPD == null ? 1 : ((int)relatedFdp.UPD) + 1;
                relatedFdp.FDPReportingTime = fdp.ReportingTime;
            }


            return new CustomActionResult(HttpStatusCode.OK, "");
        }

        public async Task<bool> IsRegisterAvailable(int id, DateTime sta, DateTime std)
        {
            var query = await this.context.ViewFlightInformations.Where(q => q.RegisterID == id && q.CancelDate == null
               && ((std >= q.STD && std <= q.STA) || (sta >= q.STD && sta <= q.STA))
            ).CountAsync();

            return query == 0;
        }

        public async Task<CustomActionResult> AssignFlightRegister(ViewModels.FlightRegisterDto dto)
        {
            var flight = await this.context.FlightInformations.FirstOrDefaultAsync(q => q.ID == dto.FlightId);
            if (flight == null)
                return new CustomActionResult(HttpStatusCode.NotFound, false);
            //  var isavailable = await IsRegisterAvailable(dto.RegisterId, (DateTime)flight.STA, (DateTime)flight.STD);
            //  if (!isavailable)
            //     return new CustomActionResult(HttpStatusCode.NotAcceptable, false);
            flight.TypeID = dto.TypeId;
            flight.RegisterID = dto.RegisterId;

            return new CustomActionResult(HttpStatusCode.OK, true);
        }
        public class TypeChangeDto
        {
            public string FlightNumber { get; set; }
            public string Route { get; set; }

            public string OldType { get; set; }

            public string NewType { get; set; }

            public string Date { get; set; }

            public DateTime? STDLocal { get; set; }
            public DateTime? STALocal { get; set; }
        }
        //doolnaz2
        public async Task<CustomActionResult> ChangeFlightRegister(ViewModels.FlightRegisterChangeLogDto dto)
        {
            object result = null;
            List<int?> changedTypes = new List<int?>();
            DateTime From = EPAGriffinAPI.Helper.BuildDateTimeFromYAFormatUTC(dto.From).Date;
            DateTime To = EPAGriffinAPI.Helper.BuildDateTimeFromYAFormatUTC(dto.To).Date.AddHours(23).AddMinutes(59).AddSeconds(59).AddMilliseconds(999);
            var newResisgerObj = await this.context.ViewMSNs.FirstOrDefaultAsync(q => q.ID == dto.NewRegisterId);
            // var newreg = await this.context.Ac_MSN.FirstOrDefaultAsync(q => q.ID == dto.NewRegisterId);
            var flights = await this.context.FlightInformations.Where(q => dto.Flights.Contains(q.ID)).ToListAsync();
            var legs = await this.context.ViewLegTimes.Where(q => dto.Flights.Contains(q.ID)).ToListAsync();
            if (flights == null || flights.Count == 0)
            {
                result = "Flights Not Found";
                return new CustomActionResult(HttpStatusCode.NotFound, result);
            }
            var existFlights = await this.context.ViewFlightInformations.Where(q => q.RegisterID == dto.NewRegisterId && q.STA >= From && q.STA <= To && !dto.Flights.Contains(q.ID)).ToListAsync();
            var isvalid = true;
            var typeChangeDtoList = new List<TypeChangeDto>();

            foreach (var x in flights)
            {
                var exist = existFlights.FirstOrDefault(q => (q.STA >= x.STD && q.STA <= x.STA) || (q.STD >= x.STD && q.STD <= x.STA)
                || (x.STD >= q.STD && x.STA <= q.STA) || (x.STA >= q.STD && x.STD <= q.STA)
                );

                var y = legs.FirstOrDefault(q => q.ID == x.ID);
                if (y.AircraftType[0] != newResisgerObj.AircraftType[0])
                {
                    changedTypes.Add(y.ID);
                    typeChangeDtoList.Add(new TypeChangeDto()
                    {
                        Date = ((DateTime)y.STDLocal).ToString("dd-MMM-yyyy"),
                        FlightNumber = y.FlightNumber,
                        Route = y.FromAirportIATA + "-" + y.ToAirportIATA,
                        OldType = y.AircraftType,
                        NewType = newResisgerObj.AircraftType,
                        STDLocal = y.STDLocal,
                        STALocal = y.STALocal,
                    });
                }
                var changeLog = new FlightChangeHistory()
                {
                    Date = DateTime.Now,
                    FlightId = y.ID,

                };
                changeLog.OldFlightNumer = y.FlightNumber;
                changeLog.OldFromAirportId = y.FromAirport;
                changeLog.OldToAirportId = y.ToAirport;
                changeLog.OldSTD = y.STD;
                changeLog.OldSTA = y.STA;
                changeLog.OldStatusId = y.FlightStatusID;
                changeLog.OldRegister = y.RegisterID;
                changeLog.OldOffBlock = y.ChocksOut;
                changeLog.OldOnBlock = y.ChocksIn;
                changeLog.OldTakeOff = y.Takeoff;
                changeLog.OldLanding = y.Landing;
                changeLog.NewFlightNumber = y.FlightNumber;
                changeLog.NewFromAirportId = y.FromAirport;
                changeLog.NewToAirportId = y.ToAirport;
                changeLog.NewSTD = y.STD;
                changeLog.NewSTA = y.STA;
                changeLog.NewStatusId = y.FlightStatusID;

                changeLog.NewOffBlock = y.ChocksOut;
                changeLog.NewOnBlock = y.ChocksIn;
                changeLog.NewTakeOff = y.Takeoff;
                changeLog.NewLanding = y.Landing;


                x.RegisterID = dto.NewRegisterId;
                x.DateCreate = DateTime.Now.ToUniversalTime();
                x.FlightStatusUserId = dto.UserId;
                changeLog.NewRegister = x.RegisterID;

                changeLog.User = dto.UserName;

                this.context.FlightChangeHistories.Add(changeLog);

                this.context.FlightRegisterChangeLogs.Add(new FlightRegisterChangeLog()
                {
                    Date = DateTime.UtcNow,
                    FlightId = x.ID,
                    NewRegisterId = dto.NewRegisterId,
                    OldRegisterId = (int)x.RegisterID,
                    ReasonId = dto.ReasonId,
                    Remark = dto.Remark,
                    UserId = dto.UserId,
                });


            }

            if (changedTypes.Count > 0)
            {
                var grps = new List<int?>() { 12000, 1160, 1161, 1162 };
                var query = from fi in this.context.FDPItems
                            join f in this.context.FDPs on fi.FDPId equals f.Id
                            where f.CrewId != null && changedTypes.Contains(fi.FlightId) && grps.Contains(fi.PositionId)
                            select new { fdpItem = fi, fdp = f };
                var qrslt = await query.ToListAsync();
                var fdpitemstr = string.Join("*", qrslt.Select(q => q.fdpItem).Select(q => q.Id).ToList());
                var fdpstr = string.Join("*", qrslt.Select(q => q.fdp).Select(q => q.Id).ToList());
                var crewStr = string.Join("*", qrslt.Select(q => q.fdp).Select(q => q.CrewId).ToList());
                var fltStr = string.Join("*", qrslt.Select(q => q.fdpItem).Select(q => q.FlightId).ToList());
                //piano
                result = new List<object>() { fdpstr, fdpitemstr, crewStr, fltStr, typeChangeDtoList };

            }
            //if (!isvalid)
            //   return new CustomActionResult(HttpStatusCode.NotAcceptable, "Conflict Error");

            return new CustomActionResult(HttpStatusCode.OK, result);
        }

        public async Task<CustomActionResult> ChangeFlightRegister2(ViewModels.FlightRegisterChangeLogDto dto)
        {
            object result = null;
            List<int?> changedTypes = new List<int?>();

            var newResisgerObj = await this.context.ViewMSNs.FirstOrDefaultAsync(q => q.ID == dto.NewRegisterId);
            // var newreg = await this.context.Ac_MSN.FirstOrDefaultAsync(q => q.ID == dto.NewRegisterId);
            var flights = await this.context.FlightInformations.Where(q => dto.Flights.Contains(q.ID)).ToListAsync();
            var legs = await this.context.ViewLegTimes.Where(q => dto.Flights.Contains(q.ID)).ToListAsync();
            if (flights == null || flights.Count == 0)
            {
                result = "Flights Not Found";
                return new CustomActionResult(HttpStatusCode.NotFound, result);
            }

            var isvalid = true;
            var typeChangeDtoList = new List<TypeChangeDto>();

            foreach (var x in flights)
            {


                var y = legs.FirstOrDefault(q => q.ID == x.ID);
                if (y.AircraftType[0] != newResisgerObj.AircraftType[0])
                {
                    changedTypes.Add(y.ID);
                    typeChangeDtoList.Add(new TypeChangeDto()
                    {
                        Date = ((DateTime)y.STDLocal).ToString("dd-MMM-yyyy"),
                        FlightNumber = y.FlightNumber,
                        Route = y.FromAirportIATA + "-" + y.ToAirportIATA,
                        OldType = y.AircraftType,
                        NewType = newResisgerObj.AircraftType,
                        STDLocal = y.STDLocal,
                        STALocal = y.STALocal,
                    });
                }
                var changeLog = new FlightChangeHistory()
                {
                    Date = DateTime.Now,
                    FlightId = y.ID,

                };
                changeLog.OldFlightNumer = y.FlightNumber;
                changeLog.OldFromAirportId = y.FromAirport;
                changeLog.OldToAirportId = y.ToAirport;
                changeLog.OldSTD = y.STD;
                changeLog.OldSTA = y.STA;
                changeLog.OldStatusId = y.FlightStatusID;
                changeLog.OldRegister = y.RegisterID;
                changeLog.OldOffBlock = y.ChocksOut;
                changeLog.OldOnBlock = y.ChocksIn;
                changeLog.OldTakeOff = y.Takeoff;
                changeLog.OldLanding = y.Landing;
                changeLog.NewFlightNumber = y.FlightNumber;
                changeLog.NewFromAirportId = y.FromAirport;
                changeLog.NewToAirportId = y.ToAirport;
                changeLog.NewSTD = y.STD;
                changeLog.NewSTA = y.STA;
                changeLog.NewStatusId = y.FlightStatusID;

                changeLog.NewOffBlock = y.ChocksOut;
                changeLog.NewOnBlock = y.ChocksIn;
                changeLog.NewTakeOff = y.Takeoff;
                changeLog.NewLanding = y.Landing;


                x.RegisterID = dto.NewRegisterId;
                x.DateCreate = DateTime.Now.ToUniversalTime();
                x.FlightStatusUserId = dto.UserId;
                x.DepartureRemark += (!string.IsNullOrEmpty(x.DepartureRemark) ? "\r\n" : "") + dto.Remark + "(REG. CHANGE REMARK BY:" + dto.UserName + ")";
                changeLog.NewRegister = x.RegisterID;


                changeLog.User = dto.UserName;

                this.context.FlightChangeHistories.Add(changeLog);

                this.context.FlightRegisterChangeLogs.Add(new FlightRegisterChangeLog()
                {
                    Date = DateTime.UtcNow,
                    FlightId = x.ID,
                    NewRegisterId = dto.NewRegisterId,
                    OldRegisterId = (int)x.RegisterID,
                    ReasonId = dto.ReasonId,
                    Remark = dto.Remark,
                    UserId = dto.UserId,
                });


            }

            if (changedTypes.Count > 0)
            {
                var grps = new List<int?>() { 12000, 1160, 1161, 1162 };
                var query = from fi in this.context.FDPItems
                            join f in this.context.FDPs on fi.FDPId equals f.Id
                            where f.CrewId != null && changedTypes.Contains(fi.FlightId) && grps.Contains(fi.PositionId)
                            select new { fdpItem = fi, fdp = f };
                var qrslt = await query.ToListAsync();
                var fdpitemstr = string.Join("*", qrslt.Select(q => q.fdpItem).Select(q => q.Id).ToList());
                var fdpstr = string.Join("*", qrslt.Select(q => q.fdp).Select(q => q.Id).ToList());
                var crewStr = string.Join("*", qrslt.Select(q => q.fdp).Select(q => q.CrewId).ToList());
                var fltStr = string.Join("*", qrslt.Select(q => q.fdpItem).Select(q => q.FlightId).ToList());
                //piano
                result = new List<object>() { fdpstr, fdpitemstr, crewStr, fltStr, typeChangeDtoList };

            }
            //if (!isvalid)
            //   return new CustomActionResult(HttpStatusCode.NotAcceptable, "Conflict Error");

            return new CustomActionResult(HttpStatusCode.OK, result);
        }
        class fltprt
        {
            public string no { get; set; }
            public string type { get; set; }
            public string reg { get; set; }
            public int id { get; set; }
        }
        //9-15
        public async Task<CustomActionResult> NotifyChangeFlightRegisterGroup(ViewModels.FlightRegisterChangeLogDto dto)
        {
            if (dto.intervalFrom != null)
            {
                var result = true;
                var _intervalTo = (DateTime)dto.intervalTo;
                var now7 = DateTime.Now.Date.AddDays(8);
                if (_intervalTo > now7)
                    _intervalTo = now7;
                var intervalDays = GetInvervalDates((int)dto.interval, (DateTime)dto.intervalFrom, (DateTime)dto.intervalTo, dto.days).Select(q => (Nullable<DateTime>)q).ToList();
                var newResisgerObj = await this.context.ViewMSNs.FirstOrDefaultAsync(q => q.ID == dto.NewRegisterId);
                var baseFlights = await this.context.FlightInformations.Where(q => dto.Flights.Contains(q.ID)).ToListAsync();
                var fltNumbers = baseFlights.Select(q => q.FlightNumber).ToList();
                var flights = await (from x in this.context.ViewLegTimes
                                     where fltNumbers.Contains(x.FlightNumber) && intervalDays.Contains(x.STDDay)
                                     orderby x.STD
                                     select x).ToListAsync();
                if (flights.Count > 0)
                {
                    var prts = new List<string>() { "CASPIAN AIRLINES", "Register(s) Changed" }; 
                    var olds = new List<fltprt>();
                    var oldStr = dto.Remark.Split('*');
                    foreach (var x in oldStr)
                    {
                        var _oldReg = x.Split('_')[1].Split('-')[1];
                        var _oldType = x.Split('_')[1].Split('-')[0];
                        var _no = x.Split('_')[0];
                        olds.Add(new fltprt()
                        {
                            no = _no,
                            reg = _oldReg,
                            type = _oldType
                        });
                        //var _flt = flights.FirstOrDefault(q => q.ID == id);
                        //if (_flt!=null)
                        //{
                        //    prts.Add("FLT: " + _flt.FlightNumber + " " + _flt.AircraftType + "-" + _flt.Register + " (" + oldType + "-" + oldReg + ")");
                        //}
                    }

                    foreach (var _flt in flights)
                    {
                        var oldrec = olds.FirstOrDefault(q => q.no == _flt.FlightNumber);
                        var str = "FLT: " + ((DateTime)_flt.STDLocal).ToString("ddd yyyy/MM/dd") + " " + _flt.FlightNumber + " " + _flt.AircraftType + "-" + _flt.Register;
                        if (oldrec != null)
                            str += " (" + oldrec.type + "-" + oldrec.reg + ")";
                        prts.Add(str);
                    }
                    var text1 = String.Join("\n", prts);
                    var recs = await this.context.SMSGroups.Where(q => q.Type == 2).ToListAsync();
                    foreach (var rec in recs)
                    {
                        try
                        {
                            Magfa m = new Magfa();
                            var result10 = m.enqueue(1, rec.Phone, text1)[0];
                        }
                        catch (Exception exx)
                        {

                        }

                    }
                    return new CustomActionResult(HttpStatusCode.OK, flights.Count + " flights found");
                }
                else
                    return new CustomActionResult(HttpStatusCode.OK, "no flights found");
            }
            else
            {
                var olds = new List<fltprt>();
                var oldStr = dto.Remark.Split('*');
                foreach (var x in oldStr)
                {
                    var _oldReg = x.Split('_')[1].Split('-')[1];
                    var _oldType = x.Split('_')[1].Split('-')[0];
                    var _id =Convert.ToInt32( x.Split('_')[0]);
                    olds.Add(new fltprt()
                    {
                        id = _id,
                        reg = _oldReg,
                        type = _oldType
                    });
                    
                }

                var _fltIds = olds.Select(q => q.id).ToList();
                var flights = await (from x in this.context.ViewLegTimes
                                     where _fltIds.Contains(x.ID) 
                                     orderby x.STD
                                     select x).ToListAsync();
                if (flights.Count > 0)
                {
                    var prts = new List<string>() { "CASPIAN AIRLINES", "Register(s) Changed" };
                    foreach (var _flt in flights)
                    {
                        var oldrec = olds.FirstOrDefault(q => q.id == _flt.ID);
                        var str = "FLT: " + ((DateTime)_flt.STDLocal).ToString("ddd yyyy/MM/dd") + " " + _flt.FlightNumber + " " + _flt.AircraftType + "-" + _flt.Register;
                        if (oldrec != null)
                            str += " (" + oldrec.type + "-" + oldrec.reg + ")";
                        prts.Add(str);
                    }
                    var text1 = String.Join("\n", prts);
                    var recs = await this.context.SMSGroups.Where(q => q.Type == 2).ToListAsync();
                    foreach (var rec in recs)
                    {
                        try
                        {
                            Magfa m = new Magfa();
                            var result10 = m.enqueue(1, rec.Phone, text1)[0];
                        }
                        catch (Exception exx)
                        {

                        }

                    }
                    return new CustomActionResult(HttpStatusCode.OK, flights.Count + " flights found");


                }
                else
                    return new CustomActionResult(HttpStatusCode.OK, "no flights found");

            }
         





        }

        public async Task<CustomActionResult> ChangeFlightRegisterGroup(ViewModels.FlightRegisterChangeLogDto dto)
        {
            object result = null;
            List<int?> changedTypes = new List<int?>();
            var intervalDays = GetInvervalDates((int)dto.interval, (DateTime)dto.intervalFrom, (DateTime)dto.intervalTo, dto.days).Select(q => (Nullable<DateTime>)q).ToList();
            var newResisgerObj = await this.context.ViewMSNs.FirstOrDefaultAsync(q => q.ID == dto.NewRegisterId);
            var baseFlights = await this.context.FlightInformations.Where(q => dto.Flights.Contains(q.ID)).ToListAsync();
            var fltNumbers = baseFlights.Select(q => q.FlightNumber).ToList();
            var fltIds = new List<int>();
            fltIds = baseFlights.Select(q => q.ID).ToList();

            var _flightIds = await (from x in this.context.ViewLegTimes
                                    where fltNumbers.Contains(x.FlightNumber) && intervalDays.Contains(x.STDDay)
                                    select x.ID).ToListAsync();
            fltIds = fltIds.Concat(_flightIds).ToList();




            // var newreg = await this.context.Ac_MSN.FirstOrDefaultAsync(q => q.ID == dto.NewRegisterId);
            var flights = await this.context.FlightInformations.Where(q => fltIds.Contains(q.ID)).ToListAsync();
            var legs = await this.context.ViewLegTimes.Where(q => fltIds.Contains(q.ID)).ToListAsync();
            if (flights == null || flights.Count == 0)
            {
                result = "Flights Not Found";
                return new CustomActionResult(HttpStatusCode.NotFound, result);
            }

            var isvalid = true;
            var typeChangeDtoList = new List<TypeChangeDto>();

            foreach (var x in flights)
            {


                var y = legs.FirstOrDefault(q => q.ID == x.ID);
                if (y.AircraftType[0] != newResisgerObj.AircraftType[0])
                {
                    changedTypes.Add(y.ID);
                    typeChangeDtoList.Add(new TypeChangeDto()
                    {
                        Date = ((DateTime)y.STDLocal).ToString("dd-MMM-yyyy"),
                        FlightNumber = y.FlightNumber,
                        Route = y.FromAirportIATA + "-" + y.ToAirportIATA,
                        OldType = y.AircraftType,
                        NewType = newResisgerObj.AircraftType,
                        STDLocal = y.STDLocal,
                        STALocal = y.STALocal,
                    });
                }
                var changeLog = new FlightChangeHistory()
                {
                    Date = DateTime.Now,
                    FlightId = y.ID,

                };
                changeLog.OldFlightNumer = y.FlightNumber;
                changeLog.OldFromAirportId = y.FromAirport;
                changeLog.OldToAirportId = y.ToAirport;
                changeLog.OldSTD = y.STD;
                changeLog.OldSTA = y.STA;
                changeLog.OldStatusId = y.FlightStatusID;
                changeLog.OldRegister = y.RegisterID;
                changeLog.OldOffBlock = y.ChocksOut;
                changeLog.OldOnBlock = y.ChocksIn;
                changeLog.OldTakeOff = y.Takeoff;
                changeLog.OldLanding = y.Landing;
                changeLog.NewFlightNumber = y.FlightNumber;
                changeLog.NewFromAirportId = y.FromAirport;
                changeLog.NewToAirportId = y.ToAirport;
                changeLog.NewSTD = y.STD;
                changeLog.NewSTA = y.STA;
                changeLog.NewStatusId = y.FlightStatusID;

                changeLog.NewOffBlock = y.ChocksOut;
                changeLog.NewOnBlock = y.ChocksIn;
                changeLog.NewTakeOff = y.Takeoff;
                changeLog.NewLanding = y.Landing;


                x.RegisterID = dto.NewRegisterId;
                x.DateCreate = DateTime.Now.ToUniversalTime();
                x.FlightStatusUserId = dto.UserId;
                x.DepartureRemark += (!string.IsNullOrEmpty(x.DepartureRemark) ? "\r\n" : "") + dto.Remark + "(REG. CHANGE REMARK BY:" + dto.UserName + ")";
                changeLog.NewRegister = x.RegisterID;


                changeLog.User = dto.UserName;

                this.context.FlightChangeHistories.Add(changeLog);

                this.context.FlightRegisterChangeLogs.Add(new FlightRegisterChangeLog()
                {
                    Date = DateTime.UtcNow,
                    FlightId = x.ID,
                    NewRegisterId = dto.NewRegisterId,
                    OldRegisterId = (int)x.RegisterID,
                    ReasonId = dto.ReasonId,
                    Remark = dto.Remark,
                    UserId = dto.UserId,
                });


            }

            if (changedTypes.Count > 0)
            {
                var grps = new List<int?>() { 12000, 1160, 1161, 1162 };
                var query = from fi in this.context.FDPItems
                            join f in this.context.FDPs on fi.FDPId equals f.Id
                            where f.CrewId != null && changedTypes.Contains(fi.FlightId) && grps.Contains(fi.PositionId)
                            select new { fdpItem = fi, fdp = f };
                var qrslt = await query.ToListAsync();
                var fdpitemstr = string.Join("*", qrslt.Select(q => q.fdpItem).Select(q => q.Id).ToList());
                var fdpstr = string.Join("*", qrslt.Select(q => q.fdp).Select(q => q.Id).ToList());
                var crewStr = string.Join("*", qrslt.Select(q => q.fdp).Select(q => q.CrewId).ToList());
                var fltStr = string.Join("*", qrslt.Select(q => q.fdpItem).Select(q => q.FlightId).ToList());
                //piano
                result = new List<object>() { fdpstr, fdpitemstr, crewStr, fltStr, typeChangeDtoList, fltIds };

            }
            else
                result = new List<object>() { fltIds };
            //if (!isvalid)
            //   return new CustomActionResult(HttpStatusCode.NotAcceptable, "Conflict Error");

            return new CustomActionResult(HttpStatusCode.OK, result);
        }

        public async Task<CustomActionResult> ApplyFlight(int id)
        {
            var flight = await this.context.FlightInformations.FirstOrDefaultAsync(q => q.ID == id);
            if (flight == null)
                return new CustomActionResult(HttpStatusCode.NotFound, false);

            flight.IsApplied = true;
            flight.DateApplied = DateTime.UtcNow;

            return new CustomActionResult(HttpStatusCode.OK, true);
        }

        public async Task<CustomActionResult> UpdateFlightCancel(ViewModels.FlightCancelDto dto)
        {
            var flight = await this.context.FlightInformations.FirstOrDefaultAsync(q => q.ID == dto.FlightId);
            if (flight == null)
                return new CustomActionResult(HttpStatusCode.NotFound, "");

            var currentStatus = this.context.FlightStatusLogs.Where(q => q.FlightID == dto.FlightId && q.FlightStatusID == 4);
            this.context.FlightStatusLogs.RemoveRange(currentStatus);

            var log = new FlightStatusLog()
            {
                FlightID = flight.ID,
                Date = dto.Date,
                FlightStatusID = 4,
                UserId = (int)dto.UserId,

            };
            this.context.FlightStatusLogs.Add(log);
            flight.CancelDate = dto.CancelDate;
            flight.CancelReasonId = dto.CancelReasonId;
            flight.CancelRemark = dto.CancelRemark;
            flight.FlightStatusID = 4;
            flight.FlightStatusUserId = dto.UserId;



            return new CustomActionResult(HttpStatusCode.OK, true);
        }


        public async Task<CustomActionResult> UpdateFlightRamp(ViewModels.FlightRampDto dto)
        {
            var flight = await this.context.FlightInformations.FirstOrDefaultAsync(q => q.ID == dto.FlightId);
            if (flight == null)
                return new CustomActionResult(HttpStatusCode.NotFound, "");

            //var currentStatus = this.context.FlightStatusLogs.Where(q => q.FlightID == dto.FlightId).OrderBy(q=>q.Date).ToList();
            // var rampstatus = currentStatus.Where(q => q.FlightStatusID == 9).OrderByDescending(q => q.Date).FirstOrDefault();
            // var index = currentStatus.IndexOf(rampstatus);
            //   this.context.FlightStatusLogs.RemoveRange(currentStatus);

            var log = new FlightStatusLog()
            {
                FlightID = flight.ID,
                Date = dto.Date,
                FlightStatusID = 9,
                UserId = (int)dto.UserId,

            };
            this.context.FlightStatusLogs.Add(log);
            flight.RampDate = dto.RampDate;
            flight.RampReasonId = dto.RampReasonId;
            flight.RampRemark = dto.RampRemark;
            flight.FlightStatusID = 9;
            flight.FlightStatusUserId = dto.UserId;



            return new CustomActionResult(HttpStatusCode.OK, true);
        }

        public async Task<CustomActionResult> UpdateFlightRedirect(ViewModels.FlightRedirectDto dto)
        {
            var flight = await this.context.FlightInformations.FirstOrDefaultAsync(q => q.ID == dto.FlightId);
            if (flight == null)
                return new CustomActionResult(HttpStatusCode.NotFound, "");

            var currentStatus = this.context.FlightStatusLogs.Where(q => q.FlightID == dto.FlightId && q.FlightStatusID == 17);
            this.context.FlightStatusLogs.RemoveRange(currentStatus);

            var log = new FlightStatusLog()
            {
                FlightID = flight.ID,
                Date = dto.Date,
                FlightStatusID = 17,
                UserId = (int)dto.UserId,

            };
            this.context.FlightStatusLogs.Add(log);
            flight.RedirectDate = dto.RedirectDate;
            flight.RedirectReasonId = dto.RedirectReasonId;
            flight.RedirectRemark = dto.RedirectRemark;

            flight.OToAirportId = flight.ToAirportId;
            flight.OToAirportIATA = dto.OAirportIATA;
            flight.ToAirportId = dto.AirportId;

            flight.OSTA = flight.STA;
            flight.STA = dto.STA;
            //old
            //flight.FlightH = Convert.ToInt32(dto.STA.Subtract((DateTime)flight.STD).TotalHours);
            //flight.FlightM = Convert.ToByte(dto.STA.Subtract((DateTime)flight.STD).TotalMinutes - flight.FlightH * 60);
            //new
            //  flight.FlightH = Convert.ToInt32(dto.STA.Subtract((DateTime)flight.ChocksOut).TotalHours);
            // flight.FlightM = Convert.ToByte(dto.STA.Subtract((DateTime)flight.ChocksOut).TotalMinutes - flight.FlightH * 60);

            flight.FlightH = Convert.ToInt32(dto.STA.Subtract((DateTime)flight.ChocksOut).Hours);
            flight.FlightM = Convert.ToByte(dto.STA.Subtract((DateTime)flight.ChocksOut).TotalHours * 60 - flight.FlightH * 60);



            flight.FlightStatusID = 17;
            flight.FlightStatusUserId = dto.UserId;



            return new CustomActionResult(HttpStatusCode.OK, true);
        }

        public async Task<CustomActionResult> UpdateFlightTakeOff(ViewModels.FlightSaveDto dto)
        {
            var flight = await this.context.FlightInformations.FirstOrDefaultAsync(q => q.ID == dto.ID);
            if (flight == null)
                return new CustomActionResult(HttpStatusCode.NotFound, "");
            var stids = dto.StatusLog.Select(q => q.FlightStatusID).ToList();
            var currentStatus = this.context.FlightStatusLogs.Where(q => q.FlightID == dto.ID && q.FlightStatusID == 2);
            this.context.FlightStatusLogs.RemoveRange(currentStatus);
            foreach (var x in dto.StatusLog)
            {
                this.context.FlightStatusLogs.Add(new FlightStatusLog()
                {
                    FlightID = dto.ID,
                    Date = x.Date,
                    FlightStatusID = x.FlightStatusID,
                    Remark = x.Remark,
                    UserId = x.UserId
                });
            }

            {
                if (flight.FlightStatusID != dto.FlightStatusID)
                {
                    if (dto.StatusLog.Count > 0)
                    {
                        flight.DateCreate = dto.StatusLog.Max(q => q.Date);
                    }
                    else
                    {
                        flight.DateCreate = DateTime.UtcNow;
                    }
                    flight.FlightStatusUserId = dto.UserId;
                }
                flight.FlightStatusID = dto.FlightStatusID;
            }

            flight.Takeoff = dto.Takeoff;

            return new CustomActionResult(HttpStatusCode.OK, "");
        }

        public async Task<CustomActionResult> UpdateFlightArrival(ViewModels.FlightSaveDto dto)
        {
            var flight = await this.context.FlightInformations.FirstOrDefaultAsync(q => q.ID == dto.ID);
            if (flight == null)
                return new CustomActionResult(HttpStatusCode.NotFound, "");
            var landingChanged = flight.Landing != dto.Landing;
            var stids = dto.StatusLog.Select(q => q.FlightStatusID).ToList();
            var currentStatus = this.context.FlightStatusLogs.Where(q => q.FlightID == dto.ID && (q.FlightStatusID == 15 || q.FlightStatusID == 3));
            this.context.FlightStatusLogs.RemoveRange(currentStatus);
            foreach (var x in dto.StatusLog)
            {
                this.context.FlightStatusLogs.Add(new FlightStatusLog()
                {
                    FlightID = dto.ID,
                    Date = x.Date,
                    FlightStatusID = x.FlightStatusID,
                    Remark = x.Remark,
                    UserId = x.UserId
                });
            }

            if (flight.FlightStatusID != dto.FlightStatusID)
            {
                if (dto.StatusLog.Count > 0)
                {
                    flight.DateCreate = dto.StatusLog.Max(q => q.Date);
                }
                else
                {
                    flight.DateCreate = DateTime.UtcNow;
                }
                flight.FlightStatusUserId = dto.UserId;
            }
            if (flight.FlightStatusID != 17 && flight.FlightStatusID != 7)
            {
                flight.FlightStatusID = dto.FlightStatusID;
            }
            else
            {
                if (dto.ChocksIn == null && dto.Landing != null)
                {
                    flight.FlightStatusID = 7;
                    var divertedStatus = this.context.FlightStatusLogs.FirstOrDefault(q => q.FlightID == dto.ID && (q.FlightStatusID == 7));
                    if (divertedStatus == null)
                    {
                        var dtoLandingStatus = dto.StatusLog.FirstOrDefault(q => q.FlightStatusID == 3);
                        var date = dtoLandingStatus != null ? dtoLandingStatus.Date : DateTime.UtcNow;
                        this.context.FlightStatusLogs.Add(new FlightStatusLog()
                        {
                            FlightID = dto.ID,
                            Date = date,
                            FlightStatusID = 7,
                            Remark = "",
                            UserId = dtoLandingStatus != null ? dtoLandingStatus.UserId : -1,
                        });
                    }
                }
                else if (dto.ChocksIn != null)
                    flight.FlightStatusID = 18;
            }


            flight.ChocksIn = dto.ChocksIn;
            flight.Landing = dto.Landing;
            flight.GWLand = dto.GWLand;
            flight.FuelArrival = dto.FuelArrival;


            flight.ArrivalRemark = dto.ArrivalRemark;
            if (flight.ChocksIn != null)
            {
                //var flightCrew = await this.context.ViewFlightCrew2.Where(q => q.FlightId == flight.ID).ToListAsync();
                var flightCrewEmployee = await (from x in this.context.Employees
                                                join y in this.context.ViewFlightCrew2 on x.Id equals y.EmployeeId
                                                where y.FlightId == flight.ID
                                                select x).ToListAsync();
                //foreach (var x in flightCrew)
                //     x.Status = 15;
                foreach (var x in flightCrewEmployee)
                    x.CurrentLocationAirport = flight.ToAirportId;

            }

            var result = UpdateDelays(dto);
            if (result.Code != HttpStatusCode.OK)
                return result;

            return new CustomActionResult(HttpStatusCode.OK, landingChanged);
        }

        public async Task<CustomActionResult> UpdateFlightLanding(ViewModels.FlightSaveDto dto)
        {
            var flight = await this.context.FlightInformations.FirstOrDefaultAsync(q => q.ID == dto.ID);
            if (flight == null)
                return new CustomActionResult(HttpStatusCode.NotFound, "");
            var stids = dto.StatusLog.Select(q => q.FlightStatusID).ToList();
            var currentStatus = this.context.FlightStatusLogs.Where(q => q.FlightID == dto.ID && q.FlightStatusID == 3);
            this.context.FlightStatusLogs.RemoveRange(currentStatus);
            foreach (var x in dto.StatusLog)
            {
                this.context.FlightStatusLogs.Add(new FlightStatusLog()
                {
                    FlightID = dto.ID,
                    Date = x.Date,
                    FlightStatusID = x.FlightStatusID,
                    Remark = x.Remark,
                    UserId = x.UserId
                });
            }

            if (flight.FlightStatusID != dto.FlightStatusID)
            {
                if (dto.StatusLog.Count > 0)
                {
                    flight.DateCreate = dto.StatusLog.Max(q => q.Date);
                }
                else
                {
                    flight.DateCreate = DateTime.UtcNow;
                }
                flight.FlightStatusUserId = dto.UserId;
            }
            if (flight.FlightStatusID != 17)
            {
                flight.FlightStatusID = dto.FlightStatusID;
            }
            else
            {
                flight.FlightStatusID = 7;
                this.context.FlightStatusLogs.Add(new FlightStatusLog()
                {
                    FlightID = dto.ID,
                    Date = dto.StatusLog.Count > 0 ? dto.StatusLog.First().Date : DateTime.UtcNow,
                    FlightStatusID = 7,
                    Remark = "",
                    UserId = dto.StatusLog.Count > 0 ? dto.StatusLog.First().UserId : -1,
                });
            }




            flight.Landing = dto.Landing;




            return new CustomActionResult(HttpStatusCode.OK, "");
        }
        //shati
        public async Task<CustomActionResult> UpdateFlightOnBlock(ViewModels.FlightSaveDto dto)
        {
            var flight = await this.context.FlightInformations.FirstOrDefaultAsync(q => q.ID == dto.ID);
            if (flight == null)
                return new CustomActionResult(HttpStatusCode.NotFound, "");
            var stids = dto.StatusLog.Select(q => q.FlightStatusID).ToList();
            var currentStatus = this.context.FlightStatusLogs.Where(q => q.FlightID == dto.ID && q.FlightStatusID == 15);
            this.context.FlightStatusLogs.RemoveRange(currentStatus);
            foreach (var x in dto.StatusLog)
            {
                this.context.FlightStatusLogs.Add(new FlightStatusLog()
                {
                    FlightID = dto.ID,
                    Date = x.Date,
                    FlightStatusID = x.FlightStatusID,
                    Remark = x.Remark,
                    UserId = x.UserId
                });
            }

            if (flight.FlightStatusID != dto.FlightStatusID)
            {
                if (dto.StatusLog.Count > 0)
                {
                    flight.DateCreate = dto.StatusLog.Max(q => q.Date);
                }
                else
                {
                    flight.DateCreate = DateTime.UtcNow;
                }
                flight.FlightStatusUserId = dto.UserId;
            }
            if (flight.FlightStatusID != 7)
            {
                flight.FlightStatusID = dto.FlightStatusID;

            }



            flight.ChocksIn = dto.ChocksIn;
            var airport = await this.context.ViewFlightInformations.Where(q => q.ID == flight.ID).Select(q => q.ToAirport).SingleAsync();
            // var flightCrew = await this.context.ViewFlightCrew2.Where(q => q.FlightId == flight.ID).ToListAsync();
            var flightCrewEmployee = await (from x in this.context.Employees
                                            join y in this.context.ViewFlightCrew2 on x.Id equals y.EmployeeId
                                            where y.FlightId == flight.ID
                                            select x).ToListAsync();
            //foreach (var x in flightCrew)
            //     x.Status = 15;
            foreach (var x in flightCrewEmployee)
                x.CurrentLocationAirport = airport;



            return new CustomActionResult(HttpStatusCode.OK, "");
        }

        public async Task<CustomActionResult> GetFlightWeather(int flightId, int status)
        {
            var weather = await this.context.FlightStatusWeathers.FirstOrDefaultAsync(q => q.FlightId == flightId && q.StatusId == status);
            if (weather != null)
            {
                dynamic myObject = JsonConvert.DeserializeObject<dynamic>(weather.Details);
                return new CustomActionResult(HttpStatusCode.OK, myObject);
            }

            var flight = await this.context.ViewFlightInformations.FirstOrDefaultAsync(q => q.ID == flightId);
            if (flight == null)
                return new CustomActionResult(HttpStatusCode.NotFound, "");

            var result = SetFlightStatusWeather(flight, status);

            return new CustomActionResult(HttpStatusCode.OK, result);
        }
        public async Task<CustomActionResult> GetFlightWeathers(int flightId)
        {
            var weathers = await this.context.FlightStatusWeathers.Where(q => q.FlightId == flightId && q.StatusId > 0).ToListAsync();
            var result = new List<object>();
            foreach (var w in weathers)
            {
                //  dynamic myObject = JsonConvert.DeserializeObject<dynamic>(w.Details);

                result.Add(w);
            }


            return new CustomActionResult(HttpStatusCode.OK, result);
        }
        public object SetFlightStatusWeather(ViewFlightInformation flight, int status)
        {

            try
            {
                var entity = new Models.FlightStatusWeather()
                {
                    StatusId = status,
                    FlightId = flight.ID,

                };
                EPAGriffinAPI.Controllers.WeatherController weather = new Controllers.WeatherController();
                long unix = 0;
                dynamic weatherResult = null;
                if (status == -1)
                {
                    unix = (long)(((DateTime)flight.STD).Subtract(new DateTime(1970, 1, 1))).TotalSeconds;
                    weatherResult = weather.GetWeatherByTimeInternal((decimal)flight.FromLatitude, (decimal)flight.FromLongitude, unix);
                    entity.DateStatus = flight.STD;
                }
                if (status == -2)
                {
                    unix = (long)(((DateTime)flight.STA).Subtract(new DateTime(1970, 1, 1))).TotalSeconds;
                    weatherResult = weather.GetWeatherByTimeInternal((decimal)flight.ToLatitude, (decimal)flight.ToLongitude, unix);
                    entity.DateStatus = flight.STA;
                }
                if (status == 2)
                {
                    unix = (long)(((DateTime)flight.Takeoff).Subtract(new DateTime(1970, 1, 1))).TotalSeconds;
                    weatherResult = weather.GetWeatherByTimeInternal((decimal)flight.FromLatitude, (decimal)flight.FromLongitude, unix);
                    entity.DateStatus = flight.Takeoff;
                }
                if (status == 14)
                {
                    unix = (long)(((DateTime)flight.ChocksOut).Subtract(new DateTime(1970, 1, 1))).TotalSeconds;
                    weatherResult = weather.GetWeatherByTimeInternal((decimal)flight.FromLatitude, (decimal)flight.FromLongitude, unix);
                    entity.DateStatus = flight.ChocksOut;
                }
                if (status == 15)
                {
                    unix = (long)(((DateTime)flight.ChocksIn).Subtract(new DateTime(1970, 1, 1))).TotalSeconds;
                    weatherResult = weather.GetWeatherByTimeInternal((decimal)flight.ToLatitude, (decimal)flight.ToLongitude, unix);
                    entity.DateStatus = flight.ChocksIn;
                }
                if (status == 3)
                {
                    unix = (long)(((DateTime)flight.Landing).Subtract(new DateTime(1970, 1, 1))).TotalSeconds;
                    weatherResult = weather.GetWeatherByTimeInternal((decimal)flight.ToLatitude, (decimal)flight.ToLongitude, unix);
                    entity.DateStatus = flight.Landing;
                }

                entity.Temprature = (decimal)weatherResult.currently.temperature;
                entity.Pressure = (decimal)weatherResult.currently.pressure;


                entity.WindSpeed = (decimal)weatherResult.currently.windSpeed;
                entity.WindBearing = (decimal)weatherResult.currently.windBearing;
                entity.CloudCover = (decimal)weatherResult.currently.cloudCover;


                entity.Humidity = (decimal)weatherResult.currently.humidity;
                entity.DewPoint = (decimal)weatherResult.currently.dewPoint;
                entity.Summary = (string)weatherResult.currently.summary;
                entity.Icon = (string)weatherResult.currently.icon;
                entity.Visibility = (decimal)weatherResult.currently.visibility;
                entity.Details = JsonConvert.SerializeObject(weatherResult);

                this.context.FlightStatusWeathers.Add(entity);
                this.context.SaveChanges();

                return weatherResult;
            }
            catch (Exception ex)
            {
                return null;
            }


            // }).Start();

        }
        public object SetFlightStatusWeather(int flightId, DateTime? time, int status)
        {
            // new Thread(() =>
            // {
            try
            {
                var flight = this.context.ViewFlightInformations.FirstOrDefault(q => q.ID == flightId);
                if (flight == null)
                    return null;
                var current = this.context.FlightStatusWeathers.FirstOrDefault(q => q.FlightId == flightId && q.StatusId == status);
                if (current != null)
                    this.context.FlightStatusWeathers.Remove(current);
                if (time == null)
                {
                    this.context.SaveChanges();
                    return null;
                }
                var entity = new Models.FlightStatusWeather()
                {
                    StatusId = status,
                    FlightId = flightId,

                };
                EPAGriffinAPI.Controllers.WeatherController weather = new Controllers.WeatherController();
                long unix = 0;
                dynamic weatherResult = null;
                if (status == 2)
                {
                    // unix = ((DateTimeOffset)flight.Takeoff).ToUnixTimeSeconds();
                    unix = (long)(((DateTime)flight.Takeoff).Subtract(new DateTime(1970, 1, 1))).TotalSeconds;
                    weatherResult = weather.GetWeatherByTimeInternal((decimal)flight.FromLatitude, (decimal)flight.FromLongitude, unix);
                    entity.DateStatus = flight.Takeoff;
                }
                else if (status == 3)
                {
                    unix = (long)(((DateTime)flight.Landing).Subtract(new DateTime(1970, 1, 1))).TotalSeconds;
                    weatherResult = weather.GetWeatherByTimeInternal((decimal)flight.ToLatitude, (decimal)flight.ToLongitude, unix);
                    entity.DateStatus = flight.Landing;
                }
                else if (status == 4)
                {
                    unix = (long)(((DateTime)time).Subtract(new DateTime(1970, 1, 1))).TotalSeconds;
                    weatherResult = weather.GetWeatherByTimeInternal((decimal)flight.FromLatitude, (decimal)flight.FromLongitude, unix);
                    entity.DateStatus = time;
                }
                else
                {
                    unix = (long)(((DateTime)time).Subtract(new DateTime(1970, 1, 1))).TotalSeconds;
                    weatherResult = weather.GetWeatherByTimeInternal((decimal)flight.ToLatitude, (decimal)flight.ToLongitude, unix);
                    entity.DateStatus = time;
                }

                entity.Temprature = (decimal)weatherResult.currently.temperature;
                entity.Pressure = (decimal)weatherResult.currently.pressure;


                entity.WindSpeed = (decimal)weatherResult.currently.windSpeed;
                entity.WindBearing = (decimal)weatherResult.currently.windBearing;
                entity.CloudCover = (decimal)weatherResult.currently.cloudCover;


                entity.Humidity = (decimal)weatherResult.currently.humidity;
                entity.DewPoint = (decimal)weatherResult.currently.dewPoint;
                entity.Summary = (string)weatherResult.currently.summary;
                entity.Icon = (string)weatherResult.currently.icon;
                entity.Visibility = (decimal)weatherResult.currently.visibility;
                entity.Details = JsonConvert.SerializeObject(weatherResult);

                this.context.FlightStatusWeathers.Add(entity);
                this.context.SaveChanges();

                return weatherResult;
            }
            catch (Exception ex)
            {
                return null;
            }


            // }).Start();

        }

        public void RemoveFlightLink(int flightId)
        {
            var links = this.context.FlightLinks.Where(q => q.Flight1Id == flightId);
            this.context.FlightLinks.RemoveRange(links);
        }

        public virtual void Insert(Models.FlightInformation entity)
        {
            this.context.FlightInformations.Add(entity);
        }

        public virtual void Insert(Models.FlightChangeHistory entity)
        {
            this.context.FlightChangeHistories.Add(entity);
        }

        public virtual void Insert(Models.FlightPlanCalanderCrew entity)
        {
            this.context.FlightPlanCalanderCrews.Add(entity);
        }
        public virtual void Insert(Models.BoxCrew entity)
        {
            this.context.BoxCrews.Add(entity);
        }
        public virtual void Insert(Models.FlightPlanItemPermit entity)
        {
            this.context.FlightPlanItemPermits.Add(entity);
        }
        public virtual void Insert(Models.FlightLink entity)
        {
            this.context.FlightLinks.Add(entity);
        }
        public virtual void Insert(Models.FlightPlanRegister entity)
        {
            this.context.FlightPlanRegisters.Add(entity);
        }
        public virtual void Insert(Models.FlightPlanItem entity)
        {
            this.context.FlightPlanItems.Add(entity);
        }
        public virtual void Insert(Models.FlightPlan entity)
        {
            this.context.FlightPlans.Add(entity);
        }
        public virtual void Insert(Models.FlightPlanMonth entity)
        {
            this.context.FlightPlanMonths.Add(entity);
        }
        public virtual void Insert(Models.EmployeeCalendar entity)
        {
            this.context.EmployeeCalendars.Add(entity);
        }
        public virtual void Insert(Models.EmployeeCalendarSplited entity)
        {
            this.context.EmployeeCalendarSpliteds.Add(entity);
        }
        public virtual void Insert(Models.FlightPlanDay entity)
        {
            this.context.FlightPlanDays.Add(entity);
        }
        public virtual void Insert(Models.PlanItem entity)
        {
            this.context.PlanItems.Add(entity);
        }
        public virtual void Delete(Models.FlightPlanItem entityToDelete)
        {
            if (context.Entry(entityToDelete).State == EntityState.Detached)
            {
                this.context.FlightPlanItems.Attach(entityToDelete);
            }
            this.context.FlightPlanItems.Remove(entityToDelete);
        }
        public virtual void Delete(Models.EmployeeCalendar entityToDelete)
        {
            if (context.Entry(entityToDelete).State == EntityState.Detached)
            {
                this.context.EmployeeCalendars.Attach(entityToDelete);
            }
            this.context.EmployeeCalendars.Remove(entityToDelete);
        }

        public virtual void Delete(Models.FlightPlanCalanderCrew entityToDelete)
        {
            if (context.Entry(entityToDelete).State == EntityState.Detached)
            {
                this.context.FlightPlanCalanderCrews.Attach(entityToDelete);
            }
            this.context.FlightPlanCalanderCrews.Remove(entityToDelete);
        }
        public virtual void Delete(Models.BoxCrew entityToDelete)
        {
            if (context.Entry(entityToDelete).State == EntityState.Detached)
            {
                this.context.BoxCrews.Attach(entityToDelete);
            }
            this.context.BoxCrews.Remove(entityToDelete);
        }


        //xdelx
        public virtual void DeleteFlight(Models.FlightInformation entityToDelete)
        {
            if (context.Entry(entityToDelete).State == EntityState.Detached)
            {
                this.context.FlightInformations.Attach(entityToDelete);
            }

            if (entityToDelete.FlightPlanId != null)
            {
                var plan = (from x in this.context.FlightPlanItems
                            join y in this.context.FlightPlans on x.FlightPlanId equals y.Id
                            where x.Id == entityToDelete.FlightPlanId
                            select y).FirstOrDefault();
                if (plan != null)
                    this.context.UpdatedPlanFlights.Add(new UpdatedPlanFlight() { Date = ((DateTime)entityToDelete.STD).Date, PlanId = plan.Id, Status = 2 });
            }

            this.context.FlightInformations.Remove(entityToDelete);
        }
        public async Task<object> DeleteFlightGroup(/*dynamic dto,*/DateTime intervalFrom, DateTime intervalTo, List<int> days, int flightId, int interval, int checkTime)
        {

            List<int> result = new List<int>();
            var intervalDays = GetInvervalDates(interval, intervalFrom, intervalTo, days).Select(q => (Nullable<DateTime>)q).ToList();
            var baseFlight = await this.context.FlightInformations.Where(q => q.ID == flightId).FirstOrDefaultAsync();

            var stdHoursBF = ((DateTime)baseFlight.STD).Hour;
            var stdMinutesBF = ((DateTime)baseFlight.STD).Minute;
            var staHoursBF = ((DateTime)baseFlight.STA).Hour;
            var staMinutesBF = ((DateTime)baseFlight.STA).Minute;

            var flightIds = await (from x in this.context.ViewLegTimes
                                   where x.FlightNumber == baseFlight.FlightNumber && intervalDays.Contains(x.STDDay)
                                   select x.ID).ToListAsync();
            var nflts = flightIds.Select(q => (Nullable<int>)q).ToList();
            var fdpitems = await this.context.FDPItems.Where(q => nflts.Contains(q.FlightId)).Select(q => q.FlightId).ToListAsync();

            var finalIds = nflts.Where(q => !fdpitems.Contains(q)).Select(q => (int)q).Distinct().ToList();
            var finalFlights = await this.context.FlightInformations.Where(q => finalIds.Contains(q.ID)).ToListAsync();
            foreach (var entity in finalFlights)
            {
                if (entity.FlightStatusID == 1)
                {
                    var flt_stdHours = ((DateTime)entity.STD).Hour;
                    var flt_stdMinutes = ((DateTime)entity.STD).Minute;
                    var flt_staHours = ((DateTime)entity.STA).Hour;
                    var flt_staMinutes = ((DateTime)entity.STA).Minute;
                    bool exec = true;
                    if (checkTime == 1)
                    {
                        exec = flt_stdHours == stdHoursBF && flt_stdMinutes == stdMinutesBF && flt_staHours == staHoursBF && flt_staMinutes == staMinutesBF;
                    }
                    if (exec)
                    {
                        result.Add(entity.ID);
                        this.context.FlightInformations.Remove(entity);
                    }

                }
            }

            return result;

            //if (context.Entry(entityToDelete).State == EntityState.Detached)
            //{
            //    this.context.FlightInformations.Attach(entityToDelete);
            //}

            //if (entityToDelete.FlightPlanId != null)
            //{
            //    var plan = (from x in this.context.FlightPlanItems
            //                join y in this.context.FlightPlans on x.FlightPlanId equals y.Id
            //                where x.Id == entityToDelete.FlightPlanId
            //                select y).FirstOrDefault();
            //    if (plan != null)
            //        this.context.UpdatedPlanFlights.Add(new UpdatedPlanFlight() { Date = ((DateTime)entityToDelete.STD).Date, PlanId = plan.Id, Status = 2 });
            //}

            //this.context.FlightInformations.Remove(entityToDelete);
        }
        //xdel
        public virtual void Delete(Models.FlightPlanRegister entityToDelete)
        {
            if (context.Entry(entityToDelete).State == EntityState.Detached)
            {
                this.context.FlightPlanRegisters.Attach(entityToDelete);
            }
            this.context.FlightPlanRegisters.Remove(entityToDelete);
        }

        public virtual void Delete(Models.FlightPlanItemPermit entityToDelete)
        {
            if (context.Entry(entityToDelete).State == EntityState.Detached)
            {
                this.context.FlightPlanItemPermits.Attach(entityToDelete);
            }
            this.context.FlightPlanItemPermits.Remove(entityToDelete);
        }


        public async Task<object> GetFlightsGrouped(int cid, string sta, string std)
        {
            DateTime dateSTA = EPAGriffinAPI.Helper.BuildDateTimeFromYAFormatUTC(sta).Date;
            DateTime dateSTD = EPAGriffinAPI.Helper.BuildDateTimeFromYAFormatUTC(std).Date.AddHours(23).AddMinutes(59).AddSeconds(59).AddMilliseconds(999);
            var query = from x in this.context.ViewFlightInformations
                        where x.RegisterID != null && x.CustomerId == cid /*&& x.FlightStatusID == 1*/ && (x.STA >= dateSTA && x.STA <= dateSTD)
                        group x by new
                        {
                            x.AircraftType,
                            x.TypeId,
                            x.Register,
                            x.RegisterID

                        }
                      into g
                        select new { g.Key.Register, g.Key.RegisterID, g.Key.TypeId, g.Key.AircraftType, TotalFlights = g.Count() };
            var result = await query.ToListAsync();
            return result;
        }

        internal async Task<object> GetGantt(int cid)
        {
            var flights = await this.context.ViewFlightInformations.Where(q => q.CustomerId == cid).ToListAsync();
            var flightsdto = new List<ViewModels.ViewFlightInformationDto>();
            foreach (var x in flights)
            {
                ViewModels.ViewFlightInformationDto dto = new ViewFlightInformationDto();
                ViewModels.ViewFlightInformationDto.FillDto(x, dto, 0);
                flightsdto.Add(dto);
            }

            var resgroups = from x in flights
                            group x by new { x.AircraftType, AircraftTypeId = x.TypeId }
                            into grp
                            select new { groupId = grp.Key.AircraftTypeId, Title = grp.Key.AircraftType };
            //            var resourceGanttResources = [
            //    { resourceId: 1, resourceName: "EP-TAD", groupId: 1 },
            //    { resourceId: 2, resourceName: "EP-TAB", groupId: 1 },
            //    { resourceId: 3, resourceName: "EP-TAC", groupId: 2 },
            //    { resourceId: 4, resourceName: "EP-TAF", groupId: 2 },
            //    { resourceId: 5, resourceName: "EP-TAE", groupId: 2 },
            //    { resourceId: 6, resourceName: "EP-TAG", groupId: 3 },
            //    { resourceId: 7, resourceName: "UNKNOWN 1" },
            //    { resourceId: 8, resourceName: "UNKNOWN 2" },
            //];
            var ressq = (from x in flights
                         group x by new { x.RegisterID, x.Register, x.TypeId }
                     into grp
                         select new { grp.Key.RegisterID, grp.Key.Register, grp.Key.TypeId }).ToList();
            var ress = ressq.OrderBy(q => q.TypeId).Select((q, i) => new { resourceName = q.Register, groupId = q.TypeId, resourceId = (q.RegisterID >= 0 ? q.RegisterID : -1 * (i + 1)) }).ToList();

            foreach (var x in flightsdto)
            {
                if (x.RegisterID >= 0)
                    x.resourceId.Add((int)x.RegisterID);
                else
                    x.resourceId.Add((int)ress.First(q => q.resourceName == x.Register).resourceId);
            }

            var result = new
            {
                flights = flightsdto,
                resourceGroups = resgroups.ToList(),
                resources = ress,
            };
            return result;
        }
        internal async Task<object> GetPlanGantt(int pid, int tzoffset)
        {
            var plan = await this.context.FlightPlans.SingleAsync(q => q.Id == pid);
            var flights = await this.context.ViewFlightPlanItems.Where(q => q.FlightPlanId == pid).ToListAsync();
            var flightsdto = new List<ViewModels.ViewFlightPlanItemDto>();
            foreach (var x in flights)
            {
                ViewModels.ViewFlightPlanItemDto dto = new ViewFlightPlanItemDto();
                ViewModels.ViewFlightPlanItemDto.FillDto(x, dto, tzoffset);
                flightsdto.Add(dto);
            }

            var resgroups = from x in flights
                            group x by new { x.AircraftType, AircraftTypeId = x.TypeId }
                            into grp
                            select new { groupId = grp.Key.AircraftTypeId, Title = grp.Key.AircraftType };

            var ressq = (from x in flights
                         group x by new { x.RegisterID, x.Register, x.TypeId }
                     into grp
                         select new resource() { resourceId = grp.Key.RegisterID, resourceName = grp.Key.Register, groupId = grp.Key.TypeId, assigned = false, registers = string.Empty }).ToList();

            //var ress = ressq.OrderBy(q => q.TypeId).Select((q, i) => new { resourceName = q.Register, groupId = q.TypeId, resourceId = (q.RegisterID >= 0 ? q.RegisterID : -1 * (i + 1)) }).ToList();

            foreach (var x in flightsdto)
            {
                //if (x.RegisterID >= 0)
                x.resourceId.Add((int)x.RegisterID);
                // else
                //    x.resourceId.Add((int)ress.First(q => q.resourceName == x.Register).resourceId);
            }
            var _registers = await this.context.ViewFlightPlanRegisters.Where(q => q.FlightPlanId == pid).ToListAsync();
            var grpRegisters = (from x in _registers
                                group x by x.PlannedRegisterId into g
                                select g).ToList();
            foreach (var g in grpRegisters)
            {
                var res = ressq.FirstOrDefault(q => q.resourceId == g.Key);
                if (res != null)
                {
                    res.registers = string.Join(", ", g.Select(q => q.Register).ToList());
                    var dates = g.OrderBy(q => q.DateFrom).ToList();
                    if (dates.First().DateFrom.Date == ((DateTime)plan.DateFrom).Date && dates.Last().DateTo.Date == ((DateTime)plan.DateTo).Date)
                        res.assigned = true;
                }
            }
            var result = new
            {
                flights = flightsdto,
                resourceGroups = resgroups.ToList(),
                resources = ressq,
                registers = _registers,
            };
            return result;
        }


        internal async Task<object> GetPlanItemsGantt(DateTime date, int tzoffset, bool design, int cid)
        {
            var plansQuery = from x in this.context.ViewFlightPlans
                             where x.DateFrom == date && x.CustomerId == cid
                             select x;
            var flightsQuery = from x in this.context.ViewFlightPlanItems
                               where x.DateFrom == date && x.CustomerId == cid
                               select x;
            if (design)
            {
                plansQuery = plansQuery.Where(q => q.IsApproved50 == 0);
                flightsQuery = flightsQuery.Where(q => q.IsApproved50 == 0);
            }

            var plans = await this.context.FlightPlans.ToListAsync();


            //var flights = await this.context.ViewFlightPlanItems.Where(q => q.FlightPlanId == pid).ToListAsync();
            var flights = await flightsQuery.ToListAsync();
            var flightsdto = new List<ViewModels.ViewFlightPlanItemDto>();
            foreach (var x in flights)
            {
                ViewModels.ViewFlightPlanItemDto dto = new ViewFlightPlanItemDto();
                ViewModels.ViewFlightPlanItemDto.FillDto(x, dto, tzoffset);
                flightsdto.Add(dto);
            }

            var resgroups = from x in flights
                            group x by new { x.AircraftType, AircraftTypeId = x.TypeId }
                            into grp
                            select new { groupId = grp.Key.AircraftTypeId, Title = grp.Key.AircraftType };

            var ressq = (from x in flights
                         group x by new { x.RegisterID, x.Register, x.TypeId }
                     into grp
                         select new resource() { resourceId = grp.Key.RegisterID, resourceName = grp.Key.Register, groupId = grp.Key.TypeId, assigned = false, registers = string.Empty }).ToList();

            //var ress = ressq.OrderBy(q => q.TypeId).Select((q, i) => new { resourceName = q.Register, groupId = q.TypeId, resourceId = (q.RegisterID >= 0 ? q.RegisterID : -1 * (i + 1)) }).ToList();

            foreach (var x in flightsdto)
            {
                //if (x.RegisterID >= 0)
                x.resourceId.Add((int)x.RegisterID);
                // else
                //    x.resourceId.Add((int)ress.First(q => q.resourceName == x.Register).resourceId);
            }
            var planIds = plans.Select(q => q.Id).ToList();
            var _registers = await this.context.ViewFlightPlanRegisters.Where(q => planIds.Contains(q.FlightPlanId)).ToListAsync();
            var grpRegisters = (from x in _registers
                                group x by x.PlannedRegisterId into g
                                select g).ToList();
            foreach (var g in grpRegisters)
            {
                var res = ressq.FirstOrDefault(q => q.resourceId == g.Key);
                if (res != null)
                {
                    res.registers = string.Join(", ", g.Select(q => q.Register).ToList());
                    var dates = g.OrderBy(q => q.DateFrom).ToList();
                    var plan = plans.FirstOrDefault(q => q.Id == g.FirstOrDefault().FlightPlanId);
                    if (dates.First().DateFrom.Date == ((DateTime)plan.DateFrom).Date && dates.Last().DateTo.Date == ((DateTime)plan.DateTo).Date)
                        res.assigned = true;
                }
            }
            var result = new
            {
                flights = flightsdto,
                resourceGroups = resgroups.ToList(),
                resources = ressq,
                registers = _registers,
            };
            return result;
        }
        public virtual async Task<Box> GetBoxByID(int id)
        {
            return await this.context.Boxes.FirstOrDefaultAsync(q => q.Id == id);
        }
        public virtual async Task<ViewBox> GetViewBoxByID(int id)
        {
            return await this.context.ViewBoxes.FirstOrDefaultAsync(q => q.Id == id);
        }


        internal async Task<bool> boxPlanItems(List<int> ids, int cid)
        {
            // var planitems = await this.context.FlightPlanItems.Where(q => ids.Contains(q.Id)).OrderBy(q=>q.STD).ToListAsync();
            var planitems = await (from x in this.context.ViewFlightPlanItemCalanders
                                   where ids.Contains(x.Id) && x.CalendarId == cid
                                   select new { x.Id, x.FlightPlanId, x.STA, x.STD, x.ToAirport, x.FromAirport }).ToListAsync();
            var IsPlanValid = planitems.Select(q => q.FlightPlanId).Distinct().Count() == 1;
            if (!IsPlanValid)
                return false;
            //,DateTime std,DateTime sta,int from,int to
            var std = planitems.First().STD;
            var sta = planitems.Last().STA;
            var from = planitems.First().FromAirport;
            var to = planitems.Last().ToAirport;
            var box = new Box();
            box.STA = sta;
            box.STD = std;
            box.FromAirportId = from;
            box.ToAirportId = to;
            box.Date = ((DateTime)std).Date;
            box.FlightPlanId = planitems.First().FlightPlanId;
            box.CalanderId = cid;
            this.context.Boxes.Add(box);
            foreach (var x in planitems)
            {
                //x.Box = box;
                var bfp = new BoxFlightPlanItem()
                {
                    CalanderId = cid,
                    ItemId = x.Id,
                    Box = box
                };
                this.context.BoxFlightPlanItems.Add(bfp);
            }
            return true;

        }
        //jooj
        internal string OnOffFDPItems(List<FDPItemOFFDto> fdps)
        //(int fdpId,int fdpItemId,bool off)
        {

            foreach (var f in fdps)
            {
                var fdpId = f.FDPId;
                var fdp = this.context.FDPs.Where(q => q.Id == fdpId).Single();
                var fdpItems = this.context.FDPItems.Where(q => q.FDPId == fdpId).ToList();
                var viewFdpItems = this.context.ViewFDPItems.AsNoTracking().Where(q => q.FDPId == fdpId).ToList();
                foreach (var fi in f.Items)
                {
                    var fdpItemId = fi.FDPItem;
                    var off = fi.Off;
                    var item = fdpItems.Single(q => q.Id == fdpItemId);
                    var viewItem = viewFdpItems.Single(q => q.Id == fdpItemId);
                    if (off)
                    {
                        item.IsOff = true;
                        viewItem.IsOff = true;
                    }
                    else
                    {
                        item.IsOff = null;
                        viewItem.IsOff = null;
                    }
                }

                var firstItem = viewFdpItems.Where(q => q.IsOff == null || q.IsOff == false).OrderBy(q => q.STD).FirstOrDefault();
                var lastItem = viewFdpItems.Where(q => q.IsOff == null || q.IsOff == false).OrderByDescending(q => q.STD).FirstOrDefault();
                if (firstItem != null)
                    fdp.FirstFlightId = firstItem.FlightId;
                if (lastItem != null)
                    fdp.LastFlightId = lastItem.FlightId;
                if (fdp.UPD == null)
                    fdp.UPD = 1;
                else
                    fdp.UPD++;

            }

            return string.Empty;


        }

        internal string UpdateFirstLastFlights(int flightId)
        //(int fdpId,int fdpItemId,bool off)
        {
            //var viewFdpItems = this.context.ViewFDPItems.AsNoTracking().Where(q => q.FlightId == flightId).ToList();
            // var fdpItems = this.context.FDPItems.Where(q => q.FlightId == flightId).ToList();
            //var fdpIds = viewFdpItems.Select(q => q.FDPId).Distinct().ToList();
            var fdps = (from x in this.context.FDPs
                        join y in this.context.FDPItems on x.Id equals y.FDPId
                        where y.FlightId == flightId
                        select x).ToList();
            var fdpIds = fdps.Select(q => q.Id).Distinct().ToList();
            var viewFdpItems = (from x in this.context.ViewFDPItems.AsNoTracking()
                                where fdpIds.Contains(x.FDPId)
                                select x).ToList();


            foreach (var f in fdps)
            {
                var fdpId = f.Id;
                var viewItems = viewFdpItems.Where(q => q.FDPId == fdpId).ToList();
                var firstItem = viewFdpItems.Where(q => (q.IsOff == null || q.IsOff == false) && q.FlightId != flightId).OrderBy(q => q.STD).FirstOrDefault();
                var lastItem = viewFdpItems.Where(q => (q.IsOff == null || q.IsOff == false) && q.FlightId != flightId).OrderByDescending(q => q.STD).FirstOrDefault();
                if (firstItem != null)
                    f.FirstFlightId = firstItem.FlightId;
                if (lastItem != null)
                    f.LastFlightId = lastItem.FlightId;
                if (f.UPD == null)
                    f.UPD = 1;
                else
                    f.UPD++;
            }


            return string.Empty;


        }

        internal async Task<FDP> CreateFDP(int crewId)
        {
            var temp = new FDP()
            {
                IsTemplate = true,
                DutyType = 1165,
                //CrewId = crewId,
                IsMain = true,
                GUID = Guid.NewGuid(),
                CP = true,

            };
            this.context.FDPs.Add(temp);
            await this.context.SaveAsync();
            var fdp = new FDP()
            {
                IsTemplate = false,
                DutyType = 1165,
                CrewId = crewId,
                GUID = Guid.NewGuid(),
                CP = true,
                TemplateId = temp.Id

            };

            this.context.FDPs.Add(fdp);
            var saveResult = await this.context.SaveAsync();
            if (saveResult.Code != HttpStatusCode.OK)
                return null;
            return fdp;
        }


        internal async Task<FDP> CreateDuty(DutyDto dto)
        {
            FDP temp = null;
            FDP fdp = null;
            if (dto.Id == -1)
            {
                temp = new FDP()
                {
                    IsTemplate = true,
                    DutyType = dto.Type,
                    //CrewId = crewId,
                    IsMain = true,
                    GUID = Guid.NewGuid(),
                    CP = true,
                    DateStart = dto.Start,
                    DateEnd = dto.End,
                    CustomerId = dto.Airline,
                    Remark = dto.Remark

                };
                this.context.FDPs.Add(temp);
                await this.context.SaveAsync();
                fdp = new FDP()
                {
                    IsTemplate = false,
                    DutyType = dto.Type,
                    CrewId = dto.CrewId,
                    GUID = Guid.NewGuid(),
                    CP = true,
                    TemplateId = temp.Id,
                    DateStart = dto.Start,
                    DateEnd = dto.End,
                    CustomerId = dto.Airline,
                    Remark = dto.Remark

                };

                this.context.FDPs.Add(fdp);
                var saveResult = await this.context.SaveAsync();
                if (saveResult.Code != HttpStatusCode.OK)
                    return null;
            }
            else
            {
                fdp = await this.context.FDPs.FirstOrDefaultAsync(q => q.Id == dto.Id);
                temp = await this.context.FDPs.FirstOrDefaultAsync(q => q.Id == fdp.TemplateId);

                temp.CustomerId = dto.Airline;
                temp.DutyType = dto.Type;
                temp.DateStart = dto.Start;
                temp.DateEnd = dto.End;
                temp.Remark = dto.Remark;

                fdp.CustomerId = dto.Airline;
                fdp.DutyType = dto.Type;
                fdp.DateStart = dto.Start;
                fdp.DateEnd = dto.End;
                fdp.Remark = dto.Remark;

                var saveResult = await this.context.SaveAsync();
                if (saveResult.Code != HttpStatusCode.OK)
                    return null;

            }

            return fdp;
        }

        internal async Task<CustomActionResult> UpdateFDPReportingTime(int id, DateTime dt)
        {
            var fdp = await this.context.FDPs.FirstOrDefaultAsync(q => q.Id == id);
            var temp = await this.context.FDPs.FirstOrDefaultAsync(q => q.Id == fdp.TemplateId);
            fdp.ReportingTime = dt;
            temp.ReportingTime = dt;
            fdp.UPD = fdp.UPD == null ? 1 : ((int)fdp.UPD) + 1;
            var saveResult = await context.SaveAsync();
            if (saveResult.Code != HttpStatusCode.OK)
                return saveResult;
            var viewfdp = await this.context.ViewFDPFlightDetails.FirstOrDefaultAsync(q => q.Id == fdp.Id);

            return new CustomActionResult(HttpStatusCode.OK, new { viewfdp });
        }
        internal async Task<bool> updateSun(DateTime dt)
        {
            var airports = await this.context.ViewAirports.Where(q => q.CountryId == 103).ToListAsync();
            var date = dt == null ? DateTime.Now.Date : (DateTime)dt;

            date = date.Date;
            foreach (var airport in airports)
            {
                var lt = airport.Latitude;
                var lng = airport.Longitude;
                var dateStr = date.Year + "-" + date.Month.ToString().PadLeft(2, '0') + "-" + date.Day.ToString().PadLeft(2, '0');
                var url = "https://api.sunrise-sunset.org/json?lat=" + lt + "&lng=" + lng + "&formatted=0&date=" + dateStr;
                WebRequest request = WebRequest.Create(url);

                request.Credentials = CredentialCache.DefaultCredentials;

                WebResponse response = await request.GetResponseAsync();

                Stream dataStream = response.GetResponseStream();

                StreamReader reader = new StreamReader(dataStream);

                string responseFromServer = reader.ReadToEnd();

                reader.Close();
                response.Close();
                dynamic myObject = JsonConvert.DeserializeObject<dynamic>(responseFromServer);
                var result = myObject.results;
                var suntime = new SunTime()
                {
                    Date = dt,
                    Lng = Convert.ToDouble(lng),
                    Lat = Convert.ToDouble(lt),
                    AirportId = airport.Id,
                    DateCreate = (DateTime.Now).ToUniversalTime(),
                    TOffset = TimeZoneInfo.Local.GetUtcOffset(DateTime.UtcNow).Hours * 60 + TimeZoneInfo.Local.GetUtcOffset(DateTime.UtcNow).Minutes,

                    Sunrise = ((DateTime)Convert.ToDateTime(result.sunrise)).ToUniversalTime(),
                    Sunset = ((DateTime)Convert.ToDateTime(result.sunset)).ToUniversalTime(),
                    SolarNoon = ((DateTime)Convert.ToDateTime(result.solar_noon)).ToUniversalTime(),
                    DayLength = Convert.ToInt32(result.day_length),
                    CivilTwilightBegin = ((DateTime)Convert.ToDateTime(result.civil_twilight_begin)).ToUniversalTime(),
                    CivilTwilightEnd = ((DateTime)Convert.ToDateTime(result.civil_twilight_end)).ToUniversalTime(),
                    NauticalTwilightBegin = ((DateTime)Convert.ToDateTime(result.nautical_twilight_begin)).ToUniversalTime(),
                    NauticalTwilightEnd = ((DateTime)Convert.ToDateTime(result.nautical_twilight_end)).ToUniversalTime(),
                    AstronomicalTwilightBegin = ((DateTime)Convert.ToDateTime(result.astronomical_twilight_begin)).ToUniversalTime(),
                    AstronomicalTwilightEnd = ((DateTime)Convert.ToDateTime(result.astronomical_twilight_end)).ToUniversalTime(),

                };
                this.context.SunTimes.Add(suntime);
            }
            await this.context.SaveChangesAsync();
            return true;
        }
        internal async Task<SunTime> GetSun(/*double lt, double lng,*/int aid, DateTime dt)
        {
            var date = dt == null ? DateTime.Now.Date : (DateTime)dt;

            date = date.Date;

            var item = await this.context.SunTimes.FirstOrDefaultAsync(q => q.AirportId == aid && q.Date == date);
            if (item != null)
                return item;
            var airport = await this.context.Airports.FirstOrDefaultAsync(q => q.Id == aid && q.Latitude != null && q.Longitude != null);
            if (airport == null)
                return null;
            var lt = airport.Latitude;
            var lng = airport.Longitude;

            var dateStr = date.Year + "-" + date.Month.ToString().PadLeft(2, '0') + "-" + date.Day.ToString().PadLeft(2, '0');
            var url = "https://api.sunrise-sunset.org/json?lat=" + lt + "&lng=" + lng + "&formatted=0&date=" + dateStr;
            WebRequest request = WebRequest.Create(url);
            // If required by the server, set the credentials.  
            request.Credentials = CredentialCache.DefaultCredentials;
            // Get the response.  
            WebResponse response = await request.GetResponseAsync();
            // Display the status.  
            //Console.WriteLine(((HttpWebResponse)response).StatusDescription);
            // Get the stream containing content returned by the server.  
            Stream dataStream = response.GetResponseStream();
            // Open the stream using a StreamReader for easy access.  
            StreamReader reader = new StreamReader(dataStream);
            // Read the content.  
            string responseFromServer = reader.ReadToEnd();
            // Display the content.  
            //Console.WriteLine(responseFromServer);
            // Clean up the streams and the response.  
            reader.Close();
            response.Close();
            dynamic myObject = JsonConvert.DeserializeObject<dynamic>(responseFromServer);
            var result = myObject.results;
            var suntime = new SunTime()
            {
                Date = dt,
                Lng = Convert.ToDouble(lng),
                Lat = Convert.ToDouble(lt),
                AirportId = aid,
                DateCreate = (DateTime.Now).ToUniversalTime(),
                TOffset = TimeZoneInfo.Local.GetUtcOffset(DateTime.UtcNow).Hours * 60 + TimeZoneInfo.Local.GetUtcOffset(DateTime.UtcNow).Minutes,

                Sunrise = ((DateTime)Convert.ToDateTime(result.sunrise)).ToUniversalTime(),
                Sunset = ((DateTime)Convert.ToDateTime(result.sunset)).ToUniversalTime(),
                SolarNoon = ((DateTime)Convert.ToDateTime(result.solar_noon)).ToUniversalTime(),
                DayLength = Convert.ToInt32(result.day_length),
                CivilTwilightBegin = ((DateTime)Convert.ToDateTime(result.civil_twilight_begin)).ToUniversalTime(),
                CivilTwilightEnd = ((DateTime)Convert.ToDateTime(result.civil_twilight_end)).ToUniversalTime(),
                NauticalTwilightBegin = ((DateTime)Convert.ToDateTime(result.nautical_twilight_begin)).ToUniversalTime(),
                NauticalTwilightEnd = ((DateTime)Convert.ToDateTime(result.nautical_twilight_end)).ToUniversalTime(),
                AstronomicalTwilightBegin = ((DateTime)Convert.ToDateTime(result.astronomical_twilight_begin)).ToUniversalTime(),
                AstronomicalTwilightEnd = ((DateTime)Convert.ToDateTime(result.astronomical_twilight_end)).ToUniversalTime(),

            };
            this.context.SunTimes.Add(suntime);
            await this.context.SaveChangesAsync();
            return suntime;
        }


        public class SunFlightResult
        {
            public double distance_km { get; set; }
            public double total_minutes { get; set; }
            public double percent_night { get; set; }
            public double total_minutes_night { get; set; }
            public double total_minutes_day { get; set; }
        }

        internal async Task<dynamic> GetSunFlight(DateTime dep, DateTime arr, string fid, string tid)
        {
            //http://sunflight.net/ajax/ajax-flight-route-manual.php?origin=MIA&destination=LHR&departure_datetime=2020-04-30T12%3A32&duration=480&_=1588233741114
            var duration = arr.Subtract(dep).TotalMinutes;
            var _dep = dep.Year + "-" + dep.Month.ToString().PadLeft(2, '0') + "-" + dep.Day.ToString().PadLeft(2, '0') + "T" + dep.Hour + "%3A" + dep.Minute;
            var url = "http://sunflight.net/ajax/ajax-flight-route-manual.php?" + "origin=" + fid + "&destination=" + tid + "&departure_datetime=" + _dep + "&duration=" + duration;
            try
            {
                WebRequest request = WebRequest.Create(url);

                request.Credentials = CredentialCache.DefaultCredentials;

                WebResponse response = await request.GetResponseAsync();

                Stream dataStream = response.GetResponseStream();

                StreamReader reader = new StreamReader(dataStream);

                string responseFromServer = reader.ReadToEnd();

                reader.Close();
                response.Close();
                responseFromServer = responseFromServer.Replace("flightmap(", "");
                responseFromServer = responseFromServer.Substring(0, responseFromServer.Length - 2);
                dynamic myObject = JsonConvert.DeserializeObject<dynamic>(responseFromServer);
                // var fdp = new FDP() {  IsMain=true,IsTemplate=true, DutyType=1165,Remark=DateTime.Now.ToString() };
                // this.context.FDPs.Add(fdp);
                // await this.context.SaveChangesAsync();
                var result = new SunFlightResult()
                {
                    distance_km = Convert.ToDouble(myObject.flight_segments[0].distance_km),
                    percent_night = Convert.ToDouble(myObject.flight_segments[0].flight_stats.percent_night),
                    total_minutes = Convert.ToDouble(myObject.flight_segments[0].flight_stats.total_minutes),
                    total_minutes_night = Convert.ToDouble(myObject.flight_segments[0].flight_stats.total_minutes_night),
                };
                result.total_minutes_day = result.total_minutes - result.total_minutes_night;
                return result;
            }
            catch (Exception ex)
            {
                var msg = ex.Message;
                if (ex.InnerException != null)
                    msg += "_______" + ex.InnerException.Message;
                return new
                {
                    MESSAGE = msg
                };
            }

        }

        internal async Task<CustomActionResult> UpdateCPFDP(int id)
        {
            var fdp = await this.context.FDPs.FirstOrDefaultAsync(q => q.Id == id);
            var temp = await this.context.FDPs.FirstOrDefaultAsync(q => q.Id == fdp.TemplateId);
            var fdpItems = await this.context.FDPItems.Where(q => q.FDPId == id).ToListAsync();
            var tempItems = await this.context.FDPItems.Where(q => q.FDPId == temp.Id).ToListAsync();
            var flights = await this.context.FlightInformations.Where(q => q.CPFDPId == id).OrderBy(q => q.STD).ToListAsync();

            this.context.FDPItems.RemoveRange(fdpItems);
            this.context.FDPItems.RemoveRange(tempItems);

            foreach (var x in flights)
            {
                fdp.FDPItems.Add(new FDPItem()
                {
                    FlightId = x.ID,
                    IsPositioning = x.CPDH == null ? false : (bool)x.CPDH,
                    IsSector = x.CPDH == null ? true : !(bool)x.CPDH,
                    PositionId = x.CPPositionId,

                });
                temp.FDPItems.Add(new FDPItem()
                {
                    FlightId = x.ID,
                    IsPositioning = x.CPDH == null ? false : (bool)x.CPDH,
                    IsSector = x.CPDH == null ? true : !(bool)x.CPDH,
                    PositionId = x.CPPositionId,

                });
            }

            var breakGreaterThan10Hours = string.Empty;
            if (flights.Count > 1)
            {
                for (int i = 1; i < flights.Count; i++)
                {
                    var dt = (DateTime)flights[i].STD - (DateTime)flights[i - 1].STA;
                    var minuts = dt.TotalMinutes;
                    // – (0:30 + 0:15 + 0:45)
                    var brk = minuts - 30 - 60; //30:travel time, post flight duty:15, pre flight duty:30
                    if (brk >= 600)
                    {
                        //var tfi = tflights.FirstOrDefault(q => q.ID == flights[i].ID);
                        // var tfi1 = tflights.FirstOrDefault(q => q.ID == flights[i - 1].ID);
                        breakGreaterThan10Hours = "The break is greater than 10 hours.";
                    }

                    else
                    if (brk >= 180)
                    {
                        var fdpitem = fdp.FDPItems.FirstOrDefault(q => q.FlightId == flights[i].ID);
                        fdpitem.SplitDuty = true;
                        var pair = fdp.FDPItems.FirstOrDefault(q => q.FlightId == flights[i - 1].ID);
                        pair.SplitDuty = true;
                        fdpitem.SplitDutyPairId = pair.FlightId;
                        ////////////////////////////////////////////////////
                        var fdpitem2 = temp.FDPItems.FirstOrDefault(q => q.FlightId == flights[i].ID);
                        fdpitem2.SplitDuty = true;
                        var pair2 = temp.FDPItems.FirstOrDefault(q => q.FlightId == flights[i - 1].ID);
                        pair2.SplitDuty = true;
                        fdpitem2.SplitDutyPairId = pair2.FlightId;

                    }
                }
            }
            //  if (!string.IsNullOrEmpty(breakGreaterThan10Hours))
            //  {
            //     this.context.FlightInformations.Remove(entity);
            //      saveResult = await context.SaveAsync();
            //      return new CustomActionResult(HttpStatusCode.NotAcceptable, breakGreaterThan10Hours);
            //  }
            //sooli
            temp.FirstFlightId = flights.First().ID;
            temp.LastFlightId = flights.Last().ID;
            fdp.FirstFlightId = flights.First().ID;
            fdp.LastFlightId = flights.Last().ID;
            if (fdp.ReportingTime != null && fdp.ReportingTime >= flights.First().STD)
            {
                fdp.ReportingTime = null;
                temp.ReportingTime = null;
            }
            fdp.UPD = fdp.UPD == null ? 1 : ((int)fdp.UPD) + 1;
            var saveResult = await context.SaveAsync();
            if (saveResult.Code != HttpStatusCode.OK)
                return saveResult;
            var viewfdp = await this.context.ViewFDPFlightDetails.FirstOrDefaultAsync(q => q.Id == fdp.Id);
            return new CustomActionResult(HttpStatusCode.OK, new { viewfdp });
        }


        internal async Task<CustomActionResult> UpdateCPFDPByFlight(int id)
        {
            var fdpIds = await this.context.FDPItems.Where(q => q.FlightId == id).Select(q => q.FDPId).ToListAsync();
            var _fdps = await this.context.FDPs.Where(q => fdpIds.Contains(q.Id)).ToListAsync();
            var fdp = _fdps.First(q => q.IsMain == null || q.IsMain == false); //await this.context.FDPs.FirstOrDefaultAsync(q => q.Id == dto.CPFDPId);
            var temp = _fdps.First(q => q.IsMain == true); //await this.context.FDPs.FirstOrDefaultAsync(q => q.Id == fdp.TemplateId);
            var fdpItems = await this.context.FDPItems.Where(q => q.FDPId == fdp.Id).ToListAsync();
            var tempItems = await this.context.FDPItems.Where(q => q.FDPId == temp.Id).ToListAsync();
            var flights = await this.context.FlightInformations.Where(q => q.CPFDPId == fdp.Id).OrderBy(q => q.STD).ToListAsync();

            this.context.FDPItems.RemoveRange(fdpItems);
            this.context.FDPItems.RemoveRange(tempItems);

            foreach (var x in flights)
            {
                fdp.FDPItems.Add(new FDPItem()
                {
                    FlightId = x.ID,
                    IsPositioning = x.CPDH == null ? false : (bool)x.CPDH,
                    IsSector = x.CPDH == null ? true : !(bool)x.CPDH,
                    PositionId = x.CPPositionId,

                });
                temp.FDPItems.Add(new FDPItem()
                {
                    FlightId = x.ID,
                    IsPositioning = x.CPDH == null ? false : (bool)x.CPDH,
                    IsSector = x.CPDH == null ? true : !(bool)x.CPDH,
                    PositionId = x.CPPositionId,

                });
            }

            var breakGreaterThan10Hours = string.Empty;
            if (flights.Count > 1)
            {
                for (int i = 1; i < flights.Count; i++)
                {
                    var dt = (DateTime)flights[i].STD - (DateTime)flights[i - 1].STA;
                    var minuts = dt.TotalMinutes;
                    // – (0:30 + 0:15 + 0:45)
                    var brk = minuts - 30 - 60; //30:travel time, post flight duty:15, pre flight duty:30
                    if (brk >= 600)
                    {
                        //var tfi = tflights.FirstOrDefault(q => q.ID == flights[i].ID);
                        // var tfi1 = tflights.FirstOrDefault(q => q.ID == flights[i - 1].ID);
                        breakGreaterThan10Hours = "The break is greater than 10 hours.";
                    }

                    else
                    if (brk >= 180)
                    {
                        var fdpitem = fdp.FDPItems.FirstOrDefault(q => q.FlightId == flights[i].ID);
                        fdpitem.SplitDuty = true;
                        var pair = fdp.FDPItems.FirstOrDefault(q => q.FlightId == flights[i - 1].ID);
                        pair.SplitDuty = true;
                        fdpitem.SplitDutyPairId = pair.FlightId;
                        ////////////////////////////////////////////////////
                        var fdpitem2 = temp.FDPItems.FirstOrDefault(q => q.FlightId == flights[i].ID);
                        fdpitem2.SplitDuty = true;
                        var pair2 = temp.FDPItems.FirstOrDefault(q => q.FlightId == flights[i - 1].ID);
                        pair2.SplitDuty = true;
                        fdpitem2.SplitDutyPairId = pair2.FlightId;

                    }
                }
            }
            if (!string.IsNullOrEmpty(breakGreaterThan10Hours))
            {
                //this.context.FlightInformations.Remove(entity);
                //saveResult = await context.SaveAsync();
                //return new CustomActionResult(HttpStatusCode.NotAcceptable, breakGreaterThan10Hours);
            }
            //sooli
            temp.FirstFlightId = flights.First().ID;
            temp.LastFlightId = flights.Last().ID;
            fdp.FirstFlightId = flights.First().ID;
            fdp.LastFlightId = flights.Last().ID;

            //var defReporting = ((DateTime)flights.First().STD).AddHours(-1);

            if (fdp.ReportingTime != null && fdp.ReportingTime >= flights.First().STD)
            {
                fdp.ReportingTime = null;
                temp.ReportingTime = null;
            }

            fdp.UPD = fdp.UPD == null ? 1 : ((int)fdp.UPD) + 1;
            var saveResult = await context.SaveAsync();
            if (saveResult.Code != HttpStatusCode.OK)
                return saveResult;

            return new CustomActionResult(HttpStatusCode.OK, fdp);
        }

        internal async Task<CustomActionResult> AddFlightToFDP(ViewModels.FlightDto dto)
        {

            // ADD FLIGHT
            var entity = new FlightInformation();
            #region flight
            entity.ID = -1;
            entity.TypeID = dto.TypeID;
            //entity.RegisterID = flightinformation.RegisterID;
            entity.CPRegister = dto.CPRegister;
            entity.FlightTypeID = dto.FlightTypeID;
            entity.FlightStatusID = dto.FlightStatusID;
            entity.AirlineOperatorsID = dto.AirlineOperatorsID;

            entity.FlightNumber = dto.FlightNumber;
            entity.FromAirportId = dto.FromAirportId;
            entity.ToAirportId = dto.ToAirportId;
            entity.STD = dto.STD;
            entity.STA = dto.STA;
            entity.ChocksOut = dto.ChocksOut;
            entity.Takeoff = dto.Takeoff;
            entity.Landing = dto.Landing;
            entity.ChocksIn = dto.ChocksIn;

            // entity.CustomerId = flightinformation.CustomerId;

            entity.DateCreate = DateTime.Now;
            entity.PFLR = dto.PFLR;
            entity.CPPositionId = dto.CPPositionId;
            entity.CPFlightTypeId = dto.CPFlightTypeId;
            entity.CPCrewId = dto.CPCrewId;
            entity.CPDH = dto.CPDH;
            entity.CPFDPId = dto.CPFDPId;
            entity.CPInstructor = dto.CPInstructor;
            entity.CPP1 = dto.CPP1;
            entity.CPP2 = dto.CPP2;
            entity.CPISCCM = dto.CPISCCM;
            entity.CPSCCM = dto.CPSCCM;
            entity.NightTime = dto.NightTime;

            this.context.FlightInformations.Add(entity);
            var saveResult = await context.SaveAsync();
            if (saveResult.Code != HttpStatusCode.OK)
                return saveResult;
            #endregion
            // var fair = await this.context.Airports.FirstOrDefaultAsync(q => q.Id == entity.FromAirportId && q.Latitude != null && q.Longitude != null);
            //   var tair = await this.context.Airports.FirstOrDefaultAsync(q => q.Id == entity.ToAirportId && q.Latitude != null && q.Longitude != null);
            // if (fair != null && tair != null)
            //  {
            //      await GetSun(fair.Id, ((DateTime)entity.STD).Date);
            //      await GetSun(tair.Id, ((DateTime)entity.STA).Date);
            //  }

            #region FDP
            //var fdp = await this.context.FDPs.FirstOrDefaultAsync(q => q.Id == dto.CPFDPId);
            //var temp = await this.context.FDPs.FirstOrDefaultAsync(q => q.Id == fdp.TemplateId);
            //var fdpItems = await this.context.FDPItems.Where(q => q.FDPId == dto.CPFDPId).ToListAsync();
            //var tempItems = await this.context.FDPItems.Where(q => q.FDPId == temp.Id).ToListAsync();
            //var flights = await this.context.FlightInformations.Where(q => q.CPFDPId == dto.CPFDPId).OrderBy(q => q.STD).ToListAsync();

            //this.context.FDPItems.RemoveRange(fdpItems);
            //this.context.FDPItems.RemoveRange(tempItems);

            //foreach (var x in flights)
            //{
            //    fdp.FDPItems.Add(new FDPItem()
            //    {
            //        FlightId = x.ID,
            //        IsPositioning = x.CPDH == null ? false : (bool)x.CPDH,
            //        IsSector = x.CPDH == null ? true : !(bool)x.CPDH,
            //        PositionId = x.CPPositionId,

            //    });
            //    temp.FDPItems.Add(new FDPItem()
            //    {
            //        FlightId = x.ID,
            //        IsPositioning = x.CPDH == null ? false : (bool)x.CPDH,
            //        IsSector = x.CPDH == null ? true : !(bool)x.CPDH,
            //        PositionId = x.CPPositionId,

            //    });
            //}

            //var breakGreaterThan10Hours = string.Empty;
            //if (flights.Count > 1)
            //{
            //    for (int i = 1; i < flights.Count; i++)
            //    {
            //        var dt = (DateTime)flights[i].STD - (DateTime)flights[i - 1].STA;
            //        var minuts = dt.TotalMinutes;

            //        var brk = minuts - 30 - 60; //30:travel time, post flight duty:15, pre flight duty:30
            //        if (brk >= 600)
            //        {

            //            breakGreaterThan10Hours = "The break is greater than 10 hours.";
            //        }

            //        else
            //        if (brk >= 180)
            //        {
            //            var fdpitem = fdp.FDPItems.FirstOrDefault(q => q.FlightId == flights[i].ID);
            //            fdpitem.SplitDuty = true;
            //            var pair = fdp.FDPItems.FirstOrDefault(q => q.FlightId == flights[i - 1].ID);
            //            pair.SplitDuty = true;
            //            fdpitem.SplitDutyPairId = pair.FlightId;
            //            ////////////////////////////////////////////////////
            //            var fdpitem2 = temp.FDPItems.FirstOrDefault(q => q.FlightId == flights[i].ID);
            //            fdpitem2.SplitDuty = true;
            //            var pair2 = temp.FDPItems.FirstOrDefault(q => q.FlightId == flights[i - 1].ID);
            //            pair2.SplitDuty = true;
            //            fdpitem2.SplitDutyPairId = pair2.FlightId;

            //        }
            //    }
            //}
            //if (!string.IsNullOrEmpty(breakGreaterThan10Hours))
            //{
            //    this.context.FlightInformations.Remove(entity);
            //    saveResult = await context.SaveAsync();
            //    return new CustomActionResult(HttpStatusCode.NotAcceptable, breakGreaterThan10Hours);
            //}
            ////sooli
            //temp.FirstFlightId = flights.First().ID;
            //temp.LastFlightId = flights.Last().ID;
            //fdp.FirstFlightId = flights.First().ID;
            //fdp.LastFlightId = flights.Last().ID;
            //fdp.UPD = fdp.UPD == null ? 1 : ((int)fdp.UPD) + 1;
            //saveResult = await context.SaveAsync();
            //if (saveResult.Code != HttpStatusCode.OK)
            //    return saveResult;
            #endregion


            // var viewfdp = await this.context.ViewFDPFlightDetails.FirstOrDefaultAsync(q => q.Id == fdp.Id);
            //var viewflight = await this.context.ViewFlightInformations.FirstOrDefaultAsync(q => q.ID == entity.ID);

            //return new CustomActionResult(HttpStatusCode.OK, new {
            //    viewfdp,
            //    entity
            //});
            return new CustomActionResult(HttpStatusCode.OK, new {/* viewfdp,*/ viewflight = dto });
        }
        internal async Task<CustomActionResult> UpdateFlightCPDirect(ViewModels.FlightDto dto)
        {

            // ADD FLIGHT
            var entity = await this.context.FlightInformations.FirstOrDefaultAsync(q => q.ID == dto.ID);

            //var fdpIds = await this.context.FDPItems.Where(q => q.FlightId == dto.ID).Select(q => q.FDPId).ToListAsync();
            //var _fdps = await this.context.FDPs.Where(q => fdpIds.Contains(q.Id)).ToListAsync();
            //var fdp = _fdps.First(q => q.IsMain == null || q.IsMain == false); //await this.context.FDPs.FirstOrDefaultAsync(q => q.Id == dto.CPFDPId);
            var std = entity.STD != dto.STD;

            entity.TypeID = dto.TypeID;
            //entity.RegisterID = flightinformation.RegisterID;
            entity.CPRegister = dto.CPRegister;
            entity.FlightTypeID = dto.FlightTypeID;
            entity.FlightStatusID = dto.FlightStatusID;
            entity.AirlineOperatorsID = dto.AirlineOperatorsID;

            entity.FlightNumber = dto.FlightNumber;
            entity.FromAirportId = dto.FromAirportId;
            entity.ToAirportId = dto.ToAirportId;
            entity.STD = dto.STD;
            entity.STA = dto.STA;
            entity.ChocksOut = dto.ChocksOut;
            entity.Takeoff = dto.Takeoff;
            entity.Landing = dto.Landing;
            entity.ChocksIn = dto.ChocksIn;

            // entity.CustomerId = flightinformation.CustomerId;

            entity.DateCreate = DateTime.Now;
            entity.PFLR = dto.PFLR;
            entity.CPPositionId = dto.CPPositionId;
            entity.CPFlightTypeId = dto.CPFlightTypeId;
            entity.CPCrewId = dto.CPCrewId;
            entity.CPDH = dto.CPDH;
            entity.CPInstructor = dto.CPInstructor;
            entity.CPP1 = dto.CPP1;
            entity.CPP2 = dto.CPP2;
            entity.CPISCCM = dto.CPISCCM;
            entity.CPSCCM = dto.CPSCCM;
            entity.NightTime = dto.NightTime;
            // entity.CPFDPId = fdp.Id;

            //this.context.FlightInformations.Add(entity);
            var saveResult = await context.SaveAsync();
            if (saveResult.Code != HttpStatusCode.OK)
                return saveResult;
            if (std)
                await UpdateCPFDPByFlight(dto.ID);
            //  var fair = await this.context.Airports.FirstOrDefaultAsync(q => q.Id == entity.FromAirportId && q.Latitude != null && q.Longitude != null);
            //   var tair = await this.context.Airports.FirstOrDefaultAsync(q => q.Id == entity.ToAirportId && q.Latitude != null && q.Longitude != null);
            //  if (fair != null && tair != null)
            //   {
            //       await GetSun(fair.Id, ((DateTime)entity.STD).Date);
            //       await GetSun(tair.Id, ((DateTime)entity.STA).Date);
            //   }

            //_fdps
            ///////////////////////////////////////////
            //var temp = _fdps.First(q => q.IsMain == true); //await this.context.FDPs.FirstOrDefaultAsync(q => q.Id == fdp.TemplateId);
            //var fdpItems = await this.context.FDPItems.Where(q => q.FDPId == fdp.Id).ToListAsync();
            //var tempItems = await this.context.FDPItems.Where(q => q.FDPId == temp.Id).ToListAsync();
            //var flights = await this.context.FlightInformations.Where(q => q.CPFDPId == fdp.Id).OrderBy(q => q.STD).ToListAsync();

            //this.context.FDPItems.RemoveRange(fdpItems);
            //this.context.FDPItems.RemoveRange(tempItems);

            //foreach (var x in flights)
            //{
            //    fdp.FDPItems.Add(new FDPItem()
            //    {
            //        FlightId = x.ID,
            //        IsPositioning = x.CPDH == null ? false : (bool)x.CPDH,
            //        IsSector = x.CPDH == null ? true : !(bool)x.CPDH,
            //        PositionId = x.CPPositionId,

            //    });
            //    temp.FDPItems.Add(new FDPItem()
            //    {
            //        FlightId = x.ID,
            //        IsPositioning = x.CPDH == null ? false : (bool)x.CPDH,
            //        IsSector = x.CPDH == null ? true : !(bool)x.CPDH,
            //        PositionId = x.CPPositionId,

            //    });
            //}

            //var breakGreaterThan10Hours = string.Empty;
            //if (flights.Count > 1)
            //{
            //    for (int i = 1; i < flights.Count; i++)
            //    {
            //        var dt = (DateTime)flights[i].STD - (DateTime)flights[i - 1].STA;
            //        var minuts = dt.TotalMinutes;
            //        // – (0:30 + 0:15 + 0:45)
            //        var brk = minuts - 30 - 60; //30:travel time, post flight duty:15, pre flight duty:30
            //        if (brk >= 600)
            //        {
            //            //var tfi = tflights.FirstOrDefault(q => q.ID == flights[i].ID);
            //            // var tfi1 = tflights.FirstOrDefault(q => q.ID == flights[i - 1].ID);
            //            breakGreaterThan10Hours = "The break is greater than 10 hours.";
            //        }

            //        else
            //        if (brk >= 180)
            //        {
            //            var fdpitem = fdp.FDPItems.FirstOrDefault(q => q.FlightId == flights[i].ID);
            //            fdpitem.SplitDuty = true;
            //            var pair = fdp.FDPItems.FirstOrDefault(q => q.FlightId == flights[i - 1].ID);
            //            pair.SplitDuty = true;
            //            fdpitem.SplitDutyPairId = pair.FlightId;
            //            ////////////////////////////////////////////////////
            //            var fdpitem2 = temp.FDPItems.FirstOrDefault(q => q.FlightId == flights[i].ID);
            //            fdpitem2.SplitDuty = true;
            //            var pair2 = temp.FDPItems.FirstOrDefault(q => q.FlightId == flights[i - 1].ID);
            //            pair2.SplitDuty = true;
            //            fdpitem2.SplitDutyPairId = pair2.FlightId;

            //        }
            //    }
            //}
            //if (!string.IsNullOrEmpty(breakGreaterThan10Hours))
            //{
            //    //this.context.FlightInformations.Remove(entity);
            //    //saveResult = await context.SaveAsync();
            //    //return new CustomActionResult(HttpStatusCode.NotAcceptable, breakGreaterThan10Hours);
            //}
            ////sooli
            //temp.FirstFlightId = flights.First().ID;
            //temp.LastFlightId = flights.Last().ID;
            //fdp.FirstFlightId = flights.First().ID;
            //fdp.LastFlightId = flights.Last().ID;

            ////var defReporting = ((DateTime)flights.First().STD).AddHours(-1);

            //if (fdp.ReportingTime != null && fdp.ReportingTime >= flights.First().STD)
            //{
            //    fdp.ReportingTime = null;
            //    temp.ReportingTime = null;
            //}

            //fdp.UPD = fdp.UPD == null ? 1 : ((int)fdp.UPD) + 1;
            //saveResult = await context.SaveAsync();
            //if (saveResult.Code != HttpStatusCode.OK)
            //    return saveResult;
            //var viewfdp = await this.context.ViewFDPFlightDetails.FirstOrDefaultAsync(q => q.Id == fdp.Id);
            //var viewflight = await this.context.ViewFlightInformations.FirstOrDefaultAsync(q => q.ID == entity.ID);

            //return new CustomActionResult(HttpStatusCode.OK, new {
            //    viewfdp,
            //    entity
            //});
            return new CustomActionResult(HttpStatusCode.OK, new { /*viewfdp,*/  viewflight = dto });
        }




        internal async Task<CustomActionResult> UpdateFlightToFDP(ViewModels.FlightDto dto)
        {

            // ADD FLIGHT
            var entity = await this.context.FlightInformations.FirstOrDefaultAsync(q => q.ID == dto.ID);

            bool std = entity.STD != dto.STD;

            entity.TypeID = dto.TypeID;
            //entity.RegisterID = flightinformation.RegisterID;
            entity.CPRegister = dto.CPRegister;
            entity.FlightTypeID = dto.FlightTypeID;
            entity.FlightStatusID = dto.FlightStatusID;
            entity.AirlineOperatorsID = dto.AirlineOperatorsID;

            entity.FlightNumber = dto.FlightNumber;
            entity.FromAirportId = dto.FromAirportId;
            entity.ToAirportId = dto.ToAirportId;
            entity.STD = dto.STD;
            entity.STA = dto.STA;
            entity.ChocksOut = dto.ChocksOut;
            entity.Takeoff = dto.Takeoff;
            entity.Landing = dto.Landing;
            entity.ChocksIn = dto.ChocksIn;

            // entity.CustomerId = flightinformation.CustomerId;

            entity.DateCreate = DateTime.Now;
            entity.PFLR = dto.PFLR;
            entity.CPPositionId = dto.CPPositionId;
            entity.CPFlightTypeId = dto.CPFlightTypeId;
            entity.CPCrewId = dto.CPCrewId;
            entity.CPDH = dto.CPDH;
            entity.CPFDPId = dto.CPFDPId;
            entity.CPInstructor = dto.CPInstructor;
            entity.CPP1 = dto.CPP1;
            entity.CPP2 = dto.CPP2;
            entity.CPISCCM = dto.CPISCCM;
            entity.CPSCCM = dto.CPSCCM;
            entity.NightTime = dto.NightTime;

            //this.context.FlightInformations.Add(entity);
            var saveResult = await context.SaveAsync();
            if (saveResult.Code != HttpStatusCode.OK)
                return saveResult;

            // var fair = await this.context.Airports.FirstOrDefaultAsync(q => q.Id == entity.FromAirportId && q.Latitude != null && q.Longitude != null);
            //  var tair = await this.context.Airports.FirstOrDefaultAsync(q => q.Id == entity.ToAirportId && q.Latitude != null && q.Longitude != null);
            // if (fair != null && tair != null)
            // {
            //      await GetSun(fair.Id, ((DateTime)entity.STD).Date);
            //      await GetSun(tair.Id, ((DateTime)entity.STA).Date);
            //  }


            //var fdp = await this.context.FDPs.FirstOrDefaultAsync(q => q.Id == dto.CPFDPId);
            //var temp = await this.context.FDPs.FirstOrDefaultAsync(q => q.Id == fdp.TemplateId);
            //var fdpItems = await this.context.FDPItems.Where(q => q.FDPId == dto.CPFDPId).ToListAsync();
            //var tempItems = await this.context.FDPItems.Where(q => q.FDPId == temp.Id).ToListAsync();
            //var flights = await this.context.FlightInformations.Where(q => q.CPFDPId == dto.CPFDPId).OrderBy(q => q.STD).ToListAsync();

            //this.context.FDPItems.RemoveRange(fdpItems);
            //this.context.FDPItems.RemoveRange(tempItems);

            //foreach (var x in flights)
            //{
            //    fdp.FDPItems.Add(new FDPItem()
            //    {
            //        FlightId = x.ID,
            //        IsPositioning = x.CPDH == null ? false : (bool)x.CPDH,
            //        IsSector = x.CPDH == null ? true : !(bool)x.CPDH,
            //        PositionId = x.CPPositionId,

            //    });
            //    temp.FDPItems.Add(new FDPItem()
            //    {
            //        FlightId = x.ID,
            //        IsPositioning = x.CPDH == null ? false : (bool)x.CPDH,
            //        IsSector = x.CPDH == null ? true : !(bool)x.CPDH,
            //        PositionId = x.CPPositionId,

            //    });
            //}

            //var breakGreaterThan10Hours = string.Empty;
            //if (flights.Count > 1)
            //{
            //    for (int i = 1; i < flights.Count; i++)
            //    {
            //        var dt = (DateTime)flights[i].STD - (DateTime)flights[i - 1].STA;
            //        var minuts = dt.TotalMinutes;
            //        // – (0:30 + 0:15 + 0:45)
            //        var brk = minuts - 30 - 60; //30:travel time, post flight duty:15, pre flight duty:30
            //        if (brk >= 600)
            //        {
            //            //var tfi = tflights.FirstOrDefault(q => q.ID == flights[i].ID);
            //            // var tfi1 = tflights.FirstOrDefault(q => q.ID == flights[i - 1].ID);
            //            breakGreaterThan10Hours = "The break is greater than 10 hours.";
            //        }

            //        else
            //        if (brk >= 180)
            //        {
            //            var fdpitem = fdp.FDPItems.FirstOrDefault(q => q.FlightId == flights[i].ID);
            //            fdpitem.SplitDuty = true;
            //            var pair = fdp.FDPItems.FirstOrDefault(q => q.FlightId == flights[i - 1].ID);
            //            pair.SplitDuty = true;
            //            fdpitem.SplitDutyPairId = pair.FlightId;
            //            ////////////////////////////////////////////////////
            //            var fdpitem2 = temp.FDPItems.FirstOrDefault(q => q.FlightId == flights[i].ID);
            //            fdpitem2.SplitDuty = true;
            //            var pair2 = temp.FDPItems.FirstOrDefault(q => q.FlightId == flights[i - 1].ID);
            //            pair2.SplitDuty = true;
            //            fdpitem2.SplitDutyPairId = pair2.FlightId;

            //        }
            //    }
            //}
            //if (!string.IsNullOrEmpty(breakGreaterThan10Hours))
            //{
            //    //this.context.FlightInformations.Remove(entity);
            //    //saveResult = await context.SaveAsync();
            //    //return new CustomActionResult(HttpStatusCode.NotAcceptable, breakGreaterThan10Hours);
            //}
            ////sooli
            //temp.FirstFlightId = flights.First().ID;
            //temp.LastFlightId = flights.Last().ID;
            //fdp.FirstFlightId = flights.First().ID;
            //fdp.LastFlightId = flights.Last().ID;

            ////var defReporting = ((DateTime)flights.First().STD).AddHours(-1);

            //if (fdp.ReportingTime != null && fdp.ReportingTime >= flights.First().STD)
            //{
            //    fdp.ReportingTime = null;
            //    temp.ReportingTime = null;
            //}

            //fdp.UPD = fdp.UPD == null ? 1 : ((int)fdp.UPD) + 1;
            //saveResult = await context.SaveAsync();
            //if (saveResult.Code != HttpStatusCode.OK)
            //    return saveResult;
            //var viewfdp = await this.context.ViewFDPFlightDetails.FirstOrDefaultAsync(q => q.Id == fdp.Id);
            //var viewflight = await this.context.ViewFlightInformations.FirstOrDefaultAsync(q => q.ID == entity.ID);

            //return new CustomActionResult(HttpStatusCode.OK, new {
            //    viewfdp,
            //    entity
            //});
            return new CustomActionResult(HttpStatusCode.OK, new { /*viewfdp,*/ viewflight = dto, std });
        }

        internal async Task<CustomActionResult> UpdateCPFlightStatus(ViewModels.FlightDto dto)
        {
            var entity = await this.context.FlightInformations.FirstOrDefaultAsync(q => q.ID == dto.ID);
            entity.FlightStatusID = dto.FlightStatusID;
            entity.STD = dto.STD;
            entity.STA = dto.STA;
            entity.ChocksOut = dto.ChocksOut;
            entity.Takeoff = dto.Takeoff;
            entity.Landing = dto.Landing;
            entity.ChocksIn = dto.ChocksIn;
            var saveResult = await this.context.SaveAsync();
            if (saveResult.Code != HttpStatusCode.OK)
                return null;

            var viewfdp = await this.context.ViewFDPFlightDetails.FirstOrDefaultAsync(q => q.Id == entity.CPFDPId);
            var viewflight = await this.context.ViewFlightInformations.FirstOrDefaultAsync(q => q.ID == entity.ID);

            return new CustomActionResult(HttpStatusCode.OK, new { viewfdp, viewflight });
        }
        //internal async Task<bool> RemoveEmptyFDPs(int crewid) {
        //    var items=await this.context
        //}
        internal async Task<CustomActionResult> RemoveFlightFromFDP(int flightId)
        {

            var entity = await this.context.FlightInformations.FirstOrDefaultAsync(q => q.ID == flightId);
            var fdp = await this.context.FDPs.FirstOrDefaultAsync(q => q.Id == entity.CPFDPId);
            var temp = await this.context.FDPs.FirstOrDefaultAsync(q => q.Id == fdp.TemplateId);
            var fdpItems = await this.context.FDPItems.Where(q => q.FDPId == fdp.Id).ToListAsync();
            var tempItems = await this.context.FDPItems.Where(q => q.FDPId == temp.Id).ToListAsync();
            var flights = await this.context.FlightInformations.Where(q => q.CPFDPId == fdp.Id).OrderBy(q => q.STD).ToListAsync();
            flights = flights.Where(q => q.ID != entity.ID).OrderBy(q => q.STD).ToList();

            CustomActionResult saveResult = null;
            this.context.FlightInformations.Remove(entity);
            this.context.FDPItems.RemoveRange(fdpItems);
            this.context.FDPItems.RemoveRange(tempItems);

            foreach (var x in flights)
            {
                fdp.FDPItems.Add(new FDPItem()
                {
                    FlightId = x.ID,
                    IsPositioning = x.CPDH == null ? false : (bool)x.CPDH,
                    IsSector = x.CPDH == null ? true : !(bool)x.CPDH,
                    PositionId = x.CPPositionId,

                });
                temp.FDPItems.Add(new FDPItem()
                {
                    FlightId = x.ID,
                    IsPositioning = x.CPDH == null ? false : (bool)x.CPDH,
                    IsSector = x.CPDH == null ? true : !(bool)x.CPDH,
                    PositionId = x.CPPositionId,

                });
            }
            fdp.Split = 0;
            temp.Split = 0;
            var breakGreaterThan10Hours = string.Empty;
            if (flights.Count > 1)
            {
                temp.FirstFlightId = flights.First().ID;
                temp.LastFlightId = flights.Last().ID;
                fdp.FirstFlightId = flights.First().ID;
                fdp.LastFlightId = flights.Last().ID;
                for (int i = 1; i < flights.Count; i++)
                {
                    var dt = (DateTime)flights[i].STD - (DateTime)flights[i - 1].STA;
                    var minuts = dt.TotalMinutes;
                    // – (0:30 + 0:15 + 0:45)
                    var brk = minuts - 30 - 60; //30:travel time, post flight duty:15, pre flight duty:30
                    if (brk >= 600)
                    {
                        //var tfi = tflights.FirstOrDefault(q => q.ID == flights[i].ID);
                        // var tfi1 = tflights.FirstOrDefault(q => q.ID == flights[i - 1].ID);
                        breakGreaterThan10Hours = "The break is greater than 10 hours.";
                    }

                    else
                    if (brk >= 180)
                    {
                        var fdpitem = fdp.FDPItems.FirstOrDefault(q => q.FlightId == flights[i].ID);
                        fdpitem.SplitDuty = true;
                        var pair = fdp.FDPItems.FirstOrDefault(q => q.FlightId == flights[i - 1].ID);
                        pair.SplitDuty = true;
                        fdpitem.SplitDutyPairId = pair.FlightId;
                        fdp.Split = 0.5 * (brk);
                        ////////////////////////////////////////////////////
                        var fdpitem2 = temp.FDPItems.FirstOrDefault(q => q.FlightId == flights[i].ID);
                        fdpitem2.SplitDuty = true;
                        var pair2 = temp.FDPItems.FirstOrDefault(q => q.FlightId == flights[i - 1].ID);
                        pair2.SplitDuty = true;
                        fdpitem2.SplitDutyPairId = pair2.FlightId;

                    }
                }
            }
            else
            {
                temp.FirstFlightId = null;
                temp.LastFlightId = null;
                fdp.FirstFlightId = null;
                fdp.LastFlightId = null;

                temp.ReportingTime = null;
                temp.FDPReportingTime = null;
                fdp.FDPReportingTime = null;
                fdp.ReportingTime = null;
            }
            //if (!string.IsNullOrEmpty(breakGreaterThan10Hours))
            //{
            //    this.context.FlightInformations.Remove(entity);
            //    saveResult = await context.SaveAsync();
            //    return new CustomActionResult(HttpStatusCode.NotAcceptable, breakGreaterThan10Hours);
            //}
            //sooli

            temp.UPD = temp.UPD == null ? 1 : ((int)temp.UPD) + 1;
            fdp.UPD = fdp.UPD == null ? 1 : ((int)fdp.UPD) + 1;
            saveResult = await context.SaveAsync();
            if (saveResult.Code != HttpStatusCode.OK)
                return saveResult;
            var viewfdp = await this.context.ViewFDPFlightDetails.FirstOrDefaultAsync(q => q.Id == fdp.Id);
            var viewflight = await this.context.ViewFlightInformations.FirstOrDefaultAsync(q => q.ID == entity.ID);

            //return new CustomActionResult(HttpStatusCode.OK, new {
            //    viewfdp,
            //    entity
            //});
            return new CustomActionResult(HttpStatusCode.OK, new { viewfdp, viewflight });
        }


        //sunset sunrise





        internal async Task<string> boxFlights(List<int> ids, bool isMain)
        {
            var flights = await (from x in this.context.FlightInformations
                                 where ids.Contains(x.ID) //&& x.CalendarId == cid
                                 orderby x.STD
                                 select x).ToListAsync();
            var fdp = new FDP()
            {
                IsTemplate = true,
                DutyType = 1165,
                FirstFlightId = flights.First().ID,
                LastFlightId = flights.Last().ID,
                GUID = Guid.NewGuid(),
                IsMain = isMain,

            };
            fdp.FDPItems = new List<FDPItem>();
            foreach (var x in flights)
            {
                fdp.FDPItems.Add(new FDPItem()
                {
                    FlightId = x.ID,
                    IsPositioning = false,
                    IsSector = true,

                });
            }
            var breakGreaterThan10Hours = string.Empty;
            if (flights.Count > 1)
            {
                for (int i = 1; i < flights.Count; i++)
                {
                    var dt = (DateTime)flights[i].STD - (DateTime)flights[i - 1].STA;
                    var minuts = dt.TotalMinutes;
                    // – (0:30 + 0:15 + 0:45)
                    var brk = minuts - 30 - 60; //30:travel time, post flight duty:15, pre flight duty:30
                    if (brk >= 600)
                    {
                        //var tfi = tflights.FirstOrDefault(q => q.ID == flights[i].ID);
                        // var tfi1 = tflights.FirstOrDefault(q => q.ID == flights[i - 1].ID);
                        breakGreaterThan10Hours = "The break is greater than 10 hours.";
                    }

                    else
                    if (brk >= 180)
                    {
                        var fdpitem = fdp.FDPItems.FirstOrDefault(q => q.FlightId == flights[i].ID);
                        fdpitem.SplitDuty = true;
                        var pair = fdp.FDPItems.FirstOrDefault(q => q.FlightId == flights[i - 1].ID);
                        pair.SplitDuty = true;
                        fdpitem.SplitDutyPairId = pair.FlightId;
                        // var tfi = tflights.FirstOrDefault(q => q.ID == flights[i].ID);
                        // tfi.SplitDuty = true;
                        // var tfi1 = tflights.FirstOrDefault(q => q.ID == flights[i - 1].ID);
                        //  tfi1.SplitDuty = true;
                    }
                }
            }
            if (!string.IsNullOrEmpty(breakGreaterThan10Hours))
                return breakGreaterThan10Hours;

            this.context.FDPs.Add(fdp);

            return string.Empty;

        }


        internal async Task<FDP> boxFlights2(List<int> ids, List<int> posIds)
        {
            var flights = await (from x in this.context.FlightInformations
                                 where ids.Contains(x.ID) //&& x.CalendarId == cid
                                 orderby x.STD
                                 select x).ToListAsync();
            var fdp = new FDP()
            {
                IsTemplate = true,
                DutyType = 1165,
                FirstFlightId = flights.First().ID,
                LastFlightId = flights.Last().ID,
                GUID = Guid.NewGuid(),

            };
            fdp.FDPItems = new List<FDPItem>();
            foreach (var x in flights)
            {
                var _fdpItem = new FDPItem()
                {
                    FlightId = x.ID,
                    IsPositioning = false,
                    IsSector = true,

                };
                if (posIds.IndexOf(x.ID) != -1)
                {
                    _fdpItem.IsSector = false;
                    _fdpItem.IsPositioning = true;
                }
                fdp.FDPItems.Add(_fdpItem);

            }
            var breakGreaterThan10Hours = string.Empty;
            if (flights.Count > 1)
            {
                for (int i = 1; i < flights.Count; i++)
                {
                    var dt = (DateTime)flights[i].STD - (DateTime)flights[i - 1].STA;
                    var minuts = dt.TotalMinutes;
                    // – (0:30 + 0:15 + 0:45)
                    var brk = minuts - 30 - 60; //30:travel time, post flight duty:15, pre flight duty:30
                    if (brk >= 600)
                    {
                        //var tfi = tflights.FirstOrDefault(q => q.ID == flights[i].ID);
                        // var tfi1 = tflights.FirstOrDefault(q => q.ID == flights[i - 1].ID);
                        breakGreaterThan10Hours = "The break is greater than 10 hours.";
                    }

                    else
                    if (brk >= 180)
                    {
                        var fdpitem = fdp.FDPItems.FirstOrDefault(q => q.FlightId == flights[i].ID);
                        fdpitem.SplitDuty = true;
                        var pair = fdp.FDPItems.FirstOrDefault(q => q.FlightId == flights[i - 1].ID);
                        pair.SplitDuty = true;
                        fdpitem.SplitDutyPairId = pair.FlightId;
                        // var tfi = tflights.FirstOrDefault(q => q.ID == flights[i].ID);
                        // tfi.SplitDuty = true;
                        // var tfi1 = tflights.FirstOrDefault(q => q.ID == flights[i - 1].ID);
                        //  tfi1.SplitDuty = true;
                    }
                }
            }
            if (!string.IsNullOrEmpty(breakGreaterThan10Hours))
                return null;

            this.context.FDPs.Add(fdp);

            return fdp;

        }
        internal async Task<string> boxFlights(List<int> ids, int cid)
        {

            var flights = await (from x in this.context.ViewFlightInformations
                                 where ids.Contains(x.ID) //&& x.CalendarId == cid
                                 orderby x.STD
                                 select new { x.ID, x.PlanId, x.STA, x.STD, x.ToAirport, x.FromAirport, x.CalendarId }).ToListAsync();





            var fids = flights.Select(q => q.ID).ToList();
            var tflights = await this.context.FlightInformations.Where(q => fids.Contains(q.ID)).OrderBy(q => q.STD).ToListAsync();
            var std = flights.First().STD;
            var sta = flights.Last().STA;
            var from = flights.First().FromAirport;
            var to = flights.Last().ToAirport;

            var breakGreaterThan10Hours = string.Empty;

            if (flights.Count > 1)
            {
                for (int i = 1; i < flights.Count; i++)
                {
                    var dt = (DateTime)flights[i].STD - (DateTime)flights[i - 1].STA;
                    var minuts = dt.TotalMinutes;
                    // – (0:30 + 0:15 + 0:45)
                    var brk = minuts - 30 - 60; //30:travel time, post flight duty:15, pre flight duty:30
                    if (brk >= 600)
                    {
                        //var tfi = tflights.FirstOrDefault(q => q.ID == flights[i].ID);
                        // var tfi1 = tflights.FirstOrDefault(q => q.ID == flights[i - 1].ID);
                        breakGreaterThan10Hours = "The break is greater than 10 hours.";
                    }

                    else
                    if (brk >= 180)
                    {

                        var tfi = tflights.FirstOrDefault(q => q.ID == flights[i].ID);
                        tfi.SplitDuty = true;
                        var tfi1 = tflights.FirstOrDefault(q => q.ID == flights[i - 1].ID);
                        tfi1.SplitDuty = true;
                    }
                }
            }
            if (!string.IsNullOrEmpty(breakGreaterThan10Hours))
                return breakGreaterThan10Hours;
            var box = new Box();
            box.STA = sta;
            box.STD = std;
            box.FromAirportId = from;
            box.ToAirportId = to;
            box.Date = ((DateTime)std).AddMinutes(270).Date;
            box.FlightPlanId = (int)flights.First().PlanId;
            box.CalanderId = cid;
            this.context.Boxes.Add(box);
            var ci = 0;
            foreach (var x in flights)
            {
                var tf = tflights.FirstOrDefault(q => q.ID == x.ID);
                tf.Box = box;
                //x.Box = box;
                var bfp = new BoxFlightPlanItem()
                {
                    CalanderId = cid,
                    ItemId = x.ID,
                    Box = box,
                    SplitDuty = tf.SplitDuty,
                };
                if (bfp.SplitDuty == true && ci > 0)
                {
                    var preitem = tflights[ci - 1];
                    if (preitem.SplitDuty == true)
                        bfp.SplitDutyPairId = preitem.ID;

                }
                this.context.BoxFlightPlanItems.Add(bfp);
                ci++;
            }
            return string.Empty;

        }


        internal async Task<bool> unboxPlanItems(int bid)
        {
            var box = await this.context.Boxes.FirstOrDefaultAsync(q => q.Id == bid);
            this.context.Boxes.Remove(box);
            //var planitems = await this.context.FlightPlanItems.Where(q => q.BoxId==bid).ToListAsync();

            //foreach (var x in planitems)
            //    x.BoxId = null;
            return true;

        }
        internal async Task<bool> unboxFlights(int bid)
        {
            //int noOfRowUpdated = this.context.Database.ExecuteSqlCommand("Update FlightInformation set BoxId = null where BoxId = " + bid);

            //var box = await this.context.Boxes.FirstOrDefaultAsync(q => q.Id == bid);
            //this.context.Boxes.Remove(box);
            var fdp = await this.context.FDPs.FirstOrDefaultAsync(q => q.Id == bid);
            this.context.FDPs.Remove(fdp);
            return true;

        }
        public IQueryable<ViewBoxCrewFlight> GetViewBoxCrewFlights()
        {
            return this.GetQuery<ViewBoxCrewFlight>();
        }
        public IQueryable<ViewCrewTime> GetViewCrewTimes()
        {
            return this.GetQuery<ViewCrewTime>();
        }

        internal async Task<object> GetJLData(int flightId)
        {
            var flight = await this.context.ViewFlightInformations.Where(q => q.ID == flightId).FirstOrDefaultAsync();
            var fdpQuery = from x in this.context.ViewFDPItems
                           join y in this.context.FDPs on x.FDPId equals y.Id
                           where
                           x.FlightId == flightId

                           //x.DepartureDay==flight.Date
                           && y.IsMain == true
                           select y;
            var fdp = await fdpQuery.FirstOrDefaultAsync();
            if (fdp == null)
                return null;
            var maxfdp = await this.context.HelperFDPs.Where(q => q.Id == fdp.Id).Select(q => q.MaxFDP).FirstOrDefaultAsync();
            var maxStr = "";
            if (maxfdp != null)
            {
                TimeSpan span = TimeSpan.FromMinutes((double)maxfdp);
                maxStr = span.ToString(@"hh\:mm");
            }

            var _flights = await (from x in this.context.ViewFDPItems
                                      //join y in this.context.FDPs on x.FDPId equals y.Id
                                      //where y.Id == fdp.Id
                                  where x.DepartureDay == flight.Date && x.Register == flight.Register
                                  orderby x.STD
                                  select x).ToListAsync();
            var flightids = _flights.Select(q => q.FlightId).Distinct().ToList();
            var vflights = await this.context.ViewFlightInformations.Where(q => flightids.Contains(q.ID)).OrderBy(q => q.STD).Select(q => new { q.ID, q.STD, q.FlightNumber, q.FromAirportIATA, q.ToAirportIATA }).ToListAsync();

            //  return unitOfWork.FlightRepository.GetViewFlightCrewNews().Where(q => q.FlightId == id).OrderBy(q=>q.IsPositioning).ThenBy(q => q.GroupOrder);
            //var _crews = await (from x in this.context.ViewFlightCrewNews
            //                    where x.FlightId == flightId
            //                    orderby x.IsPositioning, x.GroupOrder
            //                    select x).ToListAsync();



            //var _crews = await (from x in this.context.ViewFlightCrewNews
            //                        //where x.FlightId == flightId

            //                    where flightids.Contains(x.FlightId)
            //                    orderby x.IsPositioning, x.GroupOrder

            //                    select new CLJLData()
            //                    {
            //                      CrewId=  x.CrewId,
            //                        IsPositioning= x.IsPositioning,
            //                        PositionId=  x.PositionId,
            //                        Position=  x.Position,
            //                        Name=  x.Name,
            //                        GroupId= x.GroupId,
            //                        JobGroup= x.JobGroup,
            //                        JobGroupCode=  x.JobGroupCode,
            //                        GroupOrder= x.GroupOrder,
            //                        IsCockpit=   x.IsCockpit

            //                    }).Distinct().ToListAsync();


            var _crews2 = await (from x in this.context.ViewFlightCrewNews
                                     //where x.FlightId == flightId

                                 where flightids.Contains(x.FlightId) //&& x.IsPositioning != true
                                 orderby x.IsPositioning, x.GroupOrder

                                 select new CLJLData()
                                 {
                                     CrewId = x.CrewId,
                                     IsPositioning = x.IsPositioning,
                                     PositionId = x.PositionId,
                                     Position = x.Position,
                                     Name = x.Name,
                                     GroupId = x.GroupId,
                                     JobGroup = x.JobGroup,
                                     JobGroupCode = x.JobGroupCode,
                                     GroupOrder = x.GroupOrder,
                                     IsCockpit = x.IsCockpit,
                                     FlightId = x.FlightId,

                                 }).ToListAsync();

            var _gcrews = (from x in _crews2
                           group x by new
                           {
                               x.CrewId,
                               x.IsPositioning,
                               x.PositionId,
                               x.Position,
                               x.Name,
                               x.GroupId,
                               x.JobGroup,
                               x.JobGroupCode,
                               x.GroupOrder,
                               x.IsCockpit,
                           } into grp
                           select grp).ToList();
            var query = (from x in _gcrews
                         let xfids = x.Select(q => Convert.ToInt32(q.FlightId)).ToList()
                         select new CLJLData()
                         {
                             CrewId = x.Key.CrewId,
                             IsPositioning = x.Key.IsPositioning,
                             PositionId = x.Key.PositionId,
                             Position = x.Key.Position,
                             Name = x.Key.Name,
                             GroupId = x.Key.GroupId,
                             JobGroup = x.Key.JobGroup,
                             JobGroupCode = x.Key.JobGroupCode,
                             GroupOrder = x.Key.GroupOrder,
                             IsCockpit = x.Key.IsCockpit,
                             Legs = _flights.Where(q => xfids.Contains((int)q.FlightId)).OrderBy(q => q.DepartureLocal).Select(q => q.FlightNumber).Distinct().ToList(),
                             LegsStr = string.Join("-", _flights.Where(q => xfids.Contains((int)q.FlightId)).OrderBy(q => q.DepartureLocal).Select(q => q.FlightNumber).Distinct().ToList()),

                         }).ToList();
            //var _crews = new List<CLJLData>();
            //foreach (var x in _gcrews)
            //{
            //    var xfids = x.Select(q => Convert.ToInt32(q.FlightId)).ToList();
            //    var xflights = _flights.Where(q => xfids.Contains((int)q.FlightId)).OrderBy(q => q.DepartureLocal).ToList();
            //    var item = new CLJLData()
            //    {
            //        CrewId = x.Key.CrewId,

            //    };
            //}

            foreach (var x in query)
            {
                if (x.Legs.Count == flightids.Count)
                    x.LegsStr = "";
            }



            var result = new
            {
                flights = vflights,
                crew = query,//_crews,
                max = maxStr,
            };
            return result;
        }


        internal async Task<object> GetJLData(List<int?> flightIds)
        {
            //var flight = await this.context.ViewFlightInformations.Where(q => q.ID == flightId).FirstOrDefaultAsync();
            //var fdpQuery = from x in this.context.ViewFDPItems
            //               join y in this.context.FDPs on x.FDPId equals y.Id
            //               where
            //               x.FlightId == flightId


            //               && y.IsMain == true
            //               select y;
            //var fdp = await fdpQuery.FirstOrDefaultAsync();
            //if (fdp == null)
            //    return null;
            //var maxfdp = await this.context.HelperFDPs.Where(q => q.Id == fdp.Id).Select(q => q.MaxFDP).FirstOrDefaultAsync();
            //var maxStr = "";
            //if (maxfdp != null)
            //{
            //    TimeSpan span = TimeSpan.FromMinutes((double)maxfdp);
            //    maxStr = span.ToString(@"hh\:mm");
            //}

            //var _flights = await (from x in this.context.ViewFDPItems
            //                          //join y in this.context.FDPs on x.FDPId equals y.Id
            //                          //where y.Id == fdp.Id
            //                      where x.DepartureDay == flight.Date && x.Register == flight.Register
            //                      orderby x.STD
            //                      select x).ToListAsync();
            //var flightids = _flights.Select(q => q.FlightId).Distinct().ToList();

            var vflights = await this.context.ViewFlightInformations.Where(q => flightIds.Contains(q.ID)).OrderBy(q => q.STD).Select(q => new { q.ID, q.STD, q.FlightNumber, q.FromAirportIATA, q.ToAirportIATA, q.DepartureLocal, q.FlightType, q.FlightTypeAbr }).ToListAsync();

            var firstFlight = vflights.First();
            var dep = ((DateTime)firstFlight.DepartureLocal).AddHours(-1);
            var _temp = new DateTime(1900, 1, 1, dep.Hour, dep.Minute, dep.Second);

            //where h.Sectors=@sector and (@start>=h.DutyStart and @start<=h.DutyEnd)
            var maxfdp = await this.context.FDPMaxDailies.FirstOrDefaultAsync(q => q.Sectors == vflights.Count && (_temp >= q.DutyStart && _temp <= q.DutyEnd));
            var maxStr = "";
            if (maxfdp != null)
            {
                TimeSpan span = TimeSpan.FromMinutes((double)maxfdp.MaxFDP);
                maxStr = span.ToString(@"hh\:mm");
            }



            var _crews2 = await (from x in this.context.ViewFlightCrewNews
                                     //where x.FlightId == flightId

                                 where flightIds.Contains(x.FlightId) //&& x.IsPositioning != true
                                 orderby x.IsPositioning, x.GroupOrder

                                 select new CLJLData()
                                 {
                                     CrewId = x.CrewId,
                                     IsPositioning = x.IsPositioning,
                                     PositionId = x.PositionId,
                                     Position = x.Position,
                                     Name = x.Name,
                                     GroupId = x.GroupId,
                                     JobGroup = x.JobGroup,
                                     JobGroupCode = x.JobGroupCode,
                                     GroupOrder = x.GroupOrder,
                                     IsCockpit = x.IsCockpit,
                                     FlightId = x.FlightId,

                                 }).ToListAsync();

            var _gcrews = (from x in _crews2
                           group x by new
                           {
                               x.CrewId,
                               x.IsPositioning,
                               x.PositionId,
                               x.Position,
                               x.Name,
                               x.GroupId,
                               x.JobGroup,
                               x.JobGroupCode,
                               x.GroupOrder,
                               x.IsCockpit,
                           } into grp
                           select grp).ToList();
            var query = (from x in _gcrews
                         let xfids = x.Select(q => Convert.ToInt32(q.FlightId)).ToList()
                         select new CLJLData()
                         {
                             CrewId = x.Key.CrewId,
                             IsPositioning = x.Key.IsPositioning,
                             PositionId = x.Key.PositionId,
                             Position = x.Key.Position,
                             Name = x.Key.Name,
                             GroupId = x.Key.GroupId,
                             JobGroup = x.Key.JobGroup,
                             JobGroupCode = x.Key.JobGroupCode,
                             GroupOrder = x.Key.GroupOrder,
                             IsCockpit = x.Key.IsCockpit,
                             Legs = vflights.Where(q => xfids.Contains((int)q.ID)).OrderBy(q => q.DepartureLocal).Select(q => q.FlightNumber).Distinct().ToList(),
                             LegsStr = string.Join("-", vflights.Where(q => xfids.Contains((int)q.ID)).OrderBy(q => q.DepartureLocal).Select(q => q.FlightNumber).Distinct().ToList()),

                         }).ToList();


            foreach (var x in query)
            {
                if (x.Legs.Count == flightIds.Count)
                    x.LegsStr = "";
            }



            var result = new
            {
                flights = vflights,
                crew = query,//_crews,
                max = maxStr,
            };
            return result;
        }
        internal async Task<object> GetFDPReportingTime(int flightId)
        {
            var fdpQuery = from x in this.context.ViewFDPItems
                           join y in this.context.FDPs on x.FDPId equals y.Id
                           where x.FlightId == flightId
                           && y.IsMain == true
                           select y;
            var fdp = await fdpQuery.FirstOrDefaultAsync();
            if (fdp == null)
                return null;

            var _flights = await (from x in this.context.ViewFDPItems
                                  join y in this.context.FDPs on x.FDPId equals y.Id
                                  where y.Id == fdp.Id
                                  orderby x.STD
                                  select x).ToListAsync();
            var flightids = _flights.Select(q => q.FlightId).ToList();
            var fdps = await (from x in this.context.FDPItems
                              join f in this.context.HelperFDPBoxes on x.FDPId equals f.Id
                              join y in this.context.ViewCrews on f.Cid equals y.Id
                              where flightids.Contains(x.FlightId)
                              select new { FDPId = f.Id, CrewId = y.Id, Name = y.Name, RP = f.ReportingTimeLCL, y.JobGroup, y.JobGroupCode, y.GroupOrder }).Distinct().ToListAsync();
            return fdps;
        }
        internal async Task<object> GetCLData(int flightId)
        {
            var flight = await this.context.ViewFlightInformations.Where(q => q.ID == flightId).FirstOrDefaultAsync();
            var fdpQuery = from x in this.context.ViewFDPItems
                           join y in this.context.FDPs on x.FDPId equals y.Id
                           where x.FlightId == flightId
                           && y.IsMain == true
                           select y;
            var fdp = await fdpQuery.FirstOrDefaultAsync();
            if (fdp == null)
                return null;

            var _flights = await (from x in this.context.ViewFDPItems
                                      //join y in this.context.FDPs on x.FDPId equals y.Id
                                      //where y.Id == fdp.Id
                                  where x.DepartureDay == flight.Date && x.Register == flight.Register
                                  orderby x.STD
                                  select x).ToListAsync();
            var flightids = _flights.Select(q => q.FlightId).Distinct().ToList();
            var vflights = await this.context.ViewFlightInformations.Where(q => flightids.Contains(q.ID)).OrderBy(q => q.STD).Select(q => new { q.Register, q.AircraftType, q.ID, q.STD, q.FlightNumber, q.FromAirportIATA, q.ToAirportIATA }).ToListAsync();



            var _crews2 = await (from x in this.context.ViewFlightCrewNews
                                     //where x.FlightId == flightId

                                 where flightids.Contains(x.FlightId) && x.IsPositioning != true
                                 orderby x.IsPositioning, x.GroupOrder

                                 select new CLJLData()
                                 {
                                     CrewId = x.CrewId,
                                     IsPositioning = x.IsPositioning,
                                     PositionId = x.PositionId,
                                     Position = x.Position,
                                     Name = x.Name,
                                     GroupId = x.GroupId,
                                     JobGroup = x.JobGroup,
                                     JobGroupCode = x.JobGroupCode,
                                     GroupOrder = x.GroupOrder,
                                     IsCockpit = x.IsCockpit,
                                     FlightId = x.FlightId,

                                 }).ToListAsync();
            var _gcrews = (from x in _crews2
                           group x by new
                           {
                               x.CrewId,
                               x.IsPositioning,
                               x.PositionId,
                               x.Position,
                               x.Name,
                               x.GroupId,
                               x.JobGroup,
                               x.JobGroupCode,
                               x.GroupOrder,
                               x.IsCockpit,
                           } into grp
                           select grp).ToList();
            var query = (from x in _gcrews
                         let xfids = x.Select(q => Convert.ToInt32(q.FlightId)).ToList()
                         select new CLJLData()
                         {
                             CrewId = x.Key.CrewId,
                             IsPositioning = x.Key.IsPositioning,
                             PositionId = x.Key.PositionId,
                             Position = x.Key.Position,
                             Name = x.Key.Name,
                             GroupId = x.Key.GroupId,
                             JobGroup = x.Key.JobGroup,
                             JobGroupCode = x.Key.JobGroupCode,
                             GroupOrder = x.Key.GroupOrder,
                             IsCockpit = x.Key.IsCockpit,
                             Legs = _flights.Where(q => xfids.Contains((int)q.FlightId)).OrderBy(q => q.DepartureLocal).Select(q => q.FlightNumber).Distinct().ToList(),
                             LegsStr = string.Join("-", _flights.Where(q => xfids.Contains((int)q.FlightId)).OrderBy(q => q.DepartureLocal).Select(q => q.FlightNumber).Distinct().ToList()),

                         }).ToList();


            foreach (var x in query)
            {
                if (x.Legs.Count == flightids.Count)
                    x.LegsStr = "";
            }

            //select DISTINCT CrewId,IsPositioning,PositionId,[Position],Name,GroupId,JobGroup,JobGroupCode,GroupOrder,IsCockpit 
            var _route = new List<string>();
            var _flightNo = new List<string>();
            var _regs = new List<string>();
            var _types = new List<string>();
            foreach (var x in vflights)
            {
                _route.Add(x.FromAirportIATA);
                _flightNo.Add(x.FlightNumber);
                _regs.Add(x.Register);
                _types.Add(x.AircraftType);


            }
            _route.Add(_flights.Last().ToAirportIATA);
            _regs = _regs.Distinct().ToList();
            _types = _types.Distinct().ToList();

            var result = new
            {
                flights = _flights,
                crew = query, //_crews,
                route = string.Join("-", _route),
                no = string.Join(",", _flightNo),
                actype = string.Join(",", _types),
                regs = string.Join(",", _regs),
                std = _flights.First().STD,
                sta = _flights.Last().STA,
            };
            return result;
        }
        internal async Task<object> GetFlightsLine(int id)
        {
            var flight = await this.context.ViewFlightInformations.Where(q => q.ID == id).FirstOrDefaultAsync();
            var flights = await (from x in this.context.ViewFlightInformations
                                 where x.STDDay == flight.STDDay
                                 && x.RegisterID == flight.RegisterID
                                 && x.STD >= flight.STD
                                 orderby x.STD
                                 select new { x.ID, x.FlightNumber, x.Register }).ToListAsync();
            return flights;
        }

        internal async Task<object> GetCLData(List<int?> flightIds)
        {
            //var flight = await this.context.ViewFlightInformations.Where(q => q.ID == flightId).FirstOrDefaultAsync();
            //var fdpQuery = from x in this.context.ViewFDPItems
            //               join y in this.context.FDPs on x.FDPId equals y.Id
            //               where x.FlightId == flightId
            //               && y.IsMain == true
            //               select y;
            //var fdp = await fdpQuery.FirstOrDefaultAsync();
            //if (fdp == null)
            //    return null;

            //var _flights = await (from x in this.context.ViewFDPItems
            //                          //join y in this.context.FDPs on x.FDPId equals y.Id
            //                          //where y.Id == fdp.Id
            //                      where x.DepartureDay == flight.Date && x.Register == flight.Register
            //                      orderby x.STD
            //                      select x).ToListAsync();
            //var flightids = _flights.Select(q => q.FlightId).Distinct().ToList();
            var vflights = await this.context.ViewFlightInformations.Where(q => flightIds.Contains(q.ID)).OrderBy(q => q.STD).Select(q => new { q.Register, q.AircraftType, q.ID, q.STD, q.FlightNumber, q.FromAirportIATA, q.ToAirportIATA, q.DepartureLocal, q.STA, q.ArrivalLocal }).ToListAsync();

            //TOKO

            var _crews2 = await (from x in
                                     //this.context.ViewFlightCrewNews
                                     this.context.ViewCrewLists
                                     //where x.FlightId == flightId

                                 where flightIds.Contains(x.FlightId) //&& x.IsPositioning != true
                                 orderby x.IsPositioning, x.GroupOrder
                                     , x.RosterPositionId, x.Name

                                 select new CLJLData()
                                 {
                                     CrewId = x.CrewId,
                                     IsPositioning = x.IsPositioning,
                                     PositionId = x.RosterPositionId,
                                     Position = x.Position,
                                     Name = x.Name,
                                     GroupId = x.GroupId,
                                     JobGroup = x.JobGroup,
                                     JobGroupCode = x.JobGroupCode,
                                     GroupOrder = x.GroupOrder,
                                     IsCockpit = x.IsCockpit,
                                     FlightId = x.FlightId,
                                     PID = x.PID,
                                     Mobile = x.Mobile,
                                     Address = x.Address

                                 }).ToListAsync();
            var _gcrews = (from x in _crews2
                           group x by new
                           {
                               x.CrewId,
                               x.IsPositioning,
                               x.PositionId,
                               x.Position,
                               x.Name,
                               x.GroupId,
                               x.JobGroup,
                               x.JobGroupCode,
                               x.GroupOrder,
                               x.IsCockpit,
                               x.PID,
                               x.Mobile,
                               x.Address
                           } into grp
                           select grp).ToList();
            var query = (from x in _gcrews
                         let xfids = x.Select(q => Convert.ToInt32(q.FlightId)).ToList()
                         select new CLJLData()
                         {
                             CrewId = x.Key.CrewId,
                             IsPositioning = x.Key.IsPositioning,
                             PositionId = x.Key.PositionId,
                             Position = x.Key.Position,
                             Name = x.Key.Name,
                             GroupId = x.Key.GroupId,
                             JobGroup = x.Key.JobGroup,
                             JobGroupCode = x.Key.JobGroupCode,
                             GroupOrder = x.Key.GroupOrder,
                             PID = x.Key.PID,
                             Mobile = x.Key.Mobile,
                             Address = x.Key.Address,
                             IsCockpit = x.Key.IsCockpit,
                             Legs = vflights.Where(q => xfids.Contains((int)q.ID)).OrderBy(q => q.DepartureLocal).Select(q => q.FlightNumber).Distinct().ToList(),
                             LegsStr = string.Join("-", vflights.Where(q => xfids.Contains((int)q.ID)).OrderBy(q => q.DepartureLocal).Select(q => q.FlightNumber).Distinct().ToList()),

                         }).ToList();


            foreach (var x in query)
            {
                if (x.Legs.Count == flightIds.Count)
                    x.LegsStr = "";
            }

            //select DISTINCT CrewId,IsPositioning,PositionId,[Position],Name,GroupId,JobGroup,JobGroupCode,GroupOrder,IsCockpit 
            var _route = new List<string>();
            var _flightNo = new List<string>();
            var _regs = new List<string>();
            var _types = new List<string>();
            foreach (var x in vflights)
            {
                _route.Add(x.FromAirportIATA);
                _flightNo.Add(x.FlightNumber);
                _regs.Add(x.Register);
                _types.Add(x.AircraftType);


            }
            _route.Add(vflights.Last().ToAirportIATA);
            _regs = _regs.Distinct().ToList();
            _types = _types.Distinct().ToList();

            var result = new
            {
                flights = vflights,
                crew = query, //_crews,
                route = string.Join("-", _route),
                no = string.Join(",", _flightNo),
                actype = string.Join(",", _types),
                regs = string.Join(",", _regs),
                std = vflights.First().STD,
                sta = vflights.Last().STA,
            };
            return result;
        }
        //jooj
        //GetValidCrewForFDP
        internal List<ViewCrewValid> GetValidCrewForFDP(int fdp, int isvalid, int cockpit)
        {

            var jg = cockpit == 1 ? "00101" : "00102";
            // var result = this.context.GetValidCrewForFDP(fdp, true, jg).ToList();


            var p_fdp = new SqlParameter("@FDPId", fdp);
            var p_isvalid = new SqlParameter("@IsValid", 1);
            var p_jobgroup = new SqlParameter("@JobGroup", jg);
            this.context.Database.CommandTimeout = 160;
            var result = context.Database
                // .SqlQuery<ViewCrewValid>("GetValidCrewForFDP @FDPId,@IsValid,@JobGroup", p_fdp, p_isvalid, p_jobgroup)
                .SqlQuery<ViewCrewValid>("GetValidCrewForFDP2 @FDPId,@JobGroup", p_fdp, p_jobgroup)
                .ToList();

            //  .SqlQuery<ResultForCampaign>("GetResultsForCampaign @ClientId", clientIdParameter)
            // .ToList();

            result = result.OrderBy(q => q.GroupOrder).ThenBy(q => q.Flight).ToList();

            return result;
        }


        internal object GetCrewFlightsReportApp(DateTime from, DateTime to, int id)
        {
            this.context.Database.CommandTimeout = 160;
            //var dfrom = new DateTime(2019, 11, 30);
            //var dto = (new DateTime(2019, 12, 20)).Date.AddHours(23).AddMinutes(59).AddSeconds(59); //dfrom.Date.AddHours(23).AddMinutes(59).AddSeconds(59);
            var dfrom = from.Date;
            var dto = to.Date.AddHours(23).AddMinutes(59).AddSeconds(59);

            var query = (//from x in this.context.ViewFlightCrewNews
                from x in this.context.ViewFlightCrewXes
                join f in this.context.ViewFlightInformations on x.FlightId equals f.ID
                where x.CrewId == id && f.STD >= dfrom && f.STD <= dto
                //&& x.FlightStatusID==15
                orderby f.STD
                select new
                {
                    Date = ((DateTime)f.STD),
                    f.FlightNumber,
                    x.Position,
                    f.FromAirportIATA,
                    f.ToAirportIATA,
                    STD = f.STD,
                    f.STA,
                    ChocksIn = f.ChocksIn,
                    ChocksOut = f.ChocksOut,
                    Takeoff = f.Takeoff,
                    Landing = f.Landing,
                    //FlightTime = f.FlightH * 60 + f.FlightM,
                    f.FlightStatus,
                    f.FlightStatusID,
                    f.FixTime,
                    f.SITATime,
                    f.BlockTime,
                    f.FlightTimeActual,
                    f.Register,
                    f.FlightH,
                    f.FlightM,
                    Duty = 0,
                    ActualFlightHOffBlock = 0,
                    ActualFlightMOffBlock = 0,
                }).ToList();

            return query;
        }

        internal object GetCrewFlightsReportAppX(DateTime from, DateTime to, int id)
        {
            this.context.Database.CommandTimeout = 160;
            //var dfrom = new DateTime(2019, 11, 30);
            //var dto = (new DateTime(2019, 12, 20)).Date.AddHours(23).AddMinutes(59).AddSeconds(59); //dfrom.Date.AddHours(23).AddMinutes(59).AddSeconds(59);
            var dfrom = from.Date;
            var dto = to.Date.AddHours(23).AddMinutes(59).AddSeconds(59);

            //var query = ( 
            //    from x in this.context.ViewFlightCrewXes

            //    where x.CrewId == id && /*x.STD >= dfrom && x.STD <= dto*/ x.STDLocal >= dfrom && x.STDLocal <= dto
            //    //&& x.FlightStatusID==15
            //    orderby x.STD
            //    select x
            //     ).ToList();

            var query = (from x in this.context.ViewCrewFlightApps
                         where x.CrewId == id && x.STDLocal >= dfrom && x.STDLocal <= dto
                         orderby x.STD
                         select x).ToList();

            return query;
        }


        internal object GetCrewFlightsReportAppXByFDP(int crewid, int fdpid)
        {
            this.context.Database.CommandTimeout = 160;
            //var dfrom = new DateTime(2019, 11, 30);
            //var dto = (new DateTime(2019, 12, 20)).Date.AddHours(23).AddMinutes(59).AddSeconds(59); //dfrom.Date.AddHours(23).AddMinutes(59).AddSeconds(59);


            var query = (//from x in this.context.ViewFlightCrewNews
                from x in this.context.ViewFlightCrewXes

                where x.CrewId == crewid && x.FDPId == fdpid
                //&& x.FlightStatusID==15
                orderby x.STD
                select x
                 ).ToList();

            return query;
        }

        internal async Task<object> GetNextScheduledFlight(int id)
        {
            var dt = DateTime.UtcNow;
            var query = await (//from x in this.context.ViewFlightCrewNews
                from x in this.context.ViewFlightCrewXes

                where x.CrewId == id && x.STD >= dt && x.FlightStatusId == 1
                //&& x.FlightStatusID==15
                orderby x.STD
                select x
                 ).FirstOrDefaultAsync();
            return query;

        }
        public class appAll
        {
            public DateTime? Start { get; set; }
            public DateTime? End { get; set; }
            public int? Type { get; set; }
            public string TypeStr { get; set; }

            public int? Total { get; set; }
        }
        internal object GetCrewFlightsReportAppGrouped(int id)
        {
            this.context.Database.CommandTimeout = 160;


            var query = (
                from x in this.context.ViewFlightCrewXes

                where x.CrewId == id && x.DateConfirmed != null
                group x by new { x.STDDay, x.STDDayEnd } into grp
                select new appAll() { Start = grp.Key.STDDay, End = grp.Key.STDDayEnd, Total = grp.Count(), Type = 1165 }

                ).ToList();

            var dayOffs = this.context.FDPs.Where(q => q.CrewId == id && (q.DutyType == 10000 || q.DutyType == 10001) && q.DateConfirmed != null).ToList();
            var ds = dayOffs.Select(q => new appAll()
            {
                Start = ((DateTime)q.DateStart).AddMinutes(Helper.GetTimeOffset((DateTime)q.DateStart)),
                End = ((DateTime)q.DateEnd).AddMinutes(Helper.GetTimeOffset((DateTime)q.DateEnd)),
                Total = 0,
                Type = 10000,

            }).ToList();

            //var others = this.context.FDPs.Where(q => q.CrewId == id && (q.DutyType != 1165 && q.DutyType != 10001 && q.DutyType != 10000)).ToList();
            var others = this.context.FDPs.Where(q => q.CrewId == id && (q.DutyType == 1167 || q.DutyType == 1168) && q.DateConfirmed != null).ToList();
            var ds2 = others.Select(q => new appAll()
            {
                Start = ((DateTime)q.DateStart).AddMinutes(Helper.GetTimeOffset((DateTime)q.DateStart)),
                End = ((DateTime)q.DateEnd).AddMinutes(Helper.GetTimeOffset((DateTime)q.DateEnd)),
                Total = 0,
                Type = q.DutyType,

            }).ToList();
            foreach (var x in ds2)
            {
                switch (x.Type)
                {
                    case 1167:
                        x.TypeStr = "STBYP";
                        break;
                    case 1168:
                        x.TypeStr = "STBYA";
                        break;
                    case 5001:
                        x.TypeStr = "OFC";
                        break;
                    case 5000:
                        x.TypeStr = "TRN";
                        break;

                    default:
                        x.TypeStr = "DTY";
                        break;
                }
            }

            query = query.Concat(ds).Concat(ds2).ToList();

            return query;
        }

        internal List<ViewFDPAB> GetValidFDPForCrew(int pid, int year, int month)
        {




            var p_PId = new SqlParameter("@PId", pid);
            var p_Year = new SqlParameter("@Year", year);
            var p_Month = new SqlParameter("@Month", month);
            var p_Day = new SqlParameter("@Day", -1);
            this.context.Database.CommandTimeout = 160;
            var result = context.Database
                .SqlQuery<ViewFDPAB>("GetValidFDPForCrew @PId,@Year,@Month,@Day", p_PId, p_Year, p_Month, p_Day)
                .ToList();

            //  .SqlQuery<ResultForCampaign>("GetResultsForCampaign @ClientId", clientIdParameter)
            // .ToList();

            result = result.OrderBy(q => q.DutyStart).ToList();

            return result;
        }

        internal List<ViewFDPAB> GetValidFDPForCrew(int pid, int year, int month, int day)
        {




            var p_PId = new SqlParameter("@PId", pid);
            var p_Year = new SqlParameter("@Year", year);
            var p_Month = new SqlParameter("@Month", month);
            var p_Day = new SqlParameter("@Day", day);
            this.context.Database.CommandTimeout = 160;
            var result = context.Database
                .SqlQuery<ViewFDPAB>("GetValidFDPForCrew @PId,@Year,@Month,@Day", p_PId, p_Year, p_Month, p_Day)
                .ToList();

            //  .SqlQuery<ResultForCampaign>("GetResultsForCampaign @ClientId", clientIdParameter)
            // .ToList();

            result = result.OrderBy(q => q.DutyStart).ToList();

            return result;
        }

        internal string IsRERRPValid(int pid, DateTime start, DateTime end)
        {
            var p_PId = new SqlParameter("@PID", pid);
            var p_Start = new SqlParameter("@AStart", start);
            var p_End = new SqlParameter("@AEnd", end);

            this.context.Database.CommandTimeout = 160;
            var result = context.Database
                .SqlQuery<string>("IsRERRPValid @PID,@AStart,@AEnd", p_PId, p_Start, p_End)
                .ToList();

            //  .SqlQuery<ResultForCampaign>("GetResultsForCampaign @ClientId", clientIdParameter)
            // .ToList();
            return result == null ? "Unknown ERROR" : result.First();
        }

        internal string IsEventValid(int pid, DateTime start, DateTime end, int type)
        {
            var p_PId = new SqlParameter("@PID", pid);
            var p_Start = new SqlParameter("@AStart", start);
            var p_End = new SqlParameter("@AEnd", end);
            var p_Type = new SqlParameter("@AType", type);

            this.context.Database.CommandTimeout = 160;
            var result = context.Database
                .SqlQuery<string>("IsEventValid @PID,@AStart,@AEnd,@AType", p_PId, p_Start, p_End, p_Type)
                .ToList();

            //  .SqlQuery<ResultForCampaign>("GetResultsForCampaign @ClientId", clientIdParameter)
            // .ToList();
            return result == null ? "Unknown ERROR" : result.First();
        }

        internal async Task<FDP> AssignFDPToCrew(int fdpId, int crewId, int position, int stby)
        {
            var fdp = await this.context.FDPs.FirstOrDefaultAsync(q => q.Id == fdpId);

            var fdpItems = await this.context.FDPItems.Where(q => q.FDPId == fdpId).ToListAsync();

            var assigned = new FDP()
            {
                CrewId = crewId,
                IsTemplate = false,
                DutyType = fdp.DutyType,
                JobGroupId = position,
                TemplateId = fdpId,
                FirstFlightId = fdp.FirstFlightId,
                LastFlightId = fdp.LastFlightId,
                GUID = Guid.NewGuid(),

            };
            this.context.FDPs.Add(assigned);
            foreach (var x in fdpItems)
            {
                var item = new FDPItem()
                {
                    FDP = assigned,
                    FlightId = x.FlightId,
                    IsPositioning = x.IsPositioning,
                    IsSector = x.IsSector,
                    SplitDuty = x.SplitDuty,
                    SplitDutyPairId = x.SplitDutyPairId,
                };
                this.context.FDPItems.Add(item);
            }

            if (stby != -1)
            {
                var viewfdp = await this.context.ViewFDPs.FirstOrDefaultAsync(q => q.Id == fdpId);
                var sb = await this.context.FDPs.FirstOrDefaultAsync(q => q.Id == stby);
                sb.FDP2 = assigned;
                sb.FDPReportingTime = viewfdp.ReportingTime;
            }

            return assigned;
        }

        //mimi
        internal async Task<string> AssignFDPToCrews(List<FDPCrew> ds)
        {
            //int fdpId, int crewId, int position
            var fdpId = ds.First().fdp;
            var fdp = await this.context.FDPs.FirstOrDefaultAsync(q => q.Id == fdpId);
            var fdpItems = await this.context.FDPItems.Where(q => q.FDPId == fdpId).ToListAsync();
            foreach (var xx in ds)
            {
                var crewId = xx.crew;
                var position = xx.position;
                var assigned = new FDP()
                {
                    CrewId = crewId,
                    IsTemplate = false,
                    DutyType = fdp.DutyType,
                    JobGroupId = position,
                    TemplateId = fdpId,
                    FirstFlightId = fdp.FirstFlightId,
                    LastFlightId = fdp.LastFlightId,
                    GUID = Guid.NewGuid(),

                };
                this.context.FDPs.Add(assigned);
                foreach (var x in fdpItems)
                {
                    var item = new FDPItem()
                    {
                        FDP = assigned,
                        FlightId = x.FlightId,
                        IsPositioning = x.IsPositioning,
                        IsSector = x.IsSector,
                        SplitDuty = x.SplitDuty,
                        SplitDutyPairId = x.SplitDutyPairId,
                    };
                    this.context.FDPItems.Add(item);
                }

                if (xx.stby != -1)
                {
                    var viewfdp = await this.context.ViewFDPs.FirstOrDefaultAsync(q => q.Id == fdpId);
                    var sb = await this.context.FDPs.FirstOrDefaultAsync(q => q.Id == xx.stby);
                    sb.FDP2 = assigned;
                    sb.FDPReportingTime = viewfdp.ReportingTime;
                }

            }




            return string.Empty;
        }



        internal RegisterGround AddAog(dynamic dto)
        {
            var duty = new RegisterGround();
            duty.DateFrom = Convert.ToDateTime(dto.DateFrom);
            duty.DateEnd = Convert.ToDateTime(dto.DateEnd);

            duty.RegisterId = Convert.ToInt32(dto.RegisterId);
            duty.GroundTypeId = Convert.ToInt32(dto.GroundTypeId);


            duty.Remark = Convert.ToString(dto.Remark);

            this.context.RegisterGrounds.Add(duty);
            return duty;
        }


        internal async Task<object> UpdateFDPPosition(int fdpId, int position)
        {
            var fdp = await this.context.FDPs.FirstOrDefaultAsync(q => q.Id == fdpId);
            fdp.JobGroupId = position;
            return string.Empty;
        }
        internal async Task<object> DeleteFDP(int fdpId)
        {
            //doolmaloos
            var fdp = await this.context.FDPs.FirstOrDefaultAsync(q => q.Id == fdpId);
            double total = 0;
            if (!string.IsNullOrEmpty(fdp.InitFlights))
            {
                var parts = fdp.InitFlights.Split('*').ToList();

                foreach (var x in parts)
                {
                    var _std = x.Split('_')[2];
                    var _sta = x.Split('_')[3];
                    var std = DateTime.ParseExact(_std, "yyyyMMddHHmm", CultureInfo.InvariantCulture);
                    var sta = DateTime.ParseExact(_sta, "yyyyMMddHHmm", CultureInfo.InvariantCulture);
                    total += (sta - std).TotalMinutes;
                }
                //this.context.Database.ExecuteSqlCommand("update employee set flightsum=isnull(flightsum,0)-" + total + ",FlightEarly=isnull(FlightEarly,0)+" + early + ",FlightLate=isnull(FlightLate,0)+" + late + "  where id=" + dto.crewId);
                this.context.Database.ExecuteSqlCommand("update employee set flightsum=isnull(flightsum,0)-" + total + "  where id=" + fdp.CrewId);

            }
            var related = await this.context.FDPs.Where(q => q.FDPId == fdpId).FirstOrDefaultAsync();
            if (related != null)
            {
                related.FDPId = null;
                related.FDPReportingTime = null;
                related.UPD = related.UPD != null ? related.UPD + 1 : 1;
            }

            if (fdp.FDPId != null)
            {
                var stby = await this.context.FDPs.FirstOrDefaultAsync(q => q.Id == fdp.FDPId);
                if (stby != null)
                {
                    stby.FDPId = null;
                    stby.FDPReportingTime = null;
                    stby.UPD = stby.UPD == null ? 1 : ((int)stby.UPD) + 1;
                }
            }


            var templateId = fdp.TemplateId;
            this.context.FDPs.Remove(fdp);

            return total;
        }

        internal async Task<object> DeleteAOG(int id)
        {
            var aog = await this.context.RegisterGrounds.FirstOrDefaultAsync(q => q.Id == id);
            if (aog != null)
                this.context.RegisterGrounds.Remove(aog);

            return true;
        }

        internal async Task<int> GetFDPMatchingListError(int templateId)
        {
            var erx = await this.context.HelperMatchingLists.Where(q => q.TemplateId == templateId).CountAsync();
            return erx;
        }
        internal async Task<List<ViewEmployeeSimple>> _GetEmployeesByIds(List<int> ids)
        {
            var emps = await this.context.ViewEmployeeSimples.Where(q => ids.Contains(q.Id)).ToListAsync();
            return emps;
        }


        internal string SendSMSNoSave(string mobile, string text, string name, int type, int? flightId = null, string sender = null)
        {
            Magfa m = new Magfa();
            var result9 = m.enqueue(1, mobile, text)[0];
            this.context.SMSHistories.Add(new SMSHistory()
            {
                DateSent = DateTime.Now,
                RecMobile = mobile,
                RecName = name,
                Ref = result9.ToString(),
                Text = text,
                TypeId = type,
                FlightId = flightId,
                Sender = sender,
            });
            // this.context.SaveChanges();
            return result9.ToString();
        }
        string getMessageTypeStr(int id)
        {
            switch (id)
            {
                case 10010:
                    return "Pickup Time Notification";
                case 10011:
                    return "New Pickup Time Notification";
                case 10012:
                    return "Pickup Stand by Notification";
                case 10013:
                    return "اعلام تاخیر";
                case 10014:
                    return "Cancelling Notification";
                case 10015:
                    return "Delay Notification";
                case 10016:
                    return "Operation Notification";
                default:
                    return "-";
            }
        }
        internal async Task<object> SendFlightSMS(ViewModels.NotificationX dto)
        {
            var employees = await _GetEmployeesByIds(dto.Employees);

            var empids = employees.Select(q => q.Id).ToList();
            var pickups = await this.context.CrewPickupSMS.Where(q => q.Type == dto.TypeId && q.FlightId == dto.FlightId && empids.Contains(q.CrewId)).ToListAsync();

            List<IdDel> result = new List<IdDel>();
            //kiro
            int c1 = 0;
            foreach (var x in dto.Employees)
            {
                if (dto.Names != null && dto.Names.Count > 0)
                {
                    var name = dto.Names[c1];
                    //var dtime = dto.Dates[c1];

                    // if (dtime == null && dto.TypeId > 10011)
                    //    dtime = (new DateTime()).ToUniversalTime();
                    //string message = string.Empty;
                    //switch (dto.TypeId)
                    //{
                    //    case 10010:
                    //    case 10011:
                    //        if (dtime != null)
                    //        {
                    //            var tzoffset = Helper.GetTimeOffset((DateTime)dtime);
                    //            var _time2 = ((DateTime)dtime).AddMinutes(tzoffset);
                    //            var _time = (_time2).Hour.ToString().PadLeft(2, '0') + ":" + (_time2).Minute.ToString().PadLeft(2, '0');
                    //            message = dto.Message.Replace("<br/>", "\n").Replace("<br />", "\n").Replace("#Time", _time).Replace("()", _time);
                    //        }
                    //        break;
                    //    case 10012:
                    //    case 10013:
                    //        message = dto.Message.Replace("<br/>", "\n").Replace("<br />", "\n");
                    //        break;
                    //    default:
                    //        break;
                    //}
                    var message = dto.Message.Replace("<br/>", "\n").Replace("<br />", "\n").Replace("#Crew", name);
                    var emplo = employees.Where(q => q.Id == x).FirstOrDefault();
                    if (emplo != null && !string.IsNullOrEmpty(message))
                    {
                        //doodool
                        var w = SendSMSNoSave(emplo.Mobile, message, emplo.Name, dto.TypeId, dto.FlightId, dto.SenderName);

                        result.Add(new IdDel()
                        {
                            Id = emplo.Id,
                            Ref = w,
                            Status = "Queue",
                            Message = message,
                            TypeStr = getMessageTypeStr(dto.TypeId),

                        });
                        var his = pickups.FirstOrDefault(q => q.CrewId == emplo.Id);
                        if (his != null && dto.TypeId != 10016 && dto.TypeId != 10015)
                            this.context.CrewPickupSMS.Remove(his);
                        this.context.CrewPickupSMS.Add(new CrewPickupSM()
                        {
                            CrewId = emplo.Id,
                            DateSent = DateTime.Now,
                            DateStatus = DateTime.Now,
                            FlightId = dto.FlightId == null ? -1 : (int)dto.FlightId,
                            Message = message,

                            RefId = w,
                            Status = "Queue",
                            Type = dto.TypeId,
                            Sender = dto.SenderName,

                        });

                        //SendSMSNoSave("09124449584", message, emplo.Name);
                    }



                }
                c1++;
            }

            if (dto.Names2 != null && dto.Names2.Count > 0)
            {
                try
                {
                    for (int i = 0; i <= dto.Names2.Count - 1; i++)
                    {
                        var name2 = dto.Names2[i];
                        var no2 = dto.Mobiles2[i];
                        // var message = dto.Message.Replace("#Crew", name2);
                        var message2 = dto.Message.Replace("#Crew", name2);
                        var w2 = SendSMSNoSave(no2, message2, name2, dto.TypeId, null, dto.SenderName);

                        this.context.CrewPickupSMS.Add(new CrewPickupSM()
                        {
                            CrewId = -1,
                            DateSent = DateTime.Now,
                            DateStatus = DateTime.Now,
                            FlightId = -1,
                            Message = message2,

                            RefId = w2,
                            Status = "Queue",
                            Type = dto.TypeId,
                            RecMobile = no2,
                            RecName = name2,
                            Sender = dto.SenderName,

                        });
                    }
                }
                catch (Exception ex)
                {

                }

            }


            return result;
        }

        internal async Task<object> SendPickup(ViewModels.NotificationX dto)
        {
            var employees = await _GetEmployeesByIds(dto.Employees);

            var empids = employees.Select(q => q.Id).ToList();
            var pickups = await this.context.CrewPickupSMS.Where(q => q.FlightId == dto.FlightId && empids.Contains(q.CrewId)).ToListAsync();

            List<IdDel> result = new List<IdDel>();
            //kiro
            int c1 = 0;
            foreach (var x in dto.Employees)
            {
                if (dto.Names != null && dto.Names.Count > 0)
                {
                    var name = dto.Names[c1];
                    var dtime = dto.Dates[c1];

                    // if (dtime == null && dto.TypeId > 10011)
                    //    dtime = (new DateTime()).ToUniversalTime();
                    string message = string.Empty;
                    switch (dto.TypeId)
                    {
                        case 10010:
                        case 10011:
                        case 10017:
                            if (dtime != null)
                            {
                                var tzoffset = Helper.GetTimeOffset((DateTime)dtime);
                                var _time2 = ((DateTime)dtime).AddMinutes(tzoffset);
                                var _time = (_time2).Hour.ToString().PadLeft(2, '0') + ":" + (_time2).Minute.ToString().PadLeft(2, '0');
                                message = dto.Message.Replace("<br/>", "\n").Replace("<br />", "\n").Replace("#Time", _time).Replace("()", _time);
                            }
                            break;
                        case 10012:
                        case 10013:
                            message = dto.Message.Replace("<br/>", "\n").Replace("<br />", "\n");
                            break;
                        default:
                            break;
                    }
                    var emplo = employees.Where(q => q.Id == x).FirstOrDefault();
                    if (emplo != null && !string.IsNullOrEmpty(message))
                    {
                        message = message.Replace("Flt.Crew", emplo.Name);
                        var w = SendSMSNoSave(emplo.Mobile, message, emplo.Name, dto.TypeId, null, null);

                        result.Add(new IdDel()
                        {
                            Id = emplo.Id,
                            Ref = w,
                            Status = "Queue",
                            Message = message,
                            TypeStr = getMessageTypeStr(dto.TypeId),

                        });
                        var his = pickups.FirstOrDefault(q => q.CrewId == emplo.Id);
                        if (his != null)
                            this.context.CrewPickupSMS.Remove(his);
                        this.context.CrewPickupSMS.Add(new CrewPickupSM()
                        {
                            CrewId = emplo.Id,
                            DateSent = DateTime.Now,
                            DateStatus = DateTime.Now,
                            FlightId = (int)dto.FlightId,
                            Message = message,
                            Pickup = (dto.TypeId == 10012 || dto.TypeId == 10013) ? null : dtime,
                            RefId = w,
                            Status = "Queue",
                            Type = dto.TypeId

                        });

                        //SendSMSNoSave("09124449584", message, emplo.Name);
                    }

                    //    if (dtime != null)
                    //{
                    //    var tzoffset = Helper.GetTimeOffset((DateTime)dtime);
                    //    var _time2 = ((DateTime)dtime).AddMinutes(tzoffset);
                    //    var _time = (_time2).Hour.ToString().PadLeft(2, '0') + ":" + (_time2).Minute.ToString().PadLeft(2, '0');
                    //    var emplo = employees.Where(q => q.Id == x).FirstOrDefault();
                    //    if (emplo != null)
                    //    {
                    //        var mes = dto.Message.Replace("<br/>", "\n").Replace("<br />", "\n").Replace("#Time", _time).Replace("()", _time);
                    //        SendSMSNoSave(emplo.Mobile, mes, emplo.Name);

                    //        SendSMSNoSave("09124449584", mes, emplo.Name);
                    //    }
                    //}

                }
                c1++;
            }


            return result;
        }


        internal async Task<object> SMSVisit(int Id)
        {
            var record = await this.context.CrewPickupSMS.FirstOrDefaultAsync(q => q.Id == Id);
            if (record == null)
                return true;
            record.DateVisit = DateTime.Now;

            await this.context.SaveChangesAsync();
            return true;
        }

        //7-11
        public bool sendWelcome()
        {
            //var opscrew = this.context.OpsCrewPhones.Select(q => q.CellPhone).ToList().Select(q => q.Replace(" ", ""));
            //var crews = this.context.ViewCrews.ToList();
            //var users = this.context.AspNetUsers.ToList();

            //foreach (var crew in crews)
            //{

            //    var user = users.Where(q => q.Id == crew.PersonId.ToString() || q.Id == "ops" + crew.PersonId.ToString()).FirstOrDefault();
            //    var isvalid = opscrew.Contains(crew.Mobile);
            //    if (user != null && isvalid)
            //    {
            //        var strs = new List<string>();
            //        strs.Add("Dear " + crew.Name.ToUpper() + ", ");
            //        strs.Add("To see your roster, please visit ");
            //        strs.Add("http://fleet.caspianairlines.com/webpocket");
            //        strs.Add("Username: " + user.UserName);

            //        strs.Add("Password: 1234@aA");
            //        strs.Add("Caspian Airlines");
            //        var text = String.Join("\n", strs);
            //        SendSMS(crew.Mobile, text, crew.Name);
            //        // SendSMS(/*crew.Mobile*/"09122007720", text, crew.Name);
            //        // SendSMS(/*crew.Mobile*/"09123938451", text, crew.Name);

            //    }

            //}
            var users = this.context.ViewUsers.ToList();
            foreach (var user in users)
            {
                if (!string.IsNullOrEmpty(user.PhoneNumber))
                {
                    try
                    {
                        var strs = new List<string>();
                        strs.Add("Dear " + user.FirstName.ToUpper() + " " + user.LastName.ToUpper() + ", ");
                        strs.Add("To see your e-Lib, please visit ");
                        strs.Add("http://fleet.flypersia.aero/webpocket");
                        strs.Add("Username: " + user.UserName);
                        strs.Add("You can use your current AIRPOCKET/WEBPOCKET password to login.");
                        strs.Add("If you don't have a password yet, please use:");
                        strs.Add("1234@aA");
                        strs.Add("FlyPersia Airlines");
                        var text = String.Join("\n", strs);
                        SendSMS(user.PhoneNumber, text, user.FirstName.ToUpper() + " " + user.LastName);
                        SendSMS("09124449584", text, user.FirstName.ToUpper() + " " + user.LastName);
                    }
                    catch (Exception exx)
                    {
                        int yuu = 0;
                    }

                    // SendSMS(/*crew.Mobile*/"09122007720", text, crew.Name);
                    // SendSMS(/*crew.Mobile*/"09123938451", text, crew.Name);
                }
            }
            return true;

        }
        internal async Task<dynamic> NotifyDelayedFlight(int id)
        {
            var offset = 270;
            //var _df = date.AddMinutes(-tzoffset);
            var flight = await this.context.ViewFlightABS.Where(q => q.ID == id).FirstOrDefaultAsync();
            var delays = await this.context.ViewFlightDelays.Where(q => q.FlightId == id).ToListAsync();
            var total = delays.Select(q => (int)q.DelayHH * 60 + (int)q.DelayMM).Sum();
            var Hour = total / 60;
            var Minute = total % 60;
            var delayStr = FormatTwoDigits(Hour) + ":" + FormatTwoDigits(Minute);

            var strs = new List<string>() { "تاخیر پرواز زیر از 20 دقیقه گذشته است" };
            strs.Add(flight.FromAirportIATA + "-" + flight.FlightNumber + "-" + flight.ToAirportIATA);
            strs.Add("Delay: " + delayStr);
            var std = ((DateTime)flight.STD).AddMinutes(offset);
            var sta = ((DateTime)flight.STA).AddMinutes(offset);
            DateTime? offblock = null;
            if (flight.ChocksOut != null)
            {
                offblock = ((DateTime)flight.ChocksOut).AddMinutes(offset);
            }

            strs.Add("Scheduled Dep.: " + std.Hour.ToString().PadLeft(2, '0') + ":" + std.Minute.ToString().PadLeft(2, '0'));
            strs.Add("Scheduled Arr.: " + sta.Hour.ToString().PadLeft(2, '0') + ":" + sta.Minute.ToString().PadLeft(2, '0'));
            if (offblock != null)
                strs.Add("Off Block: " + ((DateTime)offblock).Hour.ToString().PadLeft(2, '0') + ":" + ((DateTime)offblock).Minute.ToString().PadLeft(2, '0'));

            var text = String.Join("\n", strs);

            var nos = new Dictionary<string, string>();
            nos.Add("Admin1", "09306678047");
            nos.Add("Admin2", "09124449584");
            ////razbani
            //nos.Add("Razbani", "09123938451");
            ////daghigh
            //nos.Add("DaghighKia", "09124500273");
            ////ashrafi
            //nos.Add("Ashrafi", "09121965762");
            ////fazeli
            //nos.Add("Fazeli", "09121323295");
            ////rahimi
            //nos.Add("Rahimi", "09121506016");
            ////bagheri
            //nos.Add("Bagheri", "09125205832");
            ////bakhshi
            //nos.Add("BakhshiZadeh", "09122587968");
            ////abbasi
            //nos.Add("Abbasi", "09132710177");

            foreach (var x in nos)
            {
                Magfa m = new Magfa();
                var result9 = m.enqueue(1, x.Value, text)[0];


                //this.context.SMSHistories.Add(new SMSHistory()
                //{
                //    DateSent = DateTime.Now,
                //    RecMobile = x.Value,
                //    RecName = x.Key,
                //    Ref = result9.ToString(),
                //    Text = text,
                //    TypeId = 2,
                //});
            }

            return true;

        }
        internal async Task<dynamic> AddSMSGroup(string name, string mobile,int type)
        {
            var sg = new SMSGroup()
            {
                Name = name,
                Phone = mobile,
                Type = type,
            };
            this.context.SMSGroups.Add(sg);
            await this.context.SaveAsync();
            return sg;
        }

        internal async Task<dynamic> DeleteSMSGroup( string mobile, int type)
        {
            var obj = this.context.SMSGroups.Where(q => q.Phone == mobile && q.Type == type).FirstOrDefault();
            if (obj == null)
                return 0;
            this.context.SMSGroups.Remove(obj);

             
            await this.context.SaveAsync();
            return 1;
        }


        // public static List<delayNotification> 
        internal async Task<dynamic> NotifyDelayedFlight2(int id, string from, string to, string no, int hh, int mm)
        {
            return true;
            var offset = 270;
            //var _df = date.AddMinutes(-tzoffset);
            // var flight = await this.context.ViewFlightABS.Where(q => q.ID == id).FirstOrDefaultAsync();
            //var delays = await this.context.ViewFlightDelays.Where(q => q.FlightId == id).ToListAsync();
            // var total = delays.Select(q => (int)q.DelayHH * 60 + (int)q.DelayMM).Sum();
            // //var Hour = total / 60;
            //var Minute = total % 60;
            var delayStr = FormatTwoDigits(hh) + ":" + FormatTwoDigits(mm);

            var strs = new List<string>() { "تاخیر پرواز زیر از 20 دقیقه گذشته است" };
            strs.Add(from + "-" + no + "-" + to);
            strs.Add("Delay: " + delayStr);



            var text = String.Join("\n", strs);

            var nos = new Dictionary<string, string>();
            nos.Add("Admin1", "09306678047");
            nos.Add("Admin2", "09124449584");
            //razbani
            nos.Add("Razbani", "09123938451");
            //daghigh
            nos.Add("DaghighKia", "09124500273");
            //ashrafi
            nos.Add("Ashrafi", "09121965762");
            //fazeli
            nos.Add("Fazeli", "09121323295");
            //rahimi
            nos.Add("Rahimi", "09121506016");
            //bagheri
            nos.Add("Bagheri", "09125205832");
            //bakhshi
            nos.Add("BakhshiZadeh", "09122587968");
            //abbasi
            nos.Add("Abbasi", "09132710177");

            foreach (var x in nos)
            {
                Magfa m = new Magfa();
                var result9 = m.enqueue(1, x.Value, text)[0];


                //this.context.SMSHistories.Add(new SMSHistory()
                //{
                //    DateSent = DateTime.Now,
                //    RecMobile = x.Value,
                //    RecName = x.Key,
                //    Ref = result9.ToString(),
                //    Text = text,
                //    TypeId = 2,
                //});
            }

            return true;

        }
        internal async Task<dynamic> NotifyDelayedFlight3(int id, string from, string to, string no, int hh, int mm)
        {

            var offset = 270;
            //var _df = date.AddMinutes(-tzoffset);
            // var flight = await this.context.ViewFlightABS.Where(q => q.ID == id).FirstOrDefaultAsync();
            //var delays = await this.context.ViewFlightDelays.Where(q => q.FlightId == id).ToListAsync();
            // var total = delays.Select(q => (int)q.DelayHH * 60 + (int)q.DelayMM).Sum();
            // //var Hour = total / 60;
            //var Minute = total % 60;
            var delayStr = FormatTwoDigits(hh) + ":" + FormatTwoDigits(mm);

            var strs = new List<string>() { "تاخیر پرواز زیر از 20 دقیقه گذشته است" };
            strs.Add(from + "-" + no + "-" + to);
            strs.Add("Delay: " + delayStr);



            var text = String.Join("\n", strs);

            var nos = new Dictionary<string, string>();
            nos.Add("Admin1", "09306678047");
            nos.Add("Admin2", "09124449584");
            //razbani
            nos.Add("Razbani", "09123938451");
            //daghigh
            nos.Add("DaghighKia", "09124500273");
            //ashrafi
            nos.Add("Ashrafi", "09121965762");
            //fazeli
            nos.Add("Fazeli", "09121323295");
            //rahimi
            nos.Add("Rahimi", "09121506016");
            //bagheri
            nos.Add("Bagheri", "09125205832");
            //bakhshi
            nos.Add("BakhshiZadeh", "09122587968");
            //abbasi
            nos.Add("Abbasi", "09132710177");

            foreach (var x in nos)
            {
                Magfa m = new Magfa();
                var result9 = m.enqueue(1, x.Value, text)[0];


                //this.context.SMSHistories.Add(new SMSHistory()
                //{
                //    DateSent = DateTime.Now,
                //    RecMobile = x.Value,
                //    RecName = x.Key,
                //    Ref = result9.ToString(),
                //    Text = text,
                //    TypeId = 2,
                //});
            }

            return true;

        }
        public class IdDel
        {
            public int Id { get; set; }
            public string Ref { get; set; }
            public string Status { get; set; }
            public string Message { get; set; }
            public string TypeStr { get; set; }

        }
        public class SMSDeliveryStatus
        {
            public string RefId { get; set; }
            public string Status { get; set; }
        }
        internal async Task<List<SMSDeliveryStatus>> GetSMSStatus(List<Int64> refIds)
        {
            var ids = refIds.Select(q => q.ToString()).ToList();
            var smses = await this.context.SMSHistories.Where(q => ids.Contains(q.Ref)).ToListAsync();
            Magfa m = new Magfa();
            var status = m.getStatus(refIds);
            List<SMSDeliveryStatus> result = new List<SMSDeliveryStatus>();
            for (int i = 0; i <= refIds.Count - 1; i++)
            {
                var _status = status[i];
                var _refId = refIds[i].ToString();
                var sms = smses.FirstOrDefault(q => q.Ref == _refId);
                if (sms != null)
                {
                    if (_status == "Unknown")
                    {
                        if (string.IsNullOrEmpty(sms.ResStr))
                            sms.ResStr = _status;
                    }
                    else
                    {
                        sms.ResStr = _status;
                    }
                    result.Add(new SMSDeliveryStatus() { RefId = _refId, Status = sms.ResStr });
                }
            }

            return result;

        }
        internal async Task<object> UpdatePickupSMSStatus(List<Int64> refIds)
        {
            var _date = DateTime.Now.AddHours(-24);
            var ststuses = await GetSMSStatus(refIds);
            var refs = refIds.Select(q => q.ToString()).ToList();
            var history = await this.context.CrewPickupSMS.Where(q => refs.Contains(q.RefId) && q.DateSent >= _date).ToListAsync();
            foreach (var x in history)
            {
                var statusobj = ststuses.FirstOrDefault(q => q.RefId == x.RefId);
                if (statusobj != null)
                {
                    x.DateStatus = DateTime.Now;
                    x.Status = statusobj.Status;
                }
            }

            await this.context.SaveChangesAsync();

            return ststuses;

        }

        internal async Task<dynamic> SMSRosterDaily(List<int> Ids, DateTime date)
        {
            var query = await (from x in this.context.ViewFDPCrewDetails
                               where Ids.Contains(x.Id)
                               select x).ToListAsync();
            var _fids = query.Select(q => (Nullable<int>)q.Id).ToList();
            var histories = await this.context.SMSHistories.Where(q => _fids.Contains(q.ResId)).ToListAsync();
            Magfa m = new Magfa();
            Magfa m2 = new Magfa();
            List<IdDel> iddels = new List<IdDel>();
            foreach (var x in query)
            {
                List<string> strs = new List<string>();
                strs.Add(ConfigurationManager.AppSettings["airline"] + " Airlines");
                strs.Add("Dear " + x.Name + ",");
                var day = (DateTime)x.DaySTDLocal;
                var dayStr = day.ToString("ddd") + " " + day.Year + "-" + day.Month + "-" + day.Day;
                var datesent = DateTime.Now.Year + "/" + DateTime.Now.Month.ToString().PadLeft(2, '0') + "/" + DateTime.Now.Day.ToString().PadLeft(2, '0') + " " + DateTime.Now.Hour.ToString().PadLeft(2, '0') + ":" + DateTime.Now.Minute.ToString().PadLeft(2, '0');
                strs.Add(dayStr);
                strs.Add(x.Route);
                strs.Add(x.Flights);
                //strs.Add("Check your WebPocket account to see more details.");
                strs.Add("Date Sent: " + datesent);
                strs.Add("Crew Scheduling Department");

                var text = String.Join("\n", strs);
                var result9 = m.enqueue(1, x.Mobile, text)[0];
                // var result10 = m2.enqueue(1, "09124449584", text)[0];
                var exist = histories.Where(q => q.ResId == x.Id).FirstOrDefault();
                if (exist != null)
                {
                    this.context.SMSHistories.Remove(exist);
                }

                this.context.SMSHistories.Add(new SMSHistory()
                {
                    DateSent = DateTime.Now,
                    RecMobile = x.Mobile,
                    RecName = x.Name,
                    Ref = result9.ToString(),
                    Text = text,
                    TypeId = 1,
                    ResId = x.Id,
                    ResFlts = x.Flights,
                    ResDate = date,
                    ResStr = "Queue",



                });

                iddels.Add(new IdDel() { Id = x.Id, Ref = result9.ToString() });


            }
            return iddels;
        }

        internal bool SendSMS(string mobile, string text, string name)
        {
            Magfa m = new Magfa();
            var result9 = m.enqueue(1, mobile, text)[0];
            this.context.SMSHistories.Add(new SMSHistory()
            {
                DateSent = DateTime.Now,
                RecMobile = mobile,
                RecName = name,
                Ref = result9.ToString(),
                Text = text,
                TypeId = 3,
            });
            this.context.SaveChanges();
            return true;
        }

        //9-14
        internal async Task<bool> SendSMSGroup(List<string> mobiles, List<string> names, string text, string sender)
        {
            Magfa m = new Magfa();
            for (int i = 0; i < mobiles.Count; i++)
            {
                var mobile = mobiles[i];
                var name = names[i];
                var result9 = m.enqueue(1, mobile, text)[0];
                this.context.SMSHistories.Add(new SMSHistory()
                {
                    DateSent = DateTime.Now,
                    RecMobile = mobile,
                    RecName = name,
                    Ref = result9.ToString(),
                    Text = text,
                    TypeId = 3,
                    Sender = sender
                });
            }

            await this.context.SaveChangesAsync();
            return true;
        }
        internal async Task<dynamic> HideVisibleDuties(List<int> Ids, DateTime date, string username)
        {
            var query = from x in this.context.FDPs
                        where Ids.Contains(x.Id)
                        select x;
            var duties = await query.ToListAsync();
            foreach (var dty in duties)
            {
                if (dty.DateConfirmed == null)
                {
                    dty.DateConfirmed = DateTime.Now;
                    dty.ConfirmedBy = username;

                }
                else
                {
                    dty.DateConfirmed = null;
                    dty.ConfirmedBy = username;
                }
            }
            return true;

        }

        internal async Task<dynamic> VisibleDuties(List<int> Ids, DateTime date, string username)
        {
            var query = from x in this.context.FDPs
                        where Ids.Contains(x.Id)
                        select x;
            var duties = await query.ToListAsync();
            foreach (var dty in duties)
            {
                if (dty.DateConfirmed == null)
                {
                    dty.DateConfirmed = DateTime.Now;
                    dty.ConfirmedBy = username;

                }

            }
            return true;

        }

        internal async Task<dynamic> VisibleDutiesByDate(DateTime dfrom, DateTime dto, string username)
        {
            var item = new FDPVisibleDate()
            {
                DateFrom = dfrom.ToLocalTime().Date,
                DateTo = dto.Date.ToLocalTime().AddDays(1).Date,
                UserName = username,
            };
            this.context.FDPVisibleDates.Add(item);
            return true;

        }

        internal async Task<dynamic> HideDuties(List<int> Ids, DateTime date, string username)
        {
            var query = from x in this.context.FDPs
                        where Ids.Contains(x.Id)
                        select x;
            var duties = await query.ToListAsync();
            foreach (var dty in duties)
            {
                if (dty.DateConfirmed != null)
                {
                    dty.DateConfirmed = null;
                    dty.ConfirmedBy = username;

                }

            }
            return true;

        }

        internal async Task<dynamic> SMSDutiesByDate(DateTime datefrom, DateTime dateto, string username = "")
        {

            var date = datefrom.ToLocalTime();
            var dfvisible = datefrom.ToLocalTime().Date;
            var dtvisible = dateto.Date.ToLocalTime().AddDays(1).Date;
            var item = new FDPVisibleDate()
            {
                DateFrom = dfvisible,
                DateTo = dtvisible,
                UserName = username,
            };
            this.context.FDPVisibleDates.Add(item);

            datefrom = datefrom.ToLocalTime().Date.ToUniversalTime();
            dateto = dateto.ToLocalTime().Date.AddDays(1).ToUniversalTime();




            var fdps = await this.context.FDPs.Where(q => (q.DateStart >= datefrom && q.DateStart <= dateto) || (q.DateEnd >= datefrom && q.DateEnd <= dateto)).ToListAsync();
            var Ids = fdps.Select(q => q.Id).ToList();
            foreach (var f in fdps)
            {
                if (f.DateConfirmed == null)
                {
                    f.DateConfirmed = DateTime.Now;
                    f.ConfirmedBy = username;
                }

            }

            var query = await (from x in this.context.ViewCrewDuties
                               where Ids.Contains(x.Id)
                               select x).ToListAsync();
            var _fids = query.Select(q => (Nullable<int>)q.Id).ToList();
            var histories = await this.context.SMSHistories.Where(q => _fids.Contains(q.ResId)).ToListAsync();
            Magfa m = new Magfa();
            Magfa m2 = new Magfa();
            List<IdDel> iddels = new List<IdDel>();
            var offs = new List<int>() { 100009, 100020, 100021, 100022, 100023 };
            foreach (var x in query)
            {

                List<string> strs = new List<string>();
                strs.Add(ConfigurationManager.AppSettings["airline"] + " Airlines");
                strs.Add("Dear " + x.Name + ",");


                var day = (DateTime)x.DateLocal;
                var _start = (DateTime)x.Start;
                var _end = (DateTime)x.End;
                var dayStr = day.ToString("ddd") + " " + day.Year + "-" + day.Month + "-" + day.Day;
                var datesent = DateTime.Now.Year + "/" + DateTime.Now.Month.ToString().PadLeft(2, '0') + "/" + DateTime.Now.Day.ToString().PadLeft(2, '0') + " " + DateTime.Now.Hour.ToString().PadLeft(2, '0') + ":" + DateTime.Now.Minute.ToString().PadLeft(2, '0');


                if (!offs.Contains(x.DutyType))
                {
                    strs.Add(x.DutyTypeTitle);
                    strs.Add(dayStr);
                    if (x.DutyType == 1165)
                    {
                        strs.Add(x.Route);
                        strs.Add(x.FltNo);
                    }
                    else
                    {
                        if (!String.IsNullOrEmpty(x.Remark))
                            strs.Add(x.Remark);
                    }
                    strs.Add("Start " + _start.ToString("ddd yy-MMM-dd HH:mm"));
                    strs.Add("End " + _end.ToString("ddd yy-MMM-dd HH:mm"));
                }
                else
                {
                    strs.Add("Canceling Notification");
                    strs.Add(dayStr);
                    strs.Add(x.CanceledNo);
                    strs.Add(x.CanceledRoute);
                    strs.Add(x.Remark2);
                    strs.Add(x.Remark);
                }




                strs.Add("Date Sent: " + datesent);
                strs.Add("Crew Scheduling Department");

                var text = String.Join("\n", strs);
                var result9 = m.enqueue(1, x.Mobile, text)[0];
                //var result10 = m2.enqueue(1, "09124449584", text)[0];
                var exist = histories.Where(q => q.ResId == x.Id).FirstOrDefault();
                if (exist != null)
                {
                    this.context.SMSHistories.Remove(exist);
                }

                this.context.SMSHistories.Add(new SMSHistory()
                {
                    DateSent = DateTime.Now,
                    RecMobile = x.Mobile,
                    RecName = x.Name,
                    Ref = result9.ToString(),
                    Text = text,
                    TypeId = 1,
                    ResId = x.Id,
                    ResFlts = !string.IsNullOrEmpty(x.FltNo) ? x.FltNo : x.Remark,
                    ResDate = date,
                    ResStr = "Queue",



                });
                var existcps = await this.context.CrewPickupSMS.FirstOrDefaultAsync(q => q.FDPId == x.Id && q.CrewId == x.CrewId);
                if (existcps != null)
                    this.context.CrewPickupSMS.Remove(existcps);
                var cps = new CrewPickupSM()
                {
                    CrewId = (int)x.CrewId,
                    DateSent = DateTime.Now,
                    DateStatus = DateTime.Now,
                    FlightId = -1,
                    Message = text,
                    Pickup = null,
                    RefId = result9.ToString(),
                    Status = "Queue",
                    Type = x.DutyType,
                    FDPId = x.Id,
                    DutyType = x.DutyTypeTitle,
                    DutyDate = x.DateLocal,


                };

                if (x.DutyType == 1165)
                {
                    cps.Flts = x.FltNo;
                    cps.Routes = x.Route;
                }
                else if (!string.IsNullOrEmpty(x.CanceledNo))
                {
                    cps.Flts = x.CanceledNo;
                    cps.Routes = x.CanceledRoute;
                }
                this.context.CrewPickupSMS.Add(cps);
                iddels.Add(new IdDel() { Id = x.Id, Ref = result9.ToString() });


            }
            return iddels;
        }
        internal async Task<dynamic> SMSDuties(List<int> Ids, DateTime date, string username = "")
        {
            var fdps = await this.context.FDPs.Where(q => Ids.Contains(q.Id)).ToListAsync();
            foreach (var f in fdps)
            {
                if (f.DateConfirmed == null)
                {
                    f.DateConfirmed = DateTime.Now;
                    f.ConfirmedBy = username;
                }

            }

            var query = await (from x in this.context.ViewCrewDuties
                               where Ids.Contains(x.Id)
                               select x).ToListAsync();
            var _fids = query.Select(q => (Nullable<int>)q.Id).ToList();
            var histories = await this.context.SMSHistories.Where(q => _fids.Contains(q.ResId)).ToListAsync();
            Magfa m = new Magfa();
            Magfa m2 = new Magfa();
            List<IdDel> iddels = new List<IdDel>();
            var offs = new List<int>() { 100009, 100020, 100021, 100022, 100023 };
            foreach (var x in query)
            {

                List<string> strs = new List<string>();
                strs.Add(ConfigurationManager.AppSettings["airline"] + " Airlines");
                strs.Add("Dear " + x.Name + ",");


                var day = (DateTime)x.DateLocal;
                var _start = (DateTime)x.Start;
                var _end = (DateTime)x.End;
                var dayStr = day.ToString("ddd") + " " + day.Year + "-" + day.Month + "-" + day.Day;
                var datesent = DateTime.Now.Year + "/" + DateTime.Now.Month.ToString().PadLeft(2, '0') + "/" + DateTime.Now.Day.ToString().PadLeft(2, '0') + " " + DateTime.Now.Hour.ToString().PadLeft(2, '0') + ":" + DateTime.Now.Minute.ToString().PadLeft(2, '0');


                if (!offs.Contains(x.DutyType))
                {
                    strs.Add(x.DutyTypeTitle);
                    strs.Add(dayStr);
                    if (x.DutyType == 1165)
                    {
                        strs.Add(x.Route);
                        strs.Add(x.FltNo);
                    }
                    else
                    {
                        if (!String.IsNullOrEmpty(x.Remark))
                            strs.Add(x.Remark);
                    }
                    strs.Add("Start " + _start.ToString("ddd yy-MMM-dd HH:mm"));
                    strs.Add("End " + _end.ToString("ddd yy-MMM-dd HH:mm"));
                }
                else
                {
                    strs.Add("Canceling Notification");
                    strs.Add(dayStr);
                    strs.Add(x.CanceledNo);
                    strs.Add(x.CanceledRoute);
                    strs.Add(x.Remark2);
                    strs.Add(x.Remark);
                }




                strs.Add("Date Sent: " + datesent);
                strs.Add("Crew Scheduling Department");

                var text = String.Join("\n", strs);
                var result9 = m.enqueue(1, x.Mobile, text)[0];
                //var result10 = m2.enqueue(1, "09124449584", text)[0];
                var exist = histories.Where(q => q.ResId == x.Id).FirstOrDefault();
                if (exist != null)
                {
                    this.context.SMSHistories.Remove(exist);
                }

                this.context.SMSHistories.Add(new SMSHistory()
                {
                    DateSent = DateTime.Now,
                    RecMobile = x.Mobile,
                    RecName = x.Name,
                    Ref = result9.ToString(),
                    Text = text,
                    TypeId = 1,
                    ResId = x.Id,
                    ResFlts = !string.IsNullOrEmpty(x.FltNo) ? x.FltNo : x.Remark,
                    ResDate = date,
                    ResStr = "Queue",



                });
                var existcps = await this.context.CrewPickupSMS.FirstOrDefaultAsync(q => q.FDPId == x.Id && q.CrewId == x.CrewId);
                if (existcps != null)
                    this.context.CrewPickupSMS.Remove(existcps);
                var cps = new CrewPickupSM()
                {
                    CrewId = (int)x.CrewId,
                    DateSent = DateTime.Now,
                    DateStatus = DateTime.Now,
                    FlightId = -1,
                    Message = text,
                    Pickup = null,
                    RefId = result9.ToString(),
                    Status = "Queue",
                    Type = x.DutyType,
                    FDPId = x.Id,
                    DutyType = x.DutyTypeTitle,
                    DutyDate = x.DateLocal,


                };

                if (x.DutyType == 1165)
                {
                    cps.Flts = x.FltNo;
                    cps.Routes = x.Route;
                }
                else if (!string.IsNullOrEmpty(x.CanceledNo))
                {
                    cps.Flts = x.CanceledNo;
                    cps.Routes = x.CanceledRoute;
                }
                this.context.CrewPickupSMS.Add(cps);
                iddels.Add(new IdDel() { Id = x.Id, Ref = result9.ToString() });


            }
            return iddels;
        }
        internal async Task<dynamic> NotifyRosterDaily(DateTime date, List<int> Ids, bool test)
        {
            var query = await (from fi in this.context.ViewFDPItems
                               join f in this.context.FDPs on fi.FDPId equals f.Id
                               join e in this.context.ViewEmployees on f.CrewId equals e.Id
                               where fi.DepartureDay == date && Ids.Contains(e.Id)
                               orderby e.Id, fi.DepartureLocal
                               select new ViewModels.RosterCrew
                               {
                                   CrewId = e.Id,
                                   Name = e.ScheduleName,
                                   DepartureLocal = fi.DepartureLocal,
                                   ArrivalLocal = fi.ArrivalLocal,
                                   FlightNumber = fi.FlightNumber,
                                   IsPositioning = fi.IsPositioning,
                                   Mobile = e.Mobile,
                                   FromAirportIATA = fi.FromAirportIATA,
                                   ToAirportIATA = fi.ToAirportIATA,
                               }
                        ).ToListAsync();

            foreach (var cid in Ids)
            {

                var items = query.Where(q => q.CrewId == cid).ToList();
                var name = items[0].Name;
                var mobile = items[0].Mobile;
                Payamak sms = new Payamak();
                Magfa m = new Magfa();
                Magfa m2 = new Magfa();

                var day = date;
                var dayStr = day.ToString("ddd") + " " + day.Year + "-" + day.Month + "-" + day.Day;
                var datesent = DateTime.Now.Year + "/" + DateTime.Now.Month.ToString().PadLeft(2, '0') + "/" + DateTime.Now.Day.ToString().PadLeft(2, '0') + " " + DateTime.Now.Hour.ToString().PadLeft(2, '0') + ":" + DateTime.Now.Minute.ToString().PadLeft(2, '0');
                List<string> flights = new List<string>();
                flights.Add(ConfigurationManager.AppSettings["airline"] + " Airlines");
                flights.Add("Dear " + name + ",");

                flights.Add(dayStr);
                foreach (var f in items)
                {
                    var std = (DateTime)f.DepartureLocal;
                    var sta = (DateTime)f.ArrivalLocal;
                    var dep = std.Hour.ToString().PadLeft(2, '0') + ":" + std.Minute.ToString().PadLeft(2, '0') + " - " + sta.Hour.ToString().PadLeft(2, '0') + ":" + sta.Minute.ToString().PadLeft(2, '0');
                    flights.Add(f.FlightNumber + "  " + f.FromAirportIATA + "-" + f.ToAirportIATA + " " + dep + (f.IsPositioning == true ? " DH" : ""));
                }
                flights.Add("Access your Crew Pocket account to see more details.");
                flights.Add("Date Sent: " + datesent);

                var text = String.Join("\n", flights);

                //if (!string.IsNullOrEmpty(mobile))
                {
                    if (test)
                    {
                        var xdd = name;
                        //var result9 = m.enqueue(1, mobile, text)[0];
                        var resultme = m2.enqueue(1, "09306678047", text)[0];
                        // sms.send("09306678047", text);
                        // sms.send("09124449584", text);
                        this.context.SMSHistories.Add(new SMSHistory()
                        {
                            DateSent = DateTime.Now,
                            RecMobile = "09306678047",
                            RecName = "Admin",
                            Ref = resultme.ToString(),
                            Text = text,
                            TypeId = 1,
                        });

                    }
                    else
                    {
                        var xdd = name;
                        var result9 = m.enqueue(1, mobile, text)[0];
                        var resultme = m2.enqueue(1, "09306678047", text)[0];
                        //sms.send("09306678047", text);
                        //sms.send("09124449584", text);
                        this.context.SMSHistories.Add(new SMSHistory()
                        {
                            DateSent = DateTime.Now,
                            RecMobile = mobile,
                            RecName = name,
                            Ref = result9.ToString(),
                            Text = text,
                            TypeId = 1,
                        });
                    }
                    ////  sms.send("09122164635", text);
                    //var xdd = name;
                    ////var result9 = m.enqueue(1, mobile, text)[0];
                    //var resultme = m2.enqueue(1, "09306678047", text)[0];
                    ////var resultm2 = m2.enqueue(1, "09122164635", text)[0];
                    //// var result_fazeli = m2.enqueue(1, "09121323295", text)[0];
                    //// var result_razbani = m2.enqueue(1, "09123938451", text)[0];
                }

            }

            return true;
        }

        internal async Task<dynamic> NotifyFDPCrews(int id)
        {
            var _fdp = await this.context.ViewFDPs.FirstOrDefaultAsync(q => q.Id == id);
            var _children = await (from x in this.context.ViewFDPs
                                   join c in this.context.ViewCrews on x.CrewId equals c.Id
                                   let items = this.context.ViewFDPItems.Where(q => q.FDPId == x.Id).OrderBy(q => q.STD)
                                   where x.TemplateId == id
                                   select new
                                   {
                                       x.CrewId
                                       ,
                                       c.ScheduleName
                                       ,
                                       c.Name
                                       ,
                                       c.Mobile
                                       ,
                                       x.Position
                                       ,
                                       x.PositionId
                                       ,
                                       x.ReportingTime
                                       ,
                                       x.ReportingTimeLocal
                                       ,
                                       x.DefaultReportingTime
                                       ,
                                       x.DefaultReportingTimeLocal
                                       ,
                                       x.ACTypeId
                                       ,
                                       x.Arrival
                                       ,
                                       x.ArrivalLocal
                                       ,
                                       x.BaseAirportId
                                       ,
                                       x.BoxId
                                       ,
                                       x.CeasedId
                                       ,
                                       x.CityId
                                       ,
                                       x.DateContact
                                       ,
                                       x.DateContactLocal
                                       ,
                                       x.DateEnd
                                       ,
                                       x.DateEndLocal
                                       ,
                                       x.DateStart
                                       ,
                                       x.DateStartDay
                                       ,
                                       x.DateStartLocal
                                       ,
                                       x.DateStartMonth
                                       ,
                                       x.DateStartYear
                                       ,
                                       x.DelayAmount
                                       ,
                                       x.DelayedReportingTime
                                       ,
                                       x.Departure
                                       ,
                                       x.DepartureLocal
                                       ,
                                       x.Duty
                                       ,
                                       x.DutyEnd
                                       ,
                                       x.DutyEndLocal
                                       ,
                                       x.DutyScheduled
                                       ,
                                       x.DutyStart
                                       ,
                                       x.DutyStartLocal
                                       ,
                                       x.DutyType
                                       ,
                                       x.DutyTypeTitle
                                       ,
                                       x.ExtendedBySplitDuty
                                       ,
                                       x.FDP
                                       ,
                                       x.FDPCount
                                       ,
                                       x.FDPEnd
                                       ,
                                       x.FDPEndLocal
                                       ,
                                       x.FDPLocationId
                                       ,
                                       x.FDPReductionByStandBy
                                       ,
                                       x.FDPRemark
                                       ,
                                       x.FDPScheduled
                                       ,
                                       x.FDPStandby
                                       ,
                                       x.FDPStandbyError
                                       ,
                                       x.FDPStandByScheduled
                                       ,
                                       x.FDPStandByScheduledError
                                       ,
                                       x.FDPStart
                                       ,
                                       x.FDPStartLocal
                                       ,
                                       x.FDPTitle
                                       ,
                                       x.FirstNotification
                                       ,
                                       x.Flights
                                       ,
                                       x.FromAirport
                                       ,
                                       x.FromAirportCityId
                                       ,
                                       x.FromAirportIATA
                                       ,
                                       x.FromAirportId
                                       ,
                                       x.Id
                                       ,
                                       x.IsCeased
                                       ,
                                       x.IsDutyOver
                                       ,
                                       x.JobGroupId

                                       ,
                                       x.MaxFDP
                                       ,
                                       x.MaxFDPExtended
                                       ,
                                       x.NextNotification
                                       ,
                                       x.RestFrom
                                       ,
                                       x.RestFromLocal
                                       ,
                                       x.RestUntil
                                       ,
                                       x.RestUntilLocal
                                       ,
                                       x.RevisedDelayedReportingTime
                                       ,
                                       x.Sectors
                                       ,
                                       x.STA
                                       ,
                                       x.STALocal
                                       ,
                                       x.StandByDuration
                                       ,
                                       x.StandById
                                       ,
                                       x.StandByStart
                                       ,
                                       x.StandByStartLocal
                                       ,
                                       x.STD
                                       ,
                                       x.STDLocal
                                       ,
                                       x.ToAirport
                                       ,
                                       x.ToAirportIATA
                                       ,
                                       x.ToAirportId
                                       ,
                                       x.TemplateId
                                       ,
                                       Items = items

                                   }).ToListAsync();

            //var result = new
            //{
            //    fdp = _fdp,
            //    children = _children
            //};
            Payamak sms = new Payamak();
            var day = (DateTime)_fdp.DefaultReportingTimeLocal;
            var dayStr = day.Year + "-" + day.Month + "-" + day.Day;
            var rep = day.Year + "/" + day.Month.ToString().PadLeft(2, '0') + "/" + day.Day.ToString().PadLeft(2, '0') + " " + day.Hour.ToString().PadLeft(2, '0') + ":" + day.Minute.ToString().PadLeft(2, '0');
            foreach (var x in _children)
            {
                var datesent = DateTime.Now.Year + "/" + DateTime.Now.Month.ToString().PadLeft(2, '0') + "/" + DateTime.Now.Day.ToString().PadLeft(2, '0') + " " + DateTime.Now.Hour.ToString().PadLeft(2, '0') + ":" + DateTime.Now.Minute.ToString().PadLeft(2, '0');
                List<string> flights = new List<string>();
                flights.Add("FlyPersia");
                flights.Add("Dear " + x.Name + ",");
                flights.Add(dayStr);
                flights.Add(_fdp.FDPTitle);
                flights.Add(_fdp.FDPRemark);
                flights.Add("Default Reporting Time");
                flights.Add(rep);
                flights.Add("Legs:");

                foreach (var f in x.Items)
                {

                    var std = (DateTime)f.DepartureLocal;
                    var sta = (DateTime)f.ArrivalLocal;
                    var dep = std.Hour.ToString().PadLeft(2, '0') + ":" + std.Minute.ToString().PadLeft(2, '0') + " - " + sta.Hour.ToString().PadLeft(2, '0') + ":" + sta.Minute.ToString().PadLeft(2, '0');
                    flights.Add(f.FlightNumber + "  " + f.FromAirportIATA + "-" + f.ToAirportIATA + " " + dep);
                }
                flights.Add("Access your Crew Pocket account to see more details.");
                flights.Add("Date Sent: " + datesent);

                var text = String.Join("\n", flights);
                if (!string.IsNullOrEmpty(x.Mobile))
                {
                    sms.send(x.Mobile, text);
                }
            }

            return true;


        }

        internal async Task<dynamic> GetFDPChildren(int id)
        {
            var _fdp = await this.context.ViewFDPs.FirstOrDefaultAsync(q => q.Id == id);
            var _children = await (from x in this.context.ViewFDPs
                                   join c in this.context.ViewCrews on x.CrewId equals c.Id
                                   let items = this.context.ViewFDPItems.Where(q => q.FDPId == x.Id).OrderBy(q => q.STD)
                                   where x.TemplateId == id
                                   select new
                                   {
                                       x.CrewId
                                       ,
                                       c.ScheduleName
                                       ,
                                       c.Name
                                       ,
                                       x.Position
                                       ,
                                       x.PositionId
                                       ,
                                       x.ReportingTime
                                       ,
                                       x.ReportingTimeLocal
                                       ,
                                       x.DefaultReportingTime
                                       ,
                                       x.DefaultReportingTimeLocal
                                       ,
                                       x.ACTypeId
                                       ,
                                       x.Arrival
                                       ,
                                       x.ArrivalLocal
                                       ,
                                       x.BaseAirportId
                                       ,
                                       x.BoxId
                                       ,
                                       x.CeasedId
                                       ,
                                       x.CityId
                                       ,
                                       x.DateContact
                                       ,
                                       x.DateContactLocal
                                       ,
                                       x.DateEnd
                                       ,
                                       x.DateEndLocal
                                       ,
                                       x.DateStart
                                       ,
                                       x.DateStartDay
                                       ,
                                       x.DateStartLocal
                                       ,
                                       x.DateStartMonth
                                       ,
                                       x.DateStartYear
                                       ,
                                       x.DelayAmount
                                       ,
                                       x.DelayedReportingTime
                                       ,
                                       x.Departure
                                       ,
                                       x.DepartureLocal
                                       ,
                                       x.Duty
                                       ,
                                       x.DutyEnd
                                       ,
                                       x.DutyEndLocal
                                       ,
                                       x.DutyScheduled
                                       ,
                                       x.DutyStart
                                       ,
                                       x.DutyStartLocal
                                       ,
                                       x.DutyType
                                       ,
                                       x.DutyTypeTitle
                                       ,
                                       x.ExtendedBySplitDuty
                                       ,
                                       x.FDP
                                       ,
                                       x.FDPCount
                                       ,
                                       x.FDPEnd
                                       ,
                                       x.FDPEndLocal
                                       ,
                                       x.FDPLocationId
                                       ,
                                       x.FDPReductionByStandBy
                                       ,
                                       x.FDPRemark
                                       ,
                                       x.FDPScheduled
                                       ,
                                       x.FDPStandby
                                       ,
                                       x.FDPStandbyError
                                       ,
                                       x.FDPStandByScheduled
                                       ,
                                       x.FDPStandByScheduledError
                                       ,
                                       x.FDPStart
                                       ,
                                       x.FDPStartLocal
                                       ,
                                       x.FDPTitle
                                       ,
                                       x.FirstNotification
                                       ,
                                       x.Flights
                                       ,
                                       x.FromAirport
                                       ,
                                       x.FromAirportCityId
                                       ,
                                       x.FromAirportIATA
                                       ,
                                       x.FromAirportId
                                       ,
                                       x.Id
                                       ,
                                       x.IsCeased
                                       ,
                                       x.IsDutyOver
                                       ,
                                       x.JobGroupId

                                       ,
                                       x.MaxFDP
                                       ,
                                       x.MaxFDPExtended
                                       ,
                                       x.NextNotification
                                       ,
                                       x.RestFrom
                                       ,
                                       x.RestFromLocal
                                       ,
                                       x.RestUntil
                                       ,
                                       x.RestUntilLocal
                                       ,
                                       x.RevisedDelayedReportingTime
                                       ,
                                       x.Sectors
                                       ,
                                       x.STA
                                       ,
                                       x.STALocal
                                       ,
                                       x.StandByDuration
                                       ,
                                       x.StandById
                                       ,
                                       x.StandByStart
                                       ,
                                       x.StandByStartLocal
                                       ,
                                       x.STD
                                       ,
                                       x.STDLocal
                                       ,
                                       x.ToAirport
                                       ,
                                       x.ToAirportIATA
                                       ,
                                       x.ToAirportId
                                       ,
                                       x.TemplateId
                                       ,
                                       Items = items

                                   }).ToListAsync();

            var result = new
            {
                fdp = _fdp,
                children = _children
            };

            return result;


        }

        internal async Task<List<ViewFlightInformation>> Getflights(DateTime date, DateTime dateTo, int tzoffset, int cid)
        {
            dateTo = dateTo.AddHours(23).AddMinutes(59).AddSeconds(59);
            var _df = date.AddMinutes(0);
            var _dt = dateTo.AddMinutes(0);
            var flights = await (from x in this.context.ViewFlightInformations.AsNoTracking()
                                 where x.DepartureLocal >= _df && x.ArrivalLocal <= _dt
                                 orderby x.RegisterID, x.DepartureLocal
                                 select x).ToListAsync();
            return flights;
        }

        internal async Task<object> GetAssignCrewFlights(DateTime date, DateTime dateTo, int tzoffset, bool design, int cid, int planid)
        {
            dateTo = dateTo.AddHours(23).AddMinutes(59).AddSeconds(59);

            //var _df = date.AddMinutes(-tzoffset);
            //var _dt = dateTo.AddMinutes(-tzoffset);
            var _df = date.AddMinutes(0);
            var _dt = dateTo.AddMinutes(0);

            var fdps = await (from x in this.context.ViewFDPRests
                              where x.IsTemplate && (x.STDLocal >= _df && x.STALocal <= _dt)
                              select x).ToListAsync();
            var fdpIds = fdps.Select(q => q.Id).ToList();

            var fdpItems = await (from x in this.context.ViewFDPItems.AsNoTracking()
                                  where fdpIds.Contains(x.FDPId)
                                  select x).ToListAsync();
            var flightIds = fdpItems.Select(q => q.FlightId).ToList();

            var flights = await (from x in this.context.ViewFlightInformations.AsNoTracking()
                                 where x.DepartureLocal >= _df && x.ArrivalLocal <= _dt && x.CPCrewId == null
                                 select x).ToListAsync();
            Dictionary<int, List<int>> flight_box = new Dictionary<int, List<int>>();
            List<ViewFlightInformation> boxedFlights = new List<ViewFlightInformation>();
            foreach (var x in fdpItems)
            {
                var f = flights.FirstOrDefault(q => q.ID == x.FlightId);
                if (f != null)
                {
                    List<int> _res = new List<int>();
                    if (!flight_box.TryGetValue(f.ID, out _res))
                    {
                        _res = new List<int>() { x.FDPId };
                        flight_box.Add(f.ID, _res);
                    }
                    else
                        _res.Add(x.FDPId);
                    var _flight = Helper.DeepClone<ViewFlightInformation>(f);
                    _flight.BoxId = x.FDPId;
                    boxedFlights.Add(_flight);

                    //f.BoxId = x.FDPId;
                }
            }
            // boxedFlights = flights.Where(q => q.BoxId != null).ToList();
            var unboxedFlights = flights.Where(q => boxedFlights.FirstOrDefault(w => w.ID == q.ID) == null   /* q.BoxId == null*/).ToList();

            var boxedFlights2 = (from x in flights
                                 where boxedFlights.FirstOrDefault(q => q.ID == x.ID) != null
                                 select x).ToList();

            var flightsdto = new List<ViewModels.ViewFlightInformationDto>();

            foreach (var x in unboxedFlights)
            //foreach (var x in flights)
            {

                ViewModels.ViewFlightInformationDto dto = new ViewFlightInformationDto();
                ViewModels.ViewFlightInformationDto.FillDto(x, dto, tzoffset);
                dto.ResKey = (-dto.RegisterID).ToString(); //dto.RegisterID.ToString();
                dto.ResTitle = dto.Register;
                dto.HasCrew = false;
                dto.HasCrewProblem = false;
                dto.AllCrewAssigned = false;
                dto.DutyStartLocal = ((DateTime)dto.STD).Date;
                dto.DutyEndLocal = ((DateTime)dto.STA).Date;
                flightsdto.Add(dto);


            }
            ////////////////////////
            foreach (var x in boxedFlights2)
            ////foreach (var x in flights)
            {

                ViewModels.ViewFlightInformationDto dto = new ViewFlightInformationDto();
                ViewModels.ViewFlightInformationDto.FillDto(x, dto, tzoffset);
                dto.ResKey = (-dto.RegisterID).ToString();
                dto.ResTitle = dto.Register;
                dto.DutyStartLocal = ((DateTime)dto.STD).Date;
                dto.DutyEndLocal = ((DateTime)dto.STA).Date;
                dto.HasCrew = false;
                dto.HasCrewProblem = false;
                dto.AllCrewAssigned = false;
                flightsdto.Add(dto);


            }
            ///////////////////////////
            var boxes = (from x in boxedFlights
                         group x by x.BoxId into g
                         select g).ToList();
            var boxids = fdpIds;


            foreach (var group in boxes)
            {
                var box = group.OrderBy(q => q.STD).ToList();
                var boxedFlight = new ViewFlightInformation();
                string str = JsonConvert.SerializeObject(box.First());
                boxedFlight = JsonConvert.DeserializeObject<ViewFlightInformation>(str);
                var boxItems = new List<ViewFlightInformationDto>();
                foreach (var _f in box)
                {

                    ViewModels.ViewFlightInformationDto dto = new ViewFlightInformationDto();
                    ViewModels.ViewFlightInformationDto.FillDto(_f, dto, tzoffset);
                    //dto.SplitDuty=
                    var fdpitem = fdpItems.FirstOrDefault(q => q.FlightId == _f.ID && q.FDPId == group.Key);
                    if (fdpitem != null)
                    {
                        dto.SplitDuty = fdpitem.SplitDuty == true;
                        dto.IsPositioning = fdpitem.IsPositioning == true;
                    }
                    boxItems.Add(dto);
                }
                // boxedFlight.taskId = 1000000 + boxedFlight.taskId;
                //boxedFlight.ID = 1000000 + boxedFlight.ID;
                boxedFlight.taskId = 1000000 + (int)group.Key;
                boxedFlight.ID = 1000000 + (int)group.Key;
                boxedFlight.FlightNumber = "ATI" + boxedFlight.FlightNumber;
                boxedFlight.ToAirport = box.Last().ToAirport;
                //boxedFlight.ToAirportCity = box.Last().ToAirportCity;
                // boxedFlight.ToAirportCityId = box.Last().ToAirportCityId;
                boxedFlight.ToAirportIATA = box.Last().ToAirportIATA;
                boxedFlight.ToAirportName = box.Last().ToAirportName;
                //boxedFlight.ToCity = box.Last().ToCity;
                // boxedFlight.ToCountry = box.Last().ToCountry;
                boxedFlight.ToLatitude = box.Last().ToLatitude;
                boxedFlight.ToLongitude = box.Last().ToLongitude;
                //boxedFlight.ToSortName = box.Last().ToSortName;
                boxedFlight.to = box.Last().ToAirportIATA;
                boxedFlight.STA = box.Last().STA;
                boxedFlight.duration = Convert.ToDecimal(((DateTime)box.Last().STA).Subtract((DateTime)boxedFlight.STD).TotalHours);
                boxedFlight.FlightH = Convert.ToInt32(Math.Truncate((decimal)boxedFlight.duration));
                boxedFlight.FlightM = Convert.ToByte((boxedFlight.duration - Math.Truncate((decimal)boxedFlight.duration)) * 60);
                boxedFlight.taskName = boxedFlight.FromAirportIATA + " -" + boxedFlight.FlightNumber + "- " + boxedFlight.ToAirportIATA;


                ViewModels.ViewFlightInformationDto bdto = new ViewFlightInformationDto();
                ViewModels.ViewFlightInformationDto.FillDto(boxedFlight, bdto, tzoffset);

                bdto.IsBox = true;

                bdto.BoxId = box.First().BoxId;
                var viewbox = fdps.FirstOrDefault(q => q.Id == bdto.BoxId);
                bdto.Date = viewbox.STD;
                bdto.Duty = viewbox.FDP;
                // bdto.Flight = viewbox.Flight;
                bdto.IsDutyOver = viewbox.IsDutyOver;
                bdto.DutyEndLocal = viewbox.DutyEndLocal;
                bdto.DutyStartLocal = viewbox.DutyStartLocal;
                bdto.WOCLError = 0; //viewbox.WOCLError;
                bdto.MaxFDPExtended = viewbox.MaxFDPExtended;
                bdto.BoxItems = boxItems.ToList();
                bdto.MaleFemalError = boxItems.FirstOrDefault(q => q.MaleFemalError == 1) != null ? 1 : 0;
                var match = boxItems.Sum(q => q.MatchingListError == null ? 0 : q.MatchingListError);
                bdto.MatchingListError = match;
                bdto.HasCrew = false; //viewbox.FDPCount > 0;
                bdto.HasCrewProblem = false;//viewbox.CrewProblemCount > 0;
                bdto.AllCrewAssigned = false; //viewbox.NotAllAssignedCount == 0;
                bdto.ExtendedBySplitDuty = viewbox.ExtendedBySplitDuty == 1;
                bdto.Flights = viewbox.Id.ToString();//viewbox.Flights;

                bdto.ResKey = viewbox.Id.ToString();
                bdto.ResTitle = viewbox.Id.ToString(); //viewbox.FDPTitle;

                flightsdto.Add(bdto);

            }





            var resgroups = from x in flights
                            group x by new { x.AircraftType, AircraftTypeId = x.TypeId }
                            into grp
                            select new { groupId = grp.Key.AircraftTypeId, Title = grp.Key.AircraftType };
            var resgroupsList = resgroups.ToList();
            var ressq = (from x in flightsdto
                             //group x by new { x.RegisterID, x.Register, x.TypeId }
                         group x by new { x.ResKey, x.ResTitle, x.TypeId, x.DutyStartLocal, x.DutyEndLocal }
                     into grp
                         //select new resource() { resourceId = (int)grp.Key.RegisterID, resourceName = grp.Key.Register, groupId = grp.Key.TypeId, assigned = false, registers = string.Empty }).ToList();
                         select new resource() { resourceId = Convert.ToInt32(grp.Key.ResKey), resourceName = grp.Key.ResTitle, groupId = grp.Key.TypeId, assigned = false, registers = string.Empty, DutyEndLocal = grp.Key.DutyEndLocal, DutyStartLocal = grp.Key.DutyStartLocal }).ToList();

            //var ressq2 = (from x in boxedFlights
            //             group x by new { RegisterID= - x.RegisterID, x.Register, x.TypeId }
            //        into grp
            //             select new resource() { resourceId = (int)grp.Key.RegisterID, resourceName = grp.Key.Register, groupId = grp.Key.TypeId, assigned = false, registers = string.Empty }).ToList();

            //ressq = ressq.Concat(ressq2).ToList();

            foreach (var x in flightsdto)
            {
                x.resourceId.Add(Convert.ToInt32(x.ResKey));
                // x.resourceId.Add((int)x.RegisterID);

            }
            //ati flights
            var result = new
            {
                flights = flightsdto,
                resourceGroups = resgroupsList,
                resources = ressq,
                //   registers = _registers,
            };
            return result;
            ////////////////////////
            ////////////////////////

        }
        //pati
        internal async Task<object> GetAssignCrewFlightsReg(DateTime date, DateTime dateTo, int tzoffset, bool design, int cid, int planid)
        {
            dateTo = dateTo.AddHours(23).AddMinutes(59).AddSeconds(59);

            //var _df = date.AddMinutes(-tzoffset);
            //var _dt = dateTo.AddMinutes(-tzoffset);
            var _df = date.AddMinutes(0);
            var _dt = dateTo.AddMinutes(0);

            var fdps = await (from x in this.context.ViewFDPs
                              where x.IsTemplate && (x.STDLocal >= _df && x.STALocal <= _dt)
                              select x).ToListAsync();
            var fdpIds = fdps.Select(q => q.Id).ToList();

            var fdpItems = await (from x in this.context.ViewFDPItems.AsNoTracking()
                                  where fdpIds.Contains(x.FDPId)
                                  select x).ToListAsync();
            var flightIds = fdpItems.Select(q => q.FlightId).ToList();

            var flights = await (from x in this.context.ViewFlightInformations.AsNoTracking()
                                 where x.DepartureLocal >= _df && x.ArrivalLocal <= _dt
                                 select x).ToListAsync();
            Dictionary<int, List<int>> flight_box = new Dictionary<int, List<int>>();
            List<ViewFlightInformation> boxedFlights = new List<ViewFlightInformation>();
            foreach (var x in fdpItems)
            {
                var f = flights.FirstOrDefault(q => q.ID == x.FlightId);
                if (f != null)
                {
                    List<int> _res = new List<int>();
                    if (!flight_box.TryGetValue(f.ID, out _res))
                    {
                        _res = new List<int>() { x.FDPId };
                        flight_box.Add(f.ID, _res);
                    }
                    else
                        _res.Add(x.FDPId);
                    var _flight = Helper.DeepClone<ViewFlightInformation>(f);
                    _flight.BoxId = x.FDPId;
                    boxedFlights.Add(_flight);

                    //f.BoxId = x.FDPId;
                }
            }
            // boxedFlights = flights.Where(q => q.BoxId != null).ToList();
            var unboxedFlights = flights.Where(q => boxedFlights.FirstOrDefault(w => w.ID == q.ID) == null   /* q.BoxId == null*/).ToList();

            var boxedFlights2 = (from x in flights
                                 where boxedFlights.FirstOrDefault(q => q.ID == x.ID) != null
                                 select x).ToList();

            var flightsdto = new List<ViewModels.ViewFlightInformationDto>();

            foreach (var x in unboxedFlights)
            //foreach (var x in flights)
            {

                ViewModels.ViewFlightInformationDto dto = new ViewFlightInformationDto();
                ViewModels.ViewFlightInformationDto.FillDto(x, dto, tzoffset);
                dto.ResKey = (-dto.RegisterID).ToString(); //dto.RegisterID.ToString();
                dto.ResTitle = dto.Register;
                dto.HasCrew = false;
                dto.HasCrewProblem = false;
                dto.AllCrewAssigned = false;
                dto.DutyStartLocal = ((DateTime)dto.STD).Date;
                dto.DutyEndLocal = ((DateTime)dto.STA).Date;
                flightsdto.Add(dto);


            }
            ////////////////////////
            foreach (var x in boxedFlights2)
            ////foreach (var x in flights)
            {

                ViewModels.ViewFlightInformationDto dto = new ViewFlightInformationDto();
                ViewModels.ViewFlightInformationDto.FillDto(x, dto, tzoffset);
                dto.ResKey = (-dto.RegisterID).ToString();
                dto.ResTitle = dto.Register;
                dto.DutyStartLocal = ((DateTime)dto.STD).Date;
                dto.DutyEndLocal = ((DateTime)dto.STA).Date;
                dto.HasCrew = false;
                dto.HasCrewProblem = false;
                dto.AllCrewAssigned = false;
                flightsdto.Add(dto);


            }
            ///////////////////////////
            var boxes = (from x in boxedFlights
                         group x by x.BoxId into g
                         select g).ToList();
            var boxids = fdpIds;


            foreach (var group in boxes)
            {
                var box = group.OrderBy(q => q.STD).ToList();
                var boxedFlight = new ViewFlightInformation();
                string str = JsonConvert.SerializeObject(box.First());
                boxedFlight = JsonConvert.DeserializeObject<ViewFlightInformation>(str);
                var boxItems = new List<ViewFlightInformationDto>();
                foreach (var _f in box)
                {

                    ViewModels.ViewFlightInformationDto dto = new ViewFlightInformationDto();
                    ViewModels.ViewFlightInformationDto.FillDto(_f, dto, tzoffset);
                    //dto.SplitDuty=
                    var fdpitem = fdpItems.FirstOrDefault(q => q.FlightId == _f.ID && q.FDPId == group.Key);
                    if (fdpitem != null)
                    {
                        dto.SplitDuty = fdpitem.SplitDuty == true;
                        dto.IsPositioning = fdpitem.IsPositioning == true;
                    }
                    boxItems.Add(dto);
                }
                // boxedFlight.taskId = 1000000 + boxedFlight.taskId;
                //boxedFlight.ID = 1000000 + boxedFlight.ID;
                boxedFlight.taskId = 1000000 + (int)group.Key;
                boxedFlight.ID = 1000000 + (int)group.Key;
                boxedFlight.FlightNumber = "ATI" + boxedFlight.FlightNumber;
                boxedFlight.ToAirport = box.Last().ToAirport;
                // boxedFlight.ToAirportCity = box.Last().ToAirportCity;
                // boxedFlight.ToAirportCityId = box.Last().ToAirportCityId;
                boxedFlight.ToAirportIATA = box.Last().ToAirportIATA;
                boxedFlight.ToAirportName = box.Last().ToAirportName;
                //boxedFlight.ToCity = box.Last().ToCity;
                // boxedFlight.ToCountry = box.Last().ToCountry;
                boxedFlight.ToLatitude = box.Last().ToLatitude;
                boxedFlight.ToLongitude = box.Last().ToLongitude;
                // boxedFlight.ToSortName = box.Last().ToSortName;
                boxedFlight.to = box.Last().ToAirportIATA;
                boxedFlight.STA = box.Last().STA;
                boxedFlight.duration = Convert.ToDecimal(((DateTime)box.Last().STA).Subtract((DateTime)boxedFlight.STD).TotalHours);
                boxedFlight.FlightH = Convert.ToInt32(Math.Truncate((decimal)boxedFlight.duration));
                boxedFlight.FlightM = Convert.ToByte((boxedFlight.duration - Math.Truncate((decimal)boxedFlight.duration)) * 60);
                boxedFlight.taskName = boxedFlight.FromAirportIATA + " -" + boxedFlight.FlightNumber + "- " + boxedFlight.ToAirportIATA;


                ViewModels.ViewFlightInformationDto bdto = new ViewFlightInformationDto();
                ViewModels.ViewFlightInformationDto.FillDto(boxedFlight, bdto, tzoffset);

                bdto.IsBox = true;

                bdto.BoxId = box.First().BoxId;
                var viewbox = fdps.FirstOrDefault(q => q.Id == bdto.BoxId);
                bdto.Date = viewbox.STD;
                bdto.Duty = viewbox.FDP;
                // bdto.Flight = viewbox.Flight;
                bdto.IsDutyOver = viewbox.IsDutyOver;
                bdto.DutyEndLocal = viewbox.DutyEndLocal;
                bdto.DutyStartLocal = viewbox.DutyStartLocal;
                bdto.WOCLError = viewbox.WOCLError;
                bdto.MaxFDPExtended = viewbox.MaxFDPExtended;
                bdto.BoxItems = boxItems.ToList();
                bdto.MaleFemalError = boxItems.FirstOrDefault(q => q.MaleFemalError == 1) != null ? 1 : 0;
                var match = boxItems.Sum(q => q.MatchingListError == null ? 0 : q.MatchingListError);
                bdto.MatchingListError = match;
                bdto.HasCrew = viewbox.FDPCount > 0;
                bdto.HasCrewProblem = false;//viewbox.CrewProblemCount > 0;
                bdto.AllCrewAssigned = false; //viewbox.NotAllAssignedCount == 0;
                bdto.ExtendedBySplitDuty = viewbox.ExtendedBySplitDuty == 1;
                bdto.Flights = viewbox.Flights;

                bdto.ResKey = viewbox.Id.ToString();
                bdto.ResTitle = viewbox.FDPTitle;

                flightsdto.Add(bdto);

            }





            var resgroups = from x in flights
                            group x by new { x.AircraftType, AircraftTypeId = x.TypeId }
                            into grp
                            select new { groupId = grp.Key.AircraftTypeId, Title = grp.Key.AircraftType };
            var resgroupsList = resgroups.ToList();
            var ressq = (from x in flightsdto
                             //group x by new { x.RegisterID, x.Register, x.TypeId }
                         group x by new { x.ResKey, x.ResTitle, x.TypeId, x.DutyStartLocal, x.DutyEndLocal }
                     into grp
                         //select new resource() { resourceId = (int)grp.Key.RegisterID, resourceName = grp.Key.Register, groupId = grp.Key.TypeId, assigned = false, registers = string.Empty }).ToList();
                         select new resource() { resourceId = Convert.ToInt32(grp.Key.ResKey), resourceName = grp.Key.ResTitle, groupId = grp.Key.TypeId, assigned = false, registers = string.Empty, DutyEndLocal = grp.Key.DutyEndLocal, DutyStartLocal = grp.Key.DutyStartLocal }).ToList();

            //var ressq2 = (from x in boxedFlights
            //             group x by new { RegisterID= - x.RegisterID, x.Register, x.TypeId }
            //        into grp
            //             select new resource() { resourceId = (int)grp.Key.RegisterID, resourceName = grp.Key.Register, groupId = grp.Key.TypeId, assigned = false, registers = string.Empty }).ToList();

            //ressq = ressq.Concat(ressq2).ToList();

            foreach (var x in flightsdto)
            {
                x.resourceId.Add(Convert.ToInt32(x.ResKey));
                // x.resourceId.Add((int)x.RegisterID);

            }
            //ati flights
            var result = new
            {
                flights = flightsdto,
                resourceGroups = resgroupsList,
                resources = ressq,
                //   registers = _registers,
            };
            return result;
            ////////////////////////
            ////////////////////////

        }
        internal async Task<object> GetPlanItemsGanttCrewTestByFlights(DateTime date, DateTime dateTo, int tzoffset, bool design, int cid, int planid)
        {
            dateTo = dateTo.AddHours(23).AddMinutes(59).AddSeconds(59);

            var _df = date.AddMinutes(-tzoffset);
            var _dt = dateTo.AddMinutes(-tzoffset);

            var plansQuery = from x in this.context.ViewFlightPlans
                             where (x.DateFrom >= date && x.DateTo <= dateTo) && x.CustomerId == cid
                             select x;
            var flightsQuery =// from x in this.context.ViewFlightPlanItems
                 from x in this.context.ViewFlightInformations
                 where (x.STD >= _df && x.STA <= _dt) && x.CustomerId == cid
                 select x;

            if (planid != -1)
                flightsQuery = flightsQuery.Where(q => q.FlightPlanId == planid);



            var flights = await flightsQuery.ToListAsync();

            var boxedFlights = flights.Where(q => q.BoxId != null).ToList();
            var unboxedFlights = flights.Where(q => q.BoxId == null).ToList();

            var flightsdto = new List<ViewModels.ViewFlightInformationDto>(); //new List<ViewModels.ViewFlightPlanItemDto>();

            foreach (var x in unboxedFlights)
            {

                ViewModels.ViewFlightInformationDto dto = new ViewFlightInformationDto();
                ViewModels.ViewFlightInformationDto.FillDto(x, dto, tzoffset);
                dto.HasCrew = false;
                dto.HasCrewProblem = false;
                dto.AllCrewAssigned = false;
                flightsdto.Add(dto);


            }
            //oks
            var boxes = (from x in boxedFlights
                         group x by x.BoxId into g
                         select g).ToList();
            var boxids = boxes.Select(q => q.Key).ToList();
            var boxReqs = await this.context.ViewBoxCrewRequirements.Where(q => boxids.Contains(q.Id) && q.Assigned != q.Min).Select(q => q.Id).ToListAsync();
            var viewboxes = await this.context.ViewBoxes.Where(q => boxids.Contains(q.Id)).ToListAsync();
            foreach (var group in boxes)
            {
                var box = group.OrderBy(q => q.STD).ToList();
                var boxedFlight = new ViewFlightInformation();
                string str = JsonConvert.SerializeObject(box.First());
                boxedFlight = JsonConvert.DeserializeObject<ViewFlightInformation>(str);
                var boxItems = new List<ViewFlightInformationDto>();
                foreach (var _f in box)
                {

                    ViewModels.ViewFlightInformationDto dto = new ViewFlightInformationDto();
                    ViewModels.ViewFlightInformationDto.FillDto(_f, dto, tzoffset);
                    boxItems.Add(dto);
                }
                boxedFlight.taskId = 1000000 + boxedFlight.taskId;
                boxedFlight.ID = 1000000 + boxedFlight.ID;
                boxedFlight.FlightNumber = "ATI" + boxedFlight.FlightNumber;
                boxedFlight.ToAirport = box.Last().ToAirport;
                // boxedFlight.ToAirportCity = box.Last().ToAirportCity;
                // boxedFlight.ToAirportCityId = box.Last().ToAirportCityId;
                boxedFlight.ToAirportIATA = box.Last().ToAirportIATA;
                boxedFlight.ToAirportName = box.Last().ToAirportName;
                //  boxedFlight.ToCity = box.Last().ToCity;
                // boxedFlight.ToCountry = box.Last().ToCountry;
                boxedFlight.ToLatitude = box.Last().ToLatitude;
                boxedFlight.ToLongitude = box.Last().ToLongitude;
                //  boxedFlight.ToSortName = box.Last().ToSortName;
                boxedFlight.to = box.Last().ToAirportIATA;
                boxedFlight.STA = box.Last().STA;
                boxedFlight.duration = Convert.ToDecimal(((DateTime)box.Last().STA).Subtract((DateTime)boxedFlight.STD).TotalHours);
                boxedFlight.FlightH = Convert.ToInt32(Math.Truncate((decimal)boxedFlight.duration));
                boxedFlight.FlightM = Convert.ToByte((boxedFlight.duration - Math.Truncate((decimal)boxedFlight.duration)) * 60);
                boxedFlight.taskName = boxedFlight.FromAirportIATA + " -" + boxedFlight.FlightNumber + "- " + boxedFlight.ToAirportIATA;


                ViewModels.ViewFlightInformationDto bdto = new ViewFlightInformationDto();
                ViewModels.ViewFlightInformationDto.FillDto(boxedFlight, bdto, tzoffset);

                bdto.IsBox = true;
                bdto.BoxId = box.First().BoxId;
                var viewbox = viewboxes.FirstOrDefault(q => q.Id == bdto.BoxId);
                bdto.Date = viewbox.Date;
                bdto.Duty = viewbox.Duty;
                bdto.Flight = viewbox.Flight;
                bdto.IsDutyOver = viewbox.IsDutyOver;
                bdto.WOCLError = viewbox.WOCLError;
                bdto.MaxFDPExtended = viewbox.MaxFDPExtended;
                bdto.BoxItems = boxItems.ToList();
                bdto.HasCrew = viewbox.AssignedCrewCount > 0;
                bdto.HasCrewProblem = viewbox.CrewProblemCount > 0;
                bdto.AllCrewAssigned = viewbox.NotAllAssignedCount == 0;
                flightsdto.Add(bdto);

            }





            var resgroups = from x in flights
                            group x by new { x.AircraftType, AircraftTypeId = x.TypeId }
                            into grp
                            select new { groupId = grp.Key.AircraftTypeId, Title = grp.Key.AircraftType };
            var resgroupsList = resgroups.ToList();
            var ressq = (from x in flights
                         group x by new { x.RegisterID, x.Register, x.TypeId }
                     into grp
                         select new resource() { resourceId = (int)grp.Key.RegisterID, resourceName = grp.Key.Register, groupId = grp.Key.TypeId, assigned = false, registers = string.Empty }).ToList();



            foreach (var x in flightsdto)
            {
                //if (x.RegisterID >= 0)
                x.resourceId.Add((int)x.RegisterID);
                // else
                //    x.resourceId.Add((int)ress.First(q => q.resourceName == x.Register).resourceId);
            }

            var result = new
            {
                flights = flightsdto,
                resourceGroups = resgroupsList,
                resources = ressq,
                //   registers = _registers,
            };
            return result;
        }
        internal async Task<object> GetPlanItemsGanttCrewTest(DateTime date, int tzoffset, bool design, int cid, int planid)
        {
            //var boxNos = new List<string>() { "2500","2501","2502"};
            var plansQuery = from x in this.context.ViewFlightPlans
                             where x.DateFrom == date && x.CustomerId == cid
                             select x;
            var flightsQuery =// from x in this.context.ViewFlightPlanItems
                 from x in this.context.ViewFlightPlanItemCalanders
                 where x.Date == date && x.CustomerId == cid
                 select x;
            if (design)
            {
                plansQuery = plansQuery.Where(q => q.IsApproved50 == 0);
                flightsQuery = flightsQuery.Where(q => q.IsApproved50 == 0);
            }
            if (planid != -1)
                flightsQuery = flightsQuery.Where(q => q.FlightPlanId == planid);
            flightsQuery = flightsQuery.Where(q => q.IsApproved50 == 1);
            var plans = await this.context.FlightPlans.ToListAsync();


            //var flights = await this.context.ViewFlightPlanItems.Where(q => q.FlightPlanId == pid).ToListAsync();
            var flights = await flightsQuery.ToListAsync();

            var boxedFlights = flights.Where(q => q.BoxId != null).ToList();
            var unboxedFlights = flights.Where(q => q.BoxId == null).ToList();

            var flightsdto = new List<ViewModels.ViewFlightPlanItemCalanderDto>(); //new List<ViewModels.ViewFlightPlanItemDto>();

            foreach (var x in unboxedFlights)
            {
                // ViewModels.ViewFlightPlanItemDto dto = new ViewFlightPlanItemDto();
                //  ViewModels.ViewFlightPlanItemDto.FillDto(x, dto, tzoffset);

                ViewModels.ViewFlightPlanItemCalanderDto dto = new ViewFlightPlanItemCalanderDto();
                ViewModels.ViewFlightPlanItemCalanderDto.FillDto(x, dto, tzoffset);
                dto.HasCrew = false;
                dto.HasCrewProblem = false;
                dto.AllCrewAssigned = false;
                flightsdto.Add(dto);
                //if (boxNos.IndexOf(x.FlightNumber) == -1)
                //{

                //    flightsdto.Add(dto);
                //}
                //else
                //{
                //    box.Add(x);
                //    boxItems.Add(dto);
                //}

            }

            var boxes = (from x in boxedFlights
                         group x by x.BoxId into g
                         select g).ToList();
            var boxids = boxes.Select(q => q.Key).ToList();
            var boxReqs = await this.context.ViewBoxCrewRequirements.Where(q => boxids.Contains(q.Id) && q.Assigned != q.Min).Select(q => q.Id).ToListAsync();

            foreach (var group in boxes)
            {
                var box = group.OrderBy(q => q.STD).ToList();
                var boxedFlight = new ViewFlightPlanItemCalander(); //new ViewFlightPlanItem();
                string str = JsonConvert.SerializeObject(box.First());
                boxedFlight = JsonConvert.DeserializeObject<ViewFlightPlanItemCalander>(str); //JsonConvert.DeserializeObject<ViewFlightPlanItem>(str);
                var boxItems = new List<ViewFlightPlanItemCalanderDto>(); //new List<ViewFlightPlanItemDto>();
                foreach (var _f in box)
                {
                    // ViewModels.ViewFlightPlanItemDto dto = new ViewFlightPlanItemDto();
                    //  ViewModels.ViewFlightPlanItemDto.FillDto(_f, dto, tzoffset);

                    ViewModels.ViewFlightPlanItemCalanderDto dto = new ViewFlightPlanItemCalanderDto();
                    ViewModels.ViewFlightPlanItemCalanderDto.FillDto(_f, dto, tzoffset);
                    boxItems.Add(dto);
                }
                boxedFlight.taskID = 1000000 + boxedFlight.taskID;
                boxedFlight.Id = 1000000 + boxedFlight.Id;
                boxedFlight.FlightNumber = "ATI" + boxedFlight.FlightNumber;
                boxedFlight.ToAirport = box.Last().ToAirport;
                boxedFlight.ToAirportCity = box.Last().ToAirportCity;
                boxedFlight.ToAirportCityId = box.Last().ToAirportCityId;
                boxedFlight.ToAirportIATA = box.Last().ToAirportIATA;
                boxedFlight.ToAirportName = box.Last().ToAirportName;
                boxedFlight.ToCity = box.Last().ToCity;
                boxedFlight.ToCountry = box.Last().ToCountry;
                boxedFlight.ToLatitude = box.Last().ToLatitude;
                boxedFlight.ToLongitude = box.Last().ToLongitude;
                boxedFlight.ToSortName = box.Last().ToSortName;
                boxedFlight.to = box.Last().ToAirportIATA;
                boxedFlight.STA = box.Last().STA;
                boxedFlight.duration = Convert.ToDecimal(((DateTime)box.Last().STA).Subtract((DateTime)boxedFlight.STD).TotalHours);
                boxedFlight.FlightH = Convert.ToInt32(Math.Truncate((decimal)boxedFlight.duration));
                boxedFlight.FlightM = Convert.ToInt32((boxedFlight.duration - Math.Truncate((decimal)boxedFlight.duration)) * 60);
                boxedFlight.taskName = boxedFlight.FromAirportIATA + " -" + boxedFlight.FlightNumber + "- " + boxedFlight.ToAirportIATA;

                //ViewModels.ViewFlightPlanItemDto bdto = new ViewFlightPlanItemDto();
                // ViewModels.ViewFlightPlanItemDto.FillDto(boxedFlight, bdto, tzoffset);

                ViewModels.ViewFlightPlanItemCalanderDto bdto = new ViewFlightPlanItemCalanderDto();
                ViewModels.ViewFlightPlanItemCalanderDto.FillDto(boxedFlight, bdto, tzoffset);

                bdto.IsBox = true;
                bdto.BoxId = box.First().BoxId;
                bdto.BoxItems = boxItems.ToList();
                bdto.HasCrew = box.First().AssignedCrewCount != 0;
                bdto.HasCrewProblem = box.First().AssignedCrewProblemCount != 0;
                bdto.AllCrewAssigned = !boxReqs.Contains((int)bdto.BoxId);
                flightsdto.Add(bdto);

            }

            //var box = new List<ViewFlightPlanItem>();

            //box = box.OrderBy(q => q.STD).ToList();








            var resgroups = from x in flights
                            group x by new { x.AircraftType, AircraftTypeId = x.TypeId }
                            into grp
                            select new { groupId = grp.Key.AircraftTypeId, Title = grp.Key.AircraftType };
            var resgroupsList = resgroups.ToList();
            var ressq = (from x in flights
                         group x by new { x.RegisterID, x.Register, x.TypeId }
                     into grp
                         select new resource() { resourceId = grp.Key.RegisterID, resourceName = grp.Key.Register, groupId = grp.Key.TypeId, assigned = false, registers = string.Empty }).ToList();

            ////var ress = ressq.OrderBy(q => q.TypeId).Select((q, i) => new { resourceName = q.Register, groupId = q.TypeId, resourceId = (q.RegisterID >= 0 ? q.RegisterID : -1 * (i + 1)) }).ToList();

            foreach (var x in flightsdto)
            {
                //if (x.RegisterID >= 0)
                x.resourceId.Add((int)x.RegisterID);
                // else
                //    x.resourceId.Add((int)ress.First(q => q.resourceName == x.Register).resourceId);
            }
            //var planIds = plans.Select(q => q.Id).ToList();
            //var _registers = await this.context.ViewFlightPlanRegisters.Where(q => planIds.Contains(q.FlightPlanId)).ToListAsync();
            //var grpRegisters = (from x in _registers
            //                    group x by x.PlannedRegisterId into g
            //                    select g).ToList();
            //foreach (var g in grpRegisters)
            //{
            //    var res = ressq.FirstOrDefault(q => q.resourceId == g.Key);
            //    if (res != null)
            //    {
            //        res.registers = string.Join(", ", g.Select(q => q.Register).ToList());
            //        var dates = g.OrderBy(q => q.DateFrom).ToList();
            //        var plan = plans.FirstOrDefault(q => q.Id == g.FirstOrDefault().FlightPlanId);
            //        if (dates.First().DateFrom.Date == ((DateTime)plan.DateFrom).Date && dates.Last().DateTo.Date == ((DateTime)plan.DateTo).Date)
            //            res.assigned = true;
            //    }
            //}
            var result = new
            {
                flights = flightsdto,
                resourceGroups = resgroupsList,
                resources = ressq,
                //   registers = _registers,
            };
            return result;
        }

        private string FormatTwoDigits(Int32 i)
        {
            string functionReturnValue = null;
            if (10 > i)
            {
                functionReturnValue = "0" + i.ToString();
            }
            else
            {
                functionReturnValue = i.ToString();
            }
            return functionReturnValue;
        }
        //09-07
        internal async Task<dynamic> NotifyDelayedFlight2(int id,bool force=false)
        {
            var leg = await this.context.ViewLegTimes.FirstOrDefaultAsync(q => q.ID == id);
            var delay = (((DateTime)leg.ChocksOut) - ((DateTime)leg.STD)).TotalMinutes;
            if (delay >= 30 && leg.FlightStatusID != 3 && leg.FlightStatusID != 15)
            {
                var his = await this.context.DelayNotifieds.FirstOrDefaultAsync(q => q.FlightId == id && q.Delay == delay && q.TypeId==2);
                if (his == null || force)
                {
                    var delayInt = Convert.ToInt32(Math.Round(delay));
                    his = new DelayNotified() { FlightId = id, Delay = delayInt,TypeId=2 };
                    this.context.DelayNotifieds.Add(his);

                    var Hour1 = delayInt / 60;
                    var Minute1 = delayInt % 60;
                    var delayStr1 = FormatTwoDigits(Hour1) + ":" + FormatTwoDigits(Minute1);
                    var strs1 = new List<string>() { "CASPIAN AIRLINES", "Delay Warning" };
                    strs1.Add(((DateTime)leg.STDDay).ToString("yyyy-MM-dd"));
                    strs1.Add(leg.FromAirportIATA + "-" + leg.FlightNumber + "-" + leg.ToAirportIATA);
                    strs1.Add("Delay: " + delayStr1);
                    strs1.Add("STD: " + ((DateTime)leg.STDLocal).ToString("HH:mm"));
                    strs1.Add("STA: " + ((DateTime)leg.STALocal).ToString("HH:mm"));
                    strs1.Add("BlockOff: " + ((DateTime)leg.DepartureLocal).ToString("HH:mm"));
                    var text1 = String.Join("\n", strs1);
                    var recs = await this.context.SMSGroups.Where(q => q.Type == 3).ToListAsync();
                    foreach (var rec in recs)
                    {
                        Magfa m = new Magfa();
                        var result10 = m.enqueue(1, rec.Phone, text1)[0];
                    }
                    await this.context.SaveAsync();
                }
            }

            return true;



        }

        internal async Task<dynamic> FindDelayedFlights( string user,bool force=false)
        {
            if (user.ToLower().StartsWith("dis") || user.ToLower().StartsWith("demo"))
            {
                var now = DateTime.UtcNow;
                var nowDay = now.Date;
                var status = new List<int?>() {2,3,6,7,8,9,14,15,4 };
                var legs = await this.context.ViewLegTimes.Where(q => q.STDDay == nowDay 
                && (!status.Contains( q.FlightStatusID)   )
                && q.STD < now).Select(q => q.ID).ToListAsync();
                string result = "";
                if (legs.Count() > 0)
                    result=await NotifyDelayedFlightList(legs);
                return result;
            }
            else
                return "-";
           
        }

        internal async Task<dynamic> NotifyDelayedFlightList(List<int> ids,bool force=false)
        {
            var legs = await this.context.ViewLegTimes.Where(q => ids.Contains(q.ID)).Select(q => new
            {
                q.ID,
                q.FlightStatusID,
                q.STD,
                q.FromAirportIATA,
                q.ToAirportIATA,
                q.FlightNumber,
                q.STDDay,
                q.STDLocal,
                q.STALocal,
                 
            }).ToListAsync();
            var now = DateTime.UtcNow;
            List<string> _flts = new List<string>();
            _flts.Add(legs.Count + " Flight(s) Found.");
            foreach (var leg in legs)
            {
                var id = leg.ID;
                //var leg = await this.context.ViewLegTimes.FirstOrDefaultAsync(q => q.ID == id);
                var delay = (now - ((DateTime)leg.STD)).TotalMinutes;
                if (delay >= 30 && (leg.FlightStatusID ==1 || leg.FlightStatusID == 5 || leg.FlightStatusID == 20 || leg.FlightStatusID == 21 || leg.FlightStatusID == 22 || leg.FlightStatusID == 23 || leg.FlightStatusID == 24 || leg.FlightStatusID == 25))
                {

                    //var his = await this.context.DelayNotifieds.FirstOrDefaultAsync(q => q.FlightId == id && q.Delay == delay);
                    var _his = await this.context.DelayNotifieds.OrderByDescending(q => q.Id).FirstOrDefaultAsync(q => q.FlightId == id && q.TypeId==1);
                    if (_his == null /*|| (_his != null && delay >= _his.Delay + 10)*/ || force)
                    {
                        var delayInt = Convert.ToInt32(Math.Round(delay));
                        var his = new DelayNotified() { FlightId = id, Delay = delayInt,TypeId=1 };
                        this.context.DelayNotifieds.Add(his);

                        var Hour1 = delayInt / 60;
                        var Minute1 = delayInt % 60;
                        var delayStr1 = FormatTwoDigits(Hour1) + ":" + FormatTwoDigits(Minute1);
                        var strs1 = new List<string>() { "CASPIAN AIRLINES", "Delay Warning" };
                        strs1.Add(((DateTime)leg.STDDay).ToString("yyyy-MM-dd"));
                        strs1.Add(leg.FromAirportIATA + "-" + leg.FlightNumber + "-" + leg.ToAirportIATA);
                        strs1.Add("Delay: " + delayStr1);
                        strs1.Add("STD: " + ((DateTime)leg.STDLocal).ToString("HH:mm"));
                        strs1.Add("STA: " + ((DateTime)leg.STALocal).ToString("HH:mm"));
                        //strs1.Add("BlockOff: " + ((DateTime)leg.DepartureLocal).ToString("HH:mm"));
                        var text1 = String.Join("\n", strs1);
                        _flts.Add(leg.FlightNumber + "  " + delayStr1);
                        var recs = await this.context.SMSGroups.Where(q => q.Type == 1).ToListAsync();
                        foreach (var rec in recs)
                        {
                            try
                            {
                                Magfa m = new Magfa();
                                var result10 = m.enqueue(1, rec.Phone, text1)[0];
                            }
                            catch(Exception xxx)
                            {
                                _flts.Add("Sending Message Falied. " + rec + "  " + leg.FlightNumber);
                            }
                           
                        }
                        
                    }

                }
            }

            await this.context.SaveAsync();
            var _result =  String.Join(", ", _flts);
            return _result;



        }
        public class delayNotification
        {
            public int Id { get; set; }
            public int delay { get; set; }

        }

        internal async Task<object> GetBoardSummary(DateTime date)
        {
            var summary = await this.context.ViewBoardSummaries.Where(q => q.Date == date).FirstOrDefaultAsync();
            if (summary == null)
                return null;
            double? delayRatio = null;
            if (summary.BlockTime != 0)
                delayRatio = Math.Round(summary.Delay * 1.0 / summary.BlockTime, 1, MidpointRounding.AwayFromZero) * 100;
            double? cargoPerPax = null;
            if (summary.Pax != 0)
                cargoPerPax = Math.Round(summary.BaggageWeight * 1.0 / summary.Pax, 1, MidpointRounding.AwayFromZero);
            double? paxLoad = null;
            if (summary.TotalSeat != 0)
                paxLoad = Math.Round(summary.Pax * 1.0 / summary.TotalSeat, 1, MidpointRounding.AwayFromZero) * 100;
            var Hour = summary.Delay / 60;
            var Minute = summary.Delay % 60;
            var delayStr = FormatTwoDigits(Hour) + ":" + FormatTwoDigits(Minute);

            Hour = summary.BlockTime / 60;
            Minute = summary.BlockTime % 60;
            var blockTimeStr = FormatTwoDigits(Hour) + ":" + FormatTwoDigits(Minute);

            if (summary.Canceled != null && summary.TotalFlight != null)
                summary.TotalFlight = (int)summary.TotalFlight - (int)summary.Canceled;

            var result = new
            {
                summary.Arrived,
                summary.Departed,
                summary.TotalFlight,
                summary.BaggageWeight,
                summary.BlockTime,
                summary.Canceled,
                summary.Date,
                summary.Delay,
                summary.Diverted,
                FuelActual = Math.Round(summary.FuelActual / 1000, 2),
                summary.Pax,
                summary.TotalSeat,
                CargoPerPax = cargoPerPax,
                DelayRatio = delayRatio,
                PaxLoad = paxLoad,
                DelayStr = delayStr,
                BlockTimeStr = blockTimeStr,

            };
            
            return result;

        }
        class BoardSummary
        {
            public DateTime DateFrom { get; set; }
            public DateTime DateTo { get; set; }
            public int BlockTime { get; set; }
            public int? TotalFlight { get; set; }
            public int? Departed { get; set; }
            public int? Arrived { get; set; }
            public int? Diverted { get; set; }
            public int? Canceled { get; set; }
            public int Delay { get; set; }
            public int Pax { get; set; }
            public int TotalSeat { get; set; }
            public int BaggageWeight { get; set; }
            public decimal FuelActual { get; set; }
            public int FlightTimeActual { get; set; }
            public int FlightTime { get; set; }
            public int FixTime { get; set; }
            public int SITATime { get; set; }
            public decimal PaxLoad { get; set; }
            public decimal FuelUplift { get; set; }
            public int BaggageCount { get; set; }
            public int CargoCount { get; set; }
            public int CargoWeight { get; set; }

            public double DelayPerFlight { get; set; }
            public int PaxAdult { get; set; }
            public int PaxChild { get; set; }
            public int PaxInfant { get; set; }
        }
        class DelayedFlight
        {
            public DateTime? Date { get; set; }
            public string FlightNumber { get; set; }
            public int Id { get; set; }
            public string FromAirport { get; set; }
            public string ToAirport { get; set; }
            public string Route { get; set; }
            public string Remark { get; set; }
            public DateTime? STD { get; set; }
            public int? Delay { get; set; }
        }
        class PaxLoadRoute
        {
            public string Route { get; set; }
            public int? TotalSeat { get; set; }
            public int? TotalPax { get; set; }
            public double PaxLoad { get; set; }
        }
        internal async Task<object> GetBoardSummaryTotal(DateTime date, DateTime date2)
        {
            // var summary = await this.context.ViewBoardSummaries.Where(q => q.Date == date).FirstOrDefaultAsync();
            var summary = await (from x in this.context.ViewBoardSummaries
                                 where x.Date >= date && x.Date <= date2
                                 group x by true into gr
                                 select new BoardSummary
                                 {
                                     BlockTime = gr.Sum(q => q.BlockTime),
                                     FlightTime = gr.Sum(q => q.FlightTime),
                                     FixTime = gr.Sum(q => q.FixTime),
                                     FlightTimeActual = gr.Sum(q => q.FlightTimeActual),
                                     SITATime = gr.Sum(q => q.SITATime),
                                     TotalFlight = gr.Sum(q => q.TotalFlight),
                                     Departed = gr.Sum(q => q.Departed),
                                     Arrived = gr.Sum(q => q.Arrived),
                                     Diverted = gr.Sum(q => q.Diverted),
                                     Canceled = gr.Sum(q => q.Canceled),
                                     Delay = gr.Sum(q => q.Delay) > 0 ? gr.Sum(q => q.Delay) : 0,
                                     Pax = gr.Sum(q => q.Pax),
                                     BaggageWeight = gr.Sum(q => q.BaggageWeight),
                                     BaggageCount = gr.Sum(q => q.BaggageCount),
                                     CargoCount = gr.Sum(q => q.CargoCount),
                                     CargoWeight = gr.Sum(q => q.CargoWeight),
                                     FuelActual = gr.Sum(q => q.FuelActual),
                                     FuelUplift = gr.Sum(q => q.FuelUplift),
                                     PaxLoad = gr.Average(q => q.PaxLoad),
                                     PaxAdult = gr.Sum(q => q.PaxAdult),
                                     PaxChild = gr.Sum(q => q.PaxChild),
                                     PaxInfant = gr.Sum(q => q.PaxInfant),
                                 }).FirstOrDefaultAsync();
            var Types = await this.context.ViewFlightInformations.Where(q => q.STDDay >= date && q.STDDay <= date2).Select(q => q.TypeId).Distinct().CountAsync();
            var Registers = await this.context.ViewFlightInformations.Where(q => q.STDDay >= date && q.STDDay <= date2).Select(q => q.RegisterID).Distinct().CountAsync();
            if (summary == null)
                return null;
            summary.DateFrom = date;
            summary.DateTo = date2;
            summary.DelayPerFlight = (summary.TotalFlight == null || summary.TotalFlight == 0) ? 0 : Math.Round(summary.Delay * 1.0 / (int)summary.TotalFlight, 0, MidpointRounding.AwayFromZero);
            summary.PaxLoad = Math.Round(summary.PaxLoad, 0, MidpointRounding.AwayFromZero);

            double? delayRatio = null;
            if (summary.BlockTime != 0)
                delayRatio = Math.Round(summary.Delay * 1.0 / summary.BlockTime, 1, MidpointRounding.AwayFromZero) * 100;
            double? cargoPerPax = null;
            if (summary.Pax != 0)
                cargoPerPax = Math.Round(summary.BaggageWeight * 1.0 / summary.Pax, 1, MidpointRounding.AwayFromZero);
            //double? paxLoad = null;
            // if (summary.TotalSeat != 0)
            //    paxLoad = Math.Round(summary.Pax * 1.0 / summary.TotalSeat, 1, MidpointRounding.AwayFromZero) * 100;
            var Hour = summary.Delay / 60;
            var Minute = summary.Delay % 60;
            var delayStr = FormatTwoDigits(Hour) + ":" + FormatTwoDigits(Minute);

            Hour = Convert.ToInt32(summary.DelayPerFlight) / 60;
            Minute = Convert.ToInt32(summary.DelayPerFlight) % 60;
            var DelayPerFlightStr = FormatTwoDigits(Hour) + ":" + FormatTwoDigits(Minute);


            Hour = summary.BlockTime / 60;
            Minute = summary.BlockTime % 60;
            var blockTimeStr = FormatTwoDigits(Hour) + ":" + FormatTwoDigits(Minute);


            Hour = summary.FlightTime / 60;
            Minute = summary.FlightTime % 60;
            var flightTimeStr = FormatTwoDigits(Hour) + ":" + FormatTwoDigits(Minute);

            Hour = summary.FixTime / 60;
            Minute = summary.FixTime % 60;
            var FixTimeStr = FormatTwoDigits(Hour) + ":" + FormatTwoDigits(Minute);

            Hour = summary.FlightTimeActual / 60;
            Minute = summary.FlightTimeActual % 60;
            var FlightTimeActualStr = FormatTwoDigits(Hour) + ":" + FormatTwoDigits(Minute);

            Hour = summary.SITATime / 60;
            Minute = summary.SITATime % 60;
            var SITATimeStr = FormatTwoDigits(Hour) + ":" + FormatTwoDigits(Minute);


            var TopDelayedFlights = await (from x in this.context.ViewFlightInformations
                                           where x.STDDay >= date && x.STDDay <= date2 && x.DelayOffBlock != null && x.FlightStatusID != 1 && x.FlightStatusID != 4 && x.DelayOffBlock > 0

                                           orderby x.DelayOffBlock descending
                                           select new DelayedFlight()
                                           {
                                               Id = x.ID,
                                               FlightNumber = x.FlightNumber,
                                               Date = x.STDDay,
                                               Delay = x.DelayOffBlock,
                                               FromAirport = x.FromAirportIATA,
                                               ToAirport = x.ToAirportIATA,
                                               Route = x.FromAirportIATA + "-" + x.ToAirportIATA,
                                               STD = x.STD,

                                           }).Take(10).ToListAsync();
            foreach (var x in TopDelayedFlights)
            {
                x.Remark = ((DateTime)x.Date).Year.ToString().Substring(2, 2) + "-" + ((DateTime)x.Date).Month.ToString().PadLeft(2, '0') + "-" + ((DateTime)x.Date).Day.ToString().PadLeft(2, '0')
                    + " " + x.FromAirport + "-" + x.ToAirport + " " + x.FlightNumber;
            }
            var date3 = date2.AddDays(1);
            var DelayCategories = await (from x in this.context.ViewFlightDelays
                                         where x.STD >= date && x.STD <= date3 && x.FlightStatusID != 1 && x.FlightStatusID != 4 && x.Code != "93"
                                         group x by x.ICategory into grp
                                         select new
                                         {
                                             Category = grp.Key,
                                             Count = grp.Count(),
                                             Delay = grp.Sum(q => q.DelayHH * 60 + q.DelayMM)
                                         }).ToListAsync();

            var PaxLoadRoute = await (from x in this.context.ViewFlightInformations
                                      where x.STADay >= date && x.STDDay <= date2 && x.FlightStatusID != 1 && x.FlightStatusID != 4
                                      group x by new { x.FromAirportIATA, x.ToAirportIATA } into grp
                                      select new PaxLoadRoute()
                                      {
                                          Route = grp.Key.FromAirportIATA + "-" + grp.Key.ToAirportIATA,
                                          TotalSeat = grp.Sum(q => q.TotalSeat),
                                          TotalPax = grp.Sum(q => q.TotalPax),
                                          //PaxLoad = (int)grp.Sum(q => q.TotalPax) * 1.0 / (int)grp.Sum(q => q.TotalSeat)
                                          PaxLoad = (double)grp.Sum(q => q.TotalPax) * 1.0 / (int)grp.Sum(q => q.TotalSeat)
                                      }).ToListAsync();
            foreach (var x in PaxLoadRoute)
            {
                x.PaxLoad = Math.Round(x.PaxLoad, 2, MidpointRounding.AwayFromZero) * 100;
            }


            var result = new
            {
                summary.Arrived,
                summary.Departed,
                summary.TotalFlight,
                BaggageWeight = Math.Round((decimal)summary.BaggageWeight / 1000, 2),
                summary.BaggageCount,
                summary.CargoCount,
                CargoWeight = Math.Round((decimal)summary.CargoWeight / 1000, 2),
                summary.BlockTime,
                summary.FlightTime,
                summary.FlightTimeActual,
                summary.FixTime,
                summary.SITATime,
                summary.Canceled,
                summary.DateFrom,
                summary.DateTo,
                summary.Delay,
                summary.Diverted,
                FuelActual = Math.Round(summary.FuelActual / 1000, 2),
                FuelUplift = Math.Round(summary.FuelUplift / 1000, 2),
                summary.Pax,
                summary.PaxAdult,
                summary.PaxInfant,
                summary.PaxChild,
                summary.PaxLoad,
                summary.TotalSeat,
                CargoPerPax = cargoPerPax,
                DelayRatio = delayRatio,
                // PaxLoad = paxLoad,
                DelayStr = delayStr,
                DelayPerFlightStr,
                BlockTimeStr = blockTimeStr,
                FlightTimeStr = flightTimeStr,
                FixTimeStr,
                FlightTimeActualStr,
                SITATimeStr,
                Types,
                Registers,
                TopDelayedFlights,
                DelayCategories,
                PaxLoadRoute
            };
            return result;

        }

        public string getOrderIndex(string reg, List<string> grounds)
        {
            var str = "";
            //orderby grp.Key.Register.Contains("CNL") ? "ZZZZ" :( grp.Key.Register[grp.Key.Register.Length - 1].ToString())
            if (reg.Contains("CNL"))
                str = "ZZZZZZ";
            else
           //str = 1000000;
           // if (grounds.Contains(reg))
           if (reg.Contains("."))
            {
                str = "ZZZZ" + reg[reg.Length - 2];
                //str = 100000;
            }
            // str= reg[reg.Length - 1].ToString();
            else
                str = reg[reg.Length - 1].ToString();

            return str;

        }

        //samira edit viewlegtime
        internal async Task<object> GetFlightGantt(int cid, DateTime dateFrom, DateTime dateTo, int tzoffset, int? airport, ViewModels.FlightsFilter filter, int? utc = 0)
        {



            //var flightsQuery = this.context.ViewFlightInformations.Where(q => q.CustomerId == cid && q.STDLocal >= dateFrom && q.STDLocal <= dateTo && q.RegisterID != null);
            var flightsQuery = this.context.ViewFlightsGantts.Where(q => q.CustomerId == cid && q.STDLocal >= dateFrom && q.STDLocal <= dateTo && q.RegisterID != null);


            int? doUtc = utc;

            // var flightsQueryAll = this.context.ViewFlightInformations.Where(q => q.CustomerId == cid && q.STD >= dateFrom && q.STD <= dateTo && q.RegisterID != null);
            if (airport != null && airport != -1)
                flightsQuery = flightsQuery.Where(q => q.FromAirport == airport || q.ToAirport == airport);
            if (filter != null)
            {
                if (filter.Status != null && filter.Status.Count > 0)
                    flightsQuery = flightsQuery.Where(q => filter.Status.Contains(q.FlightStatusID));
                if (filter.Types != null && filter.Types.Count > 0)
                    flightsQuery = flightsQuery.Where(q => filter.Types.Contains(q.TypeId));
                if (filter.Registers != null && filter.Registers.Count > 0)
                    flightsQuery = flightsQuery.Where(q => filter.Registers.Contains(q.RegisterID));
                if (filter.From != null && filter.From.Count > 0)
                    flightsQuery = flightsQuery.Where(q => filter.From.Contains(q.FromAirport));
                if (filter.To != null && filter.To.Count > 0)
                    flightsQuery = flightsQuery.Where(q => filter.To.Contains(q.ToAirport));


            }
            var flights = await flightsQuery.ToListAsync();
            var _regidsx = flights.Select(q => q.RegisterID).ToList();

            var nos = flights.Select(q => q.FlightNumber).OrderBy(q => q).ToList();

            var grounds = (from x in this.context.ViewRegisterGrounds
                           where x.CustomerId == cid &&
                           (
                            (dateFrom >= x.DateFrom && dateTo <= x.DateEnd) ||
                            (x.DateFrom >= dateFrom && x.DateEnd <= dateTo) ||

                            (x.DateFrom >= dateFrom && x.DateFrom <= dateTo) ||
                            (x.DateEnd >= dateFrom && x.DateEnd <= dateTo)
                           )
                           select x).ToList();
            var groundRegs = grounds.Select(q => q.Register + ".").ToList();
            foreach (var x in grounds)
            {
                var gdf = (DateTime)x.DateFrom;
                if (dateFrom > gdf)
                    gdf = dateFrom.AddMinutes(-270);
                var gde = (DateTime)x.DateEnd;
                if (gde > dateTo)
                    gde = dateTo.AddMinutes(-270);
                int gf = 10000;

                var existInFlights = _regidsx.Contains(x.RegisterId);
                var fg = new ViewFlightsGantt()
                {

                    ID = (int)x.taskId + gf,
                    // STD = x.DateFrom,
                    // STA = x.DateEnd,
                    FlightNumber = x.GroundType,
                    CustomerId = x.CustomerId,
                    //duration = x.duration,
                    Register = !existInFlights ? (x.AircraftType.Substring(x.AircraftType.Length - 2, 2) + "-" + x.Register + ".") : (x.AircraftType.Substring(x.AircraftType.Length - 2, 2) + "-" + x.Register),
                    RegisterID = !existInFlights ? (x.RegisterId + 100000) : (x.RegisterId),
                    FlightStatus = x.FlightStatus,
                    FlightStatusID = x.FlightStatusID,
                    TypeId = 1000,
                    AircraftType = "FLEET",
                    taskId = (int)x.taskId + gf,
                    FlightTypeID = x.FlightTypeID,
                    status = x.FlightStatusID,
                    //startDate = x.DateFrom,


                };
                var _gdf = gdf;
                fg.STD = _gdf;
                fg.startDate = _gdf;
                gdf = gdf.AddHours(24);
                fg.STA = gde;

                fg.duration = Convert.ToDecimal(((DateTime)fg.STA - (DateTime)fg.STD).TotalHours);
                flights.Add(fg);
                gf++;
            }

            flights = flights.OrderBy(q => q.STD).ToList();




            // var flightsdto = new List<ViewModels.ViewFlightInformationDto>();
            var flightsdto = new List<ViewModels.ViewFlightsGanttDto>();
            foreach (var x in flights)
            {
                // ViewModels.ViewFlightInformationDto dto = new ViewFlightInformationDto();
                //ViewModels.ViewFlightInformationDto.FillDto(x, dto, tzoffset,doUtc);
                ViewModels.ViewFlightsGanttDto dto = new ViewFlightsGanttDto();
                ViewModels.ViewFlightsGanttDto.FillDto(x, dto, tzoffset, doUtc);
                flightsdto.Add(dto);
            }

            var resgroups = from x in flights
                            group x by new { x.AircraftType, AircraftTypeId = x.TypeId }
                            into grp
                            select new { groupId = grp.Key.AircraftTypeId, Title = grp.Key.AircraftType };

            var ressq = (from x in flights
                         group x by new { x.RegisterID, x.Register, x.TypeId }
                     into grp
                         //orderby grp.Key.TypeId, grp.Key.Register
                         // orderby grp.Key.Register.Contains("CNL") ? "ZZZZ" :( grp.Key.Register[grp.Key.Register.Length - 1].ToString())
                         orderby getOrderIndex(grp.Key.Register, groundRegs)
                         select new { resourceId = grp.Key.RegisterID, resourceName = grp.Key.Register, groupId = grp.Key.TypeId }).ToList();
            //var ress = ressq.OrderBy(q => q.TypeId).Select((q, i) => new { resourceName = q.Register, groupId = q.TypeId, resourceId = (q.RegisterID >= 0 ? q.RegisterID : -1 * (i + 1)) }).ToList();

            foreach (var x in flightsdto)
            {
                //if (x.RegisterID >= 0)
                x.resourceId.Add((int)x.RegisterID);
                // else
                //    x.resourceId.Add((int)ress.First(q => q.resourceName == x.Register).resourceId);
            }

            //var baseSum = (from x in flights
            //              group x by new { x.BaseId, x.BaseIATA, x.BaseName } into g
            //              select new
            //              {
            //                  BaseId=g.Key.BaseId,
            //                  BaseIATA=g.Key.BaseIATA,
            //                  BaseName=g.Key.BaseName,
            //                  Total=g.Count(),
            //                  TakeOff=g.Where(q=>q.Takeoff!=null).Count(),
            //                  Landing=g.Where(q=>q.Landing!=null).Count(),
            //                  Canceled=g.Where(q=>q.FlightStatusID==4).Count(),
            //                  Redirected= g.Where(q => q.FlightStatusID == 17).Count(),
            //                  Diverted = g.Where(q => q.FlightStatusID == 7).Count(),
            //                  TotalDelays=g.Where(q=>q.ChocksOut!=null).Sum(q=>q.DelayOffBlock),
            //                  DepartedPax= g.Where(q => q.Takeoff != null).Sum(q=>q.TotalPax),
            //                  ArrivedPax= g.Where(q => q.Landing != null).Sum(q => q.TotalPax),

            //              }).ToList();
            var fromAirport = (from x in flights
                               group x by new { x.FromAirport, x.FromAirportIATA, x.FromAirportName } into g
                               select new BaseSummary()
                               {
                                   BaseId = g.Key.FromAirport,
                                   BaseIATA = g.Key.FromAirportIATA,
                                   BaseName = g.Key.FromAirportName,
                                   Total = g.Count(),
                                   TakeOff = g.Where(q => q.Takeoff != null).Count(),
                                   Landing = 0, //g.Where(q => q.Landing != null).Count(),
                                   Canceled = g.Where(q => q.FlightStatusID == 4).Count(),
                                   Redirected = g.Where(q => q.FlightStatusID == 17).Count(),
                                   Diverted = g.Where(q => q.FlightStatusID == 7).Count(),
                                   TotalDelays = g.Where(q => q.ChocksOut != null).Sum(q => q.DelayOffBlock),
                                   DepartedPax = g.Where(q => q.Takeoff != null).Sum(q => q.TotalPax),
                                   ArrivedPax = 0,// g.Where(q => q.Landing != null).Sum(q => q.TotalPax),

                               }).ToList();
            var toAirport = (from x in flights
                             group x by new { x.ToAirport, x.ToAirportIATA, x.ToAirportName } into g
                             select new BaseSummary()
                             {
                                 BaseId = g.Key.ToAirport,
                                 BaseIATA = g.Key.ToAirportIATA,
                                 BaseName = g.Key.ToAirportName,
                                 Total = g.Count(),
                                 TakeOff = 0,//g.Where(q => q.Takeoff != null).Count(),
                                 Landing = g.Where(q => q.Landing != null).Count(),
                                 Canceled = 0,//g.Where(q => q.FlightStatusID == 4).Count(),
                                 Redirected = 0,// g.Where(q => q.FlightStatusID == 17).Count(),
                                 Diverted = 0,// g.Where(q => q.FlightStatusID == 7).Count(),
                                 TotalDelays = 0,// g.Where(q => q.ChocksOut != null).Sum(q => q.DelayOffBlock),
                                 DepartedPax = 0,// g.Where(q => q.Takeoff != null).Sum(q => q.TotalPax),
                                 ArrivedPax = g.Where(q => q.Landing != null).Sum(q => q.TotalPax),

                             }).ToList();

            var baseSum = new List<BaseSummary>();
            foreach (var x in fromAirport)
            {
                var to = toAirport.FirstOrDefault(q => q.BaseId == x.BaseId);
                if (to != null)
                {
                    x.ArrivedPax += to.ArrivedPax;
                    x.Canceled += to.Canceled;
                    x.DepartedPax += to.DepartedPax;
                    x.Diverted += to.Diverted;
                    x.Landing += to.Landing;
                    x.Redirected += to.Redirected;
                    x.TakeOff += to.TakeOff;
                    x.Total += to.Total;
                    x.TotalDelays += to.TotalDelays;

                }

                baseSum.Add(x);
            }
            var f9641 = flightsdto.FirstOrDefault(q => q.ID == 9641);
            var result = new
            {
                flights = flightsdto,
                resourceGroups = resgroups.ToList(),
                resources = ressq,
                baseSummary = baseSum,
            };
            return result;
        }


        //baba
        internal async Task<object> GetFlightGanttFleet(int cid, DateTime dateFrom, DateTime dateTo, int tzoffset, int? airport, ViewModels.FlightsFilter filter, int? utc = 0)
        {
            //var flightsQuery = this.context.ViewFlightInformations.Where(q => q.CustomerId == cid && q.STD >= dateFrom && q.STD <= dateTo && q.RegisterID != null);
            Stopwatch stopwatch = new Stopwatch();
            stopwatch.Start();
            var flightsQuery = this.context.ViewFlightsGantts.Where(q => /*q.CustomerId == cid &&*/ q.RegisterID != null &&
            (
            (q.STDLocal >= dateFrom && q.STDLocal <= dateTo) || (q.DepartureLocal >= dateFrom && q.DepartureLocal <= dateTo)
            || (q.STALocal >= dateFrom && q.STALocal <= dateTo) || (q.ArrivalLocal >= dateFrom && q.ArrivalLocal <= dateTo)
            )
            );
            // var flightsQuery = this.context.ViewFlightsGantts.Where(q => q.CustomerId == cid && q.STDLocal >= dateFrom && q.STDLocal <= dateTo && q.RegisterID != null);
            int? doUtc = utc;
            if (cid != -1)
                flightsQuery = flightsQuery.Where(q => q.CustomerId == cid);
            // var flightsQueryAll = this.context.ViewFlightInformations.Where(q => q.CustomerId == cid && q.STD >= dateFrom && q.STD <= dateTo && q.RegisterID != null);
            if (airport != null && airport != -1)
                flightsQuery = flightsQuery.Where(q => q.FromAirport == airport || q.ToAirport == airport);
            if (filter != null)
            {
                if (filter.Status != null && filter.Status.Count > 0)
                    flightsQuery = flightsQuery.Where(q => filter.Status.Contains(q.FlightStatusID));
                if (filter.Types != null && filter.Types.Count > 0)
                    flightsQuery = flightsQuery.Where(q => filter.Types.Contains(q.TypeId));
                if (filter.Registers != null && filter.Registers.Count > 0)
                    flightsQuery = flightsQuery.Where(q => filter.Registers.Contains(q.RegisterID));
                if (filter.From != null && filter.From.Count > 0)
                    flightsQuery = flightsQuery.Where(q => filter.From.Contains(q.FromAirport));
                if (filter.To != null && filter.To.Count > 0)
                    flightsQuery = flightsQuery.Where(q => filter.To.Contains(q.ToAirport));


            }
            var flights = await flightsQuery.ToListAsync();

            stopwatch.Stop();
            Debug.WriteLine("1-Time elapsed: {0}", stopwatch.Elapsed);
            stopwatch.Restart();
            var grounds = (from x in this.context.ViewRegisterGrounds
                           where x.CustomerId == cid &&
                           (
                            (dateFrom >= x.DateFrom && dateTo <= x.DateEnd) ||
                            (x.DateFrom >= dateFrom && x.DateEnd <= dateTo) ||

                            (x.DateFrom >= dateFrom && x.DateFrom <= dateTo) ||
                            (x.DateEnd >= dateFrom && x.DateEnd <= dateTo)
                           )
                           select x).ToList();
            stopwatch.Stop();
            Debug.WriteLine("2-Time elapsed: {0}", stopwatch.Elapsed);
            //var groundRegs = grounds.Select(q => q.Register + ".").ToList();

            //foreach (var x in grounds)
            //{
            //    var gdf = (DateTime)x.DateFrom;
            //    var gde = (DateTime)x.DateEnd;
            //    int gf = 10000;
            //    while (gdf < gde)
            //    {
            //        var fg = new ViewFlightsGantt()
            //        {

            //            ID = (int)x.taskId + gf,
            //            // STD = x.DateFrom,
            //            // STA = x.DateEnd,
            //            FlightNumber = x.GroundType,
            //            CustomerId = x.CustomerId,
            //            //duration = x.duration,
            //            Register = x.Register,
            //            RegisterID = x.RegisterId,
            //            FlightStatus = x.FlightStatus,
            //            FlightStatusID = x.FlightStatusID,
            //            TypeId =1000, //x.TypeId,
            //            AircraftType ="FLEET", //x.AircraftType,
            //            taskId = (int)x.taskId + gf,
            //            FlightTypeID = x.FlightTypeID,
            //            status = x.FlightStatusID,
            //            //startDate = x.DateFrom,


            //        };
            //        fg.STD = gdf;
            //        fg.startDate = gdf;
            //        var midnight = gdf.Date.AddHours(24);
            //        if (midnight <= x.DateEnd)
            //        {
            //            fg.STA = midnight;

            //            gdf = gdf.Date.AddDays(1);
            //        }
            //        else
            //        {
            //            fg.STA = x.DateEnd;
            //            gdf = gdf.AddDays(1);
            //        }
            //        fg.duration = Convert.ToDecimal(((DateTime)fg.STA - (DateTime)fg.STD).TotalHours);
            //        flights.Add(fg);
            //        gf++;

            //    }


            //}

            //foreach (var x in grounds)
            //{
            //    var gdf = (DateTime)x.DateFrom;
            //    if (dateFrom > gdf)
            //        gdf = dateFrom.AddMinutes(-270);
            //    var gde = (DateTime)x.DateEnd;
            //    if (gde > dateTo)
            //        gde = dateTo.AddMinutes(-270);
            //    int gf = 10000;
            //    while (gdf < gde)
            //    {
            //        //var fg = new ViewFlightInformation()
            //        var fg = new ViewFlightsGantt()
            //        {

            //            ID = (int)x.taskId + gf,
            //            // STD = x.DateFrom,
            //            // STA = x.DateEnd,
            //            FlightNumber = x.GroundType,
            //            CustomerId = x.CustomerId,
            //            //duration = x.duration,
            //            Register = x.Register + ".",
            //            RegisterID = x.RegisterId + 100000,
            //            FlightStatus = x.FlightStatus,
            //            FlightStatusID = x.FlightStatusID,
            //            TypeId = 1000,
            //            AircraftType = "FLEET",
            //            taskId = (int)x.taskId + gf,
            //            FlightTypeID = x.FlightTypeID,
            //            status = x.FlightStatusID,
            //            //startDate = x.DateFrom,


            //        };
            //        var _gdf = gdf;
            //        fg.STD = _gdf;
            //        fg.startDate = _gdf;
            //        gdf = gdf.AddHours(24);
            //        fg.STA = gdf.AddMinutes(-1);

            //        fg.duration = Convert.ToDecimal(((DateTime)fg.STA - (DateTime)fg.STD).TotalHours);
            //        flights.Add(fg);
            //        gf++;

            //    }


            //}
            stopwatch.Restart();
            flights = flights.OrderBy(q => q.STD).ToList();


            var groundRegs = new List<string>();

            var flightsdto = new List<ViewModels.ViewFlightsGanttDto>();
            foreach (var x in flights)
            {
                ViewModels.ViewFlightsGanttDto dto = new ViewFlightsGanttDto();
                ViewModels.ViewFlightsGanttDto.FillDto(x, dto, tzoffset, doUtc);
                flightsdto.Add(dto);
            }

            var resgroups = from x in flights
                            group x by new { x.AircraftType, AircraftTypeId = x.TypeId }
                            into grp
                            select new { groupId = grp.Key.AircraftTypeId, Title = grp.Key.AircraftType };


            //change other method
            var ressq = (from x in flights
                         group x by new { x.RegisterID, x.Register, x.TypeId }
                     into grp
                         //orderby grp.Key.TypeId, grp.Key.Register
                         // orderby grp.Key.Register.Contains("CNL")?"ZZZZ": grp.Key.Register[grp.Key.Register.Length-1].ToString()
                         orderby getOrderIndex(grp.Key.Register, groundRegs)
                         select new { resourceId = grp.Key.RegisterID, resourceName = grp.Key.Register, groupId = grp.Key.TypeId }).ToList();
            //var ress = ressq.OrderBy(q => q.TypeId).Select((q, i) => new { resourceName = q.Register, groupId = q.TypeId, resourceId = (q.RegisterID >= 0 ? q.RegisterID : -1 * (i + 1)) }).ToList();

            foreach (var x in flightsdto)
            {
                //if (x.RegisterID >= 0)
                x.resourceId.Add((int)x.RegisterID);
                // else
                //    x.resourceId.Add((int)ress.First(q => q.resourceName == x.Register).resourceId);
            }

            //var baseSum = (from x in flights
            //              group x by new { x.BaseId, x.BaseIATA, x.BaseName } into g
            //              select new
            //              {
            //                  BaseId=g.Key.BaseId,
            //                  BaseIATA=g.Key.BaseIATA,
            //                  BaseName=g.Key.BaseName,
            //                  Total=g.Count(),
            //                  TakeOff=g.Where(q=>q.Takeoff!=null).Count(),
            //                  Landing=g.Where(q=>q.Landing!=null).Count(),
            //                  Canceled=g.Where(q=>q.FlightStatusID==4).Count(),
            //                  Redirected= g.Where(q => q.FlightStatusID == 17).Count(),
            //                  Diverted = g.Where(q => q.FlightStatusID == 7).Count(),
            //                  TotalDelays=g.Where(q=>q.ChocksOut!=null).Sum(q=>q.DelayOffBlock),
            //                  DepartedPax= g.Where(q => q.Takeoff != null).Sum(q=>q.TotalPax),
            //                  ArrivedPax= g.Where(q => q.Landing != null).Sum(q => q.TotalPax),

            //              }).ToList();
            var fromAirport = (from x in flights
                               group x by new { x.FromAirport, x.FromAirportIATA, x.FromAirportName } into g
                               select new BaseSummary()
                               {
                                   BaseId = g.Key.FromAirport,
                                   BaseIATA = g.Key.FromAirportIATA,
                                   BaseName = g.Key.FromAirportName,
                                   Total = g.Count(),
                                   TakeOff = g.Where(q => q.Takeoff != null).Count(),
                                   Landing = 0, //g.Where(q => q.Landing != null).Count(),
                                   Canceled = g.Where(q => q.FlightStatusID == 4).Count(),
                                   Redirected = g.Where(q => q.FlightStatusID == 17).Count(),
                                   Diverted = g.Where(q => q.FlightStatusID == 7).Count(),
                                   TotalDelays = g.Where(q => q.ChocksOut != null).Sum(q => q.DelayOffBlock),
                                   DepartedPax = g.Where(q => q.Takeoff != null).Sum(q => q.TotalPax),
                                   ArrivedPax = 0,// g.Where(q => q.Landing != null).Sum(q => q.TotalPax),

                               }).ToList();
            var toAirport = (from x in flights
                             group x by new { x.ToAirport, x.ToAirportIATA, x.ToAirportName } into g
                             select new BaseSummary()
                             {
                                 BaseId = g.Key.ToAirport,
                                 BaseIATA = g.Key.ToAirportIATA,
                                 BaseName = g.Key.ToAirportName,
                                 Total = g.Count(),
                                 TakeOff = 0,//g.Where(q => q.Takeoff != null).Count(),
                                 Landing = g.Where(q => q.Landing != null).Count(),
                                 Canceled = 0,//g.Where(q => q.FlightStatusID == 4).Count(),
                                 Redirected = 0,// g.Where(q => q.FlightStatusID == 17).Count(),
                                 Diverted = 0,// g.Where(q => q.FlightStatusID == 7).Count(),
                                 TotalDelays = 0,// g.Where(q => q.ChocksOut != null).Sum(q => q.DelayOffBlock),
                                 DepartedPax = 0,// g.Where(q => q.Takeoff != null).Sum(q => q.TotalPax),
                                 ArrivedPax = g.Where(q => q.Landing != null).Sum(q => q.TotalPax),

                             }).ToList();

            var baseSum = new List<BaseSummary>();
            foreach (var x in fromAirport)
            {
                var to = toAirport.FirstOrDefault(q => q.BaseId == x.BaseId);
                if (to != null)
                {
                    x.ArrivedPax += to.ArrivedPax;
                    x.Canceled += to.Canceled;
                    x.DepartedPax += to.DepartedPax;
                    x.Diverted += to.Diverted;
                    x.Landing += to.Landing;
                    x.Redirected += to.Redirected;
                    x.TakeOff += to.TakeOff;
                    x.Total += to.Total;
                    x.TotalDelays += to.TotalDelays;

                }

                baseSum.Add(x);
            }
            var f9641 = flightsdto.FirstOrDefault(q => q.ID == 9641);
            //2020-11-25
            stopwatch.Stop();
            Debug.WriteLine("3-Time elapsed: {0}", stopwatch.Elapsed);
            var result = new
            {
                flights = flightsdto,
                resourceGroups = resgroups.ToList(),
                resources = ressq,
                baseSummary = baseSum,
                grounds,
                baseDate = DateTime.UtcNow,
            };
            return result;
        }

        internal async Task<object> GetFlightGantt(string fids, int tzoffset)
        {
            var flightIds = fids.Split('_').Select(q => Convert.ToInt32(q)).ToList();
            //var flightsQuery = this.context.ViewFlightInformations.Where(q => flightIds.Contains(q.ID) && q.RegisterID != null);
            var flightsQuery = this.context.ViewLegTimes.Where(q => flightIds.Contains(q.ID) && q.RegisterID != null);

            var flights = flightsQuery.ToList();

            //    var legs = this.context.ViewLegTimes.Where(q => flightIds.Contains(q.ID) && q.RegisterID != null).ToList();


            flights = flights.OrderBy(q => q.STD).ToList();




            var flightsdto = new List<ViewModels.ViewFlightInformationDto>();
            foreach (var x in flights)
            {
                ViewModels.ViewFlightInformationDto dto = new ViewFlightInformationDto();
                ViewModels.ViewFlightInformationDto.FillDto(x, dto, tzoffset);
                flightsdto.Add(dto);
            }

            var resgroups = from x in flights
                            group x by new { x.AircraftType, AircraftTypeId = x.TypeId }
                            into grp
                            select new { groupId = grp.Key.AircraftTypeId, Title = grp.Key.AircraftType };

            var ressq = (from x in flights
                         group x by new { x.RegisterID, x.Register, x.TypeId }
                     into grp
                         orderby grp.Key.TypeId, grp.Key.Register

                         select new { resourceId = grp.Key.RegisterID, resourceName = grp.Key.Register, groupId = grp.Key.TypeId }).ToList();
            //var ress = ressq.OrderBy(q => q.TypeId).Select((q, i) => new { resourceName = q.Register, groupId = q.TypeId, resourceId = (q.RegisterID >= 0 ? q.RegisterID : -1 * (i + 1)) }).ToList();

            foreach (var x in flightsdto)
            {
                //if (x.RegisterID >= 0)
                x.resourceId.Add((int)x.RegisterID);
                // else
                //    x.resourceId.Add((int)ress.First(q => q.resourceName == x.Register).resourceId);
            }

            //var baseSum = (from x in flights
            //              group x by new { x.BaseId, x.BaseIATA, x.BaseName } into g
            //              select new
            //              {
            //                  BaseId=g.Key.BaseId,
            //                  BaseIATA=g.Key.BaseIATA,
            //                  BaseName=g.Key.BaseName,
            //                  Total=g.Count(),
            //                  TakeOff=g.Where(q=>q.Takeoff!=null).Count(),
            //                  Landing=g.Where(q=>q.Landing!=null).Count(),
            //                  Canceled=g.Where(q=>q.FlightStatusID==4).Count(),
            //                  Redirected= g.Where(q => q.FlightStatusID == 17).Count(),
            //                  Diverted = g.Where(q => q.FlightStatusID == 7).Count(),
            //                  TotalDelays=g.Where(q=>q.ChocksOut!=null).Sum(q=>q.DelayOffBlock),
            //                  DepartedPax= g.Where(q => q.Takeoff != null).Sum(q=>q.TotalPax),
            //                  ArrivedPax= g.Where(q => q.Landing != null).Sum(q => q.TotalPax),

            //              }).ToList();
            //var fromAirport = (from x in flights
            //                   group x by new { x.FromAirport, x.FromAirportIATA, x.FromAirportName } into g
            //                   select new BaseSummary()
            //                   {
            //                       BaseId = g.Key.FromAirport,
            //                       BaseIATA = g.Key.FromAirportIATA,
            //                       BaseName = g.Key.FromAirportName,
            //                       Total = g.Count(),
            //                       TakeOff = g.Where(q => q.Takeoff != null).Count(),
            //                       Landing = 0, //g.Where(q => q.Landing != null).Count(),
            //                       Canceled = g.Where(q => q.FlightStatusID == 4).Count(),
            //                       Redirected = g.Where(q => q.FlightStatusID == 17).Count(),
            //                       Diverted = g.Where(q => q.FlightStatusID == 7).Count(),
            //                       TotalDelays = g.Where(q => q.ChocksOut != null).Sum(q => q.DelayOffBlock),
            //                       DepartedPax = g.Where(q => q.Takeoff != null).Sum(q => q.TotalPax),
            //                       ArrivedPax = 0,// g.Where(q => q.Landing != null).Sum(q => q.TotalPax),

            //                   }).ToList();
            //var toAirport = (from x in flights
            //                 group x by new { x.ToAirport, x.ToAirportIATA, x.ToAirportName } into g
            //                 select new BaseSummary()
            //                 {
            //                     BaseId = g.Key.ToAirport,
            //                     BaseIATA = g.Key.ToAirportIATA,
            //                     BaseName = g.Key.ToAirportName,
            //                     Total = g.Count(),
            //                     TakeOff = 0,//g.Where(q => q.Takeoff != null).Count(),
            //                     Landing = g.Where(q => q.Landing != null).Count(),
            //                     Canceled = 0,//g.Where(q => q.FlightStatusID == 4).Count(),
            //                     Redirected = 0,// g.Where(q => q.FlightStatusID == 17).Count(),
            //                     Diverted = 0,// g.Where(q => q.FlightStatusID == 7).Count(),
            //                     TotalDelays = 0,// g.Where(q => q.ChocksOut != null).Sum(q => q.DelayOffBlock),
            //                     DepartedPax = 0,// g.Where(q => q.Takeoff != null).Sum(q => q.TotalPax),
            //                     ArrivedPax = g.Where(q => q.Landing != null).Sum(q => q.TotalPax),

            //                 }).ToList();

            var baseSum = new List<BaseSummary>();
            //foreach (var x in fromAirport)
            //{
            //    var to = toAirport.FirstOrDefault(q => q.BaseId == x.BaseId);
            //    if (to != null)
            //    {
            //        x.ArrivedPax += to.ArrivedPax;
            //        x.Canceled += to.Canceled;
            //        x.DepartedPax += to.DepartedPax;
            //        x.Diverted += to.Diverted;
            //        x.Landing += to.Landing;
            //        x.Redirected += to.Redirected;
            //        x.TakeOff += to.TakeOff;
            //        x.Total += to.Total;
            //        x.TotalDelays += to.TotalDelays;

            //    }

            //    baseSum.Add(x);
            //}
            //var f9641 = flightsdto.FirstOrDefault(q => q.ID == 9641);
            var result = new
            {
                flights = flightsdto,
                resourceGroups = resgroups.ToList(),
                resources = ressq,
                baseSummary = baseSum,
            };
            return result;
        }



        public int getDateInt(DateTime? date)
        {
            var dt = Convert.ToDateTime(date);
            var str = "20" + dt.Month.ToString() + dt.Day.ToString();
            return Convert.ToInt32(str);

        }
        public string getDateString(DateTime? date)
        {
            PersianCalendar pc = new PersianCalendar();
            var dt = Convert.ToDateTime(date);
            var culture = CultureInfo.CurrentCulture;
            var abbr = culture.DateTimeFormat.GetAbbreviatedDayName(dt.DayOfWeek).Substring(0, 2);
            //var str =   abbr+" "+ "20-" + dt.Month.ToString()+"-" + dt.Day.ToString();
            var str = abbr + " 98-" + pc.GetMonth(dt).ToString() + "-" + pc.GetDayOfMonth(dt).ToString();
            return str;

        }
        public decimal getGroupKey(DateTime d1, DateTime d2, string day, string line)
        {
            var str = d1.Year.ToString() + d1.Month.ToString() + d1.Day.ToString() + d2.Month.ToString() + d2.Day.ToString();
            var i = 0;
            switch (day.ToUpper())
            {
                case "SAT":
                    i = 1;
                    break;
                case "SUN":
                    i = 2;
                    break;
                case "MON":
                    i = 3;
                    break;
                case "TUE":
                    i = 4;
                    break;
                case "WED":
                    i = 5;
                    break;
                case "THU":
                    i = 6;
                    break;
                case "FRI":
                    i = 7;
                    break;

                default:
                    break;
            }
            str += i.ToString() + line;
            return Convert.ToDecimal(str);
        }
        int getDayOrder(string day)
        {
            var i = 0;
            switch (day.ToUpper())
            {
                case "SAT":
                    i = 1;
                    break;
                case "SUN":
                    i = 2;
                    break;
                case "MON":
                    i = 3;
                    break;
                case "TUE":
                    i = 4;
                    break;
                case "WED":
                    i = 5;
                    break;
                case "THU":
                    i = 6;
                    break;
                case "FRI":
                    i = 7;
                    break;

                default:
                    break;
            }
            return i;
        }
        int getStatus(string day)
        {
            switch (day)
            {
                case "Sat":
                    return 1;
                case "Sun":
                    return 14;
                case "Mon":
                    return 2;
                case "Tue":
                    return 15;
                case "Wed":
                    return 7;
                case "Thu":
                    return 3;
                case "Fri":
                    return 22;
                default:
                    return 1;
            }
        }
        internal async Task<object> GetPlanGantt(int cid, DateTime dateFrom, DateTime dateTo, int tzoffset, int? airport, ViewModels.FlightsFilter filter)
        {
            var flightsQuery = this.context.ViewPlanFlights.AsNoTracking().Where(q => q.CustomerId == cid && q.STD >= dateFrom && q.STD <= dateTo && q.RegisterID != null);
            // var flightsQueryAll = this.context.ViewFlightInformations.Where(q => q.CustomerId == cid && q.STD >= dateFrom && q.STD <= dateTo && q.RegisterID != null);

            var flights = await flightsQuery.ToListAsync();
            foreach (var x in flights)
            {
                x.AssignedRegisterID = getDateInt(x.STD); //Convert.ToInt32(getDateInt(x.STD).ToString() + x.AssignedRegisterID.ToString());
                x.RegisterID = x.AssignedRegisterID;
                x.Register = getDateString(x.STD);
            }



            flights = flights.OrderBy(q => q.STD).ToList();



            var flightsdto = new List<ViewModels.ViewFlightInformationDto>();
            foreach (var x in flights)
            {
                ViewModels.ViewFlightInformationDto dto = new ViewFlightInformationDto();
                ViewModels.ViewFlightInformationDto.FillDto(x, dto, tzoffset);
                // dto.RegisterID= Convert.ToInt32(getDateInt(dto.STD).ToString() + dto.RegisterID.ToString());
                flightsdto.Add(dto);
            }


            var resgroups = from x in flights
                            group x by new { x.AircraftType, AircraftTypeId = x.TypeId }
                            // group x by new {AircraftType=getDateString(x.STDDay),AircraftTypeId=getDateInt(x.STDDay)}
                            into grp
                            select new { groupId = grp.Key.AircraftTypeId, Title = grp.Key.AircraftType };

            var ressq = (from x in flights
                         group x by new { x.RegisterID, x.Register,/*TypeId= getDateInt(x.STDDay)*/x.TypeId, x.STDDay }
                     into grp
                         orderby grp.Key.TypeId, grp.Key.STDDay, grp.Key.Register

                         select new { resourceId = grp.Key.RegisterID, resourceName = grp.Key.Register, groupId = grp.Key.TypeId }).ToList();
            //var ress = ressq.OrderBy(q => q.TypeId).Select((q, i) => new { resourceName = q.Register, groupId = q.TypeId, resourceId = (q.RegisterID >= 0 ? q.RegisterID : -1 * (i + 1)) }).ToList();

            foreach (var x in flightsdto)
            {
                //if (x.RegisterID >= 0)
                x.resourceId.Add((int)x.RegisterID);
                // else
                //    x.resourceId.Add((int)ress.First(q => q.resourceName == x.Register).resourceId);
            }





            var baseSum = new List<BaseSummary>();

            var f9641 = flightsdto.FirstOrDefault(q => q.ID == 9641);
            foreach (var x in flightsdto)
            {
                var std = (DateTime)x.STD;
                var sta = (DateTime)x.STA;
                var newstd = new DateTime(dateFrom.Year, dateFrom.Month, dateFrom.Day, std.Hour, std.Minute, std.Second);
                var newsta = new DateTime(dateFrom.Year, dateFrom.Month, dateFrom.Day, sta.Hour, sta.Minute, sta.Second);
                x.STD = newstd;
                x.STA = newsta;
                x.ChocksOut = newstd;
                x.ChocksIn = newsta;
                x.Takeoff = newstd;
                x.Landing = newsta;
                x.startDate = newstd;
                x.TypeId = getDateInt(x.STD);
                x.AircraftType = getDateString(x.STD);
            }
            var result = new
            {
                flights = flightsdto,
                resourceGroups = resgroups.ToList(),
                resources = ressq,
                baseSummary = baseSum,
            };
            return result;
        }
        internal async Task<object> GetPlanGantt2(int cid, DateTime dateFrom, DateTime dateTo, int tzoffset, int? airport, ViewModels.FlightsFilter filter)
        {
            var flightsQuery = this.context.ViewPlanItems.AsNoTracking();//.Where(q => q.Dep >= dateFrom && q.Arr <= dateTo);
            // var flightsQueryAll = this.context.ViewFlightInformations.Where(q => q.CustomerId == cid && q.STD >= dateFrom && q.STD <= dateTo && q.RegisterID != null);

            var _flights = await flightsQuery.ToListAsync();
            var flights = new List<ViewPlanItemDto>();
            foreach (var x in _flights)
            {
                flights.Add(new ViewPlanItemDto()
                {
                    AircraftType = x.AircraftType,
                    Arr = x.Arr,
                    DateFrom = x.DateFrom,
                    DateTo = x.DateTo,
                    DateRangeTitle = ((DateTime)x.DateFrom).Year + "-" + ((DateTime)x.DateFrom).Month + "-" + ((DateTime)x.DateFrom).Day
                                        + " to " + ((DateTime)x.DateTo).Year + "-" + ((DateTime)x.DateTo).Month + "-" + ((DateTime)x.DateTo).Day,
                    Day = x.Day,
                    DelayLanding = x.DelayLanding,
                    DelayOffBlock = x.DelayOffBlock,
                    DelayOnBlock = x.DelayOnBlock,
                    DelayTakeoff = x.DelayTakeoff,
                    Dep = x.Dep,
                    duration = x.duration,
                    EstimatedDelay = x.EstimatedDelay,
                    FlightNumber = x.FlightNumber,
                    FromAirport = x.FromAirport,
                    FromAirportIATA = x.FromAirportIATA,
                    Id = x.Id,
                    IsDelayLanding = x.IsDelayLanding,
                    IsDelayOffBlock = x.IsDelayOffBlock,
                    IsDelayOnBlock = x.IsDelayOnBlock,
                    IsDelayTakeoff = x.IsDelayTakeoff,
                    progress = x.progress,
                    resourceId = new List<decimal>(),
                    STA = x.STA,
                    startDate = x.startDate,
                    startDateUTC = x.startDateUTC,
                    STD = x.STD,
                    taskId = x.taskId,
                    ToAirport = x.ToAirport,
                    ToAirportIATA = x.ToAirportIATA,
                    TypeId = x.TypeId,
                    FlightStatusID = getStatus(x.Day),
                    status = getStatus(x.Day),
                    FlightPlanId = 1,
                    Line = x.Line,

                });
            }
            foreach (var x in flights)
            {
                // x.AssignedRegisterID = getDateInt(x.STD); //Convert.ToInt32(getDateInt(x.STD).ToString() + x.AssignedRegisterID.ToString());
                //  x.RegisterID = x.AssignedRegisterID;
                //  x.Register = getDateString(x.STD);
            }



            flights = flights.OrderBy(q => q.STD).ToList();




            var resgroups = from x in flights
                            group x by new { x.AircraftType, AircraftTypeId = x.TypeId }
                            // group x by new {AircraftType=getDateString(x.STDDay),AircraftTypeId=getDateInt(x.STDDay)}
                            into grp
                            select new { groupId = grp.Key.AircraftTypeId, Title = grp.Key.AircraftType };

            var ressq = (from x in flights
                         group x by new { RegisterID = getGroupKey((DateTime)x.DateFrom, (DateTime)x.DateTo, x.Day, x.Line), Register = x.Day + " " + x.Line,/*TypeId= getDateInt(x.STDDay)*/x.TypeId, x.DateFrom, DayOrder = getDayOrder(x.Day) }
                     into grp
                         orderby grp.Key.TypeId, grp.Key.DateFrom, grp.Key.DayOrder

                         select new { resourceId = grp.Key.RegisterID, resourceName = grp.Key.Register, groupId = grp.Key.TypeId }).ToList();
            //var ress = ressq.OrderBy(q => q.TypeId).Select((q, i) => new { resourceName = q.Register, groupId = q.TypeId, resourceId = (q.RegisterID >= 0 ? q.RegisterID : -1 * (i + 1)) }).ToList();

            foreach (var x in flights)
            {
                //if (x.RegisterID >= 0)
                x.resourceId.Add(getGroupKey((DateTime)x.DateFrom, (DateTime)x.DateTo, x.Day, x.Line));
                // else
                //    x.resourceId.Add((int)ress.First(q => q.resourceName == x.Register).resourceId);
            }





            var baseSum = new List<BaseSummary>();


            //foreach (var x in flightsdto)
            //{
            //    var std = (DateTime)x.STD;
            //    var sta = (DateTime)x.STA;
            //    var newstd = new DateTime(dateFrom.Year, dateFrom.Month, dateFrom.Day, std.Hour, std.Minute, std.Second);
            //    var newsta = new DateTime(dateFrom.Year, dateFrom.Month, dateFrom.Day, sta.Hour, sta.Minute, sta.Second);
            //    x.STD = newstd;
            //    x.STA = newsta;
            //    x.ChocksOut = newstd;
            //    x.ChocksIn = newsta;
            //    x.Takeoff = newstd;
            //    x.Landing = newsta;
            //    x.startDate = newstd;
            //    x.TypeId = getDateInt(x.STD);
            //    x.AircraftType = getDateString(x.STD);
            //}
            var tabgroups = (from x in flights
                             group x by new { x.DateRangeTitle, x.DateFrom, x.DateTo } into grp
                             select new { grp.Key.DateRangeTitle, grp.Key.DateFrom, grp.Key.DateTo }).ToList();
            var result = new
            {
                flights, //= flightsdto,
                resourceGroups = resgroups.ToList(),
                resources = ressq,
                baseSummary = baseSum,
                tabs = tabgroups
            };
            return result;
        }


        public async Task<CustomActionResult> GetUpdatedFlights(int airport, DateTime baseDate, DateTime? fromDate, DateTime? toDate, int customer, int tzoffset, int userid)
        {
            baseDate = baseDate.ToUniversalTime();
            fromDate = ((DateTime)fromDate).ToUniversalTime();
            toDate = ((DateTime)toDate).ToUniversalTime();


            var query = from x in this.context.ViewFlightInformations
                        where x.STD >= fromDate && x.STA <= toDate && x.CustomerId == customer && x.DateStatus > baseDate && x.FlightStatusUserId != userid
                        select x;
            if (airport != -1)
            {
                query = query.Where(q => q.FromAirport == airport || q.ToAirport == airport);
            }

            var flightsQuery = this.context.ViewFlightInformations.Where(q => q.CustomerId == customer && q.STD >= fromDate && q.STD <= toDate && q.RegisterID != null);

            if (airport != -1)
                flightsQuery = flightsQuery.Where(q => q.FromAirport == airport || q.ToAirport == airport);





            var _flights = await query.ToListAsync();
            if (_flights.Count > 0)
            {
                //var baseSum = (from x in flightsQuery
                //               group x by new { x.BaseId, x.BaseIATA, x.BaseName } into g
                //               select new
                //               {
                //                   BaseId = g.Key.BaseId,
                //                   BaseIATA = g.Key.BaseIATA,
                //                   BaseName = g.Key.BaseName,
                //                   Total = g.Count(),
                //                   TakeOff = g.Where(q => q.Takeoff != null).Count(),
                //                   Landing = g.Where(q => q.Landing != null).Count(),
                //                   Canceled = g.Where(q => q.FlightStatusID == 4).Count(),
                //                   Redirected = g.Where(q => q.FlightStatusID == 17).Count(),
                //                   Diverted = g.Where(q => q.FlightStatusID == 7).Count(),
                //                   TotalDelays = g.Where(q => q.ChocksOut != null).Sum(q => q.DelayOffBlock),
                //                   DepartedPax = g.Where(q => q.Takeoff != null).Sum(q => q.TotalPax),
                //                   ArrivedPax = g.Where(q => q.Landing != null).Sum(q => q.TotalPax),

                //               }).ToList();
                /////////////////////////////////////////////////////
                var fromAirport = (from x in flightsQuery
                                   group x by new { x.FromAirport, x.FromAirportIATA, x.FromAirportName } into g
                                   select new BaseSummary()
                                   {
                                       BaseId = g.Key.FromAirport,
                                       BaseIATA = g.Key.FromAirportIATA,
                                       BaseName = g.Key.FromAirportName,
                                       Total = g.Count(),
                                       TakeOff = g.Where(q => q.Takeoff != null).Count(),
                                       Landing = 0, //g.Where(q => q.Landing != null).Count(),
                                       Canceled = g.Where(q => q.FlightStatusID == 4).Count(),
                                       Redirected = g.Where(q => q.FlightStatusID == 17).Count(),
                                       Diverted = g.Where(q => q.FlightStatusID == 7).Count(),
                                       TotalDelays = g.Where(q => q.ChocksOut != null).Sum(q => q.DelayOffBlock),
                                       DepartedPax = g.Where(q => q.Takeoff != null).Sum(q => q.TotalPax),
                                       ArrivedPax = 0,// g.Where(q => q.Landing != null).Sum(q => q.TotalPax),

                                   }).ToList();
                var toAirport = (from x in flightsQuery
                                 group x by new { x.ToAirport, x.ToAirportIATA, x.ToAirportName } into g
                                 select new BaseSummary()
                                 {
                                     BaseId = g.Key.ToAirport,
                                     BaseIATA = g.Key.ToAirportIATA,
                                     BaseName = g.Key.ToAirportName,
                                     Total = g.Count(),
                                     TakeOff = 0,//g.Where(q => q.Takeoff != null).Count(),
                                     Landing = g.Where(q => q.Landing != null).Count(),
                                     Canceled = 0,//g.Where(q => q.FlightStatusID == 4).Count(),
                                     Redirected = 0,// g.Where(q => q.FlightStatusID == 17).Count(),
                                     Diverted = 0,// g.Where(q => q.FlightStatusID == 7).Count(),
                                     TotalDelays = 0,// g.Where(q => q.ChocksOut != null).Sum(q => q.DelayOffBlock),
                                     DepartedPax = 0,// g.Where(q => q.Takeoff != null).Sum(q => q.TotalPax),
                                     ArrivedPax = g.Where(q => q.Landing != null).Sum(q => q.TotalPax),

                                 }).ToList();

                var baseSum = new List<BaseSummary>();
                foreach (var x in fromAirport)
                {
                    var to = toAirport.FirstOrDefault(q => q.BaseId == x.BaseId);
                    if (to != null)
                    {
                        x.ArrivedPax += to.ArrivedPax;
                        x.Canceled += to.Canceled;
                        x.DepartedPax += to.DepartedPax;
                        x.Diverted += to.Diverted;
                        x.Landing += to.Landing;
                        x.Redirected += to.Redirected;
                        x.TakeOff += to.TakeOff;
                        x.Total += to.Total;
                        x.TotalDelays += to.TotalDelays;

                    }

                    baseSum.Add(x);
                }
                /////////////////////////////////////////////////////
                var result = new
                {
                    flights = _flights.Select(q => ViewFlightInformationDto.GetDto(q, tzoffset)).ToList(),
                    summary = baseSum,
                };
                //  return new CustomActionResult(HttpStatusCode.OK, flights.Select(q => ViewFlightInformationDto.GetDto(q, tzoffset)).ToList());
                return new CustomActionResult(HttpStatusCode.OK, result);
            }
            else
            {
                var result = new
                {
                    flights = _flights.Select(q => ViewFlightInformationDto.GetDto(q, tzoffset)).ToList(),
                    summary = -1,
                };
                return new CustomActionResult(HttpStatusCode.OK, result);
            }


        }

        //baba
        public async Task<CustomActionResult> GetUpdatedFlightsNew(int airport, DateTime baseDate, DateTime? fromDate, DateTime? toDate, int customer, int tzoffset, int userid)
        {
            baseDate = baseDate.ToUniversalTime();
            fromDate = ((DateTime)fromDate).ToUniversalTime();
            toDate = ((DateTime)toDate).ToUniversalTime();

            // var flightsQuery = this.context.ViewFlightsGantts.Where(q => q.CustomerId == cid && q.STDLocal >= dateFrom && q.STDLocal <= dateTo && q.RegisterID != null);

            var query = from x in this.context.ViewFlightsGantts
                        where x.STD >= fromDate && x.STA <= toDate && x.CustomerId == customer && x.DateStatus > baseDate && x.FlightStatusUserId != userid
                        select x;
            if (airport != -1)
            {
                query = query.Where(q => q.FromAirport == airport || q.ToAirport == airport);
            }

            var flightsQuery = this.context.ViewFlightsGantts.Where(q => q.CustomerId == customer && q.STD >= fromDate && q.STD <= toDate && q.RegisterID != null);

            if (airport != -1)
                flightsQuery = flightsQuery.Where(q => q.FromAirport == airport || q.ToAirport == airport);





            var _flights = await query.ToListAsync();
            if (_flights.Count > 0)
            {

                var fromAirport = (from x in flightsQuery
                                   group x by new { x.FromAirport, x.FromAirportIATA, x.FromAirportName } into g
                                   select new BaseSummary()
                                   {
                                       BaseId = g.Key.FromAirport,
                                       BaseIATA = g.Key.FromAirportIATA,
                                       BaseName = g.Key.FromAirportName,
                                       Total = g.Count(),
                                       TakeOff = g.Where(q => q.Takeoff != null).Count(),
                                       Landing = 0, //g.Where(q => q.Landing != null).Count(),
                                       Canceled = g.Where(q => q.FlightStatusID == 4).Count(),
                                       Redirected = g.Where(q => q.FlightStatusID == 17).Count(),
                                       Diverted = g.Where(q => q.FlightStatusID == 7).Count(),
                                       TotalDelays = g.Where(q => q.ChocksOut != null).Sum(q => q.DelayOffBlock),
                                       DepartedPax = g.Where(q => q.Takeoff != null).Sum(q => q.TotalPax),
                                       ArrivedPax = 0,// g.Where(q => q.Landing != null).Sum(q => q.TotalPax),

                                   }).ToList();
                var toAirport = (from x in flightsQuery
                                 group x by new { x.ToAirport, x.ToAirportIATA, x.ToAirportName } into g
                                 select new BaseSummary()
                                 {
                                     BaseId = g.Key.ToAirport,
                                     BaseIATA = g.Key.ToAirportIATA,
                                     BaseName = g.Key.ToAirportName,
                                     Total = g.Count(),
                                     TakeOff = 0,//g.Where(q => q.Takeoff != null).Count(),
                                     Landing = g.Where(q => q.Landing != null).Count(),
                                     Canceled = 0,//g.Where(q => q.FlightStatusID == 4).Count(),
                                     Redirected = 0,// g.Where(q => q.FlightStatusID == 17).Count(),
                                     Diverted = 0,// g.Where(q => q.FlightStatusID == 7).Count(),
                                     TotalDelays = 0,// g.Where(q => q.ChocksOut != null).Sum(q => q.DelayOffBlock),
                                     DepartedPax = 0,// g.Where(q => q.Takeoff != null).Sum(q => q.TotalPax),
                                     ArrivedPax = g.Where(q => q.Landing != null).Sum(q => q.TotalPax),

                                 }).ToList();

                var baseSum = new List<BaseSummary>();
                foreach (var x in fromAirport)
                {
                    var to = toAirport.FirstOrDefault(q => q.BaseId == x.BaseId);
                    if (to != null)
                    {
                        x.ArrivedPax += to.ArrivedPax;
                        x.Canceled += to.Canceled;
                        x.DepartedPax += to.DepartedPax;
                        x.Diverted += to.Diverted;
                        x.Landing += to.Landing;
                        x.Redirected += to.Redirected;
                        x.TakeOff += to.TakeOff;
                        x.Total += to.Total;
                        x.TotalDelays += to.TotalDelays;

                    }

                    baseSum.Add(x);
                }
                /////////////////////////////////////////////////////
                var flightsdto = new List<ViewModels.ViewFlightsGanttDto>();
                foreach (var x in _flights)
                {
                    ViewModels.ViewFlightsGanttDto dto = new ViewFlightsGanttDto();
                    ViewModels.ViewFlightsGanttDto.FillDto(x, dto, 0, 1);
                    flightsdto.Add(dto);
                }


                var result = new
                {
                    flights = flightsdto,
                    summary = baseSum,
                    baseDate = DateTime.UtcNow,
                };
                //  return new CustomActionResult(HttpStatusCode.OK, flights.Select(q => ViewFlightInformationDto.GetDto(q, tzoffset)).ToList());
                return new CustomActionResult(HttpStatusCode.OK, result);
            }
            else
            {
                var result = new
                {
                    flights = new List<ViewModels.ViewFlightsGanttDto>(),
                    summary = -1,
                    baseDate = DateTime.UtcNow,
                };
                return new CustomActionResult(HttpStatusCode.OK, result);
            }


        }

        //        public async Task<object>

        public async Task<dynamic> GetFlightsSummary(int cid, DateTime date)
        {
            var _count = await this.context.ViewFlightInformations.Where(q => q.CustomerId == cid && q.Date == date).CountAsync();
            var _departed = await this.context.ViewFlightInformations.Where(q => q.CustomerId == cid && q.Date == date && q.Takeoff != null).CountAsync();
            var _arrived = await this.context.ViewFlightInformations.Where(q => q.CustomerId == cid && q.Date == date && q.Landing != null).CountAsync();
            var _canceled = await this.context.ViewFlightInformations.Where(q => q.CustomerId == cid && q.Date == date && q.FlightStatusID == 4).CountAsync();
            var _redirected = await this.context.ViewFlightInformations.Where(q => q.CustomerId == cid && q.Date == date && (q.FlightStatusID == 7 || q.FlightStatusID == 17)).CountAsync();
            var _plannedtime = await this.context.ViewFlightInformations.Where(q => q.CustomerId == cid && q.Date == date).Select(q => q.duration * 60).SumAsync();
            var _actualtime = await this.context.ViewFlightInformations.Where(q => q.CustomerId == cid && q.Date == date).Select(q => q.ActualFlightHOffBlock != null ? q.ActualFlightHOffBlock * 60 + q.ActualFlightMOffBlock : 0).SumAsync();
            var _delay1 = await this.context.ViewFlightInformations.Where(q => q.CustomerId == cid && q.Date == date).Select(q => q.DelayOffBlock == null ? 0 : q.DelayOffBlock).SumAsync();
            var _delay2 = await this.context.ViewFlightInformations.Where(q => q.CustomerId == cid && q.Date == date).Select(q => q.DelayOnBlock == null ? 0 : q.DelayOnBlock).SumAsync();
            var _delaytotal = _delay1 + _delay2;
            var _paxadult = await this.context.ViewFlightInformations.Where(q => q.CustomerId == cid && q.Date == date).Select(q => q.PaxAdult == null ? 0 : q.PaxAdult).SumAsync();
            var _paxchild = await this.context.ViewFlightInformations.Where(q => q.CustomerId == cid && q.Date == date).Select(q => q.PaxChild == null ? 0 : q.PaxChild).SumAsync();
            var _paxinfant = await this.context.ViewFlightInformations.Where(q => q.CustomerId == cid && q.Date == date).Select(q => q.PaxInfant == null ? 0 : q.PaxInfant).SumAsync();
            var _paxtotal = _paxadult + _paxchild + _paxinfant;
            var _fuel = await this.context.ViewFlightInformations.Where(q => q.CustomerId == cid && q.Date == date).Select(q => (q.FuelDeparture != null && q.FuelArrival != null) ? q.FuelDeparture - q.FuelArrival : 0).SumAsync();
            var _cargo = await this.context.ViewFlightInformations.Where(q => q.CustomerId == cid && q.Date == date).Select(q => (q.CargoWeight != null ? q.CargoWeight : 0) + (q.BaggageWeight != null ? q.BaggageWeight : 0)).SumAsync();
            TimeSpan span = TimeSpan.FromMinutes(Convert.ToDouble(_delaytotal));
            var _delaytotalstr = span.ToString(@"hh\:mm");

            var mostDelayQuery = await (from x in this.context.ViewFlightInformations
                                        where x.CustomerId == cid && x.Date == date && x.DelayOffBlock != null
                                        orderby x.DelayOffBlock descending
                                        select new { x.ID, x.DelayOffBlock, x.FromAirportIATA, x.ToAirportIATA, x.Register, x.FlightNumber, Remark = x.Register + " " + x.FromAirportIATA + "-" + x.FlightNumber + "-" + x.ToAirportIATA }).Take(10).ToListAsync();

            var paxLoadQuery = await (from x in this.context.ViewFlightInformations
                                      where x.CustomerId == cid && x.Date == date && x.TotalPax != null && x.PaxAdult != null
                                      orderby x.TotalPax
                                      select new
                                      {
                                          x.ID,
                                          x.TotalPax,
                                          x.TotalSeat,
                                          PaxLoad = x.TotalPax / x.TotalSeat,
                                          x.FromAirportIATA,
                                          x.ToAirportIATA,
                                          x.Register,
                                          x.FlightNumber,
                                          Remark = x.Register + " " + x.FromAirportIATA + "-" + x.FlightNumber + "-" + x.ToAirportIATA
                                      }).Take(10).ToListAsync();


            var result = new
            {
                count = _count,
                departed = _departed,
                arrived = _arrived,
                canceled = _canceled,
                redirected = _redirected,
                plannedtime = Math.Round(Convert.ToDouble(_plannedtime)),
                actualtime = Math.Round(Convert.ToDouble(_actualtime)),
                delay1 = _delay1,
                delay2 = _delay2,
                delaytotal = _delaytotal,
                delaytotalstr = _delaytotalstr,
                paxadult = _paxadult,
                paxchild = _paxchild,
                paxinfant = _paxinfant,
                paxtotal = _paxtotal,
                fuel = _fuel,
                cargo = _cargo,
                topdelays = mostDelayQuery,
                paxload = paxLoadQuery,
            };
            return result;
        }

        //public async Task<ViewModels.Ac_MSNDto> GetDto(int id)
        //{
        //    var msndto = new ViewModels.Ac_MSNDto();
        //    var dbmsn = await context.Ac_MSN.FirstOrDefaultAsync(q => q.ID == id);
        //    ViewModels.Ac_MSNDto.FillDto(dbmsn, msndto);
        //    return msndto;
        //}

        internal virtual CustomActionResult ValidateFlightPlan(FlightPlanDto dto)
        {
            return new CustomActionResult(HttpStatusCode.OK, "");
        }
        internal virtual CustomActionResult ValidateFlight(FlightDto dto)
        {
            return new CustomActionResult(HttpStatusCode.OK, "");
        }


        string getRosterFDPKey(List<RosterFlight> flts)
        {
            var str = flts.Select(q => q.FlightId.ToString() + "*" + (q.DH ? "1" : "0"));
            return string.Join("_", str);
        }
        string getRosterFDPKey(List<RosterFDPItem> items)
        {
            var strs = new List<string>();
            foreach (var x in items)
                strs.Add(x.Flight.ID.ToString() + "*" + (x.DH ? "1" : "0"));
            return string.Join("_", strs);
        }


        public static void RotateRight(List<int> sequence, int count)
        {
            int tmp = sequence[count - 1];
            sequence.RemoveAt(count - 1);
            sequence.Insert(0, tmp);
        }

        public static IEnumerable<List<int>> Permutate(List<int> sequence, int count)
        {
            if (count == 1) yield return sequence;
            else
            {
                for (int i = 0; i < count; i++)
                {
                    foreach (var perm in Permutate(sequence, count - 1))
                        yield return perm;
                    RotateRight(sequence, count);
                }
            }
        }

        public List<string> presult = new List<string>();
        public void build(int position, string schedule, int n)
        {

            if (position == n - 2)
            {
                StringBuilder sb = new StringBuilder(schedule);
                sb[position] = ' ';
                schedule = sb.ToString();
                presult.Add(schedule);


                sb = new StringBuilder(schedule);
                sb[position] = '*';
                schedule = sb.ToString();
                presult.Add(schedule);

                return;
            }

            var sb2 = new StringBuilder(schedule);
            sb2[position] = ' ';
            schedule = sb2.ToString();

            build(position + 2, schedule, n);

            sb2 = new StringBuilder(schedule);
            sb2[position] = '*';
            schedule = sb2.ToString();

            build(position + 2, schedule, n);

        }

        public int getMaxFDP(DateTime start, int sectors, List<FDPMaxDaily> rows)
        {
            var _start = new DateTime(1900, 1, 1, start.Hour, start.Minute, start.Second);
            var row = rows.FirstOrDefault(q => q.Sectors == sectors && _start >= q.DutyStart && _start <= q.DutyEnd);
            if (row != null)
                return (int)row.MaxFDP;
            else
                return 13 * 60;
        }

        public int getExtension(DateTime start, int sectors, List<Extension> rows)
        {
            var _start = new DateTime(1900, 1, 1, start.Hour, start.Minute, start.Second);
            var row = rows.FirstOrDefault(q => q.Sectors == sectors && _start >= q.DutyStart && _start <= q.DutyEnd);
            if (row != null)
                return (int)row.MaxFDP;
            else
                return 0;
        }

        public void setSplitDuty(RosterFDP fdp)
        {
            if (fdp.Items.Count > 1)
            {
                for (int i = 1; i < fdp.Items.Count; i++)
                {
                    var dt = (DateTime)fdp.Items[i].Flight.STD - (DateTime)fdp.Items[i - 1].Flight.STA;
                    var minuts = dt.TotalMinutes;

                    var brk = minuts - 30 - 60;
                    //if (brk >= 600)
                    //{

                    //    //  breakGreaterThan10Hours = "The break is greater than 10 hours.";
                    //}

                    //else
                    if (brk >= 180)
                    {

                        fdp.Items[i].SplitDuty = true;
                        var pair = fdp.Items[i - 1];
                        pair.SplitDuty = true;
                        fdp.Items[i].SplitDutyPairId = pair.Flight.ID;

                        fdp.Items[i - 1].Break = ((DateTime)fdp.Items[i].Flight.STD - (DateTime)fdp.Items[i - 1].Flight.STD).TotalMinutes;

                    }
                }
            }
        }

        public async Task<dynamic> GetPrePostDutiesByCrew(int first, int last, int crewId)
        {
            var firstFlight = await this.context.ViewFlightInformations.FirstOrDefaultAsync(q => q.ID == first);
            var lastFlight = await this.context.ViewFlightInformations.FirstOrDefaultAsync(q => q.ID == last);
            var preDuty = await this.context.ViewFDP2.OrderByDescending(q => q.DutyStart).Where(q => q.CrewId == crewId && q.DutyEnd <= firstFlight.STD).FirstOrDefaultAsync();
            var postDuty = await this.context.ViewFDP2.OrderBy(q => q.DutyStart).Where(q => q.CrewId == crewId && q.DutyStart >= lastFlight.STA).FirstOrDefaultAsync();
            var conflictedDuties = await (from x in this.context.ViewFDP2
                                          where x.CrewId == crewId
                                          && (
                                                (x.DutyEnd >= firstFlight.STD && x.DutyEnd <= lastFlight.STA)
                                                || (x.DutyStart >= firstFlight.STD && x.DutyStart <= lastFlight.STA)
                                                || (firstFlight.STD >= x.DutyStart && firstFlight.STD <= x.DutyEnd)
                                                || (lastFlight.STA >= x.DutyStart && lastFlight.STA <= x.DutyEnd)
                                                )
                                          select x
                ).ToListAsync();
            return new
            {
                preDuty
                ,
                postDuty
                ,
                conflictedDuties
            };
        }

        static List<FDPMaxDaily> MaxTable = null;
        List<FDPMaxDaily> getMaxFDPTable()
        {
            if (MaxTable == null)
            {
                MaxTable = this.context.FDPMaxDailies.ToList();
            }
            return MaxTable;
        }

        static List<Extension> ExtensionTable = null;
        List<Extension> getExtensionTable()
        {
            if (ExtensionTable == null)
            {
                ExtensionTable = this.context.Extensions.ToList();
            }
            return ExtensionTable;
        }

        //magu2
        public async Task<dynamic> GetMaxFDPStats(List<int> ids, int? dh = null)
        {
            var MaxFDPTable = getMaxFDPTable(); //await this.context.FDPMaxDailies.ToListAsync();
            //var flights = await this.context.ViewFlightABS.Where(q => ids.Contains(q.ID)).OrderBy(q => q.STDDay).ThenBy(q => q.STD).ThenBy(q => q.Register).ToListAsync();
            var flights = await this.context.ViewLegTimes.Where(q => ids.Contains(q.ID)).OrderBy(q => q.STDDay).ThenBy(q => q.STD).ThenBy(q => q.Register).ToListAsync();
            MaxFDPStats stat = new MaxFDPStats();
            stat.ReportingTime = ((DateTime)flights.First().STDLocal).AddMinutes(-60);
            stat.Sectors = ids.Count - (dh == null ? 0 : (int)dh);
            stat.RestFrom = ((DateTime)flights.Last().STALocal).AddMinutes(30);
            var endDate = ((DateTime)flights.Last().STALocal);

            var _start = stat.ReportingTime.Hour + stat.ReportingTime.Minute * 1.0 / 60;
            var _end = endDate.Hour + endDate.Minute * 1.0 / 60;
            if (stat.ReportingTime.Day != endDate.Day)
                _start = 0;
            double wocl = 0;
            if (_start >= 2 && _start <= 6)
                wocl = Math.Min(6, _end) - _start;
            else if (_end >= 2 && _end <= 6)
                wocl = Math.Min(6, _end) - 2;
            else if (2 > _start && 2 < _end && 6 > _start && 6 < _end)
                wocl = 4;


            stat.RestTo = stat.RestFrom.AddHours(12);
            stat.MaxFDP = getMaxFDP(((DateTime)flights.First().STDLocal).AddMinutes(-60), stat.Sectors, MaxFDPTable);
            stat.WOCL = wocl * 60;
            stat.Extended = 0;
            stat.AllowedExtension = 0;
            bool allowExtension = true;
            stat.WOCLError = 0;
            if (flights.Count >= 5)
                allowExtension = false;
            else if (wocl > 0 && wocl <= 2 && flights.Count > 4)
            {
                allowExtension = false;
                stat.WOCLError = 1;
            }
            else if (wocl > 2 && flights.Count > 2)
            {
                allowExtension = false;
                stat.WOCLError = 1;
            }

            if (wocl > 0 && wocl <= 2 && flights.Count > 4)
            {

                stat.WOCLError = 1;
            }
            else if (wocl > 2 && flights.Count > 2)
            {

                stat.WOCLError = 1;
            }
            //allowExtension = true;
            if (allowExtension)
                for (int i = 1; i < flights.Count; i++)
                {
                    var dt = (DateTime)flights[i].STD - (DateTime)flights[i - 1].STA;
                    var minuts = dt.TotalMinutes;

                    var brk = minuts - 30 - 60;

                    if (brk >= 180 && brk < 600)
                    {
                        stat.Extended = 0.5 * brk;
                        break;
                    }
                }

            stat.Flight = flights.Select(q => ((DateTime)q.STA - (DateTime)q.STD).TotalMinutes).Sum();
            stat.Duration = ((DateTime)flights.Last().STALocal - stat.ReportingTime).TotalMinutes;
            if (stat.Duration > stat.MaxFDP && stat.Extended == 0)
            {
                var extTable = getExtensionTable();
                var extend = getExtension(((DateTime)flights.First().STDLocal).AddMinutes(-60), stat.Sectors, extTable);
                if (extend >= stat.Duration)
                    stat.AllowedExtension = getExtension(((DateTime)flights.First().STDLocal).AddMinutes(-60), stat.Sectors, extTable);


            }
            stat.MaxFDPExtended = stat.MaxFDP + stat.Extended;

            stat.Duty = stat.Duration + 30;


            return stat;
        }


        public async Task<dynamic> GetSTBYActivationStat(int isExtended, int stbyId, int firstLeg, int duty, int maxfdp)
        {
            var stby = await this.context.ViewFDPRests.FirstOrDefaultAsync(q => q.Id == stbyId);
            var leg = await this.context.ViewLegTimes.FirstOrDefaultAsync(q => q.ID == firstLeg);
            var reporting = ((DateTime)leg.STDLocal).AddHours(-1);
            string sqlQuery = "SELECT [dbo].[getFDPReductionBySTBY] ({0},{1},{2},{3})";
            Object[] parameters = { -1, stby.DateStartLocal, reporting, isExtended };
            double reduction = context.Database.SqlQuery<double>(sqlQuery, parameters).FirstOrDefault();

            var reducedMaxFDP = maxfdp - reduction;
            var maxFDPError = duty > reducedMaxFDP;

            var stbyDuration = (reporting - (DateTime)stby.DateStartLocal).TotalMinutes;
            var stbyFDPDuration = stbyDuration + duty;
            var durationError = stbyFDPDuration > 18 * 60;

            return new
            {
                reduction,
                reducedMaxFDP,
                stbyDuration,
                stbyFDPDuration,
                maxFDPError,
                durationError

            };




        }

        public class activatedStbys
        {
            public int? CrewId { get; set; }
            public string Name { get; set; }
            public string ScheduleName { get; set; }
            public string JobGroup { get; set; }
            public string Position { get; set; }
            public int? PositionId { get; set; }

            public List<ViewLegTime> flights { get; set; }
            public int? fdpId { get; set; }
        }
        public async Task<dynamic> GetActivatedStbys(DateTime date1, DateTime date2)
        {
            var _date1 = date1.Date;
            var _date2 = date2.Date;
            var fdps = await this.context.ViewFDPRests.Where(q => (q.DaySTDLocal >= _date1 && q.DaySTDLocal <= _date2) && q.FDPId != null).ToListAsync();
            var fdpIds = fdps.Select(q => q.Id).ToList();
            var crewIds = fdps.Select(q => q.CrewId).ToList();
            var crews = await this.context.ViewEmployeeLights.Where(q => crewIds.Contains(q.Id)).ToListAsync();

            var qflights = await (from x in this.context.FDPItems
                                  join f in this.context.ViewLegTimes on x.FlightId equals f.ID
                                  where fdpIds.Contains(x.FDPId)
                                  orderby f.STD
                                  select new
                                  {
                                      fdpId = x.FDPId,
                                      flight = f,


                                  }).ToListAsync();
            var result = new List<activatedStbys>();
            foreach (var item in fdps)
            {
                var crew = crews.FirstOrDefault(q => q.Id == item.CrewId);
                var row = new activatedStbys()
                {
                    CrewId = item.CrewId,
                    Name = crew.Name,
                    ScheduleName = crew.ScheduleName,
                    JobGroup = item.JobGroup,
                    Position = item.JobGroup,
                    fdpId = item.Id,
                    PositionId = -1,

                };
                row.flights = qflights.Where(q => q.fdpId == item.Id).Select(q => q.flight).ToList();
                result.Add(row);

            }

            return result;

        }
        internal async Task<CustomActionResult> DeleteActivatedStandby(int fdpId)
        {
            var fdp = await this.context.FDPs.FirstOrDefaultAsync(q => q.Id == fdpId);
            var stby = await this.context.FDPs.FirstOrDefaultAsync(q => q.Id == fdp.FDPId);

            stby.FDPId = null;
            stby.FDPReportingTime = null;
            stby.UPD = stby.UPD == null ? 1 : ((int)stby.UPD) + 1;

            this.context.FDPs.Remove(fdp);

            var saveResult = await context.SaveAsync();
            if (saveResult.Code != HttpStatusCode.OK)
                return saveResult;

            return new CustomActionResult(HttpStatusCode.OK, true);

        }

        //SOHA2
        internal async Task<List<RosterFDPDto>> getRosterFDPDtos(DateTime start, DateTime end)
        {
            var _start = start.ToUniversalTime();
            var _end = end.ToUniversalTime();
            var fdps = await this.context.FDPs.Where(q => q.DutyType == 1165 && q.CrewId != null && q.InitStart >= _start && q.InitStart <= _end).ToListAsync();
            var _ids = fdps.Select(q => q.Id).ToList();
            //  var viewfdps=await this.context.ViewFDPRests.Where(q => _ids.Contains(q.Id)).ToListAsync();
            var result = new List<RosterFDPDto>();
            foreach (var x in fdps)
            {
                //   var rfdp = viewfdps.FirstOrDefault(q => q.Id == x.Id);
                var item = new RosterFDPDto()
                {
                    Id = x.Id,
                    crewId = (int)x.CrewId,
                    flts = x.InitFlts,
                    from = Convert.ToInt32(x.InitFromIATA),
                    group = x.InitGroup,
                    homeBase = (int)x.InitHomeBase,
                    index = (int)x.InitIndex,
                    key = x.Key.Replace("*0", ""),
                    no = x.InitNo,
                    rank = x.InitRank,
                    route = x.InitRoute,
                    scheduleName = x.InitScheduleName,
                    to = Convert.ToInt32(x.InitToIATA),
                    flights = x.InitFlights.Split('*').ToList(),

                };
                // if (rfdp!=null)
                //  {
                //     item.IsSplitDuty = rfdp.ExtendedBySplitDuty > 0;
                //     item.SplitValue = rfdp.DelayAmount;
                // }
                item.ids = new List<RosterFDPId>();
                foreach (var f in item.flights)
                {
                    var prts = f.Split('_').ToList();
                    item.ids.Add(new RosterFDPId() { id = Convert.ToInt32(prts[0]), dh = Convert.ToInt32(prts[1]) });
                }
                result.Add(item);

            }
            return result;
        }

        internal async Task<List<ViewOffItem>> getViewOffItems(DateTime start, DateTime end)
        {
            var _start = start.ToUniversalTime();
            var _end = end.ToUniversalTime();
            var fdps = await this.context.ViewOffItems.Where(q => q.DateStart >= _start && q.DateEnd <= _end).ToListAsync();

            return fdps;
        }

        internal List<RosterFDPDto> getRosterFDPDtos(List<FDP> fdps)
        {

            var result = new List<RosterFDPDto>();
            foreach (var x in fdps)
            {
                var item = new RosterFDPDto()
                {
                    Id = x.Id,
                    crewId = (int)x.CrewId,
                    flts = x.InitFlts,
                    from = Convert.ToInt32(x.InitFromIATA),
                    group = x.InitGroup,
                    homeBase = (int)x.InitHomeBase,
                    index = (int)x.InitIndex,
                    key = x.Key.Replace("*0", ""),
                    no = x.InitNo,
                    rank = x.InitRank,
                    route = x.InitRoute,
                    scheduleName = x.InitScheduleName,
                    to = Convert.ToInt32(x.InitToIATA),
                    flights = x.InitFlights.Split('*').ToList(),



                };
                item.ids = new List<RosterFDPId>();
                foreach (var f in item.flights)
                {
                    var prts = f.Split('_').ToList();
                    item.ids.Add(new RosterFDPId() { id = Convert.ToInt32(prts[0]), dh = Convert.ToInt32(prts[1]) });
                }
                result.Add(item);

            }
            return result;
        }
        //cook
        internal FDP AddDuty(dynamic dto)
        {
            var duty = new FDP();
            duty.DateStart = Convert.ToDateTime(dto.DateStart);
            duty.DateEnd = Convert.ToDateTime(dto.DateEnd);
            duty.CityId = Convert.ToInt32(dto.CityId) == -1 ? Convert.ToInt32(dto.CityId) : null;
            duty.CrewId = Convert.ToInt32(dto.CrewId);
            duty.DutyType = Convert.ToInt32(dto.DutyType);
            duty.GUID = Guid.NewGuid();
            duty.IsTemplate = false;
            duty.Remark = dto.Remark != null ? Convert.ToString(dto.Remark) : "";
            duty.UPD = 1;

            duty.InitStart = duty.DateStart;
            duty.InitEnd = duty.DateEnd;
            var rest = new List<int>() { 1167, 1168, 1170, 5000, 5001, 100001, 100003 };
            duty.InitRestTo = rest.Contains(duty.DutyType) ? ((DateTime)duty.InitEnd).AddHours(12) : duty.DateEnd;

            this.context.FDPs.Add(duty);
            return duty;
        }
        internal async Task<CustomActionResult> SaveSTBY(dynamic dto)
        {
            DateTime day = (Convert.ToDateTime(dto.date));
            var crewId = Convert.ToInt32(dto.crewId);
            var type = Convert.ToInt32(dto.type);

            //var start = day;
            //var end = day.AddHours(12);
            //if (type == 1167)
            //{
            //    start = day.AddHours(12);
            //    end = start.AddHours(12);
            //}
            //if (type == 1170)
            //{
            //    end = start.AddHours(23).AddMinutes(59).AddSeconds(59);
            //}

            //caspian
            var start = day.AddHours(4);
            var end = day.AddHours(14);
            if (type == 1167)
            {
                start = day.AddHours(13);
                end = day.AddHours(23).AddMinutes(59);
            }
            if (type == 1170)
            {
                end = start.AddHours(23).AddMinutes(59).AddSeconds(59);
            }

            var duty = new FDP();
            duty.DateStart = start;
            duty.DateEnd = end;
            duty.CityId = -1; //Convert.ToInt32(dto.CityId) == -1 ? Convert.ToInt32(dto.CityId) : null;
            duty.CrewId = crewId;
            duty.DutyType = type;
            duty.GUID = Guid.NewGuid();
            duty.IsTemplate = false;
            //duty.Remark = dto.Remark != null ? Convert.ToString(dto.Remark) : "";
            duty.UPD = 1;

            duty.InitStart = duty.DateStart;
            duty.InitEnd = duty.DateEnd;
            var rest = new List<int>() { 1167, 1168, 1170, 5000, 5001, 100001, 100003 };
            duty.InitRestTo = rest.Contains(duty.DutyType) ? ((DateTime)duty.InitEnd).AddHours(12) : duty.DateEnd;
            //porn
            var exc = new List<int>() { 100009, 100020, 100021, 100022, 100023, 1170 };
            var _interupted = await this.context.FDPs.FirstOrDefaultAsync(q => !exc.Contains(q.DutyType) && q.CrewId == duty.CrewId
            && (
                  (duty.InitStart >= q.InitStart && duty.InitStart <= q.InitRestTo)
               || (duty.InitEnd >= q.InitStart && duty.InitEnd <= q.InitRestTo)
               || (q.InitStart >= duty.InitStart && q.InitRestTo <= duty.InitRestTo)
              )
           );
            if (_interupted != null)
            {
                //Rest/Interruption Error
                return new CustomActionResult(HttpStatusCode.NotAcceptable, new
                {

                    message = "Rest/Interruption Error." + (_interupted.InitStart == null ? "" : ((DateTime)_interupted.InitStart).ToString("yyyy-MM-dd") + " " + _interupted.InitFlts + " " + _interupted.InitRoute)

                });
                //return new CustomActionResult(HttpStatusCode.NotAcceptable, _interupted);
            }


            this.context.FDPs.Add(duty);
            var saveResult = await context.SaveAsync();
            if (saveResult.Code != HttpStatusCode.OK)
                return saveResult;

            //2020-11-22 noreg
            var view = await this.context.ViewCrewDutyNoRegs.FirstOrDefaultAsync(q => q.Id == duty.Id);
            return new CustomActionResult(HttpStatusCode.OK, view);
        }

        internal async Task<CustomActionResult> RemoveItemsFromFDP(string strItems, string strfdps, string reason = "")
        {
            //dooltopol
            var _fdpItemIds = strItems.Split('*').Select(q => Convert.ToInt32(q)).Distinct().ToList();
            var _fdpIds = strfdps.Split('*').Select(q => Convert.ToInt32(q)).Distinct().ToList();


            var fdps = await this.context.FDPs.Where(q => _fdpIds.Contains(q.Id)).ToListAsync();
            var fdpIds = fdps.Select(q => q.Id).ToList();
            var crewIds = fdps.Select(q => q.CrewId).ToList();
            var fdpItems = await this.context.FDPItems.Where(q => fdpIds.Contains(q.FDPId)).ToListAsync();
            var allFlightIds = fdpItems.Select(q => q.FlightId).ToList();
            var allFlights = await this.context.ViewLegTimes.Where(q => allFlightIds.Contains(q.ID)).ToListAsync();
            var crews = await this.context.ViewEmployeeLights.Where(q => crewIds.Contains(q.Id)).ToListAsync();
            var allRemovedItems = fdpItems.Where(q => _fdpItemIds.Contains(q.Id)).ToList();

            List<string> sms = new List<string>();
            List<string> nos = new List<string>();
            foreach (var x in allRemovedItems)
            {
                var xfdp = fdps.FirstOrDefault(q => q.Id == x.FDPId);
                var xcrew = crews.FirstOrDefault(q => q.Id == xfdp.CrewId);
                var xleg = allFlights.FirstOrDefault(q => q.ID == x.FlightId);
                var strs = new List<string>();
                strs.Add(ConfigurationManager.AppSettings["airline"] + " Airlines");
                strs.Add("Dear " + xcrew.Name + ", ");
                strs.Add("Your flight canceled" + (string.IsNullOrEmpty(reason) ? "." : reason));
                strs.Add(xleg.FromAirportIATA + "-" + xleg.FlightNumber + "-" + xleg.ToAirportIATA);
                strs.Add("Date sent: " + DateTime.Now.ToLocalTime().ToString("yyyy/MM/dd HH:mm"));
                strs.Add("Crew Scheduling Department");

                var text = String.Join("\n", strs);
                sms.Add(text);
                nos.Add(xcrew.Mobile);

            }




            //  List<FDP> deleted = new List<FDP>();
            foreach (var fdp in fdps)
            {
                fdp.Split = 0;
                var allitems = fdpItems.Where(q => q.FDPId == fdp.Id).ToList();
                var removedItems = allitems.Where(q => _fdpItemIds.Contains(q.Id)).ToList();
                var remainItems = allitems.Where(q => !_fdpItemIds.Contains(q.Id)).ToList();
                var remainFlightIds = remainItems.Select(q => q.FlightId).ToList();
                if (allitems.Count == removedItems.Count)
                {
                    this.context.FDPItems.RemoveRange(removedItems);
                    this.context.FDPs.Remove(fdp);
                }
                else
                {
                    //Update FDP

                    this.context.FDPItems.RemoveRange(removedItems);
                    var items = (from x in remainItems
                                 join y in allFlights on x.FlightId equals y.ID
                                 orderby y.STD
                                 select new { fi = x, flt = y }).ToList();
                    fdp.FirstFlightId = items.First().flt.ID;
                    fdp.LastFlightId = items.Last().flt.ID;
                    fdp.InitStart = ((DateTime)items.First().flt.STD).AddMinutes(-60);
                    fdp.InitEnd = ((DateTime)items.Last().flt.STA).AddMinutes(30);
                    fdp.DateStart = ((DateTime)items.First().flt.STD).AddMinutes(-60);
                    fdp.DateEnd = ((DateTime)items.Last().flt.STA).AddMinutes(30);
                    var rst = 12;
                    if (fdp.InitHomeBase != null && fdp.InitHomeBase != items.Last().flt.ToAirport)
                        rst = 10;
                    fdp.InitRestTo = ((DateTime)items.Last().flt.STA).AddMinutes(30).AddHours(rst);
                    fdp.InitFlts = string.Join(",", items.Select(q => q.flt).Select(q => q.FlightNumber).ToList());
                    fdp.InitRoute = string.Join(",", items.Select(q => q.flt).Select(q => q.FromAirportIATA).ToList());
                    fdp.InitRoute += "," + items.Last().flt.ToAirportIATA;
                    fdp.InitFromIATA = items.First().flt.FromAirport.ToString();
                    fdp.InitToIATA = items.Last().flt.ToAirport.ToString();
                    fdp.InitNo = string.Join("-", items.Select(q => q.flt).Select(q => q.FlightNumber).ToList());
                    fdp.InitKey = string.Join("-", items.Select(q => q.flt).Select(q => q.ID).ToList());
                    fdp.InitFlights = string.Join("*", items.Select(q => q.flt.ID + "_" + (q.fi.IsPositioning == true ? "1" : "0") + "_" + ((DateTime)q.flt.STDLocal).ToString("yyyyMMddHHmm")
                      + "_" + ((DateTime)q.flt.STALocal).ToString("yyyyMMddHHmm")
                      + "_" + q.flt.FlightNumber + "_" + q.flt.FromAirportIATA + "_" + q.flt.ToAirportIATA).ToList()
                    );

                    var keyParts = new List<string>();
                    keyParts.Add(items[0].flt.ID + "*" + (items[0].fi.IsPositioning == true ? "1" : "0"));
                    var breakGreaterThan10Hours = string.Empty;
                    for (int i = 1; i < items.Count; i++)
                    {

                        keyParts.Add(items[i].flt.ID + "*" + (items[i].fi.IsPositioning == true ? "1" : "0"));
                        var dt = (DateTime)items[i].flt.STD - (DateTime)items[i - 1].flt.STA;
                        var minuts = dt.TotalMinutes;
                        // – (0:30 + 0:15 + 0:45)
                        var brk = minuts - 30 - 60; //30:travel time, post flight duty:15, pre flight duty:30
                        if (brk >= 600)
                        {
                            //var tfi = tflights.FirstOrDefault(q => q.ID == flights[i].ID);
                            // var tfi1 = tflights.FirstOrDefault(q => q.ID == flights[i - 1].ID);
                            breakGreaterThan10Hours = "The break is greater than 10 hours.";
                        }
                        else
                        if (brk >= 180)
                        {
                            var xfdpitem = allitems.FirstOrDefault(q => q.Id == items[i].fi.Id);
                            xfdpitem.SplitDuty = true;
                            var pair = allitems.FirstOrDefault(q => q.Id == items[i - 1].fi.Id);
                            pair.SplitDuty = true;
                            xfdpitem.SplitDutyPairId = pair.FlightId;
                            fdp.Split = 0.5 * (brk);

                        }

                    }
                    fdp.UPD = fdp.UPD == null ? 1 : ((int)fdp.UPD) + 1;
                    fdp.Key = string.Join("_", keyParts);

                    //var flights = allFlights.Where(q => remainFlightIds.Contains(q.ID)).OrderBy(q=>q.STD).ToList();


                }
            }





            var saveResult = await context.SaveAsync();
            if (saveResult.Code != HttpStatusCode.OK)
                return saveResult;
            Magfa m = new Magfa();
            int c = 0;
            foreach (var x in sms)
            {
                var txt = sms[c];
                var no = nos[c];

                var smsResult = m.enqueue(1, no, txt)[0];
                c++;

            }

            return new CustomActionResult(HttpStatusCode.OK, true);
        }

        //piano
        internal async Task<object> RemoveItemsFromFDPByRegisterChange(string crews, string flts)
        {
            var crewIds = crews.Split('*').Select(q => Convert.ToInt32(q)).Distinct().ToList();
            foreach (var cid in crewIds)
            {
                var result = await RemoveItemsFromFDP(flts, cid, 3, "", 1, 0);
            }
            return true;
        }
        //soha2
        //helen2
        internal async Task<CustomActionResult> RemoveItemsFromFDP(string strItems, int crewId, int reason, string remark, int notify, int noflight, string username = "")
        {
            //var _fdpItemIds = strItems.Split('*').Select(q => Convert.ToInt32(q)).Distinct().ToList();
            //var _fdpIds = strfdps.Split('*').Select(q => Convert.ToInt32(q)).Distinct().ToList();

            var flightIds = strItems.Split('*').Select(q => (Nullable<int>)Convert.ToInt32(q)).Distinct().ToList();
            var _fdpItemIds = await this.context.ViewFDPItem2.Where(q => q.CrewId == crewId && flightIds.Contains(q.FlightId)).OrderBy(q => q.STD).Select(q => q.Id).ToListAsync();
            var allRemovedItems = await this.context.FDPItems.Where(q => _fdpItemIds.Contains(q.Id)).ToListAsync();
            var _fdpIds = allRemovedItems.Select(q => q.FDPId).ToList();
            var fdps = await this.context.FDPs.Where(q => _fdpIds.Contains(q.Id)).ToListAsync();
            var fdpItems = await this.context.FDPItems.Where(q => _fdpIds.Contains(q.FDPId)).ToListAsync();


            var allFlightIds = fdpItems.Select(q => q.FlightId).ToList();
            var allFlights = await this.context.ViewLegTimes.Where(q => allFlightIds.Contains(q.ID)).OrderBy(q => q.STD).ToListAsync();
            var crews = await this.context.ViewEmployeeLights.Where(q => q.Id == crewId).ToListAsync();
            var allRemovedFlights = allFlights.Where(q => flightIds.Contains(q.ID)).OrderBy(q => q.STD).ToList();
            FDP offFDP = null;
            string offSMS = string.Empty;
            List<string> sms = new List<string>();
            List<string> nos = new List<string>();
            List<CrewPickupSM> csms = new List<CrewPickupSM>();
            if (reason != -1)
            {


                offFDP = new FDP()
                {
                    CrewId = crewId,
                    DateStart = allRemovedFlights.First().STD,
                    DateEnd = allRemovedFlights.Last().STA,
                    InitStart = allRemovedFlights.First().STD,
                    InitEnd = allRemovedFlights.Last().STA,

                    InitRestTo = allRemovedFlights.Last().STA,
                    InitKey = allRemovedFlights.First().ID.ToString(),
                    DutyType = 0,
                    GUID = Guid.NewGuid(),
                    IsTemplate = false,
                    Remark = remark,
                    UPD = 1,
                    UserName = username


                };
                offFDP.CanceledNo = string.Join(",", allRemovedFlights.Select(q => q.FlightNumber));
                offFDP.CanceledRoute = string.Join(",", allRemovedFlights.Select(q => q.FromAirportIATA)) + "," + allRemovedFlights.Last().ToAirportIATA;
                switch (reason)
                {
                    case 1:
                        offFDP.DutyType = 100009;
                        offFDP.Remark2 = "Refused by Crew";
                        break;
                    case 5:
                        offFDP.DutyType = 100020;
                        offFDP.Remark2 = "Cenceled due to Rescheduling";
                        break;
                    case 2:
                        offFDP.DutyType = 100021;
                        offFDP.Remark2 = "Cenceled due to Flight(s) Cancellation";
                        break;
                    case 3:
                        offFDP.DutyType = 100022;
                        offFDP.Remark2 = "Cenceled due to Change of A/C Type";
                        break;
                    case 4:
                        offFDP.DutyType = 100023;
                        offFDP.Remark2 = "Cenceled due to Flight/Duty Limitations";
                        break;
                    case 6:
                        offFDP.DutyType = 100024;
                        offFDP.Remark2 = "Cenceled due to Not using Split Duty";
                        break;


                    case 7:
                        offFDP.DutyType = 200000;
                        offFDP.Remark2 = "Refused-Not Home";
                        break;
                    case 8:
                        offFDP.DutyType = 200001;
                        offFDP.Remark2 = "Refused-Family Problem";
                        break;
                    case 9:
                        offFDP.DutyType = 200002;
                        offFDP.Remark2 = "Canceled - Training";
                        break;
                    case 10:
                        offFDP.DutyType = 200003;
                        offFDP.Remark2 = "Ground - Operation";
                        break;
                    case 11:
                        offFDP.DutyType = 200004;
                        offFDP.Remark2 = "Ground - Expired License";
                        break;
                    case 12:
                        offFDP.DutyType = 200005;
                        offFDP.Remark2 = "Ground - Medical";
                        break;
                    default:
                        break;
                }
                foreach (var x in allRemovedFlights)
                {
                    var _ofdpitem = fdpItems.FirstOrDefault(q => q.FlightId == x.ID);
                    string _oremark = string.Empty;
                    if (_ofdpitem != null)
                    {
                        var _ofdp = fdps.Where(q => q.Id == _ofdpitem.FDPId).FirstOrDefault();
                        if (_ofdp != null)
                            _oremark = _ofdp.InitRank;
                    }
                    offFDP.OffItems.Add(new OffItem() { FDP = offFDP, FlightId = x.ID, Remark = _oremark });
                }

                this.context.FDPs.Add(offFDP);



                var strs = new List<string>();
                strs.Add(ConfigurationManager.AppSettings["airline"] + " Airlines");
                strs.Add("Dear " + crews.FirstOrDefault(q => q.Id == crewId).Name + ", ");
                strs.Add("Canceling Notification");
                var day = ((DateTime)allRemovedFlights.First().STDLocal).Date;
                var dayStr = day.ToString("ddd") + " " + day.Year + "-" + day.Month + "-" + day.Day;
                strs.Add(dayStr);
                strs.Add(offFDP.CanceledNo);
                strs.Add(offFDP.CanceledRoute);
                strs.Add(offFDP.Remark2);
                strs.Add(remark);
                strs.Add("Date sent: " + DateTime.Now.ToLocalTime().ToString("yyyy/MM/dd HH:mm"));
                strs.Add("Crew Scheduling Department");
                offSMS = String.Join("\n", strs);
                sms.Add(offSMS);
                nos.Add(crews.FirstOrDefault(q => q.Id == crewId).Mobile);

                var csm = new CrewPickupSM()
                {
                    CrewId = (int)crewId,
                    DateSent = DateTime.Now,
                    DateStatus = DateTime.Now,
                    FlightId = -1,
                    Message = offSMS,
                    Pickup = null,
                    RefId = "",
                    Status = "",
                    Type = offFDP.DutyType,
                    FDP = offFDP,
                    DutyType = offFDP.Remark2,
                    DutyDate = ((DateTime)offFDP.InitStart).ToLocalTime().Date,
                    Flts = offFDP.CanceledNo,
                    Routes = offFDP.CanceledRoute
                };
                csms.Add(csm);
                if (notify == 1)
                    this.context.CrewPickupSMS.Add(csm);
            }

            /////////////////////////
            //var fdps = await this.context.FDPs.Where(q => _fdpIds.Contains(q.Id)).ToListAsync();
            //var fdpIds = fdps.Select(q => q.Id).ToList();
            //var crewIds = fdps.Select(q => q.CrewId).ToList();
            //var fdpItems = await this.context.FDPItems.Where(q => fdpIds.Contains(q.FDPId)).ToListAsync();
            //var allFlightIds = fdpItems.Select(q => q.FlightId).ToList();
            //var allFlights = await this.context.ViewLegTimes.Where(q => allFlightIds.Contains(q.ID)).ToListAsync();
            //var crews = await this.context.ViewEmployeeLights.Where(q => crewIds.Contains(q.Id)).ToListAsync();
            //var allRemovedItems = fdpItems.Where(q => _fdpItemIds.Contains(q.Id)).ToList();
            //////////////////////////
            //////////////////////////
            ///////////////////

            foreach (var x in allRemovedItems)
            {
                var xfdp = fdps.FirstOrDefault(q => q.Id == x.FDPId);
                var xcrew = crews.FirstOrDefault(q => q.Id == xfdp.CrewId);
                var xleg = allFlights.FirstOrDefault(q => q.ID == x.FlightId);


            }

            var updatedIds = new List<int>();
            var updated = new List<FDP>();
            var removed = new List<int>();


            //  List<FDP> deleted = new List<FDP>();
            foreach (var fdp in fdps)
            {
                fdp.Split = 0;
                var allitems = fdpItems.Where(q => q.FDPId == fdp.Id).ToList();
                var removedItems = allitems.Where(q => _fdpItemIds.Contains(q.Id)).ToList();
                var remainItems = allitems.Where(q => !_fdpItemIds.Contains(q.Id)).ToList();
                var remainFlightIds = remainItems.Select(q => q.FlightId).ToList();
                if (allitems.Count == removedItems.Count)
                {
                    removed.Add(fdp.Id);
                    this.context.FDPItems.RemoveRange(removedItems);

                    this.context.FDPs.Remove(fdp);
                }
                else
                {
                    //Update FDP

                    this.context.FDPItems.RemoveRange(removedItems);
                    var items = (from x in remainItems
                                 join y in allFlights on x.FlightId equals y.ID
                                 orderby y.STD
                                 select new { fi = x, flt = y }).ToList();
                    fdp.FirstFlightId = items.First().flt.ID;
                    fdp.LastFlightId = items.Last().flt.ID;
                    fdp.InitStart = ((DateTime)items.First().flt.STD).AddMinutes(-60);
                    fdp.InitEnd = ((DateTime)items.Last().flt.STA).AddMinutes(30);

                    fdp.DateStart = ((DateTime)items.First().flt.STD).AddMinutes(-60);
                    fdp.DateEnd = ((DateTime)items.Last().flt.STA).AddMinutes(30);

                    var rst = 12;
                    if (fdp.InitHomeBase != null && fdp.InitHomeBase != items.Last().flt.ToAirport)
                        rst = 10;
                    fdp.InitRestTo = ((DateTime)items.Last().flt.STA).AddMinutes(30).AddHours(rst);
                    fdp.InitFlts = string.Join(",", items.Select(q => q.flt).Select(q => q.FlightNumber).ToList());
                    fdp.InitRoute = string.Join(",", items.Select(q => q.flt).Select(q => q.FromAirportIATA).ToList());
                    fdp.InitRoute += "," + items.Last().flt.ToAirportIATA;
                    fdp.InitFromIATA = items.First().flt.FromAirport.ToString();
                    fdp.InitToIATA = items.Last().flt.ToAirport.ToString();
                    fdp.InitNo = string.Join("-", items.Select(q => q.flt).Select(q => q.FlightNumber).ToList());
                    fdp.InitKey = string.Join("-", items.Select(q => q.flt).Select(q => q.ID).ToList());
                    fdp.InitFlights = string.Join("*", items.Select(q => q.flt.ID + "_" + (q.fi.IsPositioning == true ? "1" : "0") + "_" + ((DateTime)q.flt.STDLocal).ToString("yyyyMMddHHmm")
                      + "_" + ((DateTime)q.flt.STALocal).ToString("yyyyMMddHHmm")
                      + "_" + q.flt.FlightNumber + "_" + q.flt.FromAirportIATA + "_" + q.flt.ToAirportIATA).ToList()
                    );

                    var keyParts = new List<string>();
                    keyParts.Add(items[0].flt.ID + "*" + (items[0].fi.IsPositioning == true ? "1" : "0"));
                    var breakGreaterThan10Hours = string.Empty;
                    for (int i = 1; i < items.Count; i++)
                    {

                        keyParts.Add(items[i].flt.ID + "*" + (items[i].fi.IsPositioning == true ? "1" : "0"));
                        var dt = (DateTime)items[i].flt.STD - (DateTime)items[i - 1].flt.STA;
                        var minuts = dt.TotalMinutes;
                        // – (0:30 + 0:15 + 0:45)
                        var brk = minuts - 30 - 60; //30:travel time, post flight duty:15, pre flight duty:30
                        if (brk >= 600)
                        {
                            //var tfi = tflights.FirstOrDefault(q => q.ID == flights[i].ID);
                            // var tfi1 = tflights.FirstOrDefault(q => q.ID == flights[i - 1].ID);
                            breakGreaterThan10Hours = "The break is greater than 10 hours.";
                        }
                        else
                        if (brk >= 180)
                        {
                            var xfdpitem = allitems.FirstOrDefault(q => q.Id == items[i].fi.Id);
                            xfdpitem.SplitDuty = true;
                            var pair = allitems.FirstOrDefault(q => q.Id == items[i - 1].fi.Id);
                            pair.SplitDuty = true;
                            xfdpitem.SplitDutyPairId = pair.FlightId;
                            fdp.Split += 0.5 * (brk);

                        }

                    }
                    fdp.UPD = fdp.UPD == null ? 1 : ((int)fdp.UPD) + 1;
                    fdp.Key = string.Join("_", keyParts);
                    fdp.UserName = username;
                    //var flights = allFlights.Where(q => remainFlightIds.Contains(q.ID)).OrderBy(q=>q.STD).ToList();
                    updatedIds.Add(fdp.Id);
                    updated.Add(fdp);

                }
            }





            var saveResult = await context.SaveAsync();
            if (saveResult.Code != HttpStatusCode.OK)
                return saveResult;
            if (notify == 1)
            {
                Magfa m = new Magfa();
                int c = 0;
                foreach (var x in sms)
                {
                    var txt = sms[c];
                    var no = nos[c];

                    var smsResult = m.enqueue(1, no, txt)[0];
                    c++;

                }
            }

            //updated = await this.context.ViewFDPKeys.Where(q => updatedIds.Contains(q.Id)).ToListAsync();

            var result = new
            {
                removed,
                updatedId = updated.Select(q => q.Id).ToList(),
                updated = getRosterFDPDtos(updated)
            };

            return new CustomActionResult(HttpStatusCode.OK, result);
        }

        public string GetDutyTypeTitle(int t)
        {
            switch (t)
            {
                case 1165: return "FDP";
                case 1166: return "Day Off";
                case 1167: return "STBY";
                case 1168: return "STBY";
                case 1169: return "Vacation";
                case 1170: return "Reserve ";
                case 5000: return "Training";
                case 5001: return "Office";
                case 10000: return "RERRP/DayOff";
                case 10001: return "RERRP2/DayOff";
                case 100000: return "Ground";
                case 100001: return "Meeting";
                case 100002: return "Sick";
                case 100003: return "Simulator";
                case 100004: return "Expired Licence";
                case 100005: return "Expired Medical";
                case 100006: return "Expired Passport";
                case 100007: return "No Flight";
                case 100008: return "Requested Off";
                case 100009: return "Refuse";
                case 100020: return "Canceled(Rescheduling)";
                case 100021: return "Canceled(Flight cancellation)";
                case 100022: return "Canceled(Change of A/C Type)";
                case 100023: return "Canceled(FTL)";
                case 100024: return "Canceled(Not using Split Duty)";
                case 100025: return "Mission";
                default:
                    return "Unknown";
            }
        }
        internal async Task<CustomActionResult> saveFDP(RosterFDPDto dto)
        {
            Stopwatch timer = new Stopwatch();
            timer.Start();
            dto.items = RosterFDPDto.getItems(dto.flights);
            bool alldh = dto.items.Where(q => q.dh == 0).Count() == 0;
            var fdpDuty = dto.getDuty();
            var fdpFlight = dto.getFlight();
            var stdday = dto.items[0].std.Date;
            //var dutyFlight = await this.context.ViewDayDutyFlights.FirstOrDefaultAsync(q => q.Date == stdday);
            //magu210



            var _d1 = stdday;
            var _d2 = stdday.AddDays(-6);
            var _df1 = stdday;
            var _df2 = stdday.AddDays(-27);
            var ncrewid = (Nullable<int>)dto.crewId;

            var _d7 = await this.context.TableDutyFDPs.Where(q => q.CrewId == ncrewid && q.CDate >= _d2 && q.CDate <= _d1).Select(q => q.DurationLocal).SumAsync();




            double duty7 = _d7 ?? 0; //d7 != null && d7.Duty7Local != null ? (double)d7.Duty7Local : 0;




            var _f28 = await this.context.ViewDutyFlightLocals.Where(q => q.CrewId == ncrewid && q.CDate >= _df2 && q.CDate <= _df1).Select(q => q.DurationLocal).SumAsync(); ;
            double flight28 = _f28 ?? 0; //f28 != null && f28.FLT28Local != null ? (double)f28.FLT28Local : 0;

            //Check Over FTL/////////////////
            if (duty7 + fdpDuty > 60 * 60 && (dto.IsAdmin == null || dto.IsAdmin == 0))
            {
                return new CustomActionResult(HttpStatusCode.NotAcceptable, new
                {
                    message = "Flight Time/Duty Limitaion Error. "
                    + "7-Day Duties: " + FormatTwoDigits(Convert.ToInt32(Math.Floor(duty7 + fdpDuty)) / 60) + ":" + FormatTwoDigits(Convert.ToInt32(Math.Floor(duty7 + fdpDuty)) % 60)
                });
            }
            if (flight28 + fdpFlight > 100 * 60 && (dto.IsAdmin == null || dto.IsAdmin == 0))
            {
                return new CustomActionResult(HttpStatusCode.NotAcceptable, new
                {
                    message = "Flight Time/Duty Limitaion Error. "
                   + "28-Day Flights: " + FormatTwoDigits(Convert.ToInt32(Math.Floor(flight28 + fdpFlight)) / 60) + ":" + FormatTwoDigits(Convert.ToInt32(Math.Floor(flight28 + fdpFlight)) % 60)
                });
            }
            ////////////////////////////////////


            //(from x in this.context.ViewDayDutyFlights
            // where x.Date >= dateStart && x.Date <= dateEnd && crewIds.Contains(x.CrewId)
            // select x).ToList();



            dto.flts = string.Join(",", dto.items.Select(q => q.no + (q.dh == 1 ? "(dh)" : "")).ToList());
            var rts = dto.items.Select(q => q.from).ToList();
            //if (dto.items.Count > 1)
            rts.Add(dto.items.Last().to);
            dto.route = string.Join(",", rts);
            // if (dto.items.Count= 1)


            var keyParts = dto.items.Select(q => q.flightId + (q.dh == 1 ? "*1" : "*0")).ToList();
            var rst = dto.to == dto.homeBase ? 12 : 10;
            if (dto.extension != null && dto.extension > 0)
                rst += 4;
            var fdp = new FDP()
            {
                IsTemplate = false,
                DutyType = 1165,
                CrewId = dto.crewId,
                GUID = Guid.NewGuid(),
                JobGroupId = RosterFDPDto.getRank(dto.rank),
                FirstFlightId = dto.items.First().flightId,
                LastFlightId = dto.items.Last().flightId,
                Key = string.Join("_", keyParts),
                InitFlts = dto.flts,
                InitRoute = dto.route,
                InitFromIATA = dto.from.ToString(),
                InitToIATA = dto.to.ToString(),
                InitStart = !alldh ? dto.items.First().std.AddMinutes(-60) : dto.items.First().std,
                InitEnd = !alldh ? dto.items.Last().sta.AddMinutes(30) : dto.items.Last().sta,
                DateStart = !alldh ? dto.items.First().std.AddMinutes(-60) : dto.items.First().std,
                DateEnd = !alldh ? dto.items.Last().sta.AddMinutes(30) : dto.items.Last().sta,
                InitRestTo = !alldh ? dto.items.Last().sta.AddMinutes(30).AddHours(rst) : dto.items.Last().sta,
                InitFlights = string.Join("*", dto.flights),
                InitGroup = dto.group,
                InitHomeBase = dto.homeBase,
                InitIndex = dto.index,
                InitKey = dto.key,
                InitNo = dto.no,
                InitRank = dto.rank,
                InitScheduleName = dto.scheduleName,
                Extension = dto.extension,
                Split = 0,
                UserName = dto.UserName,


            };
            //Check Extension //////////////////
            if (fdp.Extension != null && fdp.Extension > 0)
            {
                var exd1 = (DateTime)fdp.InitStart;
                var exd0 = exd1.AddHours(-168);
                var extcnt = await this.context.ExtensionHistories.Where(q => q.CrewId == fdp.CrewId && (q.DutyStart >= exd0 && q.DutyStart <= exd1)).CountAsync();
                if (extcnt >= 2)
                {
                    return new CustomActionResult(HttpStatusCode.NotAcceptable, new
                    {

                        message = "You can't extend maximum daily FDP due to the crew extended fdps in 7 consecutive days."

                    });
                }
            }
            //4-11
            //Check interuption/////////////////
            var exc = new List<int>() { 1166, 1169, /*10000, 10001, 100000, 100002, 100004, 100005, 100006,*/ 100007, 100008, 100024, 100025, 100009, 100020, 100021, 100022, 100023, 200000, 200001, 200002, 200003, 200004, 200005 };

            //if (!alldh)
            {
                FDP _interupted = null;

                _interupted = await this.context.FDPs.FirstOrDefaultAsync(q =>
              !exc.Contains(q.DutyType) &&
              q.Id != fdp.Id && q.CrewId == fdp.CrewId
         && (
               (fdp.InitStart >= q.InitStart && fdp.InitStart <= q.InitRestTo)
            || (fdp.InitEnd >= q.InitStart && fdp.InitEnd <= q.InitRestTo)
            || (q.InitStart >= fdp.InitStart && q.InitStart <= fdp.InitRestTo)
            || (q.InitRestTo >= fdp.InitStart && q.InitRestTo <= fdp.InitRestTo)
           )
        );


                //doolnaz
                if (_interupted != null && (dto.IsAdmin == null || dto.IsAdmin == 0))
                {
                    //Rest/Interruption Error
                    if ((_interupted.DutyType != 1167 && _interupted.DutyType != 1168 && _interupted.DutyType != 1170) || !(dto.items.First().std >= _interupted.DateStart && dto.items.First().std <= _interupted.DateEnd))
                    {
                        //if (false)
                        bool sendError = false;
                        switch (_interupted.DutyType)
                        {
                            case 10000:
                            case 100000:
                            case 100002:
                            case 100004:
                            case 100005:
                            case 100006:
                                if ((new List<int>() { 10000, 10001, 1169, 100000, 100002, 100004, 100005, 100006, 100007, 100008, 100009, 100020, 100021, 100022, 100023, 100024, 200000, 200001, 200002, 200003, 200004, 200005 }).IndexOf(fdp.DutyType) == -1)
                                {
                                    if ((fdp.InitStart >= _interupted.InitStart && fdp.InitStart <= _interupted.InitEnd)
                                        || (fdp.InitEnd >= _interupted.InitStart && fdp.InitEnd <= _interupted.InitEnd)
                                        || (_interupted.InitStart >= fdp.InitStart && _interupted.InitStart <= fdp.InitEnd)
                                        || (_interupted.InitEnd >= fdp.InitStart && _interupted.InitEnd <= fdp.InitEnd)
                                        )
                                        sendError = true;
                                }
                                break;
                            case 1165:
                                if (alldh)
                                {
                                    try
                                    {
                                        var intStart = ((DateTime)_interupted.InitStart).AddMinutes(60);
                                        var intEnd = ((DateTime)_interupted.InitEnd).AddMinutes(-30);
                                        if (fdp.InitStart > intStart && fdp.InitStart < intEnd)
                                            sendError = true;
                                        else if (fdp.InitEnd > intStart && fdp.InitEnd < intEnd)
                                            sendError = true;
                                        else if (fdp.InitStart == intStart && fdp.InitEnd == intEnd)
                                            sendError = true;
                                        else if (intStart >= fdp.InitStart && intStart <= fdp.InitEnd)
                                            sendError = true;
                                        else if (intEnd >= fdp.InitStart && intEnd <= fdp.InitEnd)
                                            sendError = true;
                                        else
                                            sendError = false;

                                    }
                                    catch (Exception exxx)
                                    {
                                        sendError = false;
                                    }

                                }
                                else
                                {
                                    if (_interupted.InitNo.Contains("*1"))
                                    {
                                        var nodh = await this.context.FDPItems.Where(q => q.FDPId == _interupted.Id && q.IsPositioning != true).CountAsync();
                                        if (nodh > 0)
                                            sendError = true;
                                        else
                                        {
                                            var fdpStart = dto.items.First().std;
                                            var fdpEnd = dto.items.Last().sta;
                                            if (_interupted.InitStart >= fdpStart && _interupted.InitStart <= fdpEnd)
                                                sendError = true;
                                            else if (_interupted.InitEnd >= fdpStart && _interupted.InitEnd <= fdpEnd)
                                                sendError = true;
                                            else if (fdpStart >= _interupted.InitStart && fdpStart <= _interupted.InitEnd)
                                                sendError = true;
                                            else if (fdpEnd >= _interupted.InitStart && fdpEnd <= _interupted.InitEnd)
                                                sendError = true;
                                            else
                                                sendError = false;
                                        }
                                    }
                                    else
                                        sendError = true;
                                }

                                break;
                            default:
                                sendError = true;
                                break;
                        }
                        if (sendError)
                            return new CustomActionResult(HttpStatusCode.NotAcceptable, new
                            {

                                message = "Rest/Interruption Error(" + _interupted.Id + "). " + (GetDutyTypeTitle(_interupted.DutyType)) + "   " + (_interupted.InitStart == null ? "" : ((DateTime)_interupted.InitStart).ToString("yyyy-MM-dd") + " " + _interupted.InitFlts + " " + _interupted.InitRoute)

                            });
                    }
                    else
                    {
                        if (_interupted.DutyType == 1167 || _interupted.DutyType == 1168)
                            return new CustomActionResult(HttpStatusCode.NotImplemented, _interupted);
                        else
                        {
                            var _strt = ((DateTime)fdp.InitStart).AddMinutes(60);
                            var rdif = Math.Abs((DateTime.UtcNow - _strt).TotalMinutes);
                            if (rdif < 10 * 60)
                                return new CustomActionResult(HttpStatusCode.NotModified, _interupted);
                        }
                    }
                    //return new CustomActionResult(HttpStatusCode.NotAcceptable, _interupted);
                }
            }

            ///////////////////////////////

            bool saveTemp = false;
            var tkey = string.Join("_", keyParts);
            var temp = await this.context.FDPs.FirstOrDefaultAsync(q => q.IsTemplate && q.Key == tkey);
            if (temp == null)
            {
                saveTemp = true;
                temp = new FDP()
                {
                    IsTemplate = true,
                    DutyType = 1165,
                    IsMain = true,
                    GUID = Guid.NewGuid(),

                    FirstFlightId = dto.items.First().flightId,
                    LastFlightId = dto.items.Last().flightId,
                    Key = string.Join("_", keyParts),
                    InitFlts = dto.flts,
                    InitRoute = dto.route,
                    InitFromIATA = dto.from.ToString(),
                    InitToIATA = dto.to.ToString(),
                    InitStart = dto.items.First().std.AddMinutes(-60),
                    InitEnd = dto.items.Last().std.AddMinutes(30),
                    Split = 0,
                    UserName = dto.UserName,

                };
                this.context.FDPs.Add(temp);
            }

            double flightSum = 0;
            var firststd = ((DateTime)dto.items.First().std).ToLocalTime();
            var laststa = ((DateTime)dto.items.Last().sta).ToLocalTime();
            int early = firststd.Hour <= 8 ? 1 : 0;
            int late = laststa.Hour >= 22 ? 1 : 0;
            foreach (var x in dto.items)
            {
                flightSum += ((DateTime)x.sta - (DateTime)x.std).TotalMinutes;
                fdp.FDPItems.Add(new FDPItem()
                {
                    FlightId = x.flightId,
                    IsPositioning = x.dh == 1,
                    IsSector = x.dh != 1,
                    PositionId = RosterFDPDto.getRank(dto.rank),
                    RosterPositionId = dto.index,

                });
                if (saveTemp)
                    temp.FDPItems.Add(new FDPItem()
                    {
                        FlightId = x.flightId,
                        IsPositioning = x.dh == 1,
                        IsSector = x.dh != 1,


                    });

            }

            var breakGreaterThan10Hours = string.Empty;
            if (dto.items.Count > 1 && dto.split)
            {
                for (int i = 1; i < dto.items.Count; i++)
                {
                    var dt = (DateTime)dto.items[i].std - (DateTime)dto.items[i - 1].sta;
                    var minuts = dt.TotalMinutes;
                    // – (0:30 + 0:15 + 0:45)
                    var brk = minuts - 30 - 60; //30:travel time, post flight duty:15, pre flight duty:30
                    if (brk >= 600)
                    {
                        //var tfi = tflights.FirstOrDefault(q => q.ID == flights[i].ID);
                        // var tfi1 = tflights.FirstOrDefault(q => q.ID == flights[i - 1].ID);
                        breakGreaterThan10Hours = "The break is greater than 10 hours.";
                    }

                    else
                    if (brk >= 180)
                    {
                        var fdpitem = fdp.FDPItems.FirstOrDefault(q => q.FlightId == dto.items[i].flightId);
                        fdpitem.SplitDuty = true;
                        var pair = fdp.FDPItems.FirstOrDefault(q => q.FlightId == dto.items[i - 1].flightId);
                        pair.SplitDuty = true;
                        fdpitem.SplitDutyPairId = pair.FlightId;
                        fdp.Split += 0.5 * (brk);
                        ////////////////////////////////////////////////////
                        if (saveTemp)
                        {
                            var fdpitemTemp = temp.FDPItems.FirstOrDefault(q => q.FlightId == dto.items[i].flightId);
                            fdpitemTemp.SplitDuty = true;
                            var pairTemp = temp.FDPItems.FirstOrDefault(q => q.FlightId == dto.items[i - 1].flightId);
                            pairTemp.SplitDuty = true;
                            fdpitemTemp.SplitDutyPairId = pair.FlightId;
                            temp.Split += 0.5 * (brk);
                        }


                        //////////////////////////////////

                    }
                }
            }

            var saveResult = new CustomActionResult(HttpStatusCode.OK, null);

            if (saveTemp)
            {
                saveResult = await context.SaveAsync();
            }

            if (saveResult.Code != HttpStatusCode.OK)
                return saveResult;
            fdp.TemplateId = temp.Id;

            //????? stby.UPD = stby.UPD == null ? 1 : ((int)stby.UPD) + 1;
            this.context.FDPs.Add(fdp);
            if (fdp.Extension != null && fdp.Extension > 0)
            {
                fdp.ExtensionHistories.Add(new ExtensionHistory()
                {
                    CrewId = (int)fdp.CrewId,
                    DutyStart = fdp.InitStart,
                    Extension = fdp.Extension,
                    Sectors = dto.items.Count,
                });
            }

            this.context.Database.ExecuteSqlCommand("update employee set flightsum=isnull(flightsum,0)+" + flightSum + ",FlightEarly=isnull(FlightEarly,0)+" + early + ",FlightLate=isnull(FlightLate,0)+" + late + "  where id=" + dto.crewId);


            saveResult = await context.SaveAsync();
            if (saveResult.Code != HttpStatusCode.OK)
                return saveResult;
            // var vfdp = await this.context.ViewFDPRests.FirstOrDefaultAsync(q => q.Id == fdp.Id);
            //  return new CustomActionResult(HttpStatusCode.OK, vfdp);



            timer.Stop();
            var _ms = timer.Elapsed;
            return new CustomActionResult(HttpStatusCode.OK, fdp);
        }

        internal async Task<CustomActionResult> saveFDPNoCrew(int userId, int flightId, string code)
        {
            //momo
            var fdp = new FDP()
            {
                IsTemplate = false,
                DutyType = 1165,
                CrewId = userId,
                GUID = Guid.NewGuid(),
                JobGroupId = RosterFDPDto.getRank(code),
                FirstFlightId = flightId,
                LastFlightId = flightId,

                Split = 0,



            };

            fdp.FDPItems.Add(new FDPItem()
            {
                FlightId = flightId,
                IsPositioning = false,
                IsSector = false,
                PositionId = RosterFDPDto.getRank(code),
                RosterPositionId = 1,

            });

            this.context.FDPs.Add(fdp);
            var saveResult = await context.SaveAsync();
            if (saveResult.Code != HttpStatusCode.OK)
                return saveResult;




            return new CustomActionResult(HttpStatusCode.OK, fdp);
        }


        internal async Task<CustomActionResult> saveFDPNoCrew2(int userId, List<int> flightIds, string code)
        {
            //momo
            List<object> results = new List<object>();

            foreach (var flightId in flightIds)
            {
                var _fdp = await this.context.FDPs.Where(q => q.FirstFlightId == flightId && q.CrewId == userId).FirstOrDefaultAsync();
                if (_fdp == null)
                {

                    var fdp = new FDP()
                    {
                        IsTemplate = false,
                        DutyType = 1165,
                        CrewId = userId,
                        GUID = Guid.NewGuid(),
                        JobGroupId = RosterFDPDto.getRank(code),
                        FirstFlightId = flightId,
                        LastFlightId = flightId,

                        Split = 0,



                    };

                    fdp.FDPItems.Add(new FDPItem()
                    {
                        FlightId = flightId,
                        IsPositioning = false,
                        IsSector = false,
                        PositionId = RosterFDPDto.getRank(code),
                        RosterPositionId = 1,

                    });

                    this.context.FDPs.Add(fdp);
                    results.Add(fdp);
                }




            }

            var saveResult = await context.SaveAsync();
            if (saveResult.Code != HttpStatusCode.OK)
                return saveResult;
            return new CustomActionResult(HttpStatusCode.OK, results);
        }


        internal async Task<CustomActionResult> deleteFDPNoCrew(int userId, int flightId)
        {
            var fdp = await this.context.FDPs.FirstOrDefaultAsync(q => q.FirstFlightId == flightId && q.CrewId == userId);
            if (fdp != null)
            {
                this.context.FDPs.Remove(fdp);
                await context.SaveAsync();
            }
            return new CustomActionResult(HttpStatusCode.OK, true);
        }

        //sook
        internal async Task<CustomActionResult> ActivateStandby(int crewId, int stbyId, string fids, int rank, int index)
        {
            //doolnazs
            var _fids = fids.Split('*').Select(q => Convert.ToInt32(q)).ToList();
            var flights = await this.context.ViewLegTimes.Where(q => _fids.Contains(q.ID)).OrderBy(q => q.STD).ToListAsync();

            var flightIds = flights.Select(q => (Nullable<int>)q.ID).ToList();
            var allFdpItems = await (from x in this.context.FDPItems
                                     join y in this.context.FDPs on x.FDPId equals y.Id
                                     where flightIds.Contains(x.FlightId) && y.CrewId != null && x.IsSector && (x.IsOff == null || x.IsOff == false)
                                     select x).ToListAsync();
            if (index == -1)
            {
                var _fpdItemX = allFdpItems.Where(q => q.FlightId == flightIds.First() && q.PositionId == rank).OrderByDescending(q => q.RosterPositionId).FirstOrDefault();
                index = 1;
                if (_fpdItemX != null)
                {
                    index = _fpdItemX.RosterPositionId == null ? 1 : (int)_fpdItemX.RosterPositionId + 1;
                }
            }


            var stby = await this.context.FDPs.FirstOrDefaultAsync(q => q.Id == stbyId);
            // keyParts.Add(items[0].flt.ID + "*" + (items[0].fi.IsPositioning == true ? "1" : "0"));
            var keyParts = flights.Select(q => q.ID + "*0").ToList();
            var crew = await this.context.ViewEmployees.Where(q => q.Id == crewId).FirstOrDefaultAsync();
            var fdp = new FDP()
            {
                IsTemplate = false,
                DutyType = 1165,
                CrewId = crewId,
                GUID = Guid.NewGuid(),
                JobGroupId = rank,
                FirstFlightId = flights.First().ID,
                LastFlightId = flights.Last().ID,
                Key = string.Join("_", keyParts),
                FDPId = stbyId,


            };
            /////////////////////////////////
            fdp.InitScheduleName = crew.ScheduleName;
            fdp.InitHomeBase = crew.BaseAirportId;
            fdp.InitIndex = index;
            fdp.InitGroup = crew.JobGroup;
            //switch (crew.JobGroup)
            //{
            //    case "TRE":
            //    case "TRI":
            //    case "LTC":
            //        fdp.InitRank = "IP";
            //        break;
            //    case "ISCCM":
            //        fdp.InitRank = "ISCCM";
            //        break;
            //    case "SCCM":
            //        fdp.InitRank = "SCCM";
            //        break;
            //    case "CCM":
            //        fdp.InitRank = "CCM";
            //        break;
            //    case "P1":
            //        fdp.InitRank = "P1";
            //        break;
            //    case "P2":
            //        fdp.InitRank = "P2";
            //        break;
            //    default:
            //        break;
            //}
            fdp.InitRank = RosterFDPDto.getRankStr(rank);
            fdp.InitStart = ((DateTime)flights.First().STD).AddMinutes(-60);
            fdp.InitEnd = ((DateTime)flights.Last().STA).AddMinutes(30);
            fdp.DateStart = ((DateTime)flights.First().STD).AddMinutes(-60);
            fdp.DateEnd = ((DateTime)flights.Last().STA).AddMinutes(30);
            var rst = 12;

            fdp.InitRestTo = ((DateTime)flights.Last().STA).AddMinutes(30).AddHours(rst);
            fdp.InitFlts = string.Join(",", flights.Select(q => q.FlightNumber).ToList());
            fdp.InitRoute = string.Join(",", flights.Select(q => q.FromAirportIATA).ToList());
            fdp.InitRoute += "," + flights.Last().ToAirportIATA;
            fdp.InitFromIATA = flights.First().FromAirport.ToString();
            fdp.InitToIATA = flights.Last().ToAirport.ToString();
            fdp.InitNo = string.Join("-", flights.Select(q => q.FlightNumber).ToList());
            fdp.InitKey = string.Join("-", flights.Select(q => q.ID).ToList());
            fdp.InitFlights = string.Join("*", flights.Select(q => q.ID + "_" + ("0") + "_" + ((DateTime)q.STDLocal).ToString("yyyyMMddHHmm")
              + "_" + ((DateTime)q.STALocal).ToString("yyyyMMddHHmm")
              + "_" + q.FlightNumber + "_" + q.FromAirportIATA + "_" + q.ToAirportIATA).ToList()
            );
            fdp.Split = 0;

            //////////////////////////////////
            var temp = new FDP()
            {
                IsTemplate = true,
                DutyType = 1165,
                IsMain = true,
                GUID = Guid.NewGuid(),

                FirstFlightId = flights.First().ID,
                LastFlightId = flights.Last().ID,
                Key = string.Join("_", keyParts),
                Split = 0,

            };
            this.context.FDPs.Add(temp);


            foreach (var x in flights)
            {
                //var _fpdItem = allFdpItems.Where(q => q.FlightId == x.ID && q.PositionId == rank).OrderByDescending(q => q.RosterPositionId).FirstOrDefault();
                //var rosterPositionId = 1;
                //if (_fpdItem != null)
                //{
                //    rosterPositionId = _fpdItem.RosterPositionId == null ? 1 : (int)_fpdItem.RosterPositionId + 1;
                //}
                fdp.FDPItems.Add(new FDPItem()
                {
                    FlightId = x.ID,
                    IsPositioning = false,
                    IsSector = true,
                    PositionId = rank,
                    RosterPositionId = index,

                });
                temp.FDPItems.Add(new FDPItem()
                {
                    FlightId = x.ID,
                    IsPositioning = false,
                    IsSector = true,


                });

            }

            var breakGreaterThan10Hours = string.Empty;
            if (flights.Count > 1)
            {
                for (int i = 1; i < flights.Count; i++)
                {
                    var dt = (DateTime)flights[i].STD - (DateTime)flights[i - 1].STA;
                    var minuts = dt.TotalMinutes;
                    // – (0:30 + 0:15 + 0:45)
                    var brk = minuts - 30 - 60; //30:travel time, post flight duty:15, pre flight duty:30
                    if (brk >= 600)
                    {
                        //var tfi = tflights.FirstOrDefault(q => q.ID == flights[i].ID);
                        // var tfi1 = tflights.FirstOrDefault(q => q.ID == flights[i - 1].ID);
                        breakGreaterThan10Hours = "The break is greater than 10 hours.";
                    }

                    else
                    if (brk >= 180)
                    {
                        var fdpitem = fdp.FDPItems.FirstOrDefault(q => q.FlightId == flights[i].ID);
                        fdpitem.SplitDuty = true;
                        var pair = fdp.FDPItems.FirstOrDefault(q => q.FlightId == flights[i - 1].ID);
                        pair.SplitDuty = true;
                        fdpitem.SplitDutyPairId = pair.FlightId;
                        fdp.Split += 0.5 * (brk);
                        ////////////////////////////////////////////////////
                        var fdpitemTemp = temp.FDPItems.FirstOrDefault(q => q.FlightId == flights[i].ID);
                        fdpitemTemp.SplitDuty = true;
                        var pairTemp = temp.FDPItems.FirstOrDefault(q => q.FlightId == flights[i - 1].ID);
                        pairTemp.SplitDuty = true;
                        fdpitemTemp.SplitDutyPairId = pair.FlightId;
                        temp.Split += 0.5 * (brk);
                        //////////////////////////////////

                    }
                }
            }



            var saveResult = await context.SaveAsync();
            if (saveResult.Code != HttpStatusCode.OK)
                return saveResult;
            fdp.TemplateId = temp.Id;
            stby.FDP2 = fdp;
            stby.FDPReportingTime = ((DateTime)flights.First().STD).AddMinutes(-60);
            stby.UPD = stby.UPD == null ? 1 : ((int)stby.UPD) + 1;
            this.context.FDPs.Add(fdp);

            saveResult = await context.SaveAsync();
            if (saveResult.Code != HttpStatusCode.OK)
                return saveResult;
            var vfdp = await this.context.ViewFDPRests.FirstOrDefaultAsync(q => q.Id == fdp.Id);
            return new CustomActionResult(HttpStatusCode.OK, vfdp);





        }


        public void setMaxFDP(RosterFDP fdp, List<FDPMaxDaily> rows)
        {

            var sectors = fdp.Items.Where(q => q.IsSector).Count();
            var firstFlight = fdp.Items.First().Flight;

            var maxFDP = getMaxFDP(((DateTime)firstFlight.STDLocal).AddMinutes(-60), sectors, rows);
            double extendedBySplitDuty = 0;
            var splitDuty = fdp.Items.FirstOrDefault(q => q.SplitDuty);
            if (splitDuty != null)
            {
                extendedBySplitDuty = (double)(0.5 * (splitDuty.Break - 30 - 60));
            }

            fdp.MaxFDP = maxFDP;
            fdp.MaxFDPExtended = maxFDP + extendedBySplitDuty;
            //banana


        }

        void setScore(List<ANormalFDPs> collection)
        {
            foreach (var item in collection)
            {
                double score = 0;
                for (int i = 0; i < item.FDPs.Count; i++)
                {
                    var fdp = item.FDPs[i];
                    var sc_maxfdp = fdp.OverDuration < 0 ? fdp.OverDuration / fdp.MaxFDPExtended : 0;
                    double sc_rest = 0;
                    if (i < item.FDPs.Count - 1)
                    {
                        var rest = ((DateTime)item.FDPs[i + 1].ReportingTime - (DateTime)fdp.FDPEnd).TotalMinutes;
                        sc_rest = (rest - 10 * 60 * 1.0) / 600;
                    }
                    score += 2 * sc_maxfdp + 1 * sc_rest;
                }
                item.Score = score / item.FDPs.Count;
            }
        }

        List<RosterFDPItem> deepCopy(List<RosterFDPItem> items)
        {
            var result = new List<RosterFDPItem>();
            foreach (var x in items)
            {
                var newItem = JsonConvert.DeserializeObject<RosterFDPItem>(JsonConvert.SerializeObject(x));
                result.Add(newItem);
            }
            return result;
        }


        public async Task<object> RosterValidate(List<RosterColumn> data, DateTime dateStart, DateTime dateEnd)
        {
            var result = new List<RosterError>();
            foreach (var x in data)
            {
                var duplicateFlights = (from z in x.Flights
                                        group z by z.FlightId into grp
                                        where grp.Count() > 1
                                        select grp).Select(q => q.Key).ToList();
                if (duplicateFlights.Count > 0)
                {
                    result.Add(new RosterError()
                    {
                        CrewId = x.CrewId,
                        Message = "Duplicated Flights Found",
                        Flights = duplicateFlights,
                    });
                }

                foreach (var f in x.Flights)
                {
                    var overlaped = x.Flights.Where(q => q.FlightId != f.FlightId && ((q.STD >= f.STD && q.STD <= f.STA) || (q.STA >= f.STD && q.STA <= f.STA))).FirstOrDefault();
                    if (overlaped != null)
                    {
                        result.Add(new RosterError()
                        {
                            CrewId = x.CrewId,
                            Message = "Overlapped Flights Found",
                            Flight = f.FlightId,
                            Flights = new List<int>() { overlaped.FlightId },
                        });
                        break;
                    }
                }

            }

            if (result.Count == 0)
                return null;
            return null;
            return result;

        }


        public async Task<object> RosterFunctionDuty(List<DutyDto> data, DateTime dateStart, DateTime dateEnd)
        {
            data = data.Where(q => q.Id < 0).ToList();
            List<FDP> entities = new List<FDP>();
            foreach (var x in data)
            {
                var duty = new FDP()
                {
                    DutyType = x.Type,
                    CrewId = x.CrewId,
                    DateStart = x.Start,
                    DateEnd = x.End,
                    GUID = Guid.NewGuid(),
                    IsTemplate = false,
                    UPD = 1,
                    LocationId = x.LocationId,
                    JobGroupId = x.GroupId,
                    Remark = x.Remark,
                };
                entities.Add(duty);
                this.context.FDPs.Add(duty);
            }

            var saveResult = await this.context.SaveAsync();
            //var saveResult = new CustomActionResult(HttpStatusCode.NotAcceptable, null);
            if (saveResult.Code == HttpStatusCode.OK)
                return entities;
            else
                return null;
        }
        public async Task<object> RosterGetTempFDPs(List<RosterColumn> data, DateTime dateStart, DateTime dateEnd, int? crewId = null, int? prepost = 1, int? year = null, int? month = null)
        {



            try
            {

                var _crew_id = data.Count > 0 ? data.First().CrewId : (int)crewId;
                var crewIds = data.Count > 0 ? data.Select(q => q.CrewId).ToList() : new List<int>() { _crew_id };
                var crews = await this.context.ViewCrews.Where(q => crewIds.Contains(q.Id)).ToListAsync();
                var flights = new List<ViewLegTime>();
                var fdps = new List<RosterFDP>();
                if (data.Count > 0)
                {
                    Stopwatch stopwatch = new Stopwatch();

                    // Begin timing.
                    stopwatch.Start();
                    var MaxFDPTable = getMaxFDPTable(); //await this.context.FDPMaxDailies.ToListAsync();



                    var flightIds = new List<int>();

                    List<FDP> overlapedFDPs = new List<FDP>();
                    foreach (var x in data)
                    {
                        var _fids = x.Flights.Select(q => q.FlightId).ToList();
                        var fstd = x.Flights.First().STD;
                        var lsta = ((DateTime)x.Flights.Last().STA);
                        var lrest = lsta.AddHours(10);


                        flightIds = flightIds.Concat(x.Flights.Select(q => q.FlightId)).ToList();
                    }

                    flightIds = flightIds.Distinct().ToList();

                    //var flights = await this.context.ViewFlightInformations.Where(q => flightIds.Contains(q.ID)).OrderBy(q => q.STD).ToListAsync();

                    flights = await this.context.ViewLegTimes.Where(q => flightIds.Contains(q.ID)).OrderBy(q => q.STD).ToListAsync();



                    foreach (var x in data)
                    {
                        var crew = crews.First(q => q.Id == x.CrewId);
                        x.Flights = x.Flights.OrderBy(q => q.STD).ToList();
                        var xFlightIds = x.Flights.Select(q => q.FlightId);
                        // x.ViewFlights = flights.Where(q => xFlightIds.Contains(q.ID)).OrderBy(q => q.STD).ToList();
                        x.ViewLegs = flights.Where(q => xFlightIds.Contains(q.ID)).OrderBy(q => q.STD).ToList();




                        var grp = 1;
                        var subgrp = 100;
                        for (int i = 0; i < x.Flights.Count; i++)
                        {
                            var flt = x.Flights[i];
                            //var flight = x.ViewFlights.First(q => q.ID == flt.FlightId);
                            var flight = x.ViewLegs.First(q => q.ID == flt.FlightId);
                            flt.STD = flight.STD;
                            flt.STA = flight.STA;
                            if (i == x.Flights.Count - 1)
                            {
                                flt.DiffToNext = 0;
                                flt.Group = grp;
                            }
                            else
                            {
                                var nextFlt = x.Flights[i + 1];
                                //var nextFlight = x.ViewFlights.First(q => q.ID == nextFlt.FlightId);
                                var nextFlight = x.ViewLegs.First(q => q.ID == nextFlt.FlightId);
                                flt.DiffToNext = ((DateTime)nextFlight.STD - (DateTime)flight.STA).TotalMinutes;
                                var rest = flight.ToAirport == crew.BaseAirportId ? 12 * 60 : 10 * 60;
                                flt.Group = grp;
                                var groupLegs = x.Flights.Where(q => q.Group == grp).Count();
                                if (flt.DiffToNext - 30 - 60 >= rest || groupLegs == 10)
                                {
                                    grp++;
                                }
                                else if (flt.DiffToNext - 30 - 60 >= 3 * 60)
                                {
                                    //flt.SubGroup = subgrp;
                                    // nextFlt.SubGroup = subgrp;
                                    // subgrp++;
                                    flt.SubGroup = -1;
                                    //nextFlt.SubGroup = -1;
                                }

                            }


                        }



                    }
                    var idCounter = -1;

                    Dictionary<string, List<int>> fdpsCrews = new Dictionary<string, List<int>>();
                    foreach (var row in data)
                    {
                        var grps = (from x in row.Flights
                                    group x by x.Group into g
                                    select g).ToList();
                        var normalGroups = (from x in grps
                                            where x.Where(q => q.SubGroup != null).Count() == 0
                                            select x).ToList();
                        var anormalGroups = (from x in grps
                                             where x.Where(q => q.SubGroup != null).Count() > 0
                                             select x).ToList();
                        ////////Normal Groups
                        foreach (var g in normalGroups)
                        {
                            var fdpkey = getRosterFDPKey(g.ToList());
                            var fdp = fdps.FirstOrDefault(q => q.Key == fdpkey);
                            if (fdp == null)
                            {
                                fdp = new RosterFDP()
                                {
                                    Items = new List<RosterFDPItem>(),
                                    Key = fdpkey,
                                    CrewId = null,
                                    Id = idCounter,
                                };
                                foreach (var item in g)
                                {
                                    fdp.Items.Add(new RosterFDPItem()
                                    {
                                        DH = item.DH,
                                        Flight = flights.First(q => q.ID == item.FlightId),
                                        IsSector = !item.DH,
                                        PositionId = item.PositionId,
                                        RosterPosition = item.RosterPosition,
                                        SplitDuty = false,
                                    });
                                }
                                //fdp.MaxFDP = 0;
                                //fdp.MaxFDPExtended = fdp.MaxFDP;
                                fdps.Add(fdp);
                                setMaxFDP(fdp, MaxFDPTable);
                                idCounter--;
                            }

                            List<int> _value = null;
                            if (fdpsCrews.TryGetValue(fdpkey, out _value))
                                _value.Add(row.CrewId);
                            else
                                fdpsCrews.Add(fdpkey, new List<int>() { row.CrewId });


                        }
                        ////////////ANormal Groups////////////////////
                        List<List<RosterFDPItem>> anormalFlights = new List<List<RosterFDPItem>>();
                        foreach (var ang in anormalGroups)
                        {
                            var list = new List<RosterFDPItem>();
                            var ordered = ang.OrderBy(q => q.STD).ToList();
                            foreach (var x in ordered)
                            {
                                list.Add(new RosterFDPItem()
                                {
                                    DH = x.DH,
                                    Flight = flights.First(q => q.ID == x.FlightId),
                                    IsSector = !x.DH,
                                    PositionId = x.PositionId,
                                    RosterPosition = x.RosterPosition,
                                    SplitDuty = false,
                                });
                                if (x.SubGroup != null)
                                {
                                    anormalFlights.Add(list.ToList());
                                    list = new List<RosterFDPItem>();
                                }

                            }
                            anormalFlights.Add(list.ToList());
                        }
                        ////////////////////////////////////////////
                        if (anormalFlights.Count > 0)
                        {
                            presult = new List<string>();
                            var ns = new List<string>();
                            for (int i = 0; i < anormalFlights.Count; i++)
                                ns.Add(i.ToString());
                            var grpStr = string.Join(" ", ns);
                            build(1, grpStr, grpStr.Length);

                            List<ANormalFDPs> anormalFDPs = new List<ANormalFDPs>();
                            foreach (var x in presult)
                            {
                                var anf = new ANormalFDPs() { FDPs = new List<RosterFDP>(), Key = x, Score = 0 };
                                List<RosterFDP> tempFDPs = new List<RosterFDP>();
                                var prts = x.Split('*').ToList();
                                foreach (var prt in prts)
                                {
                                    var tfdp = new RosterFDP() { Items = new List<RosterFDPItem>() };
                                    var nos = prt.Split(' ').Select(q => Convert.ToInt32(q)).ToList();
                                    nos.ForEach(q => tfdp.Items = tfdp.Items.Concat(deepCopy(anormalFlights[q])).ToList());
                                    setSplitDuty(tfdp);
                                    setMaxFDP(tfdp, MaxFDPTable);
                                    anf.FDPs.Add(tfdp);

                                }
                                anormalFDPs.Add(anf);
                            }
                            setScore(anormalFDPs);

                            var winner = anormalFDPs.OrderByDescending(q => q.Score).First();
                            foreach (var x in winner.FDPs)
                            {
                                var fdpkey = getRosterFDPKey(x.Items);
                                x.Key = fdpkey;
                                var fdp = fdps.FirstOrDefault(q => q.Key == fdpkey);
                                if (fdp == null)
                                {

                                    fdps.Add(x);

                                }

                                List<int> _value = null;
                                if (fdpsCrews.TryGetValue(fdpkey, out _value))
                                    _value.Add(row.CrewId);
                                else
                                    fdpsCrews.Add(fdpkey, new List<int>() { row.CrewId });

                            }

                        }


                        ////////////////////////////

                    }

                    stopwatch.Stop();
                    var elapesd = stopwatch.Elapsed;
                }



                //q.DutyType==1165 &&


                if (prepost == 1)
                {
                    //var _preDuty = await this.context.ViewFDPRests.OrderByDescending(q => q.DutyStart).Where(q => q.CrewId == _crew_id && q.DutyStartLocal < dateStart).FirstOrDefaultAsync();
                    //var _postDuty = await this.context.ViewFDPRests.OrderBy(q => q.DutyStart).Where(q => q.CrewId == _crew_id && q.DutyStartLocal > dateEnd).FirstOrDefaultAsync();
                    //List<ViewLegTime> _preflights = null;
                    //List<ViewLegTime> _postflights = null;
                    //object preDuty = null;
                    //object postDuty = null;
                    //if (_preDuty != null)
                    //{
                    //    if (_preDuty.DutyType == 1165)
                    //        _preflights = await (from x in this.context.ViewLegTimes
                    //                             join y in this.context.FDPItems on x.ID equals y.FlightId
                    //                             where y.FDPId == _preDuty.Id
                    //                             orderby x.STD
                    //                             select x).ToListAsync();
                    //    preDuty = new
                    //    {
                    //        dutyType = _preDuty.DutyType,
                    //        dutyTypeTitle = _preDuty.DutyTypeTitle,
                    //        duty = _preDuty,
                    //        flights = _preflights,
                    //        isPrePost = true,
                    //        type = 0,
                    //        LastLocationId = _preDuty.DutyType == 1165 ? _preflights.Last().ToAirport : crews.First().LastLocationId,
                    //        LastLocation = _preDuty.DutyType == 1165 ? _preflights.Last().ToAirportIATA : crews.First().LastLocation,
                    //        FirstLocationId = _preDuty.DutyType == 1165 ? _preflights.First().FromAirport : crews.First().LastLocationId,
                    //        FirstLocation = _preDuty.DutyType == 1165 ? _preflights.First().FromAirportIATA : crews.First().LastLocation,
                    //        DutyStart = _preDuty.DutyStart,
                    //        DutyStartLocal = _preDuty.DutyStartLocal,

                    //    };


                    //}
                    //if (_postDuty != null)
                    //{
                    //    if (_postDuty.DutyType == 1165)
                    //        _postflights = await (from x in this.context.ViewLegTimes
                    //                              join y in this.context.FDPItems on x.ID equals y.FlightId
                    //                              where y.FDPId == _postDuty.Id
                    //                              orderby x.STD
                    //                              select x).ToListAsync();
                    //    postDuty = new
                    //    {
                    //        dutyType = _postDuty.DutyType,
                    //        dutyTypeTitle = _postDuty.DutyTypeTitle,
                    //        duty = _postDuty,
                    //        flights = _postflights,
                    //        isPrePost = true,
                    //        type = 1,
                    //        LastLocationId = _postDuty.DutyType == 1165 ? _postflights.Last().ToAirport : crews.First().LastLocationId,
                    //        LastLocation = _postDuty.DutyType == 1165 ? _postflights.Last().ToAirportIATA : crews.First().LastLocation,
                    //        FirstLocationId = _postDuty.DutyType == 1165 ? _postflights.First().FromAirport : crews.First().LastLocationId,
                    //        FirstLocation = _postDuty.DutyType == 1165 ? _postflights.First().FromAirportIATA : crews.First().LastLocation,
                    //        DutyStart = _postDuty.DutyStart,
                    //        DutyStartLocal = _postDuty.DutyStartLocal,
                    //    };

                    //}

                    //fdps = fdps.OrderBy(q => q.DutyStart).ToList();
                    //return new { fdps/*, preDuty, postDuty*/ };
                }
                else
                {
                    //fdps = fdps.OrderBy(q => q.DutyStart).ToList();
                    //return new { fdps };
                }

                if (year != null && month != null)
                {
                    var savedDuties = (from x in this.context.ViewFDPRests
                                       where x.CrewId == crewId && ((x.DateStartLocal < dateStart || x.DateStartLocal > dateEnd) || (x.DutyStartLocal < dateStart || x.DutyStartLocal > dateEnd))
                                       && x.DateStartYear == year && x.DateStartMonth == month
                                       select x).ToList();
                    foreach (var x in savedDuties)
                    {
                        fdps.Add(new RosterFDP()
                        {
                            CrewId = crewId,
                            Id = x.Id,
                            IsRestOk = true,
                            Items = new List<RosterFDPItem>(),
                            dutyTypeTitle = x.DutyTypeTitle,
                            dutyType = x.DutyType,
                            dutyStartLocal = x.DutyStartLocal,
                            dutyStart = x.DutyStart,
                            dutyEndLocal = x.DutyEndLocal,
                            RestTo = x.RestUntil,
                            RestToLocal = x.RestUntilLocal,
                            Remark = x.Remark,

                        });
                    }
                }

                fdps = fdps.OrderBy(q => q.DutyStart).ToList();
                return new { fdps/*, preDuty, postDuty*/ };
            }
            catch (Exception ex)
            {
                return null;
            }
            // var flights = await this.context.ViewFlightInformations.Where(q => q.ID == -1).ToListAsync();





            //////////////////////

        }
        public async Task<object> RosterGetPrePostDuties(DateTime dateStart, DateTime dateEnd, int crewId)
        {
            var crews = await this.context.ViewCrews.Where(q => q.Id == crewId).ToListAsync();
            var _preDuty = await this.context.ViewFDPRests.OrderByDescending(q => q.DutyStart).Where(q => q.CrewId == crewId && q.DutyStartLocal < dateStart).FirstOrDefaultAsync();
            var _postDuty = await this.context.ViewFDPRests.OrderBy(q => q.DutyStart).Where(q => q.CrewId == crewId && q.DutyStartLocal > dateEnd).FirstOrDefaultAsync();
            List<ViewLegTime> _preflights = null;
            List<ViewLegTime> _postflights = null;
            object preDuty = null;
            object postDuty = null;
            if (_preDuty != null)
            {
                if (_preDuty.DutyType == 1165)
                    _preflights = await (from x in this.context.ViewLegTimes
                                         join y in this.context.FDPItems on x.ID equals y.FlightId
                                         where y.FDPId == _preDuty.Id
                                         orderby x.STD
                                         select x).ToListAsync();
                preDuty = new
                {
                    dutyType = _preDuty.DutyType,
                    dutyTypeTitle = _preDuty.DutyTypeTitle,
                    duty = _preDuty,
                    flights = _preflights,
                    isPrePost = true,
                    type = 0,
                    LastLocationId = _preDuty.DutyType == 1165 ? _preflights.Last().ToAirport : crews.First().LastLocationId,
                    LastLocation = _preDuty.DutyType == 1165 ? _preflights.Last().ToAirportIATA : crews.First().LastLocation,
                    FirstLocationId = _preDuty.DutyType == 1165 ? _preflights.First().FromAirport : crews.First().LastLocationId,
                    FirstLocation = _preDuty.DutyType == 1165 ? _preflights.First().FromAirportIATA : crews.First().LastLocation,
                    DutyStart = _preDuty.DutyStart,
                    DutyStartLocal = _preDuty.DutyStartLocal,
                    _preDuty.RestUntil,
                    _preDuty.RestUntilLocal,



                };


            }
            if (_postDuty != null)
            {
                if (_postDuty.DutyType == 1165)
                    _postflights = await (from x in this.context.ViewLegTimes
                                          join y in this.context.FDPItems on x.ID equals y.FlightId
                                          where y.FDPId == _postDuty.Id
                                          orderby x.STD
                                          select x).ToListAsync();
                postDuty = new
                {
                    dutyType = _postDuty.DutyType,
                    dutyTypeTitle = _postDuty.DutyTypeTitle,
                    duty = _postDuty,
                    flights = _postflights,
                    isPrePost = true,
                    type = 1,
                    LastLocationId = _postDuty.DutyType == 1165 ? _postflights.Last().ToAirport : crews.First().LastLocationId,
                    LastLocation = _postDuty.DutyType == 1165 ? _postflights.Last().ToAirportIATA : crews.First().LastLocation,
                    FirstLocationId = _postDuty.DutyType == 1165 ? _postflights.First().FromAirport : crews.First().LastLocationId,
                    FirstLocation = _postDuty.DutyType == 1165 ? _postflights.First().FromAirportIATA : crews.First().LastLocation,
                    DutyStart = _postDuty.DutyStart,
                    DutyStartLocal = _postDuty.DutyStartLocal,
                    _postDuty.RestUntil,
                    _postDuty.RestUntilLocal,
                };

            }


            return new { preDuty, postDuty };
        }
        public async Task<object> RosterFunction(RosterMethodDto obj, DateTime dateStart, DateTime dateEnd)
        {
            var data = obj.rosterColumns;
            var duties = obj.rosterDuties;

            var deletedFDPIds = await this.context.ViewFDPItems.Where(q => q.DepartureLocal >= dateStart && q.DepartureLocal <= dateEnd).Select(q => q.FDPId).ToListAsync();
            var deletedFDPS = await this.context.FDPs.Where(q => q.DutyType == 1165 && deletedFDPIds.Contains(q.Id)).ToListAsync();
            this.context.FDPs.RemoveRange(deletedFDPS);


            if (data.Count == 0)
            {
                var _XsaveResult = await this.context.SaveAsync();
                return new List<ViewFDP>();
            }


            /*
            build(1, "1 2 3 4 5 6", 11);

            var numbers = new List<int> { 1, 2, 3, 4  };
            var groups = numbers.GroupConsecutive();

            List<int> seq = new List<int>() { 1, 2, 3, 4 };
            var _str = "";
            var _strs = new List<string>();
            foreach (var permu in Permutate(seq, seq.Count))
            {
                foreach (var i in permu)
                    _str+=(i.ToString() + " ");
                _strs.Add(_str);
                _str="";
            }
            */

            //try
            //{

            var MaxFDPTable = getMaxFDPTable(); //await this.context.FDPMaxDailies.ToListAsync();

            // var xxx = new List<RosterFlight>();
            //xxx.Add(data.First().Flights[0]);
            //xxx.Add(data.First().Flights[1]);

            //data.First().Flights = xxx.ToList();

            var flightIds = new List<int>();
            var crewIds = data.Select(q => q.CrewId).ToList();
            var crews = await this.context.ViewCrews.Where(q => crewIds.Contains(q.Id)).ToListAsync();
            List<FDP> overlapedFDPs = new List<FDP>();
            foreach (var x in data)
            {
                x.Flights = x.Flights.OrderBy(q => q.STD).ToList();
                var _fids = x.Flights.Select(q => q.FlightId).ToList();
                var fstd = x.Flights.First().STD;
                var lsta = ((DateTime)x.Flights.Last().STA);
                var lrest = lsta.AddHours(10);
                //var overlaped = await this.context.ViewFDPs.Where(q => q.CrewId == x.CrewId && fstd >= q.RestFrom && fstd <= q.RestUntil).Select(q => q.Id).ToListAsync();
                var overlaped = await (from z in this.context.ViewFDPs
                                       join f in this.context.FDPs on z.Id equals f.Id
                                       where z.CrewId == x.CrewId && fstd >= z.RestFrom && fstd <= z.RestUntil && z.DutyType == 1165
                                       select f).FirstOrDefaultAsync();
                if (overlaped != null)
                {
                    overlapedFDPs.Add(overlaped);
                    var overlapedFDPItems = await this.context.ViewFDPItems.Where(q => q.FDPId == overlaped.Id).OrderBy(q => q.STD).ToListAsync();
                    var newRosterFlights = overlapedFDPItems.Where(q => !_fids.Contains((int)q.FlightId)).OrderBy(q => q.STD).Select(q => new RosterFlight()
                    {
                        DH = q.IsPositioning == true ? true : false,
                        FlightId = (int)q.FlightId,
                        PositionId = (int)q.PositionId,
                        RosterPosition = (int)q.RosterPositionId,
                        STD = q.STD,
                        STA = q.STA,

                    }).ToList();
                    x.Flights = newRosterFlights.Concat(x.Flights).ToList();


                }


                var overlapedlast = await (from z in this.context.ViewFDPs
                                           join f in this.context.FDPs on z.Id equals f.Id
                                           where z.CrewId == x.CrewId && z.DutyStart >= lsta && z.DutyStart <= lrest && z.DutyType == 1165
                                           select f).FirstOrDefaultAsync();
                if (overlapedlast != null)
                {
                    overlapedFDPs.Add(overlapedlast);
                    var overlapedFDPItems = await this.context.ViewFDPItems.Where(q => q.FDPId == overlapedlast.Id).OrderBy(q => q.STD).ToListAsync();
                    var newRosterFlights = overlapedFDPItems.Where(q => !_fids.Contains((int)q.FlightId)).OrderBy(q => q.STD).Select(q => new RosterFlight()
                    {
                        DH = q.IsPositioning == true ? true : false,
                        FlightId = (int)q.FlightId,
                        PositionId = (int)q.PositionId,
                        RosterPosition = (int)q.RosterPositionId,
                        STD = q.STD,
                        STA = q.STA

                    }).ToList();
                    x.Flights = x.Flights.Concat(newRosterFlights).ToList();


                }

                flightIds = flightIds.Concat(x.Flights.Select(q => q.FlightId)).ToList();
            }
            this.context.FDPs.RemoveRange(overlapedFDPs);
            flightIds = flightIds.Distinct().ToList();

            //var flights = await this.context.ViewFlightInformations.Where(q => flightIds.Contains(q.ID)).OrderBy(q => q.STD).ToListAsync();
            var flights = await this.context.ViewLegTimes.Where(q => flightIds.Contains(q.ID)).OrderBy(q => q.STD).ToListAsync();



            foreach (var x in data)
            {
                var crew = crews.First(q => q.Id == x.CrewId);
                var xFlightIds = x.Flights.Select(q => q.FlightId);
                //x.ViewFlights = flights.Where(q => xFlightIds.Contains(q.ID)).OrderBy(q => q.STD).ToList();
                x.ViewLegs = flights.Where(q => xFlightIds.Contains(q.ID)).OrderBy(q => q.STD).ToList();




                var grp = 1;
                var subgrp = 100;
                for (int i = 0; i < x.Flights.Count; i++)
                {
                    var flt = x.Flights[i];
                    //var flight = x.ViewFlights.First(q => q.ID == flt.FlightId);
                    var flight = x.ViewLegs.First(q => q.ID == flt.FlightId);
                    flt.STD = flight.STD;
                    flt.STA = flight.STA;
                    if (i == x.Flights.Count - 1)
                    {
                        flt.DiffToNext = 0;
                        flt.Group = grp;
                    }
                    else
                    {
                        var nextFlt = x.Flights[i + 1];
                        //var nextFlight = x.ViewFlights.First(q => q.ID == nextFlt.FlightId);
                        var nextFlight = x.ViewLegs.First(q => q.ID == nextFlt.FlightId);
                        flt.DiffToNext = ((DateTime)nextFlight.STD - (DateTime)flight.STA).TotalMinutes;
                        var rest = flight.ToAirport == crew.BaseAirportId ? 12 * 60 : 10 * 60;
                        flt.Group = grp;
                        var groupLegs = x.Flights.Where(q => q.Group == grp).Count();
                        if (flt.DiffToNext - 30 - 60 >= rest || groupLegs == 10)
                        {
                            grp++;
                        }
                        else if (flt.DiffToNext - 30 - 60 >= 3 * 60)
                        {
                            //flt.SubGroup = subgrp;
                            // nextFlt.SubGroup = subgrp;
                            // subgrp++;
                            flt.SubGroup = -1;
                            //nextFlt.SubGroup = -1;
                        }

                    }


                }

                //var fdpkey = getRosterFDPKey(x.Flights);
                //var fdp = fdps.FirstOrDefault(q => q.Key == fdpkey);
                //if (fdp == null)
                //{
                //    fdp = new RosterFDP()
                //    {
                //        Items = new List<RosterFDPItem>(),
                //        Key = fdpkey,
                //        CrewId = null,
                //        Id = idCounter,
                //    };
                //    fdps.Add(fdp);
                //    idCounter--;
                //}

            }
            var idCounter = -1;
            var fdps = new List<RosterFDP>();
            Dictionary<string, List<int>> fdpsCrews = new Dictionary<string, List<int>>();
            foreach (var row in data)
            {
                var grps = (from x in row.Flights
                            group x by x.Group into g
                            select g).ToList();
                var normalGroups = (from x in grps
                                    where x.Where(q => q.SubGroup != null).Count() == 0
                                    select x).ToList();
                var anormalGroups = (from x in grps
                                     where x.Where(q => q.SubGroup != null).Count() > 0
                                     select x).ToList();
                ////////Normal Groups
                foreach (var g in normalGroups)
                {
                    var fdpkey = getRosterFDPKey(g.ToList());
                    var fdp = fdps.FirstOrDefault(q => q.Key == fdpkey);
                    if (fdp == null)
                    {
                        fdp = new RosterFDP()
                        {
                            Items = new List<RosterFDPItem>(),
                            Key = fdpkey,
                            CrewId = null,
                            Id = idCounter,
                        };
                        foreach (var item in g)
                        {
                            fdp.Items.Add(new RosterFDPItem()
                            {
                                DH = item.DH,
                                Flight = flights.First(q => q.ID == item.FlightId),
                                IsSector = !item.DH,
                                PositionId = item.PositionId,
                                RosterPosition = item.RosterPosition,
                                SplitDuty = false,
                            });
                        }
                        //fdp.MaxFDP = 0;
                        //fdp.MaxFDPExtended = fdp.MaxFDP;
                        fdps.Add(fdp);
                        setMaxFDP(fdp, MaxFDPTable);
                        idCounter--;
                    }

                    List<int> _value = null;
                    if (fdpsCrews.TryGetValue(fdpkey, out _value))
                        _value.Add(row.CrewId);
                    else
                        fdpsCrews.Add(fdpkey, new List<int>() { row.CrewId });


                }
                ////////////ANormal Groups////////////////////
                List<List<RosterFDPItem>> anormalFlights = new List<List<RosterFDPItem>>();
                foreach (var ang in anormalGroups)
                {
                    var list = new List<RosterFDPItem>();
                    var ordered = ang.OrderBy(q => q.STD).ToList();
                    foreach (var x in ordered)
                    {
                        list.Add(new RosterFDPItem()
                        {
                            DH = x.DH,
                            Flight = flights.First(q => q.ID == x.FlightId),
                            IsSector = !x.DH,
                            PositionId = x.PositionId,
                            RosterPosition = x.RosterPosition,
                            SplitDuty = false,
                        });
                        if (x.SubGroup != null)
                        {
                            anormalFlights.Add(list.ToList());
                            list = new List<RosterFDPItem>();
                        }

                    }
                    anormalFlights.Add(list.ToList());
                }
                ////////////////////////////////////////////
                if (anormalFlights.Count > 0)
                {
                    presult = new List<string>();
                    var ns = new List<string>();
                    for (int i = 0; i < anormalFlights.Count; i++)
                        ns.Add(i.ToString());
                    var grpStr = string.Join(" ", ns);
                    build(1, grpStr, grpStr.Length);

                    List<ANormalFDPs> anormalFDPs = new List<ANormalFDPs>();
                    foreach (var x in presult)
                    {
                        var anf = new ANormalFDPs() { FDPs = new List<RosterFDP>(), Key = x, Score = 0 };
                        List<RosterFDP> tempFDPs = new List<RosterFDP>();
                        var prts = x.Split('*').ToList();
                        foreach (var prt in prts)
                        {
                            var tfdp = new RosterFDP() { Items = new List<RosterFDPItem>() };
                            var nos = prt.Split(' ').Select(q => Convert.ToInt32(q)).ToList();
                            nos.ForEach(q => tfdp.Items = tfdp.Items.Concat(deepCopy(anormalFlights[q])).ToList());
                            setSplitDuty(tfdp);
                            setMaxFDP(tfdp, MaxFDPTable);
                            anf.FDPs.Add(tfdp);

                        }
                        anormalFDPs.Add(anf);
                    }
                    setScore(anormalFDPs);

                    var winner = anormalFDPs.OrderByDescending(q => q.Score).First();
                    foreach (var x in winner.FDPs)
                    {
                        var fdpkey = getRosterFDPKey(x.Items);
                        x.Key = fdpkey;
                        var fdp = fdps.FirstOrDefault(q => q.Key == fdpkey);
                        if (fdp == null)
                        {

                            fdps.Add(x);

                        }

                        List<int> _value = null;
                        if (fdpsCrews.TryGetValue(fdpkey, out _value))
                            _value.Add(row.CrewId);
                        else
                            fdpsCrews.Add(fdpkey, new List<int>() { row.CrewId });

                    }

                }


                ////////////////////////////

            }


            List<RosterFDPLight> rosterAssignedFDPs = new List<RosterFDPLight>();

            List<FDP> outFDPs = new List<FDP>();
            foreach (var _fdp in fdps)
            {
                var fdp = new FDP()
                {
                    Key = _fdp.Key,
                    IsTemplate = true,
                    DutyType = 1165,
                    FirstFlightId = _fdp.Items.First().Flight.ID,
                    LastFlightId = _fdp.Items.Last().Flight.ID,
                    GUID = Guid.NewGuid(),
                    IsMain = true,
                };
                fdp.FDPItems = new List<FDPItem>();
                foreach (var _fi in _fdp.Items)
                {
                    fdp.FDPItems.Add(new FDPItem()
                    {
                        FlightId = _fi.Flight.ID,
                        IsPositioning = _fi.DH,
                        IsSector = !_fi.DH,
                        SplitDuty = _fi.SplitDuty,
                        SplitDutyPairId = _fi.SplitDutyPairId,

                    });
                }

                outFDPs.Add(fdp);
                this.context.FDPs.Add(fdp);
                ///////////////////////
                //////////////////////
                var acrews = fdpsCrews[_fdp.Key];
                int _cdu = 0;
                foreach (var x in duties)
                {
                    _cdu++;
                    var _duration = (x.End - x.Start).TotalMinutes;
                    var rosterAssigned = new RosterFDPLight()
                    {
                        DutyTypeId = x.Type,
                        IsFDP = false,
                        Remark = x.TypeTitle,
                        CrewId = x.CrewId,
                        Duration = _duration,
                        Duty = (x.Type == 10000 || x.Type == 10001 ? 0 : 0.25) * _duration,
                        DutyEnd = x.End,
                        DutyEndLocal = x.End.AddMinutes(Helper.GetTimeOffset(x.End.Date)),
                        DutyStart = x.Start,
                        DutyStartLocal = x.Start.AddMinutes(Helper.GetTimeOffset(x.Start.Date)),
                        FDPEnd = x.End,
                        FDPEndLocal = x.End.AddMinutes(Helper.GetTimeOffset(x.End.Date)),
                        FirstLocation = x.LocationId.ToString(),
                        FirstLocationId = x.LocationId,
                        Flight = 0,
                        IsOver = false,
                        IsRestOk = true,
                        Key = "DU" + _cdu,
                        LastLocation = x.LocationId.ToString(),
                        LastLocationId = x.LocationId,
                        MaxFDP = 1000,
                        MaxFDPExtended = 1000,
                        OverDuration = 0,
                        ReportingTime = x.Start,
                        ReportingTimeLocal = x.Start.AddMinutes(Helper.GetTimeOffset(x.Start.Date)),
                        RestTo = x.End.AddMinutes(12 * 60),

                    };
                    rosterAssigned.RestToLocal = ((DateTime)rosterAssigned.RestTo).AddMinutes(Helper.GetTimeOffset((DateTime)rosterAssigned.RestTo));
                    rosterAssignedFDPs.Add(rosterAssigned);
                }
                foreach (var ac in acrews)
                {
                    //var acrewRosterFlights = data.Where(q => q.CrewId == ac).First().Flights;
                    var rosterAssigned = new RosterFDPLight()
                    {
                        Remark = _fdp.Remark,
                        CrewId = ac,
                        Duration = _fdp.Duration,
                        Duty = _fdp.Duty,
                        DutyEnd = _fdp.DutyEnd,
                        DutyEndLocal = _fdp.DutyEndLocal,
                        DutyStart = _fdp.DutyStart,
                        DutyStartLocal = _fdp.DutyStartLocal,
                        FDPEnd = _fdp.FDPEnd,
                        FDPEndLocal = _fdp.FDPEndLocal,
                        FirstLocation = _fdp.FirstLocation,
                        FirstLocationId = _fdp.FirstLocationId,
                        Flight = _fdp.Flight,
                        IsOver = _fdp.IsOver,
                        IsRestOk = _fdp.IsRestOk,
                        Key = _fdp.Key,
                        LastLocation = _fdp.LastLocation,
                        LastLocationId = _fdp.LastLocationId,
                        MaxFDP = _fdp.MaxFDP,
                        MaxFDPExtended = _fdp.MaxFDPExtended,
                        OverDuration = _fdp.OverDuration,
                        ReportingTime = _fdp.ReportingTime,
                        ReportingTimeLocal = _fdp.ReportingTimeLocal,
                        RestTo = _fdp.RestTo,
                        RestToLocal = _fdp.RestToLocal
                    };
                    rosterAssignedFDPs.Add(rosterAssigned);

                }
                //////////////////////
                ///////////////////////
            }

            ///// Validation   //////////////////////
            //Dictionary<int, List<FTL>> ftlTable = new Dictionary<int, List<FTL>>();
            var _ccids = crewIds.Select(q => (Nullable<int>)q).ToList();
            var dayOffs = this.context.ViewDayOffRankeds.Where(q => _ccids.Contains(q.CrewId) && q.DutyRank == 1).Select(q => new RosterEvent()
            {
                CrewId = q.CrewId,
                End = q.DateEnd,
                Start = q.DateStart,
            }).ToList();
            var rosterDayOffs = rosterAssignedFDPs.Where(q => q.DutyTypeId == 10000 || q.DutyTypeId == 10001).Select(q => new RosterEvent()
            {
                CrewId = q.CrewId,
                End = q.DutyEnd,
                Start = q.DutyStart,
            }).ToList();
            dayOffs = dayOffs.Concat(rosterDayOffs).ToList();
            var _rerrpDateStart = dateStart.AddHours(-(168 + 24));
            var savedDutiesCrewIds = this.context.FDPs.Where(q => _ccids.Contains(q.CrewId) && q.DutyType != 10000 && q.DutyType != 10001 && q.DateStart <= _rerrpDateStart).Select(q => q.CrewId).Distinct().ToList();
            List<RosterErrorItem> rosterErrors = new List<RosterErrorItem>();
            var assignedGroup = (from x in rosterAssignedFDPs
                                 group x by x.CrewId into grp
                                 select grp).ToList();

            var dutyFlights = new List<ViewDayDutyFlight>();
            //comment
            //(from x in this.context.ViewDayDutyFlights
            // where x.Date >= dateStart && x.Date <= dateEnd && crewIds.Contains(x.CrewId)
            // select x).ToList();



            foreach (var row in assignedGroup)
            {
                List<FTL> ftlTable = new List<FTL>();
                for (var date = dateStart.Date; date <= dateEnd.Date; date = date.AddDays(1))
                {

                    var rdf = dutyFlights.FirstOrDefault(q => q.CrewId == row.Key && q.Date == date);
                    ftlTable.Add(new FTL()
                    {
                        Date = date,
                        D14 = rdf == null ? 0 : rdf.Duty14,
                        D7 = rdf == null ? 0 : rdf.Duty7,
                        D28 = rdf == null ? 0 : rdf.Duty28,
                        F28 = rdf == null ? 0 : rdf.Flight28,
                        FY = rdf == null ? 0 : rdf.FlightYear,
                    });
                }
                var rowFdps = row.OrderBy(q => q.DutyStart).ToList();

                var rowCrew = crews.FirstOrDefault(q => q.Id == row.Key);


                for (int i = 0; i <= rowFdps.Count - 1; i++)
                {
                    var currentRow = rowFdps[i];
                    var rowDate = ((DateTime)currentRow.DutyStartLocal).Date;
                    if (currentRow.DutyTypeId != 10000 && currentRow.DutyTypeId != 10001)
                    {
                        // var _d1 = (DateTime)currentRow.DutyStart;
                        // var _d2 = _d1.AddHours(-168);
                        if (savedDutiesCrewIds.Contains(row.Key))
                        {
                            var dayoff = dayOffs.Where(q => q.CrewId == row.Key && q.End <= currentRow.DutyStart).OrderByDescending(q => q.End).FirstOrDefault();
                            if (dayoff == null || ((DateTime)currentRow.DutyStart - (DateTime)dayoff.End).TotalHours > 168)
                            {
                                rosterErrors.Add(new RosterErrorItem()
                                {
                                    CrewId = row.Key,
                                    Name = crews.FirstOrDefault(q => q.Id == row.Key).ScheduleName,
                                    TypeId = 5,
                                    Remark = currentRow.Remark,

                                });
                            }
                        }

                    }
                    var ftlRows = ftlTable.Where(q => q.Date >= rowDate).ToList();
                    foreach (var f in ftlRows)
                    {
                        f.D7 += (double)currentRow.Duty;
                        f.D14 += (double)currentRow.Duty;
                        f.D28 += (double)currentRow.Duty;
                        if (currentRow.Flight != null)
                        {
                            f.F28 = (double)currentRow.Flight;
                            f.FY = (double)currentRow.Flight;
                        }
                    }
                    ////Check Rest Error

                    //if (i < rowFdps.Count - 1)
                    //{

                    //    var nextrow = rowFdps[i + 1];
                    //    if ((nextrow.DutyStart >= currentRow.DutyStart && nextrow.DutyStart <= currentRow.RestTo) ||
                    //        (nextrow.RestTo >= currentRow.DutyStart && nextrow.RestTo <= currentRow.RestTo) ||
                    //        currentRow.DutyStart >= nextrow.DutyStart && currentRow.RestTo <= nextrow.RestTo
                    //        )
                    //    {
                    //        rosterErrors.Add(new RosterErrorItem()
                    //        {
                    //            CrewId = row.Key,
                    //            Name = crews.FirstOrDefault(q => q.Id == row.Key).ScheduleName,
                    //            TypeId = 1,
                    //            Remark = currentRow.Remark,
                    //            Remark2 = nextrow.Remark,
                    //        });
                    //    }
                    //}

                    ///Check Over Error
                    //if (currentRow.IsOver)
                    //{
                    //    rosterErrors.Add(new RosterErrorItem()
                    //    {
                    //        CrewId = row.Key,
                    //        Name = crews.FirstOrDefault(q => q.Id == row.Key).ScheduleName,
                    //        TypeId = 3,
                    //        Remark = currentRow.Remark,
                    //        Remark2 = "FDP: " + FormatTwoDigits(Convert.ToInt32(Math.Floor((decimal)currentRow.Duty - 30)) / 60) + ":" + FormatTwoDigits(Convert.ToInt32(Math.Floor((decimal)currentRow.Duty - 30)) % 60)
                    //        + " Max FDP: " + FormatTwoDigits(Convert.ToInt32(Math.Floor(currentRow.MaxFDPExtended)) / 60) + ":" + FormatTwoDigits(Convert.ToInt32(Math.Floor(currentRow.MaxFDPExtended)) % 60)
                    //    });
                    //}
                    //Check Location Error
                    //if (i == 0)
                    //{
                    //    if (currentRow.FirstLocationId != rowCrew.LastLocationId)
                    //        rosterErrors.Add(new RosterErrorItem()
                    //        {
                    //            CrewId = row.Key,
                    //            Name = rowCrew.ScheduleName,
                    //            TypeId = 2,
                    //            Remark = currentRow.Remark,
                    //            Remark2 = "Current Crew Location: " + rowCrew.LastLocation + "  Duty Starts at: " + currentRow.FirstLocation,
                    //        });
                    //}
                    //else
                    //if (i < rowFdps.Count - 1)
                    //{
                    //    var nextrow = rowFdps[i + 1];

                    //    if (currentRow.LastLocationId != nextrow.FirstLocationId)
                    //    {
                    //        rosterErrors.Add(new RosterErrorItem()
                    //        {
                    //            CrewId = row.Key,
                    //            Name = rowCrew.ScheduleName,
                    //            TypeId = 2,
                    //            Remark = currentRow.Remark + " ends at (" + currentRow.LastLocation + ")",
                    //            Remark2 = nextrow.Remark + " starts at (" + nextrow.FirstLocation + ")"
                    //        });
                    //    }

                    //}




                }
                ///////////////////////
                //var D7 = ftlTable.FirstOrDefault(q => q.D7 > 60 * 60);
                //var D14 = ftlTable.FirstOrDefault(q => q.D14 > 110 * 60);
                //var D28 = ftlTable.FirstOrDefault(q => q.D28 > 190 * 60);
                //var F28 = ftlTable.FirstOrDefault(q => q.F28 > 100 * 60);
                //var FY = ftlTable.FirstOrDefault(q => q.FY > 1000 * 60);
                //if (D7 != null)
                //{
                //    rosterErrors.Add(new RosterErrorItem()
                //    {
                //        CrewId = row.Key,
                //        Name = rowCrew.ScheduleName,
                //        TypeId = 4,
                //        Remark = D7.Date.ToShortDateString(),
                //        Remark2 = "7-Day Duties: " + FormatTwoDigits(Convert.ToInt32(Math.Floor((decimal)D7.D7)) / 60) + ":" + FormatTwoDigits(Convert.ToInt32(Math.Floor((decimal)D7.D7)) % 60)
                //    });
                //}
                //if (D14 != null)
                //{
                //    rosterErrors.Add(new RosterErrorItem()
                //    {
                //        CrewId = row.Key,
                //        Name = rowCrew.ScheduleName,
                //        TypeId = 4,
                //        Remark = D14.Date.ToShortDateString(),
                //        Remark2 = "14-Day Duties: " + FormatTwoDigits(Convert.ToInt32(Math.Floor((decimal)D14.D14)) / 60) + ":" + FormatTwoDigits(Convert.ToInt32(Math.Floor((decimal)D14.D14)) % 60)
                //    });
                //}
                //if (D28 != null)
                //{
                //    rosterErrors.Add(new RosterErrorItem()
                //    {
                //        CrewId = row.Key,
                //        Name = rowCrew.ScheduleName,
                //        TypeId = 4,
                //        Remark = D28.Date.ToShortDateString(),
                //        Remark2 = "28-Day Duties: " + FormatTwoDigits(Convert.ToInt32(Math.Floor((decimal)D28.D28)) / 60) + ":" + FormatTwoDigits(Convert.ToInt32(Math.Floor((decimal)D28.D28)) % 60)
                //    });
                //}
                //if (F28 != null)
                //{
                //    rosterErrors.Add(new RosterErrorItem()
                //    {
                //        CrewId = row.Key,
                //        Name = rowCrew.ScheduleName,
                //        TypeId = 4,
                //        Remark = F28.Date.ToShortDateString(),
                //        Remark2 = "28-Day Flights: " + FormatTwoDigits(Convert.ToInt32(Math.Floor((decimal)F28.F28)) / 60) + ":" + FormatTwoDigits(Convert.ToInt32(Math.Floor((decimal)F28.F28)) % 60)
                //    });
                //}
                //if (FY != null)
                //{
                //    rosterErrors.Add(new RosterErrorItem()
                //    {
                //        CrewId = row.Key,
                //        Name = rowCrew.ScheduleName,
                //        TypeId = 4,
                //        Remark = FY.Date.ToShortDateString(),
                //        Remark2 = "12-Month Flights: " + FormatTwoDigits(Convert.ToInt32(Math.Floor((decimal)FY.FY)) / 60) + ":" + FormatTwoDigits(Convert.ToInt32(Math.Floor((decimal)FY.FY)) % 60)
                //    });
                //}

                /////////////////////////

            }
            if (rosterErrors.Count > 0)
            {
                return new
                {
                    error = 1,
                    errors = rosterErrors,
                };
            }
            /////////////////////////////////////////

            var saveResult = await this.context.SaveAsync();
            //var saveResult = new CustomActionResult(HttpStatusCode.NotAcceptable, null);
            if (saveResult.Code == HttpStatusCode.OK)
            {
                List<FDP> savedFDPs = new List<FDP>();
                foreach (var ofdp in outFDPs)
                {
                    var acrews = fdpsCrews[ofdp.Key];
                    foreach (var ac in acrews)
                    {
                        var acrewRosterFlights = data.Where(q => q.CrewId == ac).First().Flights;
                        var defaultPositionId = acrewRosterFlights.Where(q => q.FlightId == ofdp.FDPItems.First().FlightId).First().PositionId;
                        var assigned = new FDP()
                        {
                            CrewId = ac,
                            IsTemplate = false,
                            DutyType = ofdp.DutyType,
                            JobGroupId = defaultPositionId,
                            TemplateId = ofdp.Id,
                            FirstFlightId = ofdp.FirstFlightId,
                            LastFlightId = ofdp.LastFlightId,
                            GUID = Guid.NewGuid(),
                            Key = ofdp.Key,

                        };
                        this.context.FDPs.Add(assigned);
                        savedFDPs.Add(assigned);
                        foreach (var ofdpitem in ofdp.FDPItems)
                        {
                            var _rosterflight = acrewRosterFlights.Where(q => q.FlightId == ofdpitem.FlightId).First();
                            this.context.FDPItems.Add(new FDPItem()
                            {
                                FDP = assigned,
                                FlightId = ofdpitem.FlightId,
                                IsOff = ofdpitem.IsOff,
                                IsPositioning = ofdpitem.IsPositioning,
                                IsSector = ofdpitem.IsSector,
                                SplitDuty = ofdpitem.SplitDuty,
                                SplitDutyPairId = ofdpitem.SplitDutyPairId,
                                PositionId = _rosterflight.PositionId,
                                RosterPositionId = _rosterflight.RosterPosition,
                            });

                        }
                    }

                }

                saveResult = await this.context.SaveAsync();
                if (saveResult.Code == HttpStatusCode.OK)
                {
                    var savedIds = savedFDPs.Select(q => q.Id).ToList();
                    var viewfdps = await this.context.ViewFDPRests.Where(q => savedIds.Contains(q.Id)).ToListAsync();
                    return viewfdps;
                }
            }
            return null;
            //}
            //catch (Exception ex)
            //{
            //    return null;
            //}
            // var flights = await this.context.ViewFlightInformations.Where(q => q.ID == -1).ToListAsync();





            //////////////////////

        }

        public async Task<object> RosterDeleteFDPItem(int crewId, List<int?> Ids)
        {
            var query = await (from x in this.context.ViewFDPItem2
                               join y in this.context.FDPs on x.FDPId equals y.Id
                               where x.CrewId == crewId && Ids.Contains(x.FlightId)
                               select y).ToListAsync();
            this.context.FDPs.RemoveRange(query);
            await this.context.SaveChangesAsync();
            return true;
        }

        public async Task<object> RosterFunctionTest(RosterMethodDto obj, DateTime dateStart, DateTime dateEnd)
        {
            var data = obj.rosterColumns;
            var duties = obj.rosterDuties;


            var tzoffset = Helper.GetTimeOffset(dateStart);
            Dictionary<int, List<DateTime?>> crewDates = new Dictionary<int, List<DateTime?>>();
            foreach (var x in data)
            {
                crewDates.Add(x.CrewId, x.Flights.Select(q => (Nullable<DateTime>)((DateTime)q.STD).AddMinutes(tzoffset).Date).Distinct().ToList());
            }

            foreach (var row in crewDates)
            {
                var _deletedFDPIds = await this.context.ViewFDPItem2.Where(q => q.CrewId == row.Key && row.Value.Contains(q.DepartureDay)).Select(q => q.FDPId).ToListAsync();
                var _deletedFDPS = await this.context.FDPs.Where(q => q.DutyType == 1165 && _deletedFDPIds.Contains(q.Id)).ToListAsync();
                var _deletedTemplateIds = _deletedFDPS.Where(q => q.TemplateId != null).Select(q => (int)q.TemplateId).ToList();
                var _deletedTemplates = await this.context.FDPs.Where(q => _deletedTemplateIds.Contains(q.Id)).Distinct().ToListAsync();
                this.context.FDPs.RemoveRange(_deletedFDPS);
                this.context.FDPs.RemoveRange(_deletedTemplates);
            }

            //var deletedFDPIds = await this.context.ViewFDPItems.Where(q => q.DepartureLocal >= dateStart && q.DepartureLocal <= dateEnd).Select(q => q.FDPId).ToListAsync();
            //var deletedFDPS = await this.context.FDPs.Where(q => q.DutyType == 1165 && deletedFDPIds.Contains(q.Id)).ToListAsync();
            //this.context.FDPs.RemoveRange(deletedFDPS);


            if (data.Count == 0)
            {
                var _XsaveResult = await this.context.SaveAsync();
                return new List<ViewFDP>();
            }


            /*
            build(1, "1 2 3 4 5 6", 11);

            var numbers = new List<int> { 1, 2, 3, 4  };
            var groups = numbers.GroupConsecutive();

            List<int> seq = new List<int>() { 1, 2, 3, 4 };
            var _str = "";
            var _strs = new List<string>();
            foreach (var permu in Permutate(seq, seq.Count))
            {
                foreach (var i in permu)
                    _str+=(i.ToString() + " ");
                _strs.Add(_str);
                _str="";
            }
            */

            //try
            //{

            var MaxFDPTable = getMaxFDPTable(); //await this.context.FDPMaxDailies.ToListAsync();

            // var xxx = new List<RosterFlight>();
            //xxx.Add(data.First().Flights[0]);
            //xxx.Add(data.First().Flights[1]);

            //data.First().Flights = xxx.ToList();

            var flightIds = new List<int>();
            var crewIds = data.Select(q => q.CrewId).ToList();
            var crews = await this.context.ViewCrews.Where(q => crewIds.Contains(q.Id)).ToListAsync();
            List<FDP> overlapedFDPs = new List<FDP>();
            foreach (var x in data)
            {
                x.Flights = x.Flights.OrderBy(q => q.STD).ToList();
                var _fids = x.Flights.Select(q => q.FlightId).ToList();
                var fstd = x.Flights.First().STD;
                var lsta = ((DateTime)x.Flights.Last().STA);
                var lrest = lsta.AddHours(10);
                //var overlaped = await this.context.ViewFDPs.Where(q => q.CrewId == x.CrewId && fstd >= q.RestFrom && fstd <= q.RestUntil).Select(q => q.Id).ToListAsync();
                var overlaped = await (from z in this.context.ViewFDPs
                                       join f in this.context.FDPs on z.Id equals f.Id
                                       where z.CrewId == x.CrewId && fstd >= z.RestFrom && fstd <= z.RestUntil && z.DutyType == 1165
                                       select f).FirstOrDefaultAsync();
                if (overlaped != null)
                {
                    overlapedFDPs.Add(overlaped);
                    var overlapedFDPItems = await this.context.ViewFDPItems.Where(q => q.FDPId == overlaped.Id).OrderBy(q => q.STD).ToListAsync();
                    var newRosterFlights = overlapedFDPItems.Where(q => !_fids.Contains((int)q.FlightId)).OrderBy(q => q.STD).Select(q => new RosterFlight()
                    {
                        DH = q.IsPositioning == true ? true : false,
                        FlightId = (int)q.FlightId,
                        PositionId = (int)q.PositionId,
                        RosterPosition = (int)q.RosterPositionId,
                        STD = q.STD,
                        STA = q.STA,

                    }).ToList();
                    x.Flights = newRosterFlights.Concat(x.Flights).ToList();


                }


                var overlapedlast = await (from z in this.context.ViewFDPs
                                           join f in this.context.FDPs on z.Id equals f.Id
                                           where z.CrewId == x.CrewId && z.DutyStart >= lsta && z.DutyStart <= lrest && z.DutyType == 1165
                                           select f).FirstOrDefaultAsync();
                if (overlapedlast != null)
                {
                    overlapedFDPs.Add(overlapedlast);
                    var overlapedFDPItems = await this.context.ViewFDPItems.Where(q => q.FDPId == overlapedlast.Id).OrderBy(q => q.STD).ToListAsync();
                    var newRosterFlights = overlapedFDPItems.Where(q => !_fids.Contains((int)q.FlightId)).OrderBy(q => q.STD).Select(q => new RosterFlight()
                    {
                        DH = q.IsPositioning == true ? true : false,
                        FlightId = (int)q.FlightId,
                        PositionId = (int)q.PositionId,
                        RosterPosition = (int)q.RosterPositionId,
                        STD = q.STD,
                        STA = q.STA

                    }).ToList();
                    x.Flights = x.Flights.Concat(newRosterFlights).ToList();


                }

                flightIds = flightIds.Concat(x.Flights.Select(q => q.FlightId)).ToList();
            }
            this.context.FDPs.RemoveRange(overlapedFDPs);
            flightIds = flightIds.Distinct().ToList();

            //var flights = await this.context.ViewFlightInformations.Where(q => flightIds.Contains(q.ID)).OrderBy(q => q.STD).ToListAsync();
            var flights = await this.context.ViewLegTimes.Where(q => flightIds.Contains(q.ID)).OrderBy(q => q.STD).ToListAsync();



            foreach (var x in data)
            {
                var crew = crews.First(q => q.Id == x.CrewId);
                var xFlightIds = x.Flights.Select(q => q.FlightId);
                //x.ViewFlights = flights.Where(q => xFlightIds.Contains(q.ID)).OrderBy(q => q.STD).ToList();
                x.ViewLegs = flights.Where(q => xFlightIds.Contains(q.ID)).OrderBy(q => q.STD).ToList();




                var grp = 1;
                var subgrp = 100;
                for (int i = 0; i < x.Flights.Count; i++)
                {
                    var flt = x.Flights[i];
                    //var flight = x.ViewFlights.First(q => q.ID == flt.FlightId);
                    var flight = x.ViewLegs.First(q => q.ID == flt.FlightId);
                    flt.STD = flight.STD;
                    flt.STA = flight.STA;
                    if (i == x.Flights.Count - 1)
                    {
                        flt.DiffToNext = 0;
                        flt.Group = grp;
                    }
                    else
                    {
                        var nextFlt = x.Flights[i + 1];
                        //var nextFlight = x.ViewFlights.First(q => q.ID == nextFlt.FlightId);
                        var nextFlight = x.ViewLegs.First(q => q.ID == nextFlt.FlightId);
                        flt.DiffToNext = ((DateTime)nextFlight.STD - (DateTime)flight.STA).TotalMinutes;
                        var rest = flight.ToAirport == crew.BaseAirportId ? 12 * 60 : 10 * 60;
                        flt.Group = grp;
                        var groupLegs = x.Flights.Where(q => q.Group == grp).Count();
                        if (flt.DiffToNext - 30 - 60 >= rest || groupLegs == 10)
                        {
                            grp++;
                        }
                        else if (flt.DiffToNext - 30 - 60 >= 3 * 60)
                        {
                            //flt.SubGroup = subgrp;
                            // nextFlt.SubGroup = subgrp;
                            // subgrp++;
                            flt.SubGroup = -1;
                            //nextFlt.SubGroup = -1;
                        }

                    }


                }

                //var fdpkey = getRosterFDPKey(x.Flights);
                //var fdp = fdps.FirstOrDefault(q => q.Key == fdpkey);
                //if (fdp == null)
                //{
                //    fdp = new RosterFDP()
                //    {
                //        Items = new List<RosterFDPItem>(),
                //        Key = fdpkey,
                //        CrewId = null,
                //        Id = idCounter,
                //    };
                //    fdps.Add(fdp);
                //    idCounter--;
                //}

            }
            var idCounter = -1;
            var fdps = new List<RosterFDP>();
            Dictionary<string, List<int>> fdpsCrews = new Dictionary<string, List<int>>();
            foreach (var row in data)
            {
                var grps = (from x in row.Flights
                            group x by x.Group into g
                            select g).ToList();
                var normalGroups = (from x in grps
                                    where x.Where(q => q.SubGroup != null).Count() == 0
                                    select x).ToList();
                var anormalGroups = (from x in grps
                                     where x.Where(q => q.SubGroup != null).Count() > 0
                                     select x).ToList();
                ////////Normal Groups
                foreach (var g in normalGroups)
                {
                    var fdpkey = getRosterFDPKey(g.ToList());
                    var fdp = fdps.FirstOrDefault(q => q.Key == fdpkey);
                    if (fdp == null)
                    {
                        fdp = new RosterFDP()
                        {
                            Items = new List<RosterFDPItem>(),
                            Key = fdpkey,
                            CrewId = null,
                            Id = idCounter,
                        };
                        foreach (var item in g)
                        {
                            fdp.Items.Add(new RosterFDPItem()
                            {
                                DH = item.DH,
                                Flight = flights.First(q => q.ID == item.FlightId),
                                IsSector = !item.DH,
                                PositionId = item.PositionId,
                                RosterPosition = item.RosterPosition,
                                SplitDuty = false,
                            });
                        }
                        //fdp.MaxFDP = 0;
                        //fdp.MaxFDPExtended = fdp.MaxFDP;
                        fdps.Add(fdp);
                        setMaxFDP(fdp, MaxFDPTable);
                        idCounter--;
                    }

                    List<int> _value = null;
                    if (fdpsCrews.TryGetValue(fdpkey, out _value))
                        _value.Add(row.CrewId);
                    else
                        fdpsCrews.Add(fdpkey, new List<int>() { row.CrewId });


                }
                ////////////ANormal Groups////////////////////
                List<List<RosterFDPItem>> anormalFlights = new List<List<RosterFDPItem>>();
                foreach (var ang in anormalGroups)
                {
                    var list = new List<RosterFDPItem>();
                    var ordered = ang.OrderBy(q => q.STD).ToList();
                    foreach (var x in ordered)
                    {
                        list.Add(new RosterFDPItem()
                        {
                            DH = x.DH,
                            Flight = flights.First(q => q.ID == x.FlightId),
                            IsSector = !x.DH,
                            PositionId = x.PositionId,
                            RosterPosition = x.RosterPosition,
                            SplitDuty = false,
                        });
                        if (x.SubGroup != null)
                        {
                            anormalFlights.Add(list.ToList());
                            list = new List<RosterFDPItem>();
                        }

                    }
                    anormalFlights.Add(list.ToList());
                }
                ////////////////////////////////////////////
                if (anormalFlights.Count > 0)
                {
                    presult = new List<string>();
                    var ns = new List<string>();
                    for (int i = 0; i < anormalFlights.Count; i++)
                        ns.Add(i.ToString());
                    var grpStr = string.Join(" ", ns);
                    build(1, grpStr, grpStr.Length);

                    List<ANormalFDPs> anormalFDPs = new List<ANormalFDPs>();
                    foreach (var x in presult)
                    {
                        var anf = new ANormalFDPs() { FDPs = new List<RosterFDP>(), Key = x, Score = 0 };
                        List<RosterFDP> tempFDPs = new List<RosterFDP>();
                        var prts = x.Split('*').ToList();
                        foreach (var prt in prts)
                        {
                            var tfdp = new RosterFDP() { Items = new List<RosterFDPItem>() };
                            var nos = prt.Split(' ').Select(q => Convert.ToInt32(q)).ToList();
                            nos.ForEach(q => tfdp.Items = tfdp.Items.Concat(deepCopy(anormalFlights[q])).ToList());
                            setSplitDuty(tfdp);
                            setMaxFDP(tfdp, MaxFDPTable);
                            anf.FDPs.Add(tfdp);

                        }
                        anormalFDPs.Add(anf);
                    }
                    setScore(anormalFDPs);

                    var winner = anormalFDPs.OrderByDescending(q => q.Score).First();
                    foreach (var x in winner.FDPs)
                    {
                        var fdpkey = getRosterFDPKey(x.Items);
                        x.Key = fdpkey;
                        var fdp = fdps.FirstOrDefault(q => q.Key == fdpkey);
                        if (fdp == null)
                        {

                            fdps.Add(x);

                        }

                        List<int> _value = null;
                        if (fdpsCrews.TryGetValue(fdpkey, out _value))
                            _value.Add(row.CrewId);
                        else
                            fdpsCrews.Add(fdpkey, new List<int>() { row.CrewId });

                    }

                }


                ////////////////////////////

            }


            List<RosterFDPLight> rosterAssignedFDPs = new List<RosterFDPLight>();

            List<FDP> outFDPs = new List<FDP>();
            foreach (var _fdp in fdps)
            {
                var fdp = new FDP()
                {
                    Key = _fdp.Key,
                    IsTemplate = true,
                    DutyType = 1165,
                    FirstFlightId = _fdp.Items.First().Flight.ID,
                    LastFlightId = _fdp.Items.Last().Flight.ID,
                    GUID = Guid.NewGuid(),
                    IsMain = true,
                };
                fdp.FDPItems = new List<FDPItem>();
                foreach (var _fi in _fdp.Items)
                {
                    fdp.FDPItems.Add(new FDPItem()
                    {
                        FlightId = _fi.Flight.ID,
                        IsPositioning = _fi.DH,
                        IsSector = !_fi.DH,
                        SplitDuty = _fi.SplitDuty,
                        SplitDutyPairId = _fi.SplitDutyPairId,

                    });
                }

                outFDPs.Add(fdp);
                this.context.FDPs.Add(fdp);
                ///////////////////////
                //////////////////////
                var acrews = fdpsCrews[_fdp.Key];
                int _cdu = 0;
                foreach (var x in duties)
                {
                    _cdu++;
                    var _duration = (x.End - x.Start).TotalMinutes;
                    var rosterAssigned = new RosterFDPLight()
                    {
                        DutyTypeId = x.Type,
                        IsFDP = false,
                        Remark = x.TypeTitle,
                        CrewId = x.CrewId,
                        Duration = _duration,
                        Duty = (x.Type == 10000 || x.Type == 10001 ? 0 : 0.25) * _duration,
                        DutyEnd = x.End,
                        DutyEndLocal = x.End.AddMinutes(Helper.GetTimeOffset(x.End.Date)),
                        DutyStart = x.Start,
                        DutyStartLocal = x.Start.AddMinutes(Helper.GetTimeOffset(x.Start.Date)),
                        FDPEnd = x.End,
                        FDPEndLocal = x.End.AddMinutes(Helper.GetTimeOffset(x.End.Date)),
                        FirstLocation = x.LocationId.ToString(),
                        FirstLocationId = x.LocationId,
                        Flight = 0,
                        IsOver = false,
                        IsRestOk = true,
                        Key = "DU" + _cdu,
                        LastLocation = x.LocationId.ToString(),
                        LastLocationId = x.LocationId,
                        MaxFDP = 1000,
                        MaxFDPExtended = 1000,
                        OverDuration = 0,
                        ReportingTime = x.Start,
                        ReportingTimeLocal = x.Start.AddMinutes(Helper.GetTimeOffset(x.Start.Date)),
                        RestTo = x.End.AddMinutes(12 * 60),

                    };
                    rosterAssigned.RestToLocal = ((DateTime)rosterAssigned.RestTo).AddMinutes(Helper.GetTimeOffset((DateTime)rosterAssigned.RestTo));
                    rosterAssignedFDPs.Add(rosterAssigned);
                }
                foreach (var ac in acrews)
                {
                    //var acrewRosterFlights = data.Where(q => q.CrewId == ac).First().Flights;
                    var rosterAssigned = new RosterFDPLight()
                    {
                        Remark = _fdp.Remark,
                        CrewId = ac,
                        Duration = _fdp.Duration,
                        Duty = _fdp.Duty,
                        DutyEnd = _fdp.DutyEnd,
                        DutyEndLocal = _fdp.DutyEndLocal,
                        DutyStart = _fdp.DutyStart,
                        DutyStartLocal = _fdp.DutyStartLocal,
                        FDPEnd = _fdp.FDPEnd,
                        FDPEndLocal = _fdp.FDPEndLocal,
                        FirstLocation = _fdp.FirstLocation,
                        FirstLocationId = _fdp.FirstLocationId,
                        Flight = _fdp.Flight,
                        IsOver = _fdp.IsOver,
                        IsRestOk = _fdp.IsRestOk,
                        Key = _fdp.Key,
                        LastLocation = _fdp.LastLocation,
                        LastLocationId = _fdp.LastLocationId,
                        MaxFDP = _fdp.MaxFDP,
                        MaxFDPExtended = _fdp.MaxFDPExtended,
                        OverDuration = _fdp.OverDuration,
                        ReportingTime = _fdp.ReportingTime,
                        ReportingTimeLocal = _fdp.ReportingTimeLocal,
                        RestTo = _fdp.RestTo,
                        RestToLocal = _fdp.RestToLocal
                    };
                    rosterAssignedFDPs.Add(rosterAssigned);

                }
                //////////////////////
                ///////////////////////
            }

            ///// Validation   //////////////////////
            //Dictionary<int, List<FTL>> ftlTable = new Dictionary<int, List<FTL>>();
            var _ccids = crewIds.Select(q => (Nullable<int>)q).ToList();
            var dayOffs = this.context.ViewDayOffRankeds.Where(q => _ccids.Contains(q.CrewId) && q.DutyRank == 1).Select(q => new RosterEvent()
            {
                CrewId = q.CrewId,
                End = q.DateEnd,
                Start = q.DateStart,
            }).ToList();
            var rosterDayOffs = rosterAssignedFDPs.Where(q => q.DutyTypeId == 10000 || q.DutyTypeId == 10001).Select(q => new RosterEvent()
            {
                CrewId = q.CrewId,
                End = q.DutyEnd,
                Start = q.DutyStart,
            }).ToList();
            dayOffs = dayOffs.Concat(rosterDayOffs).ToList();
            var _rerrpDateStart = dateStart.AddHours(-(168 + 24));
            var savedDutiesCrewIds = this.context.FDPs.Where(q => _ccids.Contains(q.CrewId) && q.DutyType != 10000 && q.DutyType != 10001 && q.DateStart <= _rerrpDateStart).Select(q => q.CrewId).Distinct().ToList();
            List<RosterErrorItem> rosterErrors = new List<RosterErrorItem>();
            var assignedGroup = (from x in rosterAssignedFDPs
                                 group x by x.CrewId into grp
                                 select grp).ToList();

            var dutyFlights = new List<ViewDayDutyFlight>();
            //comment
            //(from x in this.context.ViewDayDutyFlights
            // where x.Date >= dateStart && x.Date <= dateEnd && crewIds.Contains(x.CrewId)
            // select x).ToList();



            foreach (var row in assignedGroup)
            {
                List<FTL> ftlTable = new List<FTL>();
                for (var date = dateStart.Date; date <= dateEnd.Date; date = date.AddDays(1))
                {

                    var rdf = dutyFlights.FirstOrDefault(q => q.CrewId == row.Key && q.Date == date);
                    ftlTable.Add(new FTL()
                    {
                        Date = date,
                        D14 = rdf == null ? 0 : rdf.Duty14,
                        D7 = rdf == null ? 0 : rdf.Duty7,
                        D28 = rdf == null ? 0 : rdf.Duty28,
                        F28 = rdf == null ? 0 : rdf.Flight28,
                        FY = rdf == null ? 0 : rdf.FlightYear,
                    });
                }
                var rowFdps = row.OrderBy(q => q.DutyStart).ToList();

                var rowCrew = crews.FirstOrDefault(q => q.Id == row.Key);


                for (int i = 0; i <= rowFdps.Count - 1; i++)
                {
                    var currentRow = rowFdps[i];
                    var rowDate = ((DateTime)currentRow.DutyStartLocal).Date;
                    if (currentRow.DutyTypeId != 10000 && currentRow.DutyTypeId != 10001)
                    {
                        // var _d1 = (DateTime)currentRow.DutyStart;
                        // var _d2 = _d1.AddHours(-168);
                        if (savedDutiesCrewIds.Contains(row.Key))
                        {
                            var dayoff = dayOffs.Where(q => q.CrewId == row.Key && q.End <= currentRow.DutyStart).OrderByDescending(q => q.End).FirstOrDefault();
                            if (dayoff == null || ((DateTime)currentRow.DutyStart - (DateTime)dayoff.End).TotalHours > 168)
                            {
                                rosterErrors.Add(new RosterErrorItem()
                                {
                                    CrewId = row.Key,
                                    Name = crews.FirstOrDefault(q => q.Id == row.Key).ScheduleName,
                                    TypeId = 5,
                                    Remark = currentRow.Remark,

                                });
                            }
                        }

                    }
                    var ftlRows = ftlTable.Where(q => q.Date >= rowDate).ToList();
                    foreach (var f in ftlRows)
                    {
                        f.D7 += (double)currentRow.Duty;
                        f.D14 += (double)currentRow.Duty;
                        f.D28 += (double)currentRow.Duty;
                        if (currentRow.Flight != null)
                        {
                            f.F28 = (double)currentRow.Flight;
                            f.FY = (double)currentRow.Flight;
                        }
                    }
                    ////Check Rest Error

                    //if (i < rowFdps.Count - 1)
                    //{

                    //    var nextrow = rowFdps[i + 1];
                    //    if ((nextrow.DutyStart >= currentRow.DutyStart && nextrow.DutyStart <= currentRow.RestTo) ||
                    //        (nextrow.RestTo >= currentRow.DutyStart && nextrow.RestTo <= currentRow.RestTo) ||
                    //        currentRow.DutyStart >= nextrow.DutyStart && currentRow.RestTo <= nextrow.RestTo
                    //        )
                    //    {
                    //        rosterErrors.Add(new RosterErrorItem()
                    //        {
                    //            CrewId = row.Key,
                    //            Name = crews.FirstOrDefault(q => q.Id == row.Key).ScheduleName,
                    //            TypeId = 1,
                    //            Remark = currentRow.Remark,
                    //            Remark2 = nextrow.Remark,
                    //        });
                    //    }
                    //}

                    ///Check Over Error
                    //if (currentRow.IsOver)
                    //{
                    //    rosterErrors.Add(new RosterErrorItem()
                    //    {
                    //        CrewId = row.Key,
                    //        Name = crews.FirstOrDefault(q => q.Id == row.Key).ScheduleName,
                    //        TypeId = 3,
                    //        Remark = currentRow.Remark,
                    //        Remark2 = "FDP: " + FormatTwoDigits(Convert.ToInt32(Math.Floor((decimal)currentRow.Duty - 30)) / 60) + ":" + FormatTwoDigits(Convert.ToInt32(Math.Floor((decimal)currentRow.Duty - 30)) % 60)
                    //        + " Max FDP: " + FormatTwoDigits(Convert.ToInt32(Math.Floor(currentRow.MaxFDPExtended)) / 60) + ":" + FormatTwoDigits(Convert.ToInt32(Math.Floor(currentRow.MaxFDPExtended)) % 60)
                    //    });
                    //}
                    //Check Location Error
                    //if (i == 0)
                    //{
                    //    if (currentRow.FirstLocationId != rowCrew.LastLocationId)
                    //        rosterErrors.Add(new RosterErrorItem()
                    //        {
                    //            CrewId = row.Key,
                    //            Name = rowCrew.ScheduleName,
                    //            TypeId = 2,
                    //            Remark = currentRow.Remark,
                    //            Remark2 = "Current Crew Location: " + rowCrew.LastLocation + "  Duty Starts at: " + currentRow.FirstLocation,
                    //        });
                    //}
                    //else
                    //if (i < rowFdps.Count - 1)
                    //{
                    //    var nextrow = rowFdps[i + 1];

                    //    if (currentRow.LastLocationId != nextrow.FirstLocationId)
                    //    {
                    //        rosterErrors.Add(new RosterErrorItem()
                    //        {
                    //            CrewId = row.Key,
                    //            Name = rowCrew.ScheduleName,
                    //            TypeId = 2,
                    //            Remark = currentRow.Remark + " ends at (" + currentRow.LastLocation + ")",
                    //            Remark2 = nextrow.Remark + " starts at (" + nextrow.FirstLocation + ")"
                    //        });
                    //    }

                    //}




                }
                ///////////////////////
                //var D7 = ftlTable.FirstOrDefault(q => q.D7 > 60 * 60);
                //var D14 = ftlTable.FirstOrDefault(q => q.D14 > 110 * 60);
                //var D28 = ftlTable.FirstOrDefault(q => q.D28 > 190 * 60);
                //var F28 = ftlTable.FirstOrDefault(q => q.F28 > 100 * 60);
                //var FY = ftlTable.FirstOrDefault(q => q.FY > 1000 * 60);
                //if (D7 != null)
                //{
                //    rosterErrors.Add(new RosterErrorItem()
                //    {
                //        CrewId = row.Key,
                //        Name = rowCrew.ScheduleName,
                //        TypeId = 4,
                //        Remark = D7.Date.ToShortDateString(),
                //        Remark2 = "7-Day Duties: " + FormatTwoDigits(Convert.ToInt32(Math.Floor((decimal)D7.D7)) / 60) + ":" + FormatTwoDigits(Convert.ToInt32(Math.Floor((decimal)D7.D7)) % 60)
                //    });
                //}
                //if (D14 != null)
                //{
                //    rosterErrors.Add(new RosterErrorItem()
                //    {
                //        CrewId = row.Key,
                //        Name = rowCrew.ScheduleName,
                //        TypeId = 4,
                //        Remark = D14.Date.ToShortDateString(),
                //        Remark2 = "14-Day Duties: " + FormatTwoDigits(Convert.ToInt32(Math.Floor((decimal)D14.D14)) / 60) + ":" + FormatTwoDigits(Convert.ToInt32(Math.Floor((decimal)D14.D14)) % 60)
                //    });
                //}
                //if (D28 != null)
                //{
                //    rosterErrors.Add(new RosterErrorItem()
                //    {
                //        CrewId = row.Key,
                //        Name = rowCrew.ScheduleName,
                //        TypeId = 4,
                //        Remark = D28.Date.ToShortDateString(),
                //        Remark2 = "28-Day Duties: " + FormatTwoDigits(Convert.ToInt32(Math.Floor((decimal)D28.D28)) / 60) + ":" + FormatTwoDigits(Convert.ToInt32(Math.Floor((decimal)D28.D28)) % 60)
                //    });
                //}
                //if (F28 != null)
                //{
                //    rosterErrors.Add(new RosterErrorItem()
                //    {
                //        CrewId = row.Key,
                //        Name = rowCrew.ScheduleName,
                //        TypeId = 4,
                //        Remark = F28.Date.ToShortDateString(),
                //        Remark2 = "28-Day Flights: " + FormatTwoDigits(Convert.ToInt32(Math.Floor((decimal)F28.F28)) / 60) + ":" + FormatTwoDigits(Convert.ToInt32(Math.Floor((decimal)F28.F28)) % 60)
                //    });
                //}
                //if (FY != null)
                //{
                //    rosterErrors.Add(new RosterErrorItem()
                //    {
                //        CrewId = row.Key,
                //        Name = rowCrew.ScheduleName,
                //        TypeId = 4,
                //        Remark = FY.Date.ToShortDateString(),
                //        Remark2 = "12-Month Flights: " + FormatTwoDigits(Convert.ToInt32(Math.Floor((decimal)FY.FY)) / 60) + ":" + FormatTwoDigits(Convert.ToInt32(Math.Floor((decimal)FY.FY)) % 60)
                //    });
                //}

                /////////////////////////

            }
            //if (rosterErrors.Count > 0)
            //{
            //    return new
            //    {
            //        error = 1,
            //        errors = rosterErrors,
            //    };
            //}
            /////////////////////////////////////////

            var saveResult = await this.context.SaveAsync();
            //var saveResult = new CustomActionResult(HttpStatusCode.NotAcceptable, null);
            if (saveResult.Code == HttpStatusCode.OK)
            {
                List<FDP> savedFDPs = new List<FDP>();
                foreach (var ofdp in outFDPs)
                {
                    var acrews = fdpsCrews[ofdp.Key];
                    foreach (var ac in acrews)
                    {
                        var acrewRosterFlights = data.Where(q => q.CrewId == ac).First().Flights;
                        var defaultPositionId = acrewRosterFlights.Where(q => q.FlightId == ofdp.FDPItems.First().FlightId).First().PositionId;
                        var assigned = new FDP()
                        {
                            CrewId = ac,
                            IsTemplate = false,
                            DutyType = ofdp.DutyType,
                            JobGroupId = defaultPositionId,
                            TemplateId = ofdp.Id,
                            FirstFlightId = ofdp.FirstFlightId,
                            LastFlightId = ofdp.LastFlightId,
                            GUID = Guid.NewGuid(),
                            Key = ofdp.Key,

                        };
                        this.context.FDPs.Add(assigned);
                        savedFDPs.Add(assigned);
                        foreach (var ofdpitem in ofdp.FDPItems)
                        {
                            var _rosterflight = acrewRosterFlights.Where(q => q.FlightId == ofdpitem.FlightId).First();
                            this.context.FDPItems.Add(new FDPItem()
                            {
                                FDP = assigned,
                                FlightId = ofdpitem.FlightId,
                                IsOff = ofdpitem.IsOff,
                                IsPositioning = ofdpitem.IsPositioning,
                                IsSector = ofdpitem.IsSector,
                                SplitDuty = ofdpitem.SplitDuty,
                                SplitDutyPairId = ofdpitem.SplitDutyPairId,
                                PositionId = _rosterflight.PositionId,
                                RosterPositionId = _rosterflight.RosterPosition,
                            });

                        }
                    }

                }

                saveResult = await this.context.SaveAsync();
                if (saveResult.Code == HttpStatusCode.OK)
                {
                    var savedIds = savedFDPs.Select(q => q.Id).ToList();
                    var viewfdps = await this.context.ViewFDPRests.Where(q => savedIds.Contains(q.Id)).ToListAsync();
                    return viewfdps;
                }
            }
            return null;
            //}
            //catch (Exception ex)
            //{
            //    return null;
            //}
            // var flights = await this.context.ViewFlightInformations.Where(q => q.ID == -1).ToListAsync();





            //////////////////////

        }


        public async Task<object> RosterFunctionTotal(RosterMethodDto obj, DateTime dateStart, DateTime dateEnd)
        {
            var data = obj.rosterColumns;
            var duties = obj.rosterDuties;


            var tzoffset = Helper.GetTimeOffset(dateStart);
            Dictionary<int, List<DateTime?>> crewDates = new Dictionary<int, List<DateTime?>>();
            foreach (var x in data)
            {
                crewDates.Add(x.CrewId, x.Flights.Select(q => (Nullable<DateTime>)((DateTime)q.STD).AddMinutes(tzoffset).Date).Distinct().ToList());
            }

            foreach (var row in crewDates)
            {
                var _deletedFDPIds = await this.context.ViewFDPItem2.Where(q => q.CrewId == row.Key && row.Value.Contains(q.DepartureDay)).Select(q => q.FDPId).ToListAsync();
                var _deletedFDPS = await this.context.FDPs.Where(q => q.DutyType == 1165 && _deletedFDPIds.Contains(q.Id)).ToListAsync();
                var _deletedTemplateIds = _deletedFDPS.Where(q => q.TemplateId != null).Select(q => (int)q.TemplateId).ToList();
                var _deletedTemplates = await this.context.FDPs.Where(q => _deletedTemplateIds.Contains(q.Id)).Distinct().ToListAsync();
                this.context.FDPs.RemoveRange(_deletedFDPS);
                this.context.FDPs.RemoveRange(_deletedTemplates);
            }

            //var deletedFDPIds = await this.context.ViewFDPItems.Where(q => q.DepartureLocal >= dateStart && q.DepartureLocal <= dateEnd).Select(q => q.FDPId).ToListAsync();
            //var deletedFDPS = await this.context.FDPs.Where(q => q.DutyType == 1165 && deletedFDPIds.Contains(q.Id)).ToListAsync();
            //this.context.FDPs.RemoveRange(deletedFDPS);


            if (data.Count == 0)
            {
                var _XsaveResult = await this.context.SaveAsync();
                return new List<ViewFDP>();
            }


            /*
            build(1, "1 2 3 4 5 6", 11);

            var numbers = new List<int> { 1, 2, 3, 4  };
            var groups = numbers.GroupConsecutive();

            List<int> seq = new List<int>() { 1, 2, 3, 4 };
            var _str = "";
            var _strs = new List<string>();
            foreach (var permu in Permutate(seq, seq.Count))
            {
                foreach (var i in permu)
                    _str+=(i.ToString() + " ");
                _strs.Add(_str);
                _str="";
            }
            */

            //try
            //{

            var MaxFDPTable = getMaxFDPTable(); //await this.context.FDPMaxDailies.ToListAsync();

            // var xxx = new List<RosterFlight>();
            //xxx.Add(data.First().Flights[0]);
            //xxx.Add(data.First().Flights[1]);

            //data.First().Flights = xxx.ToList();

            var flightIds = new List<int>();
            var crewIds = data.Select(q => q.CrewId).ToList();
            var crews = await this.context.ViewCrews.Where(q => crewIds.Contains(q.Id)).ToListAsync();
            var crewnamesssss = crews.Select(q => q.Name).ToList();
            List<FDP> overlapedFDPs = new List<FDP>();
            foreach (var x in data)
            {
                x.Flights = x.Flights.OrderBy(q => q.STD).ToList();
                var _fids = x.Flights.Select(q => q.FlightId).ToList();
                var fstd = x.Flights.First().STD;
                var lsta = ((DateTime)x.Flights.Last().STA);
                var lrest = lsta.AddHours(10);
                //var overlaped = await this.context.ViewFDPs.Where(q => q.CrewId == x.CrewId && fstd >= q.RestFrom && fstd <= q.RestUntil).Select(q => q.Id).ToListAsync();
                var overlaped = await (from z in this.context.ViewFDPs
                                       join f in this.context.FDPs on z.Id equals f.Id
                                       where z.CrewId == x.CrewId && fstd >= z.RestFrom && fstd <= z.RestUntil && z.DutyType == 1165
                                       select f).FirstOrDefaultAsync();
                if (overlaped != null)
                {
                    overlapedFDPs.Add(overlaped);
                    var overlapedFDPItems = await this.context.ViewFDPItems.Where(q => q.FDPId == overlaped.Id).OrderBy(q => q.STD).ToListAsync();
                    var newRosterFlights = overlapedFDPItems.Where(q => !_fids.Contains((int)q.FlightId)).OrderBy(q => q.STD).Select(q => new RosterFlight()
                    {
                        DH = q.IsPositioning == true ? true : false,
                        FlightId = (int)q.FlightId,
                        PositionId = (int)q.PositionId,
                        RosterPosition = (int)q.RosterPositionId,
                        STD = q.STD,
                        STA = q.STA,

                    }).ToList();
                    x.Flights = newRosterFlights.Concat(x.Flights).ToList();


                }


                var overlapedlast = await (from z in this.context.ViewFDPs
                                           join f in this.context.FDPs on z.Id equals f.Id
                                           where z.CrewId == x.CrewId && z.DutyStart >= lsta && z.DutyStart <= lrest && z.DutyType == 1165
                                           select f).FirstOrDefaultAsync();
                if (overlapedlast != null)
                {
                    overlapedFDPs.Add(overlapedlast);
                    var overlapedFDPItems = await this.context.ViewFDPItems.Where(q => q.FDPId == overlapedlast.Id).OrderBy(q => q.STD).ToListAsync();
                    var newRosterFlights = overlapedFDPItems.Where(q => !_fids.Contains((int)q.FlightId)).OrderBy(q => q.STD).Select(q => new RosterFlight()
                    {
                        DH = q.IsPositioning == true ? true : false,
                        FlightId = (int)q.FlightId,
                        PositionId = (int)q.PositionId,
                        RosterPosition = (int)q.RosterPositionId,
                        STD = q.STD,
                        STA = q.STA

                    }).ToList();
                    x.Flights = x.Flights.Concat(newRosterFlights).ToList();


                }

                flightIds = flightIds.Concat(x.Flights.Select(q => q.FlightId)).ToList();
            }
            this.context.FDPs.RemoveRange(overlapedFDPs);
            flightIds = flightIds.Distinct().ToList();

            //var flights = await this.context.ViewFlightInformations.Where(q => flightIds.Contains(q.ID)).OrderBy(q => q.STD).ToListAsync();
            var flights = await this.context.ViewLegTimes.Where(q => flightIds.Contains(q.ID)).OrderBy(q => q.STD).ToListAsync();



            foreach (var x in data)
            {
                var crew = crews.First(q => q.Id == x.CrewId);
                var xFlightIds = x.Flights.Select(q => q.FlightId);
                //x.ViewFlights = flights.Where(q => xFlightIds.Contains(q.ID)).OrderBy(q => q.STD).ToList();
                x.ViewLegs = flights.Where(q => xFlightIds.Contains(q.ID)).OrderBy(q => q.STD).ToList();




                var grp = 1;
                var subgrp = 100;
                for (int i = 0; i < x.Flights.Count; i++)
                {
                    var flt = x.Flights[i];
                    //var flight = x.ViewFlights.First(q => q.ID == flt.FlightId);
                    var flight = x.ViewLegs.First(q => q.ID == flt.FlightId);
                    flt.STD = flight.STD;
                    flt.STA = flight.STA;
                    if (i == x.Flights.Count - 1)
                    {
                        flt.DiffToNext = 0;
                        flt.Group = grp;
                    }
                    else
                    {
                        var nextFlt = x.Flights[i + 1];
                        //var nextFlight = x.ViewFlights.First(q => q.ID == nextFlt.FlightId);
                        var nextFlight = x.ViewLegs.First(q => q.ID == nextFlt.FlightId);
                        flt.DiffToNext = ((DateTime)nextFlight.STD - (DateTime)flight.STA).TotalMinutes;
                        var rest = flight.ToAirport == crew.BaseAirportId ? 12 * 60 : 10 * 60;
                        flt.Group = grp;
                        var groupLegs = x.Flights.Where(q => q.Group == grp).Count();
                        if (flt.DiffToNext - 30 - 60 >= rest || groupLegs == 10)
                        {
                            grp++;
                        }
                        else if (flt.DiffToNext - 30 - 60 >= 3 * 60)
                        {
                            //flt.SubGroup = subgrp;
                            // nextFlt.SubGroup = subgrp;
                            // subgrp++;
                            flt.SubGroup = -1;
                            //nextFlt.SubGroup = -1;
                        }

                    }


                }

                //var fdpkey = getRosterFDPKey(x.Flights);
                //var fdp = fdps.FirstOrDefault(q => q.Key == fdpkey);
                //if (fdp == null)
                //{
                //    fdp = new RosterFDP()
                //    {
                //        Items = new List<RosterFDPItem>(),
                //        Key = fdpkey,
                //        CrewId = null,
                //        Id = idCounter,
                //    };
                //    fdps.Add(fdp);
                //    idCounter--;
                //}

            }
            var idCounter = -1;
            var fdps = new List<RosterFDP>();
            Dictionary<string, List<int>> fdpsCrews = new Dictionary<string, List<int>>();
            foreach (var row in data)
            {
                var grps = (from x in row.Flights
                            group x by x.Group into g
                            select g).ToList();
                var normalGroups = (from x in grps
                                    where x.Where(q => q.SubGroup != null).Count() == 0
                                    select x).ToList();
                var anormalGroups = (from x in grps
                                     where x.Where(q => q.SubGroup != null).Count() > 0
                                     select x).ToList();
                ////////Normal Groups
                foreach (var g in normalGroups)
                {
                    var fdpkey = getRosterFDPKey(g.ToList());
                    var fdp = fdps.FirstOrDefault(q => q.Key == fdpkey);
                    if (fdp == null)
                    {
                        fdp = new RosterFDP()
                        {
                            Items = new List<RosterFDPItem>(),
                            Key = fdpkey,
                            CrewId = null,
                            Id = idCounter,
                        };
                        foreach (var item in g)
                        {
                            fdp.Items.Add(new RosterFDPItem()
                            {
                                DH = item.DH,
                                Flight = flights.First(q => q.ID == item.FlightId),
                                IsSector = !item.DH,
                                PositionId = item.PositionId,
                                RosterPosition = item.RosterPosition,
                                SplitDuty = false,
                            });
                        }
                        //fdp.MaxFDP = 0;
                        //fdp.MaxFDPExtended = fdp.MaxFDP;
                        fdps.Add(fdp);
                        setMaxFDP(fdp, MaxFDPTable);
                        idCounter--;
                    }

                    List<int> _value = null;
                    if (fdpsCrews.TryGetValue(fdpkey, out _value))
                        _value.Add(row.CrewId);
                    else
                        fdpsCrews.Add(fdpkey, new List<int>() { row.CrewId });


                }
                ////////////ANormal Groups////////////////////
                List<List<RosterFDPItem>> anormalFlights = new List<List<RosterFDPItem>>();
                foreach (var ang in anormalGroups)
                {
                    var list = new List<RosterFDPItem>();
                    var ordered = ang.OrderBy(q => q.STD).ToList();
                    foreach (var x in ordered)
                    {
                        list.Add(new RosterFDPItem()
                        {
                            DH = x.DH,
                            Flight = flights.First(q => q.ID == x.FlightId),
                            IsSector = !x.DH,
                            PositionId = x.PositionId,
                            RosterPosition = x.RosterPosition,
                            SplitDuty = false,
                        });
                        if (x.SubGroup != null)
                        {
                            anormalFlights.Add(list.ToList());
                            list = new List<RosterFDPItem>();
                        }

                    }
                    anormalFlights.Add(list.ToList());
                }
                ////////////////////////////////////////////
                if (anormalFlights.Count > 0)
                {
                    presult = new List<string>();
                    var ns = new List<string>();
                    for (int i = 0; i < anormalFlights.Count; i++)
                        ns.Add(i.ToString());
                    var grpStr = string.Join(" ", ns);
                    build(1, grpStr, grpStr.Length);

                    List<ANormalFDPs> anormalFDPs = new List<ANormalFDPs>();
                    foreach (var x in presult)
                    {
                        var anf = new ANormalFDPs() { FDPs = new List<RosterFDP>(), Key = x, Score = 0 };
                        List<RosterFDP> tempFDPs = new List<RosterFDP>();
                        var prts = x.Split('*').ToList();
                        foreach (var prt in prts)
                        {
                            var tfdp = new RosterFDP() { Items = new List<RosterFDPItem>() };
                            var nos = prt.Split(' ').Select(q => Convert.ToInt32(q)).ToList();
                            nos.ForEach(q => tfdp.Items = tfdp.Items.Concat(deepCopy(anormalFlights[q])).ToList());
                            setSplitDuty(tfdp);
                            setMaxFDP(tfdp, MaxFDPTable);
                            anf.FDPs.Add(tfdp);

                        }
                        anormalFDPs.Add(anf);
                    }
                    setScore(anormalFDPs);

                    var winner = anormalFDPs.OrderByDescending(q => q.Score).First();
                    foreach (var x in winner.FDPs)
                    {
                        var fdpkey = getRosterFDPKey(x.Items);
                        x.Key = fdpkey;
                        var fdp = fdps.FirstOrDefault(q => q.Key == fdpkey);
                        if (fdp == null)
                        {

                            fdps.Add(x);

                        }

                        List<int> _value = null;
                        if (fdpsCrews.TryGetValue(fdpkey, out _value))
                            _value.Add(row.CrewId);
                        else
                            fdpsCrews.Add(fdpkey, new List<int>() { row.CrewId });

                    }

                }


                ////////////////////////////

            }


            List<RosterFDPLight> rosterAssignedFDPs = new List<RosterFDPLight>();

            List<FDP> outFDPs = new List<FDP>();
            foreach (var _fdp in fdps)
            {
                var fdp = new FDP()
                {
                    Key = _fdp.Key,
                    IsTemplate = true,
                    DutyType = 1165,
                    FirstFlightId = _fdp.Items.First().Flight.ID,
                    LastFlightId = _fdp.Items.Last().Flight.ID,
                    GUID = Guid.NewGuid(),
                    IsMain = true,
                };
                fdp.FDPItems = new List<FDPItem>();
                foreach (var _fi in _fdp.Items)
                {
                    fdp.FDPItems.Add(new FDPItem()
                    {
                        FlightId = _fi.Flight.ID,
                        IsPositioning = _fi.DH,
                        IsSector = !_fi.DH,
                        SplitDuty = _fi.SplitDuty,
                        SplitDutyPairId = _fi.SplitDutyPairId,

                    });
                }

                outFDPs.Add(fdp);
                this.context.FDPs.Add(fdp);
                ///////////////////////
                //////////////////////
                var acrews = fdpsCrews[_fdp.Key];
                int _cdu = 0;
                foreach (var x in duties)
                {
                    _cdu++;
                    var _duration = (x.End - x.Start).TotalMinutes;
                    var rosterAssigned = new RosterFDPLight()
                    {
                        DutyTypeId = x.Type,
                        IsFDP = false,
                        Remark = x.TypeTitle,
                        CrewId = x.CrewId,
                        Duration = _duration,
                        Duty = (x.Type == 10000 || x.Type == 10001 ? 0 : 0.25) * _duration,
                        DutyEnd = x.End,
                        DutyEndLocal = x.End.AddMinutes(Helper.GetTimeOffset(x.End.Date)),
                        DutyStart = x.Start,
                        DutyStartLocal = x.Start.AddMinutes(Helper.GetTimeOffset(x.Start.Date)),
                        FDPEnd = x.End,
                        FDPEndLocal = x.End.AddMinutes(Helper.GetTimeOffset(x.End.Date)),
                        FirstLocation = x.LocationId.ToString(),
                        FirstLocationId = x.LocationId,
                        Flight = 0,
                        IsOver = false,
                        IsRestOk = true,
                        Key = "DU" + _cdu,
                        LastLocation = x.LocationId.ToString(),
                        LastLocationId = x.LocationId,
                        MaxFDP = 1000,
                        MaxFDPExtended = 1000,
                        OverDuration = 0,
                        ReportingTime = x.Start,
                        ReportingTimeLocal = x.Start.AddMinutes(Helper.GetTimeOffset(x.Start.Date)),
                        RestTo = x.End.AddMinutes(12 * 60),

                    };
                    rosterAssigned.RestToLocal = ((DateTime)rosterAssigned.RestTo).AddMinutes(Helper.GetTimeOffset((DateTime)rosterAssigned.RestTo));
                    rosterAssignedFDPs.Add(rosterAssigned);
                }
                foreach (var ac in acrews)
                {
                    //var acrewRosterFlights = data.Where(q => q.CrewId == ac).First().Flights;
                    var rosterAssigned = new RosterFDPLight()
                    {
                        Remark = _fdp.Remark,
                        CrewId = ac,
                        Duration = _fdp.Duration,
                        Duty = _fdp.Duty,
                        DutyEnd = _fdp.DutyEnd,
                        DutyEndLocal = _fdp.DutyEndLocal,
                        DutyStart = _fdp.DutyStart,
                        DutyStartLocal = _fdp.DutyStartLocal,
                        FDPEnd = _fdp.FDPEnd,
                        FDPEndLocal = _fdp.FDPEndLocal,
                        FirstLocation = _fdp.FirstLocation,
                        FirstLocationId = _fdp.FirstLocationId,
                        Flight = _fdp.Flight,
                        IsOver = _fdp.IsOver,
                        IsRestOk = _fdp.IsRestOk,
                        Key = _fdp.Key,
                        LastLocation = _fdp.LastLocation,
                        LastLocationId = _fdp.LastLocationId,
                        MaxFDP = _fdp.MaxFDP,
                        MaxFDPExtended = _fdp.MaxFDPExtended,
                        OverDuration = _fdp.OverDuration,
                        ReportingTime = _fdp.ReportingTime,
                        ReportingTimeLocal = _fdp.ReportingTimeLocal,
                        RestTo = _fdp.RestTo,
                        RestToLocal = _fdp.RestToLocal
                    };
                    rosterAssignedFDPs.Add(rosterAssigned);

                }
                //////////////////////
                ///////////////////////
            }

            ///// Validation   //////////////////////
            //Dictionary<int, List<FTL>> ftlTable = new Dictionary<int, List<FTL>>();
            var _ccids = crewIds.Select(q => (Nullable<int>)q).ToList();
            var dayOffs = this.context.ViewDayOffRankeds.Where(q => _ccids.Contains(q.CrewId) && q.DutyRank == 1).Select(q => new RosterEvent()
            {
                CrewId = q.CrewId,
                End = q.DateEnd,
                Start = q.DateStart,
            }).ToList();
            var rosterDayOffs = rosterAssignedFDPs.Where(q => q.DutyTypeId == 10000 || q.DutyTypeId == 10001).Select(q => new RosterEvent()
            {
                CrewId = q.CrewId,
                End = q.DutyEnd,
                Start = q.DutyStart,
            }).ToList();
            dayOffs = dayOffs.Concat(rosterDayOffs).ToList();
            var _rerrpDateStart = dateStart.AddHours(-(168 + 24));
            var savedDutiesCrewIds = this.context.FDPs.Where(q => _ccids.Contains(q.CrewId) && q.DutyType != 10000 && q.DutyType != 10001 && q.DateStart <= _rerrpDateStart).Select(q => q.CrewId).Distinct().ToList();
            List<RosterErrorItem> rosterErrors = new List<RosterErrorItem>();
            var assignedGroup = (from x in rosterAssignedFDPs
                                 group x by x.CrewId into grp
                                 select grp).ToList();

            var dutyFlights = new List<ViewDayDutyFlight>();
            //comment
            //(from x in this.context.ViewDayDutyFlights
            // where x.Date >= dateStart && x.Date <= dateEnd && crewIds.Contains(x.CrewId)
            // select x).ToList();



            foreach (var row in assignedGroup)
            {
                List<FTL> ftlTable = new List<FTL>();
                for (var date = dateStart.Date; date <= dateEnd.Date; date = date.AddDays(1))
                {

                    var rdf = dutyFlights.FirstOrDefault(q => q.CrewId == row.Key && q.Date == date);
                    ftlTable.Add(new FTL()
                    {
                        Date = date,
                        D14 = rdf == null ? 0 : rdf.Duty14,
                        D7 = rdf == null ? 0 : rdf.Duty7,
                        D28 = rdf == null ? 0 : rdf.Duty28,
                        F28 = rdf == null ? 0 : rdf.Flight28,
                        FY = rdf == null ? 0 : rdf.FlightYear,
                    });
                }
                var rowFdps = row.OrderBy(q => q.DutyStart).ToList();

                var rowCrew = crews.FirstOrDefault(q => q.Id == row.Key);


                for (int i = 0; i <= rowFdps.Count - 1; i++)
                {
                    var currentRow = rowFdps[i];
                    var rowDate = ((DateTime)currentRow.DutyStartLocal).Date;
                    if (currentRow.DutyTypeId != 10000 && currentRow.DutyTypeId != 10001)
                    {
                        // var _d1 = (DateTime)currentRow.DutyStart;
                        // var _d2 = _d1.AddHours(-168);
                        if (savedDutiesCrewIds.Contains(row.Key))
                        {
                            var dayoff = dayOffs.Where(q => q.CrewId == row.Key && q.End <= currentRow.DutyStart).OrderByDescending(q => q.End).FirstOrDefault();
                            if (dayoff == null || ((DateTime)currentRow.DutyStart - (DateTime)dayoff.End).TotalHours > 168)
                            {
                                //rosterErrors.Add(new RosterErrorItem()
                                //{
                                //    CrewId = row.Key,
                                //    Name = crews.FirstOrDefault(q => q.Id == row.Key).ScheduleName,
                                //    TypeId = 5,
                                //    Remark = currentRow.Remark,

                                //});
                            }
                        }

                    }
                    var ftlRows = ftlTable.Where(q => q.Date >= rowDate).ToList();
                    foreach (var f in ftlRows)
                    {
                        f.D7 += (double)currentRow.Duty;
                        f.D14 += (double)currentRow.Duty;
                        f.D28 += (double)currentRow.Duty;
                        if (currentRow.Flight != null)
                        {
                            f.F28 = (double)currentRow.Flight;
                            f.FY = (double)currentRow.Flight;
                        }
                    }
                    ////Check Rest Error

                    if (i < rowFdps.Count - 1)
                    {

                        var nextrow = rowFdps[i + 1];
                        if ((nextrow.DutyStart >= currentRow.DutyStart && nextrow.DutyStart <= currentRow.RestTo) ||
                            (nextrow.RestTo >= currentRow.DutyStart && nextrow.RestTo <= currentRow.RestTo) ||
                            currentRow.DutyStart >= nextrow.DutyStart && currentRow.RestTo <= nextrow.RestTo
                            )
                        {
                            var _crewww = crews.FirstOrDefault(q => q.Id == row.Key);
                            if (_crewww != null)
                                rosterErrors.Add(new RosterErrorItem()
                                {
                                    CrewId = row.Key,
                                    Name = crews.FirstOrDefault(q => q.Id == row.Key).ScheduleName,
                                    TypeId = 1,
                                    Remark = currentRow.Remark,
                                    Remark2 = nextrow.Remark,
                                });
                        }
                    }

                    // Check Over Error
                    if (currentRow.IsOver)
                    {
                        rosterErrors.Add(new RosterErrorItem()
                        {
                            CrewId = row.Key,
                            Name = crews.FirstOrDefault(q => q.Id == row.Key).ScheduleName,
                            TypeId = 3,
                            Remark = currentRow.Remark,
                            Remark2 = "FDP: " + FormatTwoDigits(Convert.ToInt32(Math.Floor((decimal)currentRow.Duty - 30)) / 60) + ":" + FormatTwoDigits(Convert.ToInt32(Math.Floor((decimal)currentRow.Duty - 30)) % 60)
                            + " Max FDP: " + FormatTwoDigits(Convert.ToInt32(Math.Floor(currentRow.MaxFDPExtended)) / 60) + ":" + FormatTwoDigits(Convert.ToInt32(Math.Floor(currentRow.MaxFDPExtended)) % 60)
                        });
                    }
                    ////Check Location Error
                    //if (i == 0)
                    //{
                    //    if (currentRow.FirstLocationId != rowCrew.LastLocationId)
                    //        rosterErrors.Add(new RosterErrorItem()
                    //        {
                    //            CrewId = row.Key,
                    //            Name = rowCrew.ScheduleName,
                    //            TypeId = 2,
                    //            Remark = currentRow.Remark,
                    //            Remark2 = "Current Crew Location: " + rowCrew.LastLocation + "  Duty Starts at: " + currentRow.FirstLocation,
                    //        });
                    //}
                    //else
                    //if (i < rowFdps.Count - 1)
                    //{
                    //    var nextrow = rowFdps[i + 1];

                    //    if (currentRow.LastLocationId != nextrow.FirstLocationId)
                    //    {
                    //        rosterErrors.Add(new RosterErrorItem()
                    //        {
                    //            CrewId = row.Key,
                    //            Name = rowCrew.ScheduleName,
                    //            TypeId = 2,
                    //            Remark = currentRow.Remark + " ends at (" + currentRow.LastLocation + ")",
                    //            Remark2 = nextrow.Remark + " starts at (" + nextrow.FirstLocation + ")"
                    //        });
                    //    }

                    //}




                }
                ///////////////////////
                var D7 = ftlTable.FirstOrDefault(q => q.D7 > 60 * 60);
                var D14 = ftlTable.FirstOrDefault(q => q.D14 > 110 * 60);
                var D28 = ftlTable.FirstOrDefault(q => q.D28 > 190 * 60);
                var F28 = ftlTable.FirstOrDefault(q => q.F28 > 100 * 60);
                var FY = ftlTable.FirstOrDefault(q => q.FY > 1000 * 60);
                if (D7 != null)
                {
                    rosterErrors.Add(new RosterErrorItem()
                    {
                        CrewId = row.Key,
                        Name = rowCrew.ScheduleName,
                        TypeId = 4,
                        Remark = D7.Date.ToShortDateString(),
                        Remark2 = "7-Day Duties: " + FormatTwoDigits(Convert.ToInt32(Math.Floor((decimal)D7.D7)) / 60) + ":" + FormatTwoDigits(Convert.ToInt32(Math.Floor((decimal)D7.D7)) % 60)
                    });
                }
                if (D14 != null)
                {
                    rosterErrors.Add(new RosterErrorItem()
                    {
                        CrewId = row.Key,
                        Name = rowCrew.ScheduleName,
                        TypeId = 4,
                        Remark = D14.Date.ToShortDateString(),
                        Remark2 = "14-Day Duties: " + FormatTwoDigits(Convert.ToInt32(Math.Floor((decimal)D14.D14)) / 60) + ":" + FormatTwoDigits(Convert.ToInt32(Math.Floor((decimal)D14.D14)) % 60)
                    });
                }
                if (D28 != null)
                {
                    rosterErrors.Add(new RosterErrorItem()
                    {
                        CrewId = row.Key,
                        Name = rowCrew.ScheduleName,
                        TypeId = 4,
                        Remark = D28.Date.ToShortDateString(),
                        Remark2 = "28-Day Duties: " + FormatTwoDigits(Convert.ToInt32(Math.Floor((decimal)D28.D28)) / 60) + ":" + FormatTwoDigits(Convert.ToInt32(Math.Floor((decimal)D28.D28)) % 60)
                    });
                }
                if (F28 != null)
                {
                    rosterErrors.Add(new RosterErrorItem()
                    {
                        CrewId = row.Key,
                        Name = rowCrew.ScheduleName,
                        TypeId = 4,
                        Remark = F28.Date.ToShortDateString(),
                        Remark2 = "28-Day Flights: " + FormatTwoDigits(Convert.ToInt32(Math.Floor((decimal)F28.F28)) / 60) + ":" + FormatTwoDigits(Convert.ToInt32(Math.Floor((decimal)F28.F28)) % 60)
                    });
                }
                if (FY != null)
                {
                    rosterErrors.Add(new RosterErrorItem()
                    {
                        CrewId = row.Key,
                        Name = rowCrew.ScheduleName,
                        TypeId = 4,
                        Remark = FY.Date.ToShortDateString(),
                        Remark2 = "12-Month Flights: " + FormatTwoDigits(Convert.ToInt32(Math.Floor((decimal)FY.FY)) / 60) + ":" + FormatTwoDigits(Convert.ToInt32(Math.Floor((decimal)FY.FY)) % 60)
                    });
                }

                /////////////////////////

            }
            if (rosterErrors.Count > 0)
            {
                return new
                {
                    error = 1,
                    errors = rosterErrors,
                };
            }
            /////////////////////////////////////////

            var saveResult = await this.context.SaveAsync();
            //var saveResult = new CustomActionResult(HttpStatusCode.NotAcceptable, null);
            if (saveResult.Code == HttpStatusCode.OK)
            {
                List<FDP> savedFDPs = new List<FDP>();
                foreach (var ofdp in outFDPs)
                {
                    var acrews = fdpsCrews[ofdp.Key];
                    foreach (var ac in acrews)
                    {
                        var acrewRosterFlights = data.Where(q => q.CrewId == ac).First().Flights;
                        var defaultPositionId = acrewRosterFlights.Where(q => q.FlightId == ofdp.FDPItems.First().FlightId).First().PositionId;
                        var assigned = new FDP()
                        {
                            CrewId = ac,
                            IsTemplate = false,
                            DutyType = ofdp.DutyType,
                            JobGroupId = defaultPositionId,
                            TemplateId = ofdp.Id,
                            FirstFlightId = ofdp.FirstFlightId,
                            LastFlightId = ofdp.LastFlightId,
                            GUID = Guid.NewGuid(),
                            Key = ofdp.Key,

                        };
                        this.context.FDPs.Add(assigned);
                        savedFDPs.Add(assigned);
                        foreach (var ofdpitem in ofdp.FDPItems)
                        {
                            var _rosterflight = acrewRosterFlights.Where(q => q.FlightId == ofdpitem.FlightId).First();
                            this.context.FDPItems.Add(new FDPItem()
                            {
                                FDP = assigned,
                                FlightId = ofdpitem.FlightId,
                                IsOff = ofdpitem.IsOff,
                                IsPositioning = ofdpitem.IsPositioning,
                                IsSector = ofdpitem.IsSector,
                                SplitDuty = ofdpitem.SplitDuty,
                                SplitDutyPairId = ofdpitem.SplitDutyPairId,
                                PositionId = _rosterflight.PositionId,
                                RosterPositionId = _rosterflight.RosterPosition,
                            });

                        }
                    }

                }

                saveResult = await this.context.SaveAsync();
                if (saveResult.Code == HttpStatusCode.OK)
                {
                    var savedIds = savedFDPs.Select(q => q.Id).ToList();
                    var viewfdps = await this.context.ViewFDPRests.Where(q => savedIds.Contains(q.Id)).ToListAsync();
                    return viewfdps;
                }
            }
            return null;
            //}
            //catch (Exception ex)
            //{
            //    return null;
            //}
            // var flights = await this.context.ViewFlightInformations.Where(q => q.ID == -1).ToListAsync();





            //////////////////////

        }

        public async Task<object> RosterGetDuties(DateTime dateStart, DateTime dateEnd)
        {
            var duties = await this.context.ViewFDPRests.OrderByDescending(q => q.DutyStart).Where(q => q.DutyType != 1165
            && (
                 (q.DutyStartLocal >= dateStart && q.DutyStartLocal <= dateEnd) ||
                 (q.DutyEndLocal >= dateStart && q.DutyEndLocal <= dateEnd)
               )
            ).ToListAsync();
            var result = new List<object>();
            foreach (var x in duties)
            {
                var duty = new
                {
                    Id = x.Id,
                    dutyType = x.DutyType,
                    dutyTypeTitle = x.DutyTypeTitle,
                    duty = x,
                    crewId = x.CrewId,
                    isPrePost = false,
                    type = 0,
                    LastLocationId = x.LocationId,
                    LastLocation = x.Location,
                    FirstLocationId = x.LocationId,
                    FirstLocation = x.Location,
                    x.DutyStartLocal,
                    x.DutyStart,
                    x.JobGroup,
                    Duty = x.Duty,
                    GroupId = x.JobGroupId,
                    day = ((DateTime)x.DateStartLocal).Date,
                    DutyEnd = x.DutyEnd,
                    DutyEndLocal = x.DutyEndLocal,
                    RestTo = x.RestUntil,
                    RestToLocal = x.RestUntilLocal,
                    Remark = x.Remark


                };
                result.Add(duty);
            }

            return result;

        }

        public async Task<object> RosterGetSTBYs(DateTime dateStart, DateTime dateEnd, int loc, int time)
        {
            //var duties = await this.context.ViewFDPRests.OrderByDescending(q => q.DutyStart).Where(q => (q.DutyType == 1167 || q.DutyType==1168 || q.DutyType==1170)
            //&& (
            //     (q.DutyStartLocal >= dateStart && q.DutyStartLocal <= dateEnd) ||
            //     (q.DutyEndLocal >= dateStart && q.DutyEndLocal <= dateEnd)
            //   )
            //).ToListAsync();
            var sts = new List<int>() { 1170 };
            if (time >= 1200)
                sts.Add(1167);
            else
                sts.Add(1168);

            var duties = await (from q in this.context.ViewFDPRests
                                join c in this.context.ViewCrews on q.CrewId equals c.Id
                                where sts.Contains(q.DutyType) && c.LastLocationId == loc
                     && (
                          (q.DutyStartLocal >= dateStart && q.DutyStartLocal <= dateEnd) ||
                          (q.DutyEndLocal >= dateStart && q.DutyEndLocal <= dateEnd)
                        )
                                orderby q.DutyStart
                                select new
                                {
                                    q.CrewId,
                                    FDPId = q.Id,
                                    q.DutyStart,
                                    q.DutyStartLocal,
                                    q.DutyEnd,
                                    q.DutyEndLocal,
                                    q.RestUntil,
                                    q.RestUntilLocal,
                                    q.DutyType,
                                    q.DutyTypeTitle,
                                    // day = ((DateTime)q.DateStartLocal).Date,
                                    // dayUTC= ((DateTime)q.DateStart).Date,
                                    c.Name,
                                    c.ScheduleName,
                                    c.JobGroup,
                                    c.JobGroupCode,
                                    c.GroupId,
                                    c.LastLocation,
                                    c.LastLocationId,



                                }).ToListAsync();
            return duties;

        }


        internal IQueryable<ViewCrewValidFTL> GetValidCrewForRoster(int cid, DateTime dt)
        {

            dt = dt.Date;
            // var result = this.context.GetValidCrewForFDP(fdp, true, jg).ToList();


            var p_dt = new SqlParameter("@dt", dt);

            this.context.Database.CommandTimeout = 160;
            var result = context.Database
                // .SqlQuery<ViewCrewValid>("GetValidCrewForFDP @FDPId,@IsValid,@JobGroup", p_fdp, p_isvalid, p_jobgroup)
                .SqlQuery<ViewCrewValidFTL>("dbo.GetValidCrewForRoster @dt", p_dt)
                .ToList();

            //  .SqlQuery<ResultForCampaign>("GetResultsForCampaign @ClientId", clientIdParameter)
            // .ToList();

            // result = result.OrderBy(q => q.GroupOrder).ThenBy(q => q.Flight).ToList();

            return result.AsQueryable();
        }


        public async Task<object> GetDailyRosterReport(DateTime df)
        {
            var dt = df.AddHours(24);
            var query = await this.context.ViewRosterReports.Where(q => q.DateLocal == df).OrderBy(q => q.STDLocal).ToListAsync();
            var stbyam = await this.context.ViewCrewDuties.Where(q => q.CrewId != null && q.DutyType == 1168 && q.DateLocal == df).OrderBy(q => q.OrderIndex).ThenBy(q => q.ScheduleName).ToListAsync();
            var stbypm = await this.context.ViewCrewDuties.Where(q => q.CrewId != null && q.DutyType == 1167 && q.DateLocal == df).OrderBy(q => q.OrderIndex).ThenBy(q => q.ScheduleName).ToListAsync();

            var result = new
            {
                fdps = query,
                am = stbyam,
                pm = stbypm,

            };
            return result;
        }
        public async Task<object> GetDailyRosterReportFP(DateTime df)
        {
            var dt = df.AddHours(24);
            var query = await this.context.ViewRosterReportFPs.Where(q => q.STDDay == df).OrderBy(q => q.Register).ThenBy(q => q.STD).ToListAsync();
            // var stbyam = await this.context.ViewCrewDuties.Where(q => q.CrewId != null && q.DutyType == 1168 && q.DateLocal == df).OrderBy(q => q.OrderIndex).ThenBy(q => q.ScheduleName).ToListAsync();
            // var stbypm = await this.context.ViewCrewDuties.Where(q => q.CrewId != null && q.DutyType == 1167 && q.DateLocal == df).OrderBy(q => q.OrderIndex).ThenBy(q => q.ScheduleName).ToListAsync();

            var result = new
            {
                items = query,
                //am = stbyam,
                //pm = stbypm,

            };
            return result;
        }
        // return unitOfWork.FlightRepository.GetViewFDPRest().Where(q => q.CrewId == crewid && q.DateStartYear == year && q.DateStartMonth == month);
        public async Task<object> GetCrewDuties(DateTime dateStart, DateTime dateEnd, int? cabin, int? cockpit)
        {
            //2020-11-22 noreg
            var query = from x in this.context.ViewCrewDutyNoRegs
                        where x.Start >= dateStart && x.Start <= dateEnd
                        select x;
            if (cabin == 1)
                query = query.Where(q => q.IsCabin == 1);
            if (cockpit == 1)
                query = query.Where(q => q.IsCockpit == 1);
            var result = await query.OrderBy(q => q.ScheduleName).ThenBy(q => q.DateStartLocal).ToListAsync();
            return result;

        }


        public async Task<object> GetCrewDuties(int crewId, int year, int month)
        {
            var query = from x in this.context.ViewCrewDuties
                        where x.DateStartYear == year && x.DateStartMonth == month && x.CrewId == crewId
                        select x;

            var result = await query.OrderBy(q => q.DateStartLocal).ToListAsync();
            return result;

        }

        public async Task<object> GetDayDuties(string type, int year, int month, int day)
        {

            var query = from x in this.context.ViewCrewDuties
                        where x.DateStartYear == year && x.DateStartMonth == month && x.DateStartDay == day && (x.DutyType == 1167 || x.DutyType == 1168 || x.DutyType == 1170)
                        select x;

            var result = await query.OrderBy(q => q.DateStartLocal).ToListAsync();
            return result;

        }

        public async Task<object> GetCrewDutiesGrouped(DateTime dateStart, DateTime dateEnd, int? cabin, int? cockpit)
        {
            var query = from x in this.context.ViewCrewDuties
                        where x.DateStartLocal >= dateStart && x.DateStartLocal <= dateEnd
                        select x;
            if (cabin == 1)
                query = query.Where(q => q.IsCabin == 1);
            if (cockpit == 1)
                query = query.Where(q => q.IsCockpit == 1);
            var result = await query.ToListAsync();
            var grouped = (from x in result
                           group x by new { x.CrewId, x.ScheduleName, x.Name, x.JobGroup, x.JobGroupCode, x.GroupId } into grp
                           select
                           new
                           {
                               grp.Key.CrewId,
                               grp.Key.ScheduleName,
                               grp.Key.Name,
                               grp.Key.JobGroup,
                               grp.Key.JobGroupCode,
                               grp.Key.GroupId,
                               Duties = grp.OrderBy(q => q.DateStartLocal).ToList()

                           }).ToList();

            return result;

        }


        public async Task<bool> _deleteFDPs()
        {
            var fdps = await this.context.FDPs.Where(q => !string.IsNullOrEmpty(q.Key)).ToListAsync();
            this.context.FDPs.RemoveRange(fdps);
            var saveResult = await this.context.SaveAsync();
            return true;
        }



        internal class DelayReportObject
        {
            public string Category { get; set; }
            public string Airport { get; set; }
            public double? Delay { get; set; }
            public string DelayFormatted { get; set; }
            public int Count { get; set; }

            public double? Avg { get; set; }
            public double? Slope { get; set; }
        }
        char[] hexDigits = {
         '0', '1', '2', '3', '4', '5', '6', '7',
         '8', '9', 'A', 'B', 'C', 'D', 'E', 'F'};
        /// <summary>
        /// Convert a .NET Color to a hex string.
        /// </summary>
        /// <returns>ex: "FFFFFF", "AB12E9"</returns>
        public string ColorToHexString(Color color)
        {
            byte[] bytes = new byte[3];
            bytes[0] = color.R;
            bytes[1] = color.G;
            bytes[2] = color.B;
            char[] chars = new char[bytes.Length * 2];
            for (int i = 0; i < bytes.Length; i++)
            {
                int b = bytes[i];
                chars[i * 2] = hexDigits[b >> 4];
                chars[i * 2 + 1] = hexDigits[b & 0xF];
            }
            return new string(chars);
        }
        string getRandomColor()
        {
            Random rnd = new Random();
            Color randomColor = Color.FromArgb(rnd.Next(256), rnd.Next(256), rnd.Next(256));
            return ColorToHexString(randomColor);
        }
        Dictionary<string, double?> calculateTrendSlope(List<ViewDelayDailyCategory> ds)
        {

            double c = 1;
            Dictionary<string, double?> result = new Dictionary<string, double?>();
            var grouped = (from x in ds
                           group x by x.Category into grp
                           select grp).ToList();

            foreach (var grp in grouped)
            {
                c = 1;
                TrendCalculus.LinearTrend<TrendCalculus.IValueItem> linearTrend = new TrendCalculus.LinearTrend<TrendCalculus.IValueItem>();
                var items = grp.OrderBy(q => q.Date).ToList();
                foreach (var r in items)
                {
                    linearTrend.DataItems.Add(new TrendCalculus.NumberItem()
                    {
                        X = c,
                        Y = Convert.ToDouble(r.Delay)
                    });
                    c++;
                }
                linearTrend.Calculate();
                result.Add(grp.Key, linearTrend.Slope);

            }
            return result;

        }


        Dictionary<string, double?> calculateTrendSlope(List<ViewDelayDailyAirport> ds)
        {

            double c = 1;
            Dictionary<string, double?> result = new Dictionary<string, double?>();
            var grouped = (from x in ds
                           group x by x.Airport into grp
                           select grp).ToList();

            foreach (var grp in grouped)
            {
                c = 1;
                TrendCalculus.LinearTrend<TrendCalculus.IValueItem> linearTrend = new TrendCalculus.LinearTrend<TrendCalculus.IValueItem>();
                var items = grp.OrderBy(q => q.Date).ToList();
                foreach (var r in items)
                {
                    linearTrend.DataItems.Add(new TrendCalculus.NumberItem()
                    {
                        X = c,
                        Y = Convert.ToDouble(r.Delay)
                    });
                    c++;
                }
                linearTrend.Calculate();
                result.Add(grp.Key, linearTrend.Slope);

            }
            return result;

        }
        internal async Task<object> GetReportDelayDaily(int cid, DateTime df, DateTime dt)
        {
            //masha
            var colorSet1 = new List<string>() { "#ffffb3", "#ffbf80", "#ff9999", "#ffb3ff", "#ffd633", "#e6ac00", "#d65cad", "#ff1a1a", "#ff661a" };

            var colorSet2 = new List<string>() { "#66ff99", "#4ddbff", "#ffb3ff", "#33cccc", "#ffff4d", "#70db70", "#6699ff", "#94b8b8", "#a3a375", "#7575a3" };
            var flightsCount = await this.context.FlightInformations.Where(q => q.CustomerId == cid && q.FlightStatusID != 1 && q.FlightStatusID != 4).CountAsync();
            var delaysSum = await this.context.ViewFlightDelays.Where(q => q.CustomerId == cid && q.Code != "93").SumAsync(q => q.Delay);
            var avgDelayLeg = flightsCount != 0 ? Math.Round(Convert.ToDouble(delaysSum * 1.0) / flightsCount, 2) : 0;




            var flightsCountDate = await this.context.ViewFlightInformations.Where(q => q.CustomerId == cid && q.STDDay >= df && q.STDDay <= dt && q.FlightStatusID != 1 && q.FlightStatusID != 4).CountAsync();
            // var times = await this.context.ViewFlightInformations.Where(q => q.CustomerId == cid && q.STDDay >= df && q.STDDay <= dt && q.FlightStatusID != 1 && q.FlightStatusID != 4).Select(q => new { });
            var times = await this.context.ViewFlightInformations.Where(q => q.CustomerId == cid && q.STDDay >= df && q.STDDay <= dt && q.FlightStatusID != 1 && q.FlightStatusID != 4)
                .GroupBy(x => true)
                .Select(x => new
                {
                    BL = x.Sum(y => y.BlockTime),
                    FL = x.Sum(y => y.FlightTime)
                }).ToListAsync();


            var delays = await this.context.ViewFlightDelays.Where(q => q.CustomerId == cid && q.STDDay >= df && q.STDDay <= dt && q.Code != "93").ToListAsync();
            var delaysTotal = await this.context.ViewDelayDailies.Where(q => q.Date >= df && q.Date <= dt).OrderBy(q => q.Date).ToListAsync();
            foreach (var x in delaysTotal)
            {
                x.DelayLeg = x.TotalFlights == 0 || x.TotalFlights == null ? 0 : Math.Round(Convert.ToDouble(x.Delay * 1.0) / (int)x.TotalFlights, 2);
                x.DelayRatio = x.BlockTime == 0 ? 0 : Math.Round(Convert.ToDouble(x.Delay * 1.0) / x.BlockTime, 2);
            }

            TrendCalculus.LinearTrend<TrendCalculus.IValueItem> linearTrend = new TrendCalculus.LinearTrend<TrendCalculus.IValueItem>();
            TrendCalculus.LinearTrend<TrendCalculus.IValueItem> linearTrend2 = new TrendCalculus.LinearTrend<TrendCalculus.IValueItem>();
            foreach (var d in delaysTotal)
            {
                linearTrend.DataItems.Add(new TrendCalculus.DateItem()
                {
                    X = d.Date,
                    Y = Convert.ToDouble(d.Delay)
                });
                linearTrend2.DataItems.Add(new TrendCalculus.DateItem()
                {
                    X = d.Date,
                    Y = Convert.ToDouble(d.DelayLeg)
                });
            }

            if (linearTrend.Calculate() && linearTrend2.Calculate())
            {
                var totalDelaysTrend = linearTrend.TrendItems.OrderBy(q => q.ConvertedX).ToList();
                var totalDelaysTrendDl = linearTrend2.TrendItems.OrderBy(q => q.ConvertedX).ToList();
                for (var j = 0; j < totalDelaysTrend.Count; j++)
                {
                    delaysTotal[j].TRND = totalDelaysTrend[j].Y;
                    delaysTotal[j].TRNDLeg = totalDelaysTrendDl[j].Y;
                }

            }

            var dailyCats = await this.context.ViewDelayDailyCategories.Where(q => q.Date >= df && q.Date <= dt).OrderBy(q => q.Date).ToListAsync();
            var _dailyCatsSlope = calculateTrendSlope(dailyCats);
            #region dailyCats table
            var dailyCatsTbl = new DataTable();
            dailyCatsTbl.Columns.Add(new DataColumn("Date", typeof(DateTime)));
            var _dcs = dailyCats.Select(q => q.Category).Distinct().OrderBy(q => q).ToList();
            foreach (var dc in _dcs)
            {
                dailyCatsTbl.Columns.Add(new DataColumn(dc, typeof(double)));
            }
            var _dailyCatsGrouped = dailyCats.GroupBy(q => q.Date).OrderBy(q => q.Key).ToList();
            foreach (var x in _dailyCatsGrouped)
            {
                var row = dailyCatsTbl.NewRow();
                row["Date"] = x.Key;

                for (int i = 1; i <= dailyCatsTbl.Columns.Count - 1; i++)
                {
                    var _ct = dailyCatsTbl.Columns[i].ColumnName;
                    var _vl = x.FirstOrDefault(q => q.Category == _ct);

                    row[_ct] = _vl == null ? 0 : _vl.Delay;
                }

                dailyCatsTbl.Rows.Add(row);
            }

            #endregion

            var dailyAirports = await this.context.ViewDelayDailyAirports.Where(q => q.Date >= df && q.Date <= dt).OrderBy(q => q.Date).ThenBy(q => q.Airport).ToListAsync();
            var _dailyAirportsSlope = calculateTrendSlope(dailyAirports);
            #region dailyAirports table
            var dailyAirportsTbl = new DataTable();
            dailyAirportsTbl.Columns.Add(new DataColumn("Date", typeof(DateTime)));
            var _das = dailyAirports.Select(q => q.Airport).Distinct().OrderBy(q => q).ToList();
            foreach (var dc in _das)
            {
                dailyAirportsTbl.Columns.Add(new DataColumn(dc, typeof(double)));
            }
            var _dailyAirportsGrouped = dailyAirports.GroupBy(q => q.Date).OrderBy(q => q.Key).ToList();
            foreach (var x in _dailyAirportsGrouped)
            {
                var row = dailyAirportsTbl.NewRow();
                row["Date"] = x.Key;

                for (int i = 1; i <= dailyAirportsTbl.Columns.Count - 1; i++)
                {
                    var _ct = dailyAirportsTbl.Columns[i].ColumnName;
                    var _vl = x.FirstOrDefault(q => q.Airport == _ct);

                    row[_ct] = _vl == null ? 0 : _vl.Delay;
                }

                dailyAirportsTbl.Rows.Add(row);
            }

            #endregion


            var delaysSumDate = delays.Sum(q => q.Delay);
            var delayLeg = delays == null || flightsCountDate == 0 ? 0 : Math.Round(Convert.ToDouble(delaysSumDate * 1.0) / flightsCountDate, 2);

            var avgCategory = await this.context.DelayAvgByCategories.ToListAsync();
            var avgAirport = await this.context.DelayAvgByAirports.ToListAsync();
            var avgAirportCategory = await this.context.DelayAvgByAirportCategories.ToListAsync();
            //pussy
            var category = (from vfd in delays
                            group vfd by vfd.ICategory into grp
                            let sumDelay = grp.Sum(q => q.DelayHH * 60) + grp.Sum(q => q.DelayMM)
                            select new DelayReportObject()
                            {
                                Category = grp.Key,
                                Count = grp.Count(),
                                Delay = sumDelay,
                                DelayFormatted = FormatTwoDigits(Convert.ToInt32(sumDelay) / 60) + ":" + FormatTwoDigits(Convert.ToInt32(sumDelay) % 60),
                                Avg = avgCategory.First(q => q.Category == grp.Key).Avg,
                                Slope = _dailyCatsSlope[grp.Key],

                            }).OrderByDescending(q => q.Delay).ThenBy(q => q.Category).ToList();

            Dictionary<string, string> categoryColors = new Dictionary<string, string>();
            for (int i = 0; i < category.Count; i++)
            {
                if (i < colorSet1.Count)
                    categoryColors.Add(category[i].Category, colorSet1[i]);
                else
                    categoryColors.Add(category[i].Category, getRandomColor());
            }

            var categoryDetails = delays.OrderBy(q => q.Category).ThenBy(q => q.STDDay).ThenBy(q => q.FlightNumber).ToList();


            var airport = (from vfd in delays
                           group vfd by vfd.FromAirportIATA into grp
                           let sumDelay = grp.Sum(q => q.DelayHH * 60) + grp.Sum(q => q.DelayMM)
                           select new DelayReportObject()
                           {
                               Airport = grp.Key,
                               Count = grp.Count(),
                               Delay = sumDelay,
                               DelayFormatted = FormatTwoDigits(Convert.ToInt32(sumDelay) / 60) + ":" + FormatTwoDigits(Convert.ToInt32(sumDelay) % 60),
                               Avg = avgAirport.First(q => q.FromAirportIATA == grp.Key).Avg,
                               Slope = _dailyAirportsSlope[grp.Key],

                           }).OrderByDescending(q => q.Delay).ThenBy(q => q.Airport).ToList();
            Dictionary<string, string> airportColors = new Dictionary<string, string>();
            for (int i = 0; i < airport.Count; i++)
            {
                if (i < colorSet2.Count)
                    airportColors.Add(airport[i].Airport, colorSet2[i]);
                else
                    airportColors.Add(airport[i].Airport, getRandomColor());
            }
            var airportCategory = (from vfd in delays
                                   group vfd by new { vfd.FromAirportIATA, vfd.ICategory } into grp
                                   let sumDelay = grp.Sum(q => q.DelayHH * 60) + grp.Sum(q => q.DelayMM)
                                   let avgCat = avgAirportCategory.FirstOrDefault(q => q.FromAirportIATA == grp.Key.FromAirportIATA && q.Category == grp.Key.ICategory)
                                   select new DelayReportObject()
                                   {
                                       Airport = grp.Key.FromAirportIATA,
                                       Category = grp.Key.ICategory,
                                       Count = grp.Count(),
                                       Delay = sumDelay,
                                       DelayFormatted = FormatTwoDigits(Convert.ToInt32(sumDelay) / 60) + ":" + FormatTwoDigits(Convert.ToInt32(sumDelay) % 60),
                                       Avg = avgCat == null ? 0 : avgCat.Avg,

                                   }).OrderBy(q => q.Airport).ThenByDescending(q => q.Delay).ThenBy(q => q.Category).ToList();

            var airportCategoryGrouped = await (from x in this.context.ViewDelayAirportCategoryGroupeds
                                                where x.STDDay >= df && x.STDDay <= dt
                                                group x by new { x.Airport, x.Category } into grp
                                                select new
                                                {
                                                    grp.Key.Airport,
                                                    grp.Key.Category,
                                                    Delay = grp.Sum(q => q.Delay),
                                                    Count = grp.Sum(q => q.Count),
                                                }
                                                ).OrderBy(q => q.Airport).ThenBy(q => q.Category).ToListAsync();
            var airportCategoryDaily = await this.context.ViewDelayDailyAirportCategories.Where(q => q.Date >= df && q.Date <= dt).OrderBy(q => q.Date).ThenBy(q => q.Airport).ThenBy(q => q.Category).ToListAsync();
            #region process airportCategoryDaily
            var acdGrouped = from x in airportCategoryDaily
                             group x by new { x.Date, x.PDate } into grp
                             select new { grp.Key.Date, grp.Key.PDate, Items = grp.Select(w => new { Title = w.Airport + "-" + w.Category, w.Delay, w.Count, w.TotalFlights }).ToList() };
            var airportCategoryDailyTbl = new DataTable();
            airportCategoryDailyTbl.Columns.Add(new DataColumn("Date", typeof(DateTime)));
            airportCategoryDailyTbl.Columns.Add(new DataColumn("PDate", typeof(string)));
            foreach (var item in acdGrouped.First().Items)
            {
                airportCategoryDailyTbl.Columns.Add(new DataColumn(item.Title, typeof(double)));
                airportCategoryDailyTbl.Columns.Add(new DataColumn(item.Title + "Count", typeof(double)));

            }
            foreach (var grp in acdGrouped)
            {
                var row = airportCategoryDailyTbl.NewRow();
                row["Date"] = grp.Date;
                row["PDate"] = grp.PDate;
                foreach (var item in grp.Items)
                {

                    row[item.Title] = item.Delay;
                    row[item.Title + "Count"] = item.Count;
                }
                airportCategoryDailyTbl.Rows.Add(row);
            }
            #endregion

            var airportDetails = delays.OrderBy(q => q.FromAirportIATA).ThenBy(q => q.STDDay).ThenBy(q => q.FlightNumber).ToList();


            delays = delays.OrderBy(q => q.Register).OrderBy(q => q.STD).ToList();

            //                SELECT
            // vfd.ICategory as Category,
            // count(*) as Count,
            //SUM(vfd.DelayHH * 60 + vfd.DelayMM) AS Delay,
            //      format(dateadd(minute, SUM(vfd.DelayHH * 60 + vfd.DelayMM), '00:00:00'), N'HH\:mm', 'FR-fr') 


            //  FROM ViewFlightDelay vfd

            //  GROUP BY vfd.ICategory
            //    ORDER BY ICategory




            //var fdp = await this.context.FDPs.FirstOrDefaultAsync(q => q.Id == fdpId);
            //fdp.JobGroupId = position;
            return new
            {
                categoryColors,
                airportColors,
                delays,
                delaysTotal,
                dailyCats,
                dailyCatsTbl,
                dailyAirports,
                dailyAirportsTbl,
                airport,
                airportCategory,
                airportCategoryGrouped,
                airportDetails,
                airportCategoryDaily,
                airportCategoryDailyTbl,
                category,
                categoryDetails,
                avgCategory,
                avgAirport,
                avgAirportCategory,
                delaysSum,
                delaysSumDate,
                flightsCount,
                flightsCountDate,
                avgDelayLeg,
                delayLeg,
                block = times.First().BL,
                flight = times.First().FL,
                delayRatio = Math.Round(Convert.ToDouble(delaysSumDate) * 100.0 / (double)times.First().BL, 1)
            };
        }


        Dictionary<string, double?> calculateDelayTrendByCategories(List<ViewDelayWeeklyCategory> ds)
        {
            double c = 1;
            Dictionary<string, double?> result = new Dictionary<string, double?>();
            var grouped = (from x in ds
                           group x by x.Category into grp
                           select grp).ToList();

            foreach (var grp in grouped)
            {
                c = 1;
                TrendCalculus.LinearTrend<TrendCalculus.IValueItem> linearTrend = new TrendCalculus.LinearTrend<TrendCalculus.IValueItem>();
                var items = grp.OrderBy(q => q.PassedYear).ThenBy(q => q.MonthOfYear).ThenBy(q => q.WeekOfMonth).ToList();
                foreach (var r in items)
                {
                    linearTrend.DataItems.Add(new TrendCalculus.NumberItem()
                    {
                        X = c,
                        Y = Convert.ToDouble(r.Delay)
                    });
                    c++;
                }
                linearTrend.Calculate();
                result.Add(grp.Key, linearTrend.Slope);

            }
            return result;

        }

        Dictionary<string, double?> calculateDelayTrendByAirport(List<ViewDelayWeeklyAirport> ds)
        {
            double c = 1;
            Dictionary<string, double?> result = new Dictionary<string, double?>();
            var grouped = (from x in ds
                           group x by x.Airport into grp
                           select grp).ToList();

            foreach (var grp in grouped)
            {
                c = 1;
                TrendCalculus.LinearTrend<TrendCalculus.IValueItem> linearTrend = new TrendCalculus.LinearTrend<TrendCalculus.IValueItem>();
                var items = grp.OrderBy(q => q.PassedYear).ThenBy(q => q.MonthOfYear).ThenBy(q => q.WeekOfMonth).ToList();
                foreach (var r in items)
                {
                    linearTrend.DataItems.Add(new TrendCalculus.NumberItem()
                    {
                        X = c,
                        Y = Convert.ToDouble(r.Delay)
                    });
                    c++;
                }
                linearTrend.Calculate();
                result.Add(grp.Key, linearTrend.Slope);

            }
            return result;

        }
        internal async Task<object> GetReportDelayYearlyTotal(int cid)
        {
            var flightsCount = await this.context.FlightInformations.Where(q => q.CustomerId == cid && q.FlightStatusID != 1 && q.FlightStatusID != 4).CountAsync();
            var delaysSum = await this.context.ViewFlightDelays.Where(q => q.CustomerId == cid && q.Code != "93").SumAsync(q => q.Delay);
            var avgDelayLeg = flightsCount != 0 ? Math.Round(Convert.ToDouble(delaysSum * 1.0) / flightsCount, 2) : 0;
            var times = await this.context.ViewFlightInformations.Where(q => q.CustomerId == cid && q.FlightStatusID != 1 && q.FlightStatusID != 4)
                .GroupBy(x => true)
                .Select(x => new
                {
                    BL = x.Sum(y => y.BlockTime),
                    FL = x.Sum(y => y.FlightTime)
                }).ToListAsync();

            var delays = await this.context.ViewDelayMonthlies.ToListAsync();
            dynamic delaysTrend = null;
            dynamic delaysWeekTrend = null;
            dynamic delayLegTrend = null;
            dynamic delayLegWeekTrend = null;
            TrendCalculus.LinearTrend<TrendCalculus.IValueItem> linearTrend = new TrendCalculus.LinearTrend<TrendCalculus.IValueItem>();
            TrendCalculus.LinearTrend<TrendCalculus.IValueItem> linearTrend2 = new TrendCalculus.LinearTrend<TrendCalculus.IValueItem>();
            linearTrend.DataItems.Clear();
            foreach (var d in delays)
            {
                linearTrend.DataItems.Add(new TrendCalculus.NumberItem()
                {
                    X = d.MonthOfYear,
                    Y = Convert.ToDouble(d.Delay)
                });
            }


            if (linearTrend.Calculate())
            {
                delaysTrend = linearTrend.TrendItems.ToList();
                var Slope = linearTrend.Slope;
                var Intercept = linearTrend.Intercept;
                var Correl = linearTrend.Correl;
                var R2 = linearTrend.R2;
                var StartX = linearTrend.StartPoint.ConvertedX;
                var StartY = linearTrend.StartPoint.Y;
                var EndX = linearTrend.EndPoint.ConvertedX;
                var EndY = linearTrend.EndPoint.Y;
            }

            var categories = await this.context.ViewDelayMonthlyCategories.OrderBy(q => q.PassedYear).ThenBy(q => q.MonthOfYear).ThenBy(q => q.Category).ToListAsync();
            var qry1 = (from x in categories
                        group x by x.Category into grp
                        orderby grp.Key
                        select grp).ToList();
            var categoriesTbl = new DataTable();
            categoriesTbl.Columns.Add(new DataColumn("Category", typeof(string)));
            for (int i = 1; i <= 12; i++)
            {
                categoriesTbl.Columns.Add(new DataColumn("M" + i, typeof(double)));
            }

            foreach (var x in qry1)
            {
                var row = categoriesTbl.NewRow();
                row["Category"] = x.Key;
                for (int i = 1; i <= 12; i++)
                {
                    var md = x.FirstOrDefault(q => q.MonthOfYear == i);
                    row["M" + i] = md == null ? 0 : md.Delay;
                }

                categoriesTbl.Rows.Add(row);
            }


            var airports = await this.context.ViewDelayMonthlyAirports.OrderBy(q => q.PassedYear).ThenBy(q => q.MonthOfYear).ThenBy(q => q.Airport).ToListAsync();

            var airportsCategories = await this.context.ViewDelayMonthlyAirportCategories.OrderBy(q => q.PassedYear).ThenBy(q => q.MonthOfYear).ThenBy(q => q.Airport).ThenBy(q => q.Category).ToListAsync();
            var airportsCategoriesSum = (from x in airportsCategories group x by new { x.Airport, x.Category } into grp select new { airport = grp.Key.Airport, category = grp.Key.Category, count = grp.Count(), sum = grp.Sum(q => q.Delay) }).ToList();

            var delaysWeek = await this.context.ViewDelayWeeklies.OrderBy(q => q.PassedYear).ThenBy(q => q.MonthOfYear).ThenBy(q => q.WeekOfMonth).ToListAsync();
            var categoriesWeek = await this.context.ViewDelayWeeklyCategories.OrderBy(q => q.PassedYear).ThenBy(q => q.MonthOfYear).ThenBy(q => q.WeekOfMonth).ThenBy(q => q.Category).ToListAsync();
            //var qry2 = (from x in categoriesWeek
            //            group x by x.Category into grp
            //            orderby grp.Key
            //            select grp).ToList();
            //var categoriesWeekTbl = new DataTable();
            //categoriesWeekTbl.Columns.Add(new DataColumn("Category", typeof(string)));
            //for (int i = 1; i <= 12; i++)
            //{
            //    for (int j = 1; j <= 4; j++)
            //    {
            //        categoriesTbl.Columns.Add(new DataColumn("M" + i+"W"+j, typeof(double)));
            //    }
            //}

            //foreach (var x in qry2)
            //{
            //    var row = categoriesWeekTbl.NewRow();
            //    row["Category"] = x.Key;
            //    for (int i = 1; i <= 12; i++)
            //    {
            //        for (int j = 1; j <= 4; j++)
            //        {
            //            var md = x.FirstOrDefault(q => q.MonthOfYear == i && q.WeekOfMonth==j);
            //            row["M" + i+"W"+j] = md == null ? 0 : md.Delay;
            //        }

            //    }

            //    categoriesWeekTbl.Rows.Add(row);
            //}



            var airportsWeek = await this.context.ViewDelayWeeklyAirports.OrderBy(q => q.PassedYear).ThenBy(q => q.MonthOfYear).ThenBy(q => q.WeekOfMonth).ThenBy(q => q.Airport).ToListAsync();
            var airportsCategoriesWeek = await this.context.ViewDelayWeeklyAirportCategories.OrderBy(q => q.PassedYear).ThenBy(q => q.MonthOfYear).ThenBy(q => q.WeekOfMonth).ThenBy(q => q.Airport).ThenBy(q => q.Category).ToListAsync();

            var categoriesTrend = calculateDelayTrendByCategories(categoriesWeek);
            var airportsTrend = calculateDelayTrendByAirport(airportsWeek);
            var categoriesSum = (from x in categories
                                 group x by x.Category into grp
                                 select new
                                 {
                                     category = grp.Key,
                                     sum = grp.Sum(q => q.Delay),
                                     count = grp.Sum(q => q.Count),
                                     trend = categoriesTrend[grp.Key],
                                 }
                                 ).OrderByDescending(q => q.sum).ToList();

            var airportsSum = (from x in airports group x by x.Airport into grp select new { airport = grp.Key, count = grp.Sum(q => q.Count), sum = grp.Sum(q => q.Delay), trend = airportsTrend[grp.Key], }).OrderByDescending(q => q.sum).ToList();

            var cats = categories.Select(q => q.Category).Distinct().ToList();
            var apts = airports.Select(q => q.Airport).Distinct().ToList();
            var colorSet1 = new List<string>() { "#ff4d4d", "#9999ff", "#00cccc", "#e6e600", "#cc9966", "#a6a6a6", "#ff33ff", "#cc6666", "#4ddbff" };
            var colorSet2 = new List<string>() { "#66ff33", "#ffcc00", "#ff00ff", "#ff3300", "#0000cc", "#00ccff", "#b3b3b3", "#00cccc" };
            Dictionary<string, string> categoryColors = new Dictionary<string, string>();
            for (int i = 0; i < cats.Count; i++)
            {
                if (i < colorSet1.Count)
                    categoryColors.Add(cats[i], colorSet1[i]);
                else
                    categoryColors.Add(cats[i], getRandomColor());
            }
            Dictionary<string, string> airportColors = new Dictionary<string, string>();
            for (int i = 0; i < apts.Count; i++)
            {
                if (i < colorSet2.Count)
                    airportColors.Add(apts[i], colorSet2[i]);
                else
                    airportColors.Add(apts[i], getRandomColor());
            }
            linearTrend.DataItems.Clear();
            foreach (var x in delays)
            {
                x.DelayRatio = Math.Round(((double)x.Delay) / x.BlockTime, 2, MidpointRounding.AwayFromZero) * 100;
                x.DelayLeg = Math.Round(((double)x.Delay) / (int)x.TotalFlights, 2, MidpointRounding.AwayFromZero);
                linearTrend.DataItems.Add(new TrendCalculus.NumberItem()
                {
                    X = x.MonthOfYear,
                    Y = Convert.ToDouble(x.DelayLeg)
                });

            }

            if (linearTrend.Calculate())
            {
                delayLegTrend = linearTrend.TrendItems.ToList(); ;

            }

            linearTrend.DataItems.Clear();
            linearTrend2.DataItems.Clear();
            foreach (var x in delaysWeek)
            {
                x.DelayRatio = Math.Round(((double)x.Delay) / x.BlockTime, 2, MidpointRounding.AwayFromZero) * 100;
                x.DelayLeg = Math.Round(((double)x.Delay) / (int)x.TotalFlights, 2, MidpointRounding.AwayFromZero);



            }
            var min_month = delaysWeek.Min(q => q.MonthOfYear);
            var max_month = delaysWeek.Max(q => q.MonthOfYear);
            var _c = 0;
            for (int i = min_month; i <= max_month; i++)
            {
                for (int j = 1; j <= 4; j++)
                {
                    var item = delaysWeek.Where(q => q.MonthOfYear == i && q.WeekOfMonth == j).FirstOrDefault();
                    var x = _c; //i.ToString() + j.ToString();
                    var y1 = item == null ? 0 : item.Delay;
                    var y2 = item == null ? 0 : item.DelayLeg;
                    linearTrend2.DataItems.Add(new TrendCalculus.NumberItem()
                    {
                        X = Convert.ToDouble(x),
                        Y = Convert.ToDouble(y2)
                    });

                    linearTrend.DataItems.Add(new TrendCalculus.NumberItem()
                    {
                        X = Convert.ToDouble(x),
                        Y = Convert.ToDouble(y1)
                    });
                    _c++;
                }
            }
            if (linearTrend.Calculate())
            {
                delaysWeekTrend = linearTrend.TrendItems.ToList(); ;

            }
            if (linearTrend2.Calculate())
            {
                delayLegWeekTrend = linearTrend2.TrendItems.ToList(); ;

            }
            var grouped = (from x in delays
                           group x by x.YearStr into grp
                           select grp).ToList();

            var groupedWeek = (from x in delaysWeek
                               group x by x.YearStr into grp
                               select grp).ToList();

            foreach (var x in airports)
            {
                //x.DelayRatio = Math.Round(((double)x.Delay) / x.BlockTime, 2, MidpointRounding.AwayFromZero) * 100;
                x.DelayLeg = Math.Round(((double)x.Delay) / (int)x.TotalFlights, 2, MidpointRounding.AwayFromZero);



            }
            foreach (var x in airportsCategories)
            {
                //x.DelayRatio = Math.Round(((double)x.Delay) / x.BlockTime, 2, MidpointRounding.AwayFromZero) * 100;
                x.DelayLeg = Math.Round(((double)x.Delay) / (int)x.TotalFlights, 2, MidpointRounding.AwayFromZero);



            }
            foreach (var x in airportsWeek)
            {
                //x.DelayRatio = Math.Round(((double)x.Delay) / x.BlockTime, 2, MidpointRounding.AwayFromZero) * 100;
                x.DelayLeg = Math.Round(((double)x.Delay) / (int)x.TotalFlights, 2, MidpointRounding.AwayFromZero);



            }
            foreach (var x in airportsCategoriesWeek)
            {
                //x.DelayRatio = Math.Round(((double)x.Delay) / x.BlockTime, 2, MidpointRounding.AwayFromZero) * 100;
                x.DelayLeg = Math.Round(((double)x.Delay) / (int)x.TotalFlights, 2, MidpointRounding.AwayFromZero);



            }

            var result = new
            {
                delays,
                delaysTrend,
                delayLegTrend,
                delaysWeekTrend,
                delayLegWeekTrend,
                grouped,
                categories,
                categoriesTbl,
                categoriesSum,
                delaysWeek,
                groupedWeek,
                categoriesWeek,
                // categoriesWeekTbl,
                airports,
                airportsSum,
                airportsCategories,
                airportsCategoriesSum,
                airportsWeek,
                airportsCategoriesWeek,
                categoryColors,
                airportColors,
                flightsCount,
                delaysSum,
                avgDelayLeg,
                block = times.First().BL,
                flight = times.First().FL,
                delayRatio = Math.Round(Convert.ToDouble(delaysSum) * 100.0 / (double)times.First().BL, 1)

            };

            return result;
        }
        public class FlightTimeReport2
        {
            public DateTime Date { get; set; }
            public string FlightNumber { get; set; }
            public string Position { get; set; }
            public string FromAirportIATA { get; set; }
            public string ToAirportIATA { get; set; }
            public DateTime? STD { get; set; }
            public DateTime? STA { get; set; }
            public DateTime? ChocksIn { get; set; }
            public DateTime? ChocksOut { get; set; }
            public DateTime? Takeoff { get; set; }
            public DateTime? Landing { get; set; }
            public int? FlightTime { get; set; }
            public int? FlightH { get; set; }
            public int? FlightM { get; set; }
            public int? Duty { get; set; }
            public int? ActualFlightHOffBlock { get; set; }
            public int? ActualFlightMOffBlock { get; set; }
            public double? BlockTime { get; set; }
            public double? ScheduledFlightTime { get; set; }
            public double? FixTime { get; set; }
            public double? SITATime { get; set; }
            public int? FlightId { get; set; }
            public bool? IsPositioning { get; set; }

        }
        internal async Task<object> GetAppFlightsReport(DateTime dfrom, DateTime dto, int id)
        {


            var query = (from x in this.context.ViewFlightCrewNews
                         join f in this.context.ViewFlightInformations on x.FlightId equals f.ID
                         where x.CrewId == id && f.STD >= dfrom && f.STD <= dto
                         && f.FlightStatusID != 1 && f.FlightStatusID != 4
                         orderby f.STD
                         select new
                         {
                             Date = ((DateTime)f.STD),
                             x.FlightId,
                             f.FlightNumber,
                             x.Position,
                             f.FromAirportIATA,
                             f.ToAirportIATA,
                             STD = f.STD,
                             f.STA,
                             ChocksIn = f.ChocksIn,
                             ChocksOut = f.ChocksOut,
                             Takeoff = f.Takeoff,
                             Landing = f.Landing,
                             FlightTime = f.FlightH * 60 + f.FlightM,
                             f.FlightH,
                             f.FlightM,
                             Duty = 0,
                             ActualFlightHOffBlock = 0,
                             ActualFlightMOffBlock = 0,
                             f.Arrival,
                             f.Departure,
                             BlockTime = (x.IsPositioning == true ? 0 : 1) * f.BlockTime,
                             ScheduledFlightTime = (x.IsPositioning == true ? 0 : 1) * f.FlightTime,
                             FixTime = (x.IsPositioning == true || x.PositionId == 1153 ? 0 : 1) * f.FixTime,
                             SITATime = (x.IsPositioning == true ? 0 : 1) * f.SITATime,
                             x.IsPositioning
                         }).ToList();
            var result = new List<FlightTimeReport2>();
            foreach (var f in query)
            {
                var item = new FlightTimeReport2()
                {
                    ActualFlightHOffBlock = f.ActualFlightHOffBlock,
                    ActualFlightMOffBlock = f.ActualFlightMOffBlock,
                    BlockTime = f.BlockTime, //((DateTime)f.Arrival - (DateTime)f.Departure).TotalMinutes,
                    ChocksIn = f.ChocksIn,
                    ChocksOut = f.ChocksOut,
                    Date = f.Date,
                    Duty = 0,
                    FixTime = f.FixTime, //((DateTime)f.STA - (DateTime)f.STD).TotalMinutes,
                    FlightH = f.FlightH,
                    FlightM = f.FlightM,
                    FlightNumber = f.FlightNumber,
                    FlightTime = f.FlightTime,
                    FromAirportIATA = f.FromAirportIATA,
                    Landing = f.Landing,
                    Position = f.Position,
                    ScheduledFlightTime = f.ScheduledFlightTime, //((DateTime)f.STA - (DateTime)f.STD).TotalMinutes,
                    STA = f.STA,
                    STD = f.STD,
                    Takeoff = f.Takeoff,
                    ToAirportIATA = f.ToAirportIATA,
                    FlightId = f.FlightId,
                    IsPositioning = f.IsPositioning,
                    SITATime = f.SITATime,

                };
                result.Add(item);
            }

            var apts = (from x in result
                        group x by new { x.FromAirportIATA, x.ToAirportIATA } into grp
                        select new
                        {
                            route = grp.Key.FromAirportIATA + '-' + grp.Key.ToAirportIATA,
                            bl = grp.Sum(q => q.BlockTime),
                            legs = grp.Where(q => q.IsPositioning == null || q.IsPositioning == false).Count(),
                            fix = grp.Sum(q => q.FixTime),
                            dh = grp.Where(q => q.IsPositioning == true).Count(),
                            di = 0,
                            cnl = 0,
                        }).ToList();


            return new
            {
                flights = result,
                legs = result.Where(q => q.IsPositioning == null || q.IsPositioning == false).Count(),
                bl = result.Sum(q => q.BlockTime),
                fix = result.Sum(q => q.FixTime),
                dh = result.Where(q => q.IsPositioning == true).Count(),
                di = 0,
                cnl = 0,
                apts
            };
        }

        internal async Task<object> GetAppFlights2(DateTime dfrom, DateTime dto, int id, int airline, int status, int report, int from, int to)
        {
            var query = (from x in this.context.ViewFlightCrewXOffs
                         where x.CrewId == id && x.STDDay >= dfrom && x.STDDay <= dto
                         select x
                );
            if (airline != -1)
                query = query.Where(q => q.AirlineOperatorsID == airline);
            if (status != -1)
                query = query.Where(q => q.FlightStatusId == status);
            if (from != -1)
                query = query.Where(q => q.FromAirport == from);
            if (to != -1)
                query = query.Where(q => q.ToAirport == to);

            var result = await query.OrderBy(q => q.STD).ToListAsync();
            return result;
        }

        internal async Task<object> GetAppFlightsReport2(DateTime dfrom, DateTime dto, int id, int? airline = null, int? status = null, int? fromAirport = null, int? toAirport = null)
        {

            var query = (from x in this.context.ViewFlightCrewXOffs

                         where x.CrewId == id && x.STDDay >= dfrom && x.STDDay <= dto

                         //orderby x.STD
                         select x
                 );
            if (airline != null)
                query = query.Where(q => q.AirlineOperatorsID == airline);
            if (fromAirport != null)
                query = query.Where(q => q.FromAirport == fromAirport);
            if (toAirport != null)
                query = query.Where(q => q.ToAirport == toAirport);
            if (status != null)
                query = query.Where(q => q.FlightStatusId == status);

            var flights = await query.OrderByDescending(q => q.STD).ToListAsync();
            //var query = (from x in this.context.ViewFlightCrewNews
            //             join f in this.context.ViewFlightInformations on x.FlightId equals f.ID
            //             where x.CrewId == id && f.STD >= dfrom && f.STD <= dto
            //             && f.FlightStatusID != 1 && f.FlightStatusID != 4
            //             orderby f.STD
            //             select new
            //             {
            //                 Date = ((DateTime)f.STD),
            //                 x.FlightId,
            //                 f.FlightNumber,
            //                 x.Position,
            //                 f.FromAirportIATA,
            //                 f.ToAirportIATA,
            //                 STD = f.STD,
            //                 f.STA,
            //                 ChocksIn = f.ChocksIn,
            //                 ChocksOut = f.ChocksOut,
            //                 Takeoff = f.Takeoff,
            //                 Landing = f.Landing,
            //                 FlightTime = f.FlightH * 60 + f.FlightM,
            //                 f.FlightH,
            //                 f.FlightM,
            //                 Duty = 0,
            //                 ActualFlightHOffBlock = 0,
            //                 ActualFlightMOffBlock = 0,
            //                 f.Arrival,
            //                 f.Departure,
            //                 BlockTime = (x.IsPositioning == true ? 0 : 1) * f.BlockTime,
            //                 ScheduledFlightTime = (x.IsPositioning == true ? 0 : 1) * f.FlightTime,
            //                 FixTime = (x.IsPositioning == true || x.PositionId == 1153 ? 0 : 1) * f.FixTime,
            //                 SITATime = (x.IsPositioning == true ? 0 : 1) * f.SITATime,
            //                 x.IsPositioning
            //             }).ToList();
            //var result = new List<FlightTimeReport2>();
            //foreach (var f in query)
            //{
            //    var item = new FlightTimeReport2()
            //    {
            //        ActualFlightHOffBlock = f.ActualFlightHOffBlock,
            //        ActualFlightMOffBlock = f.ActualFlightMOffBlock,
            //        BlockTime = f.BlockTime, //((DateTime)f.Arrival - (DateTime)f.Departure).TotalMinutes,
            //        ChocksIn = f.ChocksIn,
            //        ChocksOut = f.ChocksOut,
            //        Date = f.Date,
            //        Duty = 0,
            //        FixTime = f.FixTime, //((DateTime)f.STA - (DateTime)f.STD).TotalMinutes,
            //        FlightH = f.FlightH,
            //        FlightM = f.FlightM,
            //        FlightNumber = f.FlightNumber,
            //        FlightTime = f.FlightTime,
            //        FromAirportIATA = f.FromAirportIATA,
            //        Landing = f.Landing,
            //        Position = f.Position,
            //        ScheduledFlightTime = f.ScheduledFlightTime, //((DateTime)f.STA - (DateTime)f.STD).TotalMinutes,
            //        STA = f.STA,
            //        STD = f.STD,
            //        Takeoff = f.Takeoff,
            //        ToAirportIATA = f.ToAirportIATA,
            //        FlightId = f.FlightId,
            //        IsPositioning = f.IsPositioning,
            //        SITATime = f.SITATime,

            //    };
            //    result.Add(item);
            //}

            var apts = (from x in flights
                        group x by new { x.FromAirportIATA, x.ToAirportIATA } into grp
                        select new
                        {
                            route = grp.Key.FromAirportIATA + '-' + grp.Key.ToAirportIATA,
                            bl = grp.Sum(q => q.BlockTime),
                            fl = grp.Sum(q => q.FlightTimeActual),
                            legs = grp.Where(q => q.IsPositioning == null || q.IsPositioning == false).Count(),
                            fix = grp.Sum(q => q.Fixtime),
                            dh = grp.Where(q => q.IsPositioning == true).Count(),
                            di = grp.Where(q => q.FlightStatusId == 17),
                            cnl = 0,
                        }).OrderBy(q => q.route).ToList();
            var airlines = from x in flights
                           group x by x.Airline into grp
                           select new
                           {
                               title = grp.Key,
                               bl = grp.Sum(q => q.BlockTime),
                               fl = grp.Sum(q => q.FlightTimeActual),
                               legs = grp.Where(q => q.IsPositioning == null || q.IsPositioning == false).Count(),
                               fix = grp.Sum(q => q.Fixtime),
                               dh = grp.Where(q => q.IsPositioning == true).Count(),
                               di = grp.Where(q => q.FlightStatusId == 17),
                               cnl = 0,
                               flights = grp.ToList(),
                               apts = (from z in grp
                                       group z by new { z.FromAirportIATA, z.ToAirportIATA } into grp2
                                       select new
                                       {
                                           route = grp2.Key.FromAirportIATA + '-' + grp2.Key.ToAirportIATA,
                                           bl = grp2.Sum(q => q.BlockTime),
                                           fl = grp2.Sum(q => q.FlightTimeActual),
                                           legs = grp2.Where(q => q.IsPositioning == null || q.IsPositioning == false).Count(),
                                           fix = grp2.Sum(q => q.Fixtime),
                                           dh = grp2.Where(q => q.IsPositioning == true).Count(),
                                           di = grp2.Where(q => q.FlightStatusId == 17),
                                           cnl = 0,
                                       }).OrderBy(q => q.route).ToList()
                           };

            return new
            {
                flights,
                legs = flights.Where(q => q.IsPositioning == null || q.IsPositioning == false).Count(),
                bl = flights.Sum(q => q.BlockTime),
                fl = flights.Sum(q => q.FlightTime),
                fix = flights.Sum(q => q.Fixtime),
                dh = flights.Where(q => q.IsPositioning == true).Count(),
                di = flights.Where(q => q.FlightStatusId == 17).Count(),
                cnl = 0,
                apts,
                airlines,
            };
        }


        public class NiraResult
        {
            public string FLIGHT { get; set; }
            public string CHTIME { get; set; }
            public string NEWAIRCRAFT { get; set; }
            public string NEWSTATUS { get; set; }


        }

        internal async Task<object> AllNira(DateTime d1, DateTime d2)
        {
            //if (ConfigurationManager.AppSettings["nira"] == "0")
            //    return true;
            var legs = await this.context.ViewLegTimes.Where(q => q.STDDay >= d1 && q.STDDay <= d2 && q.FlightStatusID == 1).OrderBy(q => q.STDLocal).ToListAsync();
            foreach (var leg in legs)
            {
                var _std = (DateTime)leg.STDLocal;
                string airline = "IV";
                var date = (_std).Year + "-" + (_std).Month.ToString().PadLeft(2, '0') + "-" + (_std).Day.ToString().PadLeft(2, '0');

                var dep = ((DateTime)leg.DepartureLocal).ToString("HH:mm");
                var depDate = ((DateTime)leg.DepartureLocal).ToString("yyyy-MM-dd");
                var arr = ((DateTime)leg.ArrivalLocal).ToString("HH:mm");
                var status = "Scheduled";
                if (leg.FlightStatusID == 4)
                    status = "Canceled";
                else if (leg.FlightStatusID == 2)
                    status = "TookOff";
                else if (leg.FlightStatusID == 3)
                    status = "Landed";
                //var duration = arr.Subtract(dep).TotalMinutes;
                //var _dep = dep.Year + "-" + dep.Month.ToString().PadLeft(2, '0') + "-" + dep.Day.ToString().PadLeft(2, '0') + "T" + dep.Hour + "%3A" + dep.Minute;
                var url2 = "http://iv.nirasoftware.com:882/NRSFlightInfo.jsp?Airline=" + airline + "&FlightNo=" + leg.FlightNumber
                    + "&Origin=" + leg.FromAirportIATA + "&Destination=" + leg.ToAirportIATA + "&FlightDate="
                    + date
                    + "&NewDepartureTime=" + dep + "&NewArrivalTime=" + arr + "&NewFlightStatus=" + status + "&NewACT=EP-" + leg.Register
                    + "&Comment=lorem_ipsum&FleetWatchKey" + leg.ID + "&SendSMS=NO&OfficeUser=" + "Thr003.airpocket" + "&OfficePass=" + "nira123";


                var url = "http://iv.nirasoftware.com:882/NRSFlightInfo.jsp?Airline=" + airline + "&FlightNo=" + leg.FlightNumber
                    + "&Origin=" + leg.FromAirportIATA + "&Destination=" + leg.ToAirportIATA + "&FlightDate="
                    + date
                    + "&NewDepartureTime=" + dep + "&NewDepartureDate=" + depDate + "&NewArrivalTime=" + arr + "&NewFlightStatus=" + status + "&NewACT=EP-" + leg.Register
                    + "&Comment=lorem_ipsum&FleetWatchKey=" + leg.ID + "&SendSMS=NO&OfficeUser=" + "Thr003.airpocket" + "&OfficePass=" + "nira123";


                try
                {
                    var result = new NiraHistory()
                    {
                        FlightId = leg.ID,
                        Arrival = leg.Arrival,
                        Departure = leg.Departure,
                        FlightStatusId = leg.FlightStatusID,
                        Register = leg.Register,
                        DateSend = DateTime.Now,
                        Remark = url
                    };
                    WebRequest request = WebRequest.Create(url);

                    request.Credentials = CredentialCache.DefaultCredentials;

                    WebResponse response = await request.GetResponseAsync();

                    Stream dataStream = response.GetResponseStream();

                    StreamReader reader = new StreamReader(dataStream);

                    string responseFromServer = reader.ReadToEnd();

                    reader.Close();
                    response.Close();

                    result.DateReplied = DateTime.Now;


                    dynamic myObject = JsonConvert.DeserializeObject<dynamic>(responseFromServer);
                    result.CHTIME = Convert.ToString(myObject.CHTIME);
                    result.FLIGHT = Convert.ToString(myObject.FLIGHT);
                    result.NEWAIRCRAFT = Convert.ToString(myObject.NEWAIRCRAFT);
                    result.NEWSTATUS = Convert.ToString(myObject.NEWSTATUS);

                    this.context.NiraHistories.Add(result);
                    var saveResult = await this.context.SaveAsync();


                }
                catch (Exception ex)
                {
                    var msg = ex.Message;
                    if (ex.InnerException != null)
                        msg += "_______" + ex.InnerException.Message;
                    return msg;

                }
            }

            return legs.Count;
        }

        internal async Task<object> NIRAFLYPERSIA()
        {
            // if (ConfigurationManager.AppSettings["nira"] == "0")
            //     return true;
            var legs = await this.context.ViewLegTimes.Where(q => q.STDDay >= new DateTime(2020, 4, 1, 0, 0, 0) && q.STDDay < new DateTime(2020, 12, 20, 0, 0, 0) && (q.FlightStatusID == 15 || q.FlightStatusID == 3)).OrderBy(q => q.STDLocal).ToListAsync();
            foreach (var leg in legs)
            {
                var _std = (DateTime)leg.STDLocal;
                string airline = "FP";
                var date = (_std).Year + "-" + (_std).Month.ToString().PadLeft(2, '0') + "-" + (_std).Day.ToString().PadLeft(2, '0');

                var dep = ((DateTime)leg.DepartureLocal).ToString("HH:mm");
                var depDate = ((DateTime)leg.DepartureLocal).ToString("yyyy-MM-dd");
                var arr = ((DateTime)leg.ArrivalLocal).ToString("HH:mm");
                var status = "Scheduled";
                if (leg.FlightStatusID == 4)
                    status = "Canceled";
                else if (leg.FlightStatusID == 2)
                    status = "TookOff";
                else if (leg.FlightStatusID == 3 || leg.FlightStatusID == 15)
                    status = "Landed";
                //var duration = arr.Subtract(dep).TotalMinutes;
                //var _dep = dep.Year + "-" + dep.Month.ToString().PadLeft(2, '0') + "-" + dep.Day.ToString().PadLeft(2, '0') + "T" + dep.Hour + "%3A" + dep.Minute;
                var url2 = "http://api.flypersia.aero/ws1/NRSFlightInfo.jsp?Airline=" + airline + "&FlightNo=" + leg.FlightNumber
                    + "&Origin=" + leg.FromAirportIATA + "&Destination=" + leg.ToAirportIATA + "&FlightDate="
                    + date
                    + "&NewDepartureTime=" + dep + "&NewArrivalTime=" + arr + "&NewFlightStatus=" + status + "&NewACT=EP-" + leg.Register
                    + "&Comment=lorem_ipsum&FleetWatchKey" + leg.ID + "&SendSMS=NO&OfficeUser=" + "Thr003.airpocket" + "&OfficePass=" + "nira123";


                var url = "http://api.flypersia.aero/ws1/NRSFlightInfo.jsp?Airline=" + airline + "&FlightNo=" + leg.FlightNumber
                    + "&Origin=" + leg.FromAirportIATA + "&Destination=" + leg.ToAirportIATA + "&FlightDate="
                    + date
                    + "&NewDepartureTime=" + dep + "&NewDepartureDate=" + depDate + "&NewArrivalTime=" + arr + "&NewFlightStatus=" + status + "&NewACT=EP-" + leg.Register
                    + "&Comment=lorem_ipsum&FleetWatchKey=" + leg.ID + "&SendSMS=NO&OfficeUser=" + "Thr003.airpocket" + "&OfficePass=" + "nira123";


                try
                {
                    var result = new NiraHistory()
                    {
                        FlightId = leg.ID,
                        Arrival = leg.Arrival,
                        Departure = leg.Departure,
                        FlightStatusId = leg.FlightStatusID,
                        Register = leg.Register,
                        DateSend = DateTime.Now,
                        Remark = url
                    };
                    WebRequest request = WebRequest.Create(url);

                    request.Credentials = CredentialCache.DefaultCredentials;

                    WebResponse response = await request.GetResponseAsync();

                    Stream dataStream = response.GetResponseStream();

                    StreamReader reader = new StreamReader(dataStream);

                    string responseFromServer = reader.ReadToEnd();

                    reader.Close();
                    response.Close();

                    result.DateReplied = DateTime.Now;


                    dynamic myObject = JsonConvert.DeserializeObject<dynamic>(responseFromServer);
                    result.CHTIME = Convert.ToString(myObject.CHTIME);
                    result.FLIGHT = Convert.ToString(myObject.FLIGHT);
                    result.NEWAIRCRAFT = Convert.ToString(myObject.NEWAIRCRAFT);
                    result.NEWSTATUS = Convert.ToString(myObject.NEWSTATUS);

                    this.context.NiraHistories.Add(result);
                    var saveResult = await this.context.SaveAsync();


                }
                catch (Exception ex)
                {
                    var msg = ex.Message;
                    if (ex.InnerException != null)
                        msg += "_______" + ex.InnerException.Message;
                    return msg;

                }
            }

            return legs.Count;
        }

        internal async Task<dynamic> NotifyNira(int id, string remark, string newregister = "")
        {
            if (ConfigurationManager.AppSettings["nira"] == "0")
                return true;
            using (var _context = new EPAGRIFFINEntities())
            {
                var _nreg = "";
                if (!string.IsNullOrEmpty(newregister))
                {
                    var _nnn = Convert.ToInt32(newregister);
                    var ennewreg = await _context.Ac_MSN.FirstOrDefaultAsync(q => q.ID == _nnn);
                    _nreg = ennewreg.Register;
                }

                var leg = await _context.ViewLegTimes.FirstOrDefaultAsync(q => q.ID == id);
                if (leg == null)
                    return false;
                if (leg.Register.ToLower().Contains("cnl"))
                    return false;
                var _std = (DateTime)leg.STDLocal;
                string airline = "IV";
                var date = (_std).Year + "-" + (_std).Month.ToString().PadLeft(2, '0') + "-" + (_std).Day.ToString().PadLeft(2, '0');
                if (leg.FlightDate != null)
                {
                    var fd = ((DateTime)leg.FlightDate).Date;
                    date = (fd).Year + "-" + (fd).Month.ToString().PadLeft(2, '0') + "-" + (fd).Day.ToString().PadLeft(2, '0');
                }


                var dep = ((DateTime)leg.DepartureLocal).ToString("HH:mm");
                var depDate = ((DateTime)leg.DepartureLocal).ToString("yyyy-MM-dd");
                var arr = ((DateTime)leg.ArrivalLocal).ToString("HH:mm");
                var status = "Scheduled";
                if (leg.FlightStatusID == 4)
                    status = "Canceled";
                else if (leg.FlightStatusID == 2)
                    status = "TookOff";
                else if (leg.FlightStatusID == 3)
                    status = "Landed";
                //var duration = arr.Subtract(dep).TotalMinutes;
                //var _dep = dep.Year + "-" + dep.Month.ToString().PadLeft(2, '0') + "-" + dep.Day.ToString().PadLeft(2, '0') + "T" + dep.Hour + "%3A" + dep.Minute;

                var atireg = !string.IsNullOrEmpty(_nreg) ? _nreg : leg.Register;
                var url = "http://iv.nirasoftware.com:882/NRSFlightInfo.jsp?Airline=" + airline + "&FlightNo=" + leg.FlightNumber
                    + "&Origin=" + leg.FromAirportIATA + "&Destination=" + leg.ToAirportIATA + "&FlightDate="
                    + date
                    + "&NewDepartureTime=" + dep + "&NewDepartureDate=" + depDate + "&NewArrivalTime=" + arr + "&NewFlightStatus=" + status + "&NewACT=EP-" + atireg
                    + "&Comment=lorem_ipsum&FleetWatchKey=" + leg.ID + "&SendSMS=false&OfficeUser=" + "Thr003.airpocket" + "&OfficePass=" + "nira123";
                try
                {
                    var result = new NiraHistory()
                    {
                        FlightId = leg.ID,
                        Arrival = leg.Arrival,
                        Departure = leg.Departure,
                        FlightStatusId = leg.FlightStatusID,
                        Register = leg.Register,
                        DateSend = DateTime.Now,
                        Remark = remark + "_" + url
                    };
                    WebRequest request = WebRequest.Create(url);

                    request.Credentials = CredentialCache.DefaultCredentials;

                    WebResponse response = await request.GetResponseAsync();

                    Stream dataStream = response.GetResponseStream();

                    StreamReader reader = new StreamReader(dataStream);

                    string responseFromServer = reader.ReadToEnd();

                    reader.Close();
                    response.Close();

                    result.DateReplied = DateTime.Now;


                    dynamic myObject = JsonConvert.DeserializeObject<dynamic>(responseFromServer);
                    result.CHTIME = Convert.ToString(myObject.CHTIME);
                    result.FLIGHT = Convert.ToString(myObject.FLIGHT);
                    result.NEWAIRCRAFT = Convert.ToString(myObject.NEWAIRCRAFT);
                    result.NEWSTATUS = Convert.ToString(myObject.NEWSTATUS);

                    _context.NiraHistories.Add(result);
                    var saveResult = await _context.SaveAsync();

                    return true;
                }
                catch (Exception ex)
                {
                    var msg = ex.Message;
                    if (ex.InnerException != null)
                        msg += "_______" + ex.InnerException.Message;
                    return new
                    {
                        MESSAGE = msg
                    };
                }
            }


        }

        internal async Task<dynamic> NotifyNira2(int id, string remark, string newregister = "", string prms = "")
        {
            if (ConfigurationManager.AppSettings["nira"] == "0")
                return true;
            var _nreg = "";
            if (!string.IsNullOrEmpty(newregister))
            {
                var _nnn = Convert.ToInt32(newregister);
                var ennewreg = await this.context.Ac_MSN.FirstOrDefaultAsync(q => q.ID == _nnn);
                _nreg = ennewreg.Register;
            }

            var leg = await this.context.ViewLegTimes.FirstOrDefaultAsync(q => q.ID == id);
            if (leg == null)
                return false;
            if (leg.Register.ToLower().Contains("cnl"))
                return false;
            var _std = (DateTime)leg.STDLocal;
            string airline = "IV";
            var date = (_std).Year + "-" + (_std).Month.ToString().PadLeft(2, '0') + "-" + (_std).Day.ToString().PadLeft(2, '0');
            var dep = ((DateTime)leg.DepartureLocal).ToString("HH:mm");
            var arr = ((DateTime)leg.ArrivalLocal).ToString("HH:mm");
            var status = "Scheduled";
            if (leg.FlightStatusID == 4)
                status = "Canceled";
            else if (leg.FlightStatusID == 2)
                status = "TookOff";
            else if (leg.FlightStatusID == 3)
                status = "Landed";
            //var duration = arr.Subtract(dep).TotalMinutes;
            //var _dep = dep.Year + "-" + dep.Month.ToString().PadLeft(2, '0') + "-" + dep.Day.ToString().PadLeft(2, '0') + "T" + dep.Hour + "%3A" + dep.Minute;

            var atireg = !string.IsNullOrEmpty(_nreg) ? _nreg : leg.Register;
            var url = "http://iv.nirasoftware.com:882/NRSFlightInfo.jsp?Airline=" + airline + "&FlightNo=" + leg.FlightNumber
                + "&Origin=" + leg.FromAirportIATA + "&Destination=" + leg.ToAirportIATA + "&FlightDate="
                + date
                + "&NewDepartureTime=" + dep + "&NewArrivalTime=" + arr + "&NewFlightStatus=" + status + "&NewACT=EP-" + atireg
                + "&Comment=lorem_ipsum&FleetWatchKey" + leg.ID + "&SendSMS=false&OfficeUser=" + "Thr003.airpocket" + "&OfficePass=" + "nira123";
            try
            {
                var result = new NiraHistory()
                {
                    FlightId = leg.ID,
                    Arrival = leg.Arrival,
                    Departure = leg.Departure,
                    FlightStatusId = leg.FlightStatusID,
                    Register = leg.Register,
                    DateSend = DateTime.Now,
                    Remark = remark + "_" + url
                };
                WebRequest request = WebRequest.Create(url);

                request.Credentials = CredentialCache.DefaultCredentials;

                WebResponse response = await request.GetResponseAsync();

                Stream dataStream = response.GetResponseStream();

                StreamReader reader = new StreamReader(dataStream);

                string responseFromServer = reader.ReadToEnd();

                reader.Close();
                response.Close();

                result.DateReplied = DateTime.Now;


                dynamic myObject = JsonConvert.DeserializeObject<dynamic>(responseFromServer);
                result.CHTIME = Convert.ToString(myObject.CHTIME);
                result.FLIGHT = Convert.ToString(myObject.FLIGHT);
                result.NEWAIRCRAFT = Convert.ToString(myObject.NEWAIRCRAFT);
                result.NEWSTATUS = Convert.ToString(myObject.NEWSTATUS);

                this.context.NiraHistories.Add(result);
                var saveResult = await this.context.SaveAsync();
                //var result = new SunFlightResult()
                //{
                //    distance_km = Convert.ToDouble(myObject.flight_segments[0].distance_km),
                //    percent_night = Convert.ToDouble(myObject.flight_segments[0].flight_stats.percent_night),
                //    total_minutes = Convert.ToDouble(myObject.flight_segments[0].flight_stats.total_minutes),
                //    total_minutes_night = Convert.ToDouble(myObject.flight_segments[0].flight_stats.total_minutes_night),
                //};
                //result.total_minutes_day = result.total_minutes - result.total_minutes_night;
                //return result;
                return true;
            }
            catch (Exception ex)
            {
                var msg = ex.Message;
                if (ex.InnerException != null)
                    msg += "_______" + ex.InnerException.Message;
                return new
                {
                    MESSAGE = msg
                };
            }

        }
        public class DelayReportPeriodic
        {
            public string Title { get; set; }
            public string Title2 { get; set; }
            public int? Current { get; set; }
            public int? Past { get; set; }
            public int? Diff { get; set; }
            public double? Percent { get; set; }
            public double? DiffPercent { get; set; }
        }
        public class DelayReportFlightSum
        {
            public double? Total { get; set; }
            public double? Seats { get; set; }
            public double? Pax { get; set; }
            public double? Freight { get; set; }
            public double? LF { get; set; }

            public double? TotalDiff { get; set; }
            public double? SeatsDiff { get; set; }
            public double? PaxDiff { get; set; }
            public double? FreightDiff { get; set; }
            public double? LFDiff { get; set; }


        }
        public async Task<object> GetDelayMapTitles()
        {
            var query = await this.context.RptDelayLegMaps.Select(q => q.MapTitle2).Distinct().ToListAsync();
            return query;
        }
        //monk
        public class AirportDelayReport
        {
            public string Airport { get; set; }
            public int? Delay { get; set; }
            public int? Delay30 { get; set; }
            public int? Cycle { get; set; }
            public double? DC30 { get; set; }
            public double? DC { get; set; }
            public double? Ratio { get; set; }
            public double? Ratio30 { get; set; }

        }

        public async Task<object> GetDelaysAirportReport(DateTime df, DateTime dt)
        {
            df = df.Date;
            dt = dt.Date;
            var query = from x in this.context.DlyGrpFlights
                        where x.STDDay >= df && x.STDDay <= dt
                        group x by x.FromAirportIATA into grp
                        select new AirportDelayReport()
                        {
                            Airport = grp.Key,
                            Delay = grp.Sum(q => q.Delay),

                        };
            var airports = await query.ToListAsync();

            var query30 = from x in this.context.DlyGrpFlights
                          where x.Delay > 30 && x.STDDay >= df && x.STDDay <= dt
                          group x by x.FromAirportIATA into grp
                          select new AirportDelayReport()
                          {
                              Airport = grp.Key,
                              Delay = grp.Sum(q => q.Delay),

                          };
            var airports30 = await query30.ToListAsync();

            var apts = airports.Select(q => q.Airport).ToList();
            var cycles = await (from x in this.context.ViewLegTimes
                                where (x.FlightStatusID == 3 || x.FlightStatusID == 15 || x.FlightStatusID == 7) && apts.Contains(x.FromAirportIATA)
                                && x.STDDay >= df && x.STDDay <= dt
                                group x by x.FromAirportIATA into grp
                                select new AirportDelayReport()
                                {
                                    Airport = grp.Key,
                                    Cycle = grp.Count()
                                }).ToListAsync();

            var total = airports.Sum(q => q.Delay);
            var total30 = airports30.Sum(q => q.Delay);

            foreach (var airport in airports)
            {
                var d30 = airports30.FirstOrDefault(q => q.Airport == airport.Airport);
                airport.Delay30 = d30 != null ? d30.Delay : 0;
                var cycle = cycles.FirstOrDefault(q => q.Airport == airport.Airport);
                airport.Cycle = cycle != null ? cycle.Cycle : 0;

                //5-7
                airport.DC = airport.Cycle == 0 ? 0 : Math.Round((double)((airport.Delay * 1.0) / airport.Cycle), 2, MidpointRounding.AwayFromZero);
                airport.DC30 = airport.Cycle == 0 ? 0 : Math.Round((double)((airport.Delay30 * 1.0) / airport.Cycle), 2, MidpointRounding.AwayFromZero);

                airport.Ratio = (airport.Delay * 1.0) / total;
                airport.Ratio30 = (airport.Delay30 * 1.0) / total30;
            }


            var result = airports.OrderByDescending(q => q.Delay30).ToList();
            return result;




        }
        public async Task<object> GetRptDelayReportPeriodic2(DateTime dto, DateTime dfrom, int period, List<string> cats)
        {
            dto = dto.Date;
            dfrom = dfrom.Date;
            period = Convert.ToInt32((dto - dfrom).TotalDays) + 1;
            var dto2 = dfrom.AddDays(-1).Date;
            var dfrom2 = dto2.AddDays(-period + 1).Date;
            var delayedFlightsCurrent = await this.context.DlyGrpFlights.Where(x => x.STDDay >= dfrom && x.STDDay <= dto).ToListAsync();
            var currentDelayedFlightsIds = delayedFlightsCurrent.Where(q => q.Delay >= 31).Select(q => q.FlightId).ToList();
            var delayedFlightsPast = await this.context.DlyGrpFlights.Where(x => x.STDDay >= dfrom2 && x.STDDay <= dto2).ToListAsync();
            var pastDelayedFlightsIds = delayedFlightsPast.Where(q => q.Delay >= 31).Select(q => q.FlightId).ToList();
            /////////////////////////////////////////////
            ///cat delays
            var query = from x in this.context.RptDelayLegMaps
                        where x.STDDay >= dfrom && x.STDDay <= dto && cats.Contains(x.MapTitle2) && currentDelayedFlightsIds.Contains(x.FlightId)
                        group x by new { x.MapTitle, x.MapTitle2 } into grp
                        select new DelayReportPeriodic()
                        {
                            Title = grp.Key.MapTitle,
                            Title2 = grp.Key.MapTitle2,
                            Current = grp.Sum(q => q.Delay),
                            Past = 0,
                            Diff = 0,
                            Percent = 0,

                        };
            var missCurrent = await (from x in this.context.RptDelayLegMaps
                                     where x.STDDay >= dfrom && x.STDDay <= dto && !cats.Contains(x.MapTitle2) && currentDelayedFlightsIds.Contains(x.FlightId)
                                     group x by true into grp
                                     select new DelayReportPeriodic()
                                     {
                                         Title = "متفرقه",
                                         Title2 = "MISCELLANEOUS",
                                         Current = grp.Sum(q => q.Delay),
                                         Past = 0,
                                         Diff = 0,
                                         Percent = 0,

                                     }).FirstOrDefaultAsync();
            var query2 = from x in this.context.RptDelayLegMaps
                         where x.STDDay >= dfrom2 && x.STDDay <= dto2 && cats.Contains(x.MapTitle2) && pastDelayedFlightsIds.Contains(x.FlightId)
                         group x by new { x.MapTitle, x.MapTitle2 } into grp
                         select new DelayReportPeriodic()
                         {
                             Title = grp.Key.MapTitle,
                             Title2 = grp.Key.MapTitle2,
                             Current = grp.Sum(q => q.Delay),
                             Past = 0,
                             Diff = 0,
                             Percent = 0,

                         };
            var missPast = await (from x in this.context.RptDelayLegMaps
                                  where x.STDDay >= dfrom2 && x.STDDay <= dto2 && !cats.Contains(x.MapTitle2) && pastDelayedFlightsIds.Contains(x.FlightId)
                                  group x by true into grp
                                  select new DelayReportPeriodic()
                                  {
                                      Title = "متفرقه",
                                      Title2 = "MISCELLANEOUS",
                                      Current = grp.Sum(q => q.Delay),
                                      Past = 0,
                                      Diff = 0,
                                      Percent = 0,

                                  }).FirstOrDefaultAsync();

            var current = await query.ToListAsync();
            var past = await query2.ToListAsync();
            var currentOther = missCurrent; //current.FirstOrDefault(q => q.Title2 == "MISCELLANEOUS");
            var pastOther = missPast; //past.FirstOrDefault(q => q.Title2 == "MISCELLANEOUS");
            if (currentOther == null)
            {
                currentOther = new DelayReportPeriodic()
                {
                    Current = 0,
                    Diff = 0,
                    Past = 0,
                    Percent = 0,
                    Title = "متفرقه",
                    Title2 = "MISCELLANEOUS"
                };

            }
            current.Add(currentOther);

            if (pastOther == null)
            {
                pastOther = new DelayReportPeriodic()
                {
                    Current = 0,
                    Diff = 0,
                    Past = 0,
                    Percent = 0,
                    Title = "متفرقه",
                    Title2 = "MISCELLANEOUS"
                };

            }
            past.Add(pastOther);

            foreach (var c in current)
            {
                var cat = cats.FirstOrDefault(w => w == c.Title2);
                if (cat == null && c.Title2 != "MISCELLANEOUS")
                {
                    currentOther.Current += c.Current;
                    c.Current = -1;

                }

            }
            foreach (var c in past)
            {
                var cat = cats.FirstOrDefault(w => w == c.Title2);
                if (cat == null && c.Title2 != "MISCELLANEOUS")
                {
                    pastOther.Current += c.Current;
                    c.Current = -1;

                }

            }

            foreach (var cat in cats)
            {
                var xc = current.FirstOrDefault(q => q.Title2 == cat);
                var xp = past.FirstOrDefault(q => q.Title2 == cat);
                if (xc == null)
                {
                    current.Add(new DelayReportPeriodic()
                    {
                        Current = 0,
                        Diff = 0,
                        Past = 0,
                        Percent = 0,
                        Title2 = cat,

                    });
                }
                if (xp == null)
                {
                    past.Add(new DelayReportPeriodic()
                    {
                        Current = 0,
                        Diff = 0,
                        Past = 0,
                        Percent = 0,
                        Title2 = cat,

                    });
                }

            }

            current = current.Where(q => q.Current != -1).ToList();
            past = past.Where(q => q.Current != -1).ToList();
            var totalCurrent = current.Sum(q => q.Current);
            foreach (var x in current)
            {
                x.Percent = Math.Round((double)(x.Current * 100.0 / totalCurrent), 2, MidpointRounding.AwayFromZero);
                var pst = past.FirstOrDefault(q => q.Title2 == x.Title2);
                if (pst == null || pst.Current == 0)
                {
                    x.Diff = x.Current;
                    x.DiffPercent = 100;
                    x.Past = 0;
                }
                else
                {
                    x.Past = pst.Current;
                    x.Diff = x.Current - pst.Current;
                    x.DiffPercent = Math.Round((double)(x.Diff * 100.0 / pst.Current), 2, MidpointRounding.AwayFromZero);
                }

            }
            ////////////////////////////////////


            var flight = await (from x in this.context.C_ViewLegTime
                                where (x.FlightStatusID == 3 || x.FlightStatusID == 15) && x.STDDay >= dfrom && x.STDDay <= dto
                                group x by true into grp
                                select new DelayReportFlightSum()
                                {
                                    Total = grp.Count(),
                                    Pax = grp.Sum(q => q.PaxInfant + q.PaxAdult + q.PaxChild),
                                    Seats = grp.Sum(q => q.TotalSeat),
                                    Freight = grp.Sum(q => q.Freight)
                                }).FirstOrDefaultAsync();
            flight.LF = Math.Round((double)(flight.Pax * 100.0 / flight.Seats), 2, MidpointRounding.AwayFromZero);

            var flightPast = await (from x in this.context.C_ViewLegTime
                                    where (x.FlightStatusID == 3 || x.FlightStatusID == 15) && x.STDDay >= dfrom2 && x.STDDay <= dto2
                                    group x by true into grp
                                    select new DelayReportFlightSum()
                                    {
                                        Total = grp.Count(),
                                        Pax = grp.Sum(q => q.PaxInfant + q.PaxAdult + q.PaxChild),
                                        Seats = grp.Sum(q => q.TotalSeat),
                                        Freight = grp.Sum(q => q.Freight),

                                    }).FirstOrDefaultAsync();
            flightPast.LF = Math.Round((double)(flight.Pax * 100.0 / flight.Seats), 2, MidpointRounding.AwayFromZero);

            flight.TotalDiff = flightPast.Total == 0 ? 100 : Math.Round((double)((flight.Total - flightPast.Total) * 100.0 / flightPast.Total), 2, MidpointRounding.AwayFromZero);
            flight.PaxDiff = flightPast.Pax == 0 ? 100 : Math.Round((double)((flight.Pax - flightPast.Pax) * 100.0 / flightPast.Pax), 2, MidpointRounding.AwayFromZero);
            flight.SeatsDiff = flightPast.Seats == 0 ? 100 : Math.Round((double)((flight.Seats - flightPast.Seats) * 100.0 / flightPast.Seats), 2, MidpointRounding.AwayFromZero);
            flight.FreightDiff = flightPast.Freight == 0 ? 100 : Math.Round((double)((flight.Freight - flightPast.Freight) * 100.0 / flightPast.Freight), 2, MidpointRounding.AwayFromZero);
            flight.LFDiff = flightPast.LF == 0 ? 100 : Math.Round((double)((flight.LF - flightPast.LF) * 100.0 / flightPast.LF), 2, MidpointRounding.AwayFromZero);
            //////////////////////////////////////////
            var currentTotalFlights = flight.Total;

            var pastTotalFlights = flightPast.Total;
            //////////////////////////////////////////
            //var OnTime = 0;// await this.context.SumFlightDelays.Where(q => q.STDDay >= dfrom && q.STDDay <= dto && q.Delay <= 30).CountAsync();
            var D3160 = delayedFlightsCurrent.Where(q => q.Delay >= 31 && q.Delay <= 60).Count();
            var D61120 = delayedFlightsCurrent.Where(q => q.Delay >= 61 && q.Delay <= 120).Count();
            var D121180 = delayedFlightsCurrent.Where(q => q.Delay >= 121 && q.Delay <= 180).Count();
            var D181 = delayedFlightsCurrent.Where(q => q.Delay >= 181).Count();
            var DelayedTotalCurrent = D3160 + D61120 + D121180 + D181;
            var OnTime = currentTotalFlights - DelayedTotalCurrent;

            // var pastOnTime = 0;// await this.context.SumFlightDelays.Where(q => q.STDDay >= dfrom && q.STDDay <= dto && q.Delay <= 30).CountAsync();
            var pastD3160 = delayedFlightsPast.Where(q => q.Delay >= 31 && q.Delay <= 60).Count();
            var pastD61120 = delayedFlightsPast.Where(q => q.Delay >= 61 && q.Delay <= 120).Count();
            var pastD121180 = delayedFlightsPast.Where(q => q.Delay >= 121 && q.Delay <= 180).Count();
            var pastD181 = delayedFlightsPast.Where(q => q.Delay >= 181).Count();
            var DelayedTotalPast = pastD3160 + pastD61120 + pastD121180 + pastD181;
            var pastOnTime = pastTotalFlights - DelayedTotalPast;

            //await this.context.SumFlightDelays.Where(q => q.STDDay >= dfrom && q.STDDay <= dto && (q.Delay >= 181)).CountAsync();
            ///////////////////////////////////////////

            var totalDelay = delayedFlightsCurrent.Sum(q => q.Delay);



            var result = new
            {
                delayedFlights = new
                {
                    OnTime,
                    D3160,
                    D61120,
                    D121180,
                    D181,
                    pastOnTime,
                    pastD3160,
                    pastD61120,
                    pastD121180,
                    pastD181,
                    OnTimePercent = Math.Round((double)(OnTime * 100.0 / currentTotalFlights), 2, MidpointRounding.AwayFromZero),
                    D3160Percent = Math.Round((double)(D3160 * 100.0 / currentTotalFlights), 2, MidpointRounding.AwayFromZero),
                    D61120Percent = Math.Round((double)(D61120 * 100.0 / currentTotalFlights), 2, MidpointRounding.AwayFromZero),
                    D121180Percent = Math.Round((double)(D121180 * 100.0 / currentTotalFlights), 2, MidpointRounding.AwayFromZero),
                    D181Percent = Math.Round((double)(D181 * 100.0 / currentTotalFlights), 2, MidpointRounding.AwayFromZero),
                    OnTimeDiff = Math.Round((double)((OnTime - pastOnTime) * 100.0 / pastOnTime), 2, MidpointRounding.AwayFromZero),
                    D3160Diff = Math.Round((double)((D3160 - pastD3160) * 100.0 / pastD3160), 2, MidpointRounding.AwayFromZero),
                    D61120Diff = Math.Round((double)((D61120 - pastD61120) * 100.0 / pastD61120), 2, MidpointRounding.AwayFromZero),
                    D121180Diff = Math.Round((double)((D121180 - pastD121180) * 100.0 / pastD121180), 2, MidpointRounding.AwayFromZero),
                    D181Diff = Math.Round((double)((D181 - pastD181) * 100.0 / pastD181), 2, MidpointRounding.AwayFromZero),
                    DelayedCount = D3160 + D61120 + D121180 + D181,
                    DelayedCountPercent = 100 - Math.Round((double)(OnTime * 100.0 / currentTotalFlights), 2, MidpointRounding.AwayFromZero),


                },
                currentFrom = dfrom,
                currentTo = dto,
                pastFrom = dfrom2,
                pastTo = dto2,

                totalDelay,
                delays = current.OrderByDescending(q => q.Current).ToList(),
                delay = current.Sum(q => q.Current),
                dl = Math.Round((double)(current.Sum(q => q.Current) / flight.Total), 0, MidpointRounding.AwayFromZero),
                delayTotal = totalDelay,
                dlTotal = Math.Round((double)(totalDelay / flight.Total), 0, MidpointRounding.AwayFromZero),
                flight,
                flightPast,

            };

            return result;
        }
        public async Task<object> GetRptDelayReportPeriodic(DateTime dto, DateTime dfrom, int period, List<string> cats)
        {
            dto = dto.Date;
            dfrom = dfrom.Date;
            period = Convert.ToInt32((dto - dfrom).TotalDays) + 1;
            var dto2 = dfrom.AddDays(-1).Date;
            var dfrom2 = dto2.AddDays(-period + 1).Date;
            var query = from x in this.context.RptDelayLegMaps
                        where x.STDDay >= dfrom && x.STDDay <= dto && cats.Contains(x.MapTitle2)
                        group x by new { x.MapTitle, x.MapTitle2 } into grp
                        select new DelayReportPeriodic()
                        {
                            Title = grp.Key.MapTitle,
                            Title2 = grp.Key.MapTitle2,
                            Current = grp.Sum(q => q.Delay),
                            Past = 0,
                            Diff = 0,
                            Percent = 0,

                        };

            var query2 = from x in this.context.RptDelayLegMaps
                         where x.STDDay >= dfrom2 && x.STDDay <= dto2 && cats.Contains(x.MapTitle2)
                         group x by new { x.MapTitle, x.MapTitle2 } into grp
                         select new DelayReportPeriodic()
                         {
                             Title = grp.Key.MapTitle,
                             Title2 = grp.Key.MapTitle2,
                             Current = grp.Sum(q => q.Delay),
                             Past = 0,
                             Diff = 0,
                             Percent = 0,

                         };
            var missCurrent = await (from x in this.context.RptDelayLegMaps
                                     where x.STDDay >= dfrom && x.STDDay <= dto && !cats.Contains(x.MapTitle2) && x.Delay > 30
                                     group x by true into grp
                                     select new DelayReportPeriodic()
                                     {
                                         Title = "متفرقه",
                                         Title2 = "MISCELLANEOUS",
                                         Current = grp.Sum(q => q.Delay),
                                         Past = 0,
                                         Diff = 0,
                                         Percent = 0,

                                     }).FirstOrDefaultAsync();

            var missPast = await (from x in this.context.RptDelayLegMaps
                                  where x.STDDay >= dfrom2 && x.STDDay <= dto2 && !cats.Contains(x.MapTitle2) && x.Delay > 30
                                  group x by true into grp
                                  select new DelayReportPeriodic()
                                  {
                                      Title = "متفرقه",
                                      Title2 = "MISCELLANEOUS",
                                      Current = grp.Sum(q => q.Delay),
                                      Past = 0,
                                      Diff = 0,
                                      Percent = 0,

                                  }).FirstOrDefaultAsync();

            var current = await query.ToListAsync();
            var past = await query2.ToListAsync();
            var currentOther = missCurrent; //current.FirstOrDefault(q => q.Title2 == "MISCELLANEOUS");
            var pastOther = missPast; //past.FirstOrDefault(q => q.Title2 == "MISCELLANEOUS");
            if (currentOther == null)
            {
                currentOther = new DelayReportPeriodic()
                {
                    Current = 0,
                    Diff = 0,
                    Past = 0,
                    Percent = 0,
                    Title = "متفرقه",
                    Title2 = "MISCELLANEOUS"
                };

            }
            current.Add(currentOther);

            if (pastOther == null)
            {
                pastOther = new DelayReportPeriodic()
                {
                    Current = 0,
                    Diff = 0,
                    Past = 0,
                    Percent = 0,
                    Title = "متفرقه",
                    Title2 = "MISCELLANEOUS"
                };

            }
            past.Add(pastOther);

            foreach (var c in current)
            {
                var cat = cats.FirstOrDefault(w => w == c.Title2);
                if (cat == null && c.Title2 != "MISCELLANEOUS")
                {
                    currentOther.Current += c.Current;
                    c.Current = -1;

                }

            }
            foreach (var c in past)
            {
                var cat = cats.FirstOrDefault(w => w == c.Title2);
                if (cat == null && c.Title2 != "MISCELLANEOUS")
                {
                    pastOther.Current += c.Current;
                    c.Current = -1;

                }

            }

            foreach (var cat in cats)
            {
                var xc = current.FirstOrDefault(q => q.Title2 == cat);
                var xp = past.FirstOrDefault(q => q.Title2 == cat);
                if (xc == null)
                {
                    current.Add(new DelayReportPeriodic()
                    {
                        Current = 0,
                        Diff = 0,
                        Past = 0,
                        Percent = 0,
                        Title2 = cat,

                    });
                }
                if (xp == null)
                {
                    past.Add(new DelayReportPeriodic()
                    {
                        Current = 0,
                        Diff = 0,
                        Past = 0,
                        Percent = 0,
                        Title2 = cat,

                    });
                }

            }

            current = current.Where(q => q.Current != -1).ToList();
            past = past.Where(q => q.Current != -1).ToList();
            var totalCurrent = current.Sum(q => q.Current);
            foreach (var x in current)
            {
                x.Percent = Math.Round((double)(x.Current * 100.0 / totalCurrent), 2, MidpointRounding.AwayFromZero);
                var pst = past.FirstOrDefault(q => q.Title2 == x.Title2);
                if (pst == null || pst.Current == 0)
                {
                    x.Diff = x.Current;
                    x.DiffPercent = 100;
                    x.Past = 0;
                }
                else
                {
                    x.Past = pst.Current;
                    x.Diff = x.Current - pst.Current;
                    x.DiffPercent = Math.Round((double)(x.Diff * 100.0 / pst.Current), 2, MidpointRounding.AwayFromZero);
                }

            }

            var OnTime = await this.context.SumFlightDelays.Where(q => q.STDDay >= dfrom && q.STDDay <= dto && q.Delay <= 30).CountAsync();
            var D3160 = await this.context.SumFlightDelays.Where(q => q.STDDay >= dfrom && q.STDDay <= dto && (q.Delay >= 31 && q.Delay <= 60)).CountAsync();
            var D61120 = await this.context.SumFlightDelays.Where(q => q.STDDay >= dfrom && q.STDDay <= dto && (q.Delay >= 61 && q.Delay <= 120)).CountAsync();
            var D121180 = await this.context.SumFlightDelays.Where(q => q.STDDay >= dfrom && q.STDDay <= dto && (q.Delay >= 121 && q.Delay <= 180)).CountAsync();
            var D181 = await this.context.SumFlightDelays.Where(q => q.STDDay >= dfrom && q.STDDay <= dto && (q.Delay >= 181)).CountAsync();

            var totalDelay = await this.context.SumFlightDelays.Where(q => q.STDDay >= dfrom && q.STDDay <= dto).SumAsync(q => q.Delay);

            var pastOnTime = await this.context.SumFlightDelays.Where(q => q.STDDay >= dfrom2 && q.STDDay <= dto2 && q.Delay <= 30).CountAsync();
            var pastD3160 = await this.context.SumFlightDelays.Where(q => q.STDDay >= dfrom2 && q.STDDay <= dto2 && (q.Delay >= 31 && q.Delay <= 60)).CountAsync();
            var pastD61120 = await this.context.SumFlightDelays.Where(q => q.STDDay >= dfrom2 && q.STDDay <= dto2 && (q.Delay >= 61 && q.Delay <= 120)).CountAsync();
            var pastD121180 = await this.context.SumFlightDelays.Where(q => q.STDDay >= dfrom2 && q.STDDay <= dto2 && (q.Delay >= 121 && q.Delay <= 180)).CountAsync();
            var pastD181 = await this.context.SumFlightDelays.Where(q => q.STDDay >= dfrom2 && q.STDDay <= dto2 && (q.Delay >= 181)).CountAsync();

            var currentTotalFlights = await this.context.SumFlightDelays.Where(q => q.STDDay >= dfrom && q.STDDay <= dto).CountAsync();

            var flight = await (from x in this.context.ViewLegTimes
                                where (x.FlightStatusID == 3 || x.FlightStatusID == 15) && x.STDDay >= dfrom && x.STDDay <= dto
                                group x by true into grp
                                select new DelayReportFlightSum()
                                {
                                    Total = grp.Count(),
                                    Pax = grp.Sum(q => q.PaxInfant + q.PaxAdult + q.PaxChild),
                                    Seats = grp.Sum(q => q.TotalSeat),
                                    Freight = grp.Sum(q => q.Freight)
                                }).FirstOrDefaultAsync();
            flight.LF = Math.Round((double)(flight.Pax * 100.0 / flight.Seats), 2, MidpointRounding.AwayFromZero);

            var flightPast = await (from x in this.context.ViewLegTimes
                                    where (x.FlightStatusID == 3 || x.FlightStatusID == 15) && x.STDDay >= dfrom2 && x.STDDay <= dto2
                                    group x by true into grp
                                    select new DelayReportFlightSum()
                                    {
                                        Total = grp.Count(),
                                        Pax = grp.Sum(q => q.PaxInfant + q.PaxAdult + q.PaxChild),
                                        Seats = grp.Sum(q => q.TotalSeat),
                                        Freight = grp.Sum(q => q.Freight),

                                    }).FirstOrDefaultAsync();
            flightPast.LF = Math.Round((double)(flight.Pax * 100.0 / flight.Seats), 2, MidpointRounding.AwayFromZero);

            flight.TotalDiff = flightPast.Total == 0 ? 100 : Math.Round((double)((flight.Total - flightPast.Total) * 100.0 / flightPast.Total), 2, MidpointRounding.AwayFromZero);
            flight.PaxDiff = flightPast.Pax == 0 ? 100 : Math.Round((double)((flight.Pax - flightPast.Pax) * 100.0 / flightPast.Pax), 2, MidpointRounding.AwayFromZero);
            flight.SeatsDiff = flightPast.Seats == 0 ? 100 : Math.Round((double)((flight.Seats - flightPast.Seats) * 100.0 / flightPast.Seats), 2, MidpointRounding.AwayFromZero);
            flight.FreightDiff = flightPast.Freight == 0 ? 100 : Math.Round((double)((flight.Freight - flightPast.Freight) * 100.0 / flightPast.Freight), 2, MidpointRounding.AwayFromZero);
            flight.LFDiff = flightPast.LF == 0 ? 100 : Math.Round((double)((flight.LF - flightPast.LF) * 100.0 / flightPast.LF), 2, MidpointRounding.AwayFromZero);


            var result = new
            {
                delayedFlights = new
                {
                    OnTime,
                    D3160,
                    D61120,
                    D121180,
                    D181,
                    pastOnTime,
                    pastD3160,
                    pastD61120,
                    pastD121180,
                    pastD181,
                    OnTimePercent = Math.Round((double)(OnTime * 100.0 / currentTotalFlights), 2, MidpointRounding.AwayFromZero),
                    D3160Percent = Math.Round((double)(D3160 * 100.0 / currentTotalFlights), 2, MidpointRounding.AwayFromZero),
                    D61120Percent = Math.Round((double)(D61120 * 100.0 / currentTotalFlights), 2, MidpointRounding.AwayFromZero),
                    D121180Percent = Math.Round((double)(D121180 * 100.0 / currentTotalFlights), 2, MidpointRounding.AwayFromZero),
                    D181Percent = Math.Round((double)(D121180 * 100.0 / currentTotalFlights), 2, MidpointRounding.AwayFromZero),
                    OnTimeDiff = Math.Round((double)((OnTime - pastOnTime) * 100.0 / pastOnTime), 2, MidpointRounding.AwayFromZero),
                    D3160Diff = Math.Round((double)((D3160 - pastD3160) * 100.0 / pastD3160), 2, MidpointRounding.AwayFromZero),
                    D61120Diff = Math.Round((double)((D61120 - pastD61120) * 100.0 / pastD61120), 2, MidpointRounding.AwayFromZero),
                    D121180Diff = Math.Round((double)((D121180 - pastD121180) * 100.0 / pastD121180), 2, MidpointRounding.AwayFromZero),
                    D181Diff = Math.Round((double)((D181 - pastD181) * 100.0 / pastD181), 2, MidpointRounding.AwayFromZero),
                    DelayedCount = D3160 + D61120 + D121180 + D181,
                    DelayedCountPercent = 100 - Math.Round((double)(OnTime * 100.0 / currentTotalFlights), 2, MidpointRounding.AwayFromZero),


                },
                currentFrom = dfrom,
                currentTo = dto,
                pastFrom = dfrom2,
                pastTo = dto2,
                // totalDelay=totalCurrent,
                totalDelay,
                delays = current.OrderByDescending(q => q.Current).ToList(),
                delay = current.Sum(q => q.Current),
                dl = Math.Round((double)(current.Sum(q => q.Current) / flight.Total), 0, MidpointRounding.AwayFromZero),
                delayTotal = totalDelay,
                dlTotal = Math.Round((double)(totalDelay / flight.Total), 0, MidpointRounding.AwayFromZero),
                flight,
                flightPast,

            };
            return result;
        }


        public async Task<object> GetRptDelayReportFlightSummary(DateTime dto, DateTime dfrom)
        {
            dto = dto.Date;
            dfrom = dfrom.Date;

            //magu6
            var delayedFlightsCurrent = await this.context.DlyGrpFlights.Where(x => x.STDDay >= dfrom && x.STDDay <= dto).ToListAsync();

            //var OnTime = await this.context.SumFlightDelays.Where(q => q.STDDay >= dfrom && q.STDDay <= dto && q.Delay <= 30).CountAsync();
            var D3160 = delayedFlightsCurrent.Where(q => q.Delay >= 31 && q.Delay <= 60).Count(); //await this.context.SumFlightDelays.Where(q => q.STDDay >= dfrom && q.STDDay <= dto && (q.Delay >= 31 && q.Delay <= 60)).CountAsync();
            var D61120 = delayedFlightsCurrent.Where(q => q.Delay >= 61 && q.Delay <= 120).Count(); //await this.context.SumFlightDelays.Where(q => q.STDDay >= dfrom && q.STDDay <= dto && (q.Delay >= 61 && q.Delay <= 120)).CountAsync();
            var D121180 = delayedFlightsCurrent.Where(q => q.Delay >= 121 && q.Delay <= 180).Count();//await this.context.SumFlightDelays.Where(q => q.STDDay >= dfrom && q.STDDay <= dto && (q.Delay >= 121 && q.Delay <= 180)).CountAsync();
            var D181 = delayedFlightsCurrent.Where(q => q.Delay >= 181).Count(); // await this.context.SumFlightDelays.Where(q => q.STDDay >= dfrom && q.STDDay <= dto && (q.Delay >= 181)).CountAsync();

            var totalDelay = delayedFlightsCurrent.Sum(q => q.Delay);


            var currentTotalFlights = await this.context.SumFlightDelays.Where(q => q.STDDay >= dfrom && q.STDDay <= dto).CountAsync();
            var OnTime = currentTotalFlights - D181 - D121180 - D61120 - D3160;

            var flight = await (from x in this.context.ViewLegTimes
                                where (x.FlightStatusID == 3 || x.FlightStatusID == 15) && x.STDDay >= dfrom && x.STDDay <= dto
                                group x by true into grp
                                select new DelayReportFlightSum()
                                {
                                    Total = grp.Count(),
                                    Pax = grp.Sum(q => q.PaxInfant + q.PaxAdult + q.PaxChild),
                                    Seats = grp.Sum(q => q.TotalSeat),
                                    Freight = grp.Sum(q => q.Freight)
                                }).FirstOrDefaultAsync();
            if (flight != null)
            {
                flight.Freight = Math.Round((double)flight.Freight * 1.0 / 1000, 2, MidpointRounding.AwayFromZero);
                flight.LF = Math.Round((double)(flight.Pax * 100.0 / flight.Seats), 2, MidpointRounding.AwayFromZero);
            }
            else
            {
                flight = new DelayReportFlightSum()
                {
                    Total = 0,
                    Pax = 0,
                    Seats = 0,
                    Freight = 0,
                };
            }






            var result = new
            {
                delayedFlights = new
                {
                    OnTime,
                    D3160,
                    D61120,
                    D121180,
                    D181,

                    OnTimePercent = Math.Round((double)(OnTime * 100.0 / currentTotalFlights), 2, MidpointRounding.AwayFromZero),
                    D3160Percent = Math.Round((double)(D3160 * 100.0 / currentTotalFlights), 2, MidpointRounding.AwayFromZero),
                    D61120Percent = Math.Round((double)(D61120 * 100.0 / currentTotalFlights), 2, MidpointRounding.AwayFromZero),
                    D121180Percent = Math.Round((double)(D121180 * 100.0 / currentTotalFlights), 2, MidpointRounding.AwayFromZero),
                    D181Percent = Math.Round((double)(D121180 * 100.0 / currentTotalFlights), 2, MidpointRounding.AwayFromZero),

                    DelayedCount = D3160 + D61120 + D121180 + D181,
                    DelayedCountPercent = 100 - Math.Round((double)(OnTime * 100.0 / currentTotalFlights), 2, MidpointRounding.AwayFromZero),


                },
                currentFrom = dfrom,
                currentTo = dto,

                // totalDelay=totalCurrent,
                totalDelay,

                delayTotal = totalDelay,
                dlTotal = flight.Total == 0 ? 0 : Math.Round((double)(totalDelay / flight.Total), 0, MidpointRounding.AwayFromZero),
                flight,


            };
            return result;
        }

        internal async Task<object> UpdateAti(int id, int offset, string std = "", string sta = "", string offblock = "", string onblock = "", string takeoff = "", string landing = "")
        {
            var flight = await this.context.FlightInformations.Where(q => q.ID == id).FirstOrDefaultAsync();
            if (flight == null)
                return null;
            var _std = string.IsNullOrEmpty(std) ? null : (Nullable<DateTime>)new DateTime(Convert.ToInt32(std.Substring(0, 4)), Convert.ToInt32(std.Substring(4, 2)), Convert.ToInt32(std.Substring(6, 2)), Convert.ToInt32(std.Substring(8, 2)), Convert.ToInt32(std.Substring(10, 2)), 0);
            var _sta = string.IsNullOrEmpty(sta) ? null : (Nullable<DateTime>)new DateTime(Convert.ToInt32(sta.Substring(0, 4)), Convert.ToInt32(sta.Substring(4, 2)), Convert.ToInt32(sta.Substring(6, 2)), Convert.ToInt32(sta.Substring(8, 2)), Convert.ToInt32(sta.Substring(10, 2)), 0);
            var _off = string.IsNullOrEmpty(offblock) ? null : (Nullable<DateTime>)new DateTime(Convert.ToInt32(offblock.Substring(0, 4)), Convert.ToInt32(offblock.Substring(4, 2)), Convert.ToInt32(offblock.Substring(6, 2)), Convert.ToInt32(offblock.Substring(8, 2)), Convert.ToInt32(offblock.Substring(10, 2)), 0);
            var _on = string.IsNullOrEmpty(onblock) ? null : (Nullable<DateTime>)new DateTime(Convert.ToInt32(onblock.Substring(0, 4)), Convert.ToInt32(onblock.Substring(4, 2)), Convert.ToInt32(onblock.Substring(6, 2)), Convert.ToInt32(onblock.Substring(8, 2)), Convert.ToInt32(onblock.Substring(10, 2)), 0);
            var _takeoff = string.IsNullOrEmpty(takeoff) ? null : (Nullable<DateTime>)new DateTime(Convert.ToInt32(takeoff.Substring(0, 4)), Convert.ToInt32(takeoff.Substring(4, 2)), Convert.ToInt32(takeoff.Substring(6, 2)), Convert.ToInt32(takeoff.Substring(8, 2)), Convert.ToInt32(takeoff.Substring(10, 2)), 0);
            var _landing = string.IsNullOrEmpty(landing) ? null : (Nullable<DateTime>)new DateTime(Convert.ToInt32(landing.Substring(0, 4)), Convert.ToInt32(landing.Substring(4, 2)), Convert.ToInt32(landing.Substring(6, 2)), Convert.ToInt32(landing.Substring(8, 2)), Convert.ToInt32(landing.Substring(10, 2)), 0);

            if (_std != null)
                flight.STD = ((DateTime)_std).AddMinutes(offset);
            if (_sta != null)
                flight.STA = ((DateTime)_sta).AddMinutes(offset);
            if (_off != null)
                flight.ChocksOut = ((DateTime)_off).AddMinutes(offset);
            if (_on != null)
                flight.ChocksIn = ((DateTime)_on).AddMinutes(offset);
            if (_takeoff != null)
                flight.Takeoff = ((DateTime)_takeoff).AddMinutes(offset);
            if (_landing != null)
                flight.Landing = ((DateTime)_landing).AddMinutes(offset);
            await this.context.SaveChangesAsync();

            return flight;

        }
        //internal virtual CustomActionResult CanDelete(Ac_MSN entity)
        //{
        //    return new CustomActionResult(HttpStatusCode.OK, "");
        //}

        internal async Task<object> GetFinMonthlyReport(int yf, int yt)
        {
            var total = await this.context.ViewFinMonthlies.Where(q => q.Year >= yf && q.Year <= yt).OrderBy(q => q.Year).ThenBy(q => q.Month).ToListAsync();
            var route = await this.context.ViewFinMonthlyRoutes.Where(q => q.Year >= yf && q.Year <= yt).OrderBy(q => q.Year).ThenBy(q => q.Month).ThenBy(q => q.Route).ToListAsync();
            var reg = await this.context.ViewFinMonthlyRegs.Where(q => q.Year >= yf && q.Year <= yt).OrderBy(q => q.Year).ThenBy(q => q.Month).ThenBy(q => q.Register).ToListAsync();
            var routereg = await this.context.ViewFinMonthlyRouteRegs.Where(q => q.Year >= yf && q.Year <= yt).OrderBy(q => q.Year).ThenBy(q => q.Month).ThenBy(q => q.Route).ThenBy(q => q.Register).ToListAsync();
            return new
            {
                total,
                route,
                reg,
                routereg
            };
        }

        string getMonthName(int i)
        {
            switch (i)
            {
                case 1:
                    return "فروردین";
                case 2:
                    return "اردیبهشت";
                case 3:
                    return "خرداد";
                case 4:
                    return "تیر";
                case 5:
                    return "مرداد";
                case 6:
                    return "شهریور";
                case 7:
                    return "مهر";
                case 8:
                    return "آبان";
                case 9:
                    return "آذر";
                case 10:
                    return "دی";
                case 11:
                    return "بهمن";
                case 12:
                    return "اسفند";
                default:
                    return "-";
            }
        }
        //GetFlightMonthlyReport
        internal async Task<object> GetFlightMonthlyReport(int year)
        {

            var totalQuery = this.context.ViewRegHistoryYearlies.Where(q => q.Year == year);

            var total = await totalQuery.OrderBy(q => q.Year)
                .ThenBy(q => q.Month)

                .ToListAsync();
            for (int i = 1; i <= 12; i++)
            {
                var exist = total.FirstOrDefault(q => q.Month == i);
                if (exist == null)
                    total.Add(new ViewRegHistoryYearly()
                    {
                        Adult = 0,
                        BlockTime = 0,
                        Month = i,
                        BtLeg = 0,
                        PaxLeg = 0,
                        Child = 0,
                        FlightTime = 0,
                        FtLeg = 0,
                        Infant = 0,
                        Legs = 0,
                        MonthName = getMonthName(i),
                        TotalPax = 0,
                        TotalPaxAll = 0,
                        TotalSeat = 0,
                        Year = year,
                        YearMonth = "",
                        YearName = year.ToString()
                    });

            }

            total = total.OrderBy(q => q.Year).ThenBy(q => q.Month).ToList();
            return new
            {

                total
            };
        }
        internal async Task<object> GetRegFlightMonthlyReport(int year, int month, string fleet)
        {
            var details = await this.context.ViewRegHistories.Where(q => q.PYear == year && q.PMonth == month)
               .OrderBy(q => q.PYear).ThenBy(q => q.PMonth)
               .ThenBy(q => q.AircraftType).ThenBy(q => q.Register).ThenBy(q => q.STD)
               .Select(q => new
               {
                   q.Fleet,
                   q.AircraftType,
                   q.TypeId,
                   q.Register,
                   q.RegisterID,
                   q.BlockTime,
                   q.FlightTimeActual,
                   q.PDate,
                   q.STDDay,
                   q.FlightNumber,
                   q.OffBlockLocal,
                   q.OnBlockLocal,
                   q.TakeoffLocal,
                   q.LandingLocal,
                   q.PaxTotal,

               })
               .ToListAsync();
            var totalQuery = this.context.ViewRegHistoryMonthlies.Where(q => q.Year == year && q.Month == month);
            if (fleet != "All Fleets")
            {
                totalQuery = totalQuery.Where(q => q.Fleet == fleet);
            }
            var total = await totalQuery.OrderBy(q => q.Year)
                .ThenBy(q => q.Month)
                .ThenBy(q => q.Fleet)
                .ThenBy(q => q.Register)
                .ToListAsync();
            return new
            {
                details,
                total
            };
        }

        //internal async Task<object> GetCrewFixTimeMonthlyReport(int year, int month, string rank)
        //{


        //    var query = from x in this.context.RptFDPMonthlyPersians
        //                where x.PYear == year && x.PMonth == month
        //                select x;
        //    switch (rank)
        //    {
        //        case "All":
        //            break;
        //        case "Cockpit":
        //            query = query.Where(q => q.JobGroup == "TRE" || q.JobGroup == "TRI" || q.JobGroup == "LTC" || q.JobGroup == "P1" || q.JobGroup == "P2");
        //            break;
        //        case "Cabin":
        //            query = query.Where(q => q.JobGroup == "ISCCM" || q.JobGroup == "SCCM" || q.JobGroup == "CCM");
        //            break;
        //        case "IP":
        //            query = query.Where(q => q.JobGroup == "TRE" || q.JobGroup == "TRI" || q.JobGroup == "LTC");
        //            break;
        //        case "P1":
        //            query = query.Where(q => q.JobGroup == "P1");
        //            break;
        //        case "P2":
        //            query = query.Where(q => q.JobGroup == "P2");
        //            break;
        //        case "ISCCM":
        //            query = query.Where(q => q.JobGroup == "ISCCM");
        //            break;
        //        case "SCCM":
        //            query = query.Where(q => q.JobGroup == "SCCM");
        //            break;
        //        case "CCM":
        //            query = query.Where(q => q.JobGroup == "CCM");
        //            break;
        //        default:
        //            break;
        //    }
        //    var fixDs = await query.OrderBy(q => q.RankOrder).ThenByDescending(q => q.FixTime).ThenBy(q => q.LastName).ToListAsync();

        //    var ids = fixDs.Select(q => q.CrewId).ToList();
        //    var noDs = await this.context.ViewEmployeeLights.Where(q => !ids.Contains(q.Id)).OrderBy(q => q.JobGroup).OrderBy(q => q.LastName).ToListAsync();


        //    return new
        //    {
        //        fixDs,
        //        noDs
        //    };
        //}
        //mimi
        internal async Task<object> GetFixTimeRoutes()
        {
            var query = await this.context.ViewFixTimeRoutes.OrderBy(q => q.Route).ToListAsync();
            return query;
        }
        internal async Task<object> GetNoCrews()
        {
            var query = await this.context.ViewEmployeeLights.Where(q => q.JobGroupCode.StartsWith("00103") || q.JobGroupCode.StartsWith("004") || q.JobGroupCode.StartsWith("005")).OrderBy(q => q.JobGroup).ThenBy(q => q.LastName).ThenBy(q => q.FirstName).ToListAsync();
            return query;
        }
        internal async Task<CustomActionResult> deleteFixTime(string route, string userName)
        {
            route = route.ToUpper();
            var exist = await this.context.FixTimeRoutes.Where(q => q.Route == route).FirstOrDefaultAsync();
            if (exist != null)
            {
                this.context.FixTimeRouteHistories.Add(new FixTimeRouteHistory()
                {
                    Date = DateTime.Now,
                    NewTime = null,
                    OldTime = exist.FixTime2,
                    Route = route,
                    UserName = userName,
                });
                this.context.FixTimeRoutes.Remove(exist);
                var saveResult = await context.SaveAsync();
                if (saveResult.Code != HttpStatusCode.OK)
                    return saveResult;


            }
            return new CustomActionResult(HttpStatusCode.OK, exist);
        }
        internal async Task<CustomActionResult> saveFixTime(string route, int hh, int mm, string userName, bool edit)
        {
            route = route.ToUpper();
            var exist = await this.context.FixTimeRoutes.Where(q => q.Route == route).FirstOrDefaultAsync();
            if (edit)
            {
                if (exist == null)
                {
                    return new CustomActionResult(HttpStatusCode.NotAcceptable, new
                    {

                        message = "The item not found."

                    });
                }
                var fxHistory = new FixTimeRouteHistory()
                {
                    UserName = userName,
                    Route = exist.Route,
                    OldTime = exist.FixTime2,
                    Date = DateTime.Now,
                };
                exist.FixTime2 = new TimeSpan(hh, mm, 0);
                exist.FixtTime = hh * 60 + mm;
                fxHistory.NewTime = exist.FixTime2;
                this.context.FixTimeRouteHistories.Add(fxHistory);
                var saveResult = await context.SaveAsync();
                if (saveResult.Code != HttpStatusCode.OK)
                    return saveResult;

                return new CustomActionResult(HttpStatusCode.OK, exist);
            }
            else
            {
                if (exist != null)
                {
                    return new CustomActionResult(HttpStatusCode.NotAcceptable, new
                    {

                        message = "The item already exists."

                    });
                }
                var fx = new FixTimeRoute()
                {
                    FixTime2 = new TimeSpan(hh, mm, 0),
                    FixtTime = hh * 60 + mm,
                    Route = route,
                };
                var fxHistory = new FixTimeRouteHistory()
                {
                    UserName = userName,
                    Route = fx.Route,
                    OldTime = null,
                    NewTime = fx.FixTime2,
                    Date = DateTime.Now,
                };
                this.context.FixTimeRoutes.Add(fx);
                this.context.FixTimeRouteHistories.Add(fxHistory);
                var saveResult = await context.SaveAsync();
                if (saveResult.Code != HttpStatusCode.OK)
                    return saveResult;

                return new CustomActionResult(HttpStatusCode.OK, fx);

            }
        }
        internal async Task<object> GetCrewFixTimePeriodReport(int year, string period, string rank)
        {
            string _period = "";
            switch (period)
            {
                case "1":
                    _period = "12/16 - 01/15";
                    break;
                case "2":
                    _period = "01/16 - 02/15";
                    break;
                case "3":
                    _period = "02/16 - 03/15";
                    break;
                case "4":
                    _period = "03/16 - 04/15";
                    break;
                case "5":
                    _period = "04/16 - 05/15";
                    break;
                case "6":
                    _period = "05/16 - 06/15";
                    break;
                case "7":
                    _period = "06/16 - 07/15";
                    break;
                case "8":
                    _period = "07/16 - 08/15";
                    break;
                case "9":
                    _period = "08/16 - 09/15";
                    break;
                case "10":
                    _period = "09/16 - 10/15";
                    break;
                case "11":
                    _period = "10/16 - 11/15";
                    break;
                case "12":
                    _period = "11/16 - 12/15";
                    break;
                default:
                    break;
            }


            var query = from x in this.context.RptFDPMonthlyPersians
                        where x.PYear == year && x.PeriodFixTime == _period
                        select x;
            var query2 = from x in this.context.RptNoFDPMonthlyPersians
                         where x.PYear == year && x.PeriodFixTime == _period
                         select x;
            switch (rank)
            {
                case "All":
                    break;
                case "Cockpit":
                    query = query.Where(q => q.JobGroup == "TRE" || q.JobGroup == "TRI" || q.JobGroup == "LTC" || q.JobGroup == "P1" || q.JobGroup == "P2");
                    query2 = query2.Where(q => q.JobGroup == "TRE" || q.JobGroup == "TRI" || q.JobGroup == "LTC" || q.JobGroup == "P1" || q.JobGroup == "P2");
                    break;
                case "Cabin":
                    query = query.Where(q => q.JobGroup == "ISCCM" || q.JobGroup == "SCCM" || q.JobGroup == "CCM");
                    query2 = query2.Where(q => q.JobGroup == "ISCCM" || q.JobGroup == "SCCM" || q.JobGroup == "CCM");
                    break;
                case "IP":
                    query = query.Where(q => q.JobGroup == "TRE" || q.JobGroup == "TRI" || q.JobGroup == "LTC");
                    query2 = query2.Where(q => q.JobGroup == "TRE" || q.JobGroup == "TRI" || q.JobGroup == "LTC");
                    break;
                case "P1":
                    query = query.Where(q => q.JobGroup == "P1");
                    query2 = query2.Where(q => q.JobGroup == "P1");
                    break;
                case "P2":
                    query = query.Where(q => q.JobGroup == "P2");
                    query2 = query2.Where(q => q.JobGroup == "P2");
                    break;
                case "ISCCM":
                    query = query.Where(q => q.JobGroup == "ISCCM");
                    query2 = query2.Where(q => q.JobGroup == "ISCCM");
                    break;
                case "SCCM":
                    query = query.Where(q => q.JobGroup == "SCCM");
                    query2 = query2.Where(q => q.JobGroup == "SCCM");
                    break;
                case "CCM":
                    query = query.Where(q => q.JobGroup == "CCM");
                    query2 = query2.Where(q => q.JobGroup == "CCM");
                    break;
                default:
                    break;
            }
            var fixDs = await query.OrderBy(q => q.RankOrder).ThenByDescending(q => q.FixTime).ThenBy(q => q.LastName).ToListAsync();
            foreach (var x in fixDs)
            {
                x.FixTimeTotal = x.FixTime;
            }
            var noFDPs = await query2.ToListAsync();
            foreach (var x in noFDPs)
            {
                var exist = fixDs.FirstOrDefault(q => q.CrewId == x.CrewId);
                if (exist != null)
                {
                    if (x.DutyTypeTitle == "StandBy")
                        exist.StandBy = x.Count;
                    if (x.DutyTypeTitle == "Mission")
                    {
                        exist.Misson = x.Duration;
                        exist.FixTimeTotal = (int)exist.FixTimeTotal + exist.Misson;
                    }


                }
                else
                {
                    var rec = new RptFDPMonthlyPersian()
                    {
                        CrewId = x.CrewId,
                        Name = x.Name,
                        PeriodFixTime = x.PeriodFixTime,
                        PYear = x.PYear,
                        RankOrder = x.RankOrder,
                        ScheduleName = x.ScheduleName,
                        JobGroup = x.JobGroup,
                        JobGroupCode = x.JobGroupCode,
                        JobGroupRoot = x.JobGroupRoot,
                        LastName = x.LastName,
                        FirstName = x.FirstName,
                        Misson = 0,
                        StandBy = 0,

                    };
                    if (x.DutyTypeTitle == "StandBy")
                        rec.StandBy = x.Count;
                    if (x.DutyTypeTitle == "Mission")
                    {
                        rec.Misson = x.Duration;
                        rec.FixTimeTotal = x.Duration;
                    }

                    fixDs.Add(rec);

                }
            }
            fixDs = fixDs.OrderBy(q => q.RankOrder).ThenByDescending(q => q.FixTime).ThenBy(q => q.LastName).ToList();
            var ids = fixDs.Select(q => q.CrewId).ToList();
            var noDs = await this.context.ViewEmployeeLights.Where(q => !ids.Contains(q.Id)).OrderBy(q => q.JobGroup).OrderBy(q => q.LastName).ToListAsync();


            return new
            {
                fixDs,
                noDs
            };
        }

        internal async Task<object> GetCrewFixTimePeriodReportCrew(int year, string period, int crew)
        {
            string _period = "";
            switch (period)
            {
                case "1":
                    _period = "12/16 - 01/15";
                    break;
                case "2":
                    _period = "01/16 - 02/15";
                    break;
                case "3":
                    _period = "02/16 - 03/15";
                    break;
                case "4":
                    _period = "03/16 - 04/15";
                    break;
                case "5":
                    _period = "04/16 - 05/15";
                    break;
                case "6":
                    _period = "05/16 - 06/15";
                    break;
                case "7":
                    _period = "06/16 - 07/15";
                    break;
                case "8":
                    _period = "07/16 - 08/15";
                    break;
                case "9":
                    _period = "08/16 - 09/15";
                    break;
                case "10":
                    _period = "09/16 - 10/15";
                    break;
                case "11":
                    _period = "10/16 - 11/15";
                    break;
                case "12":
                    _period = "11/16 - 12/15";
                    break;
                default:
                    break;
            }


            var query = await (from x in this.context.RptFDPs
                               where x.PYear == year && x.PeriodFixTime == _period && x.CrewId == crew
                               orderby x.STDDay
                               select x).ToListAsync();

            return query;


        }

        internal async Task<object> GetCrewFixTimePeriodReportCrewNoFDP(int year, string period, int crew)
        {
            string _period = "";
            switch (period)
            {
                case "1":
                    _period = "12/16 - 01/15";
                    break;
                case "2":
                    _period = "01/16 - 02/15";
                    break;
                case "3":
                    _period = "02/16 - 03/15";
                    break;
                case "4":
                    _period = "03/16 - 04/15";
                    break;
                case "5":
                    _period = "04/16 - 05/15";
                    break;
                case "6":
                    _period = "05/16 - 06/15";
                    break;
                case "7":
                    _period = "06/16 - 07/15";
                    break;
                case "8":
                    _period = "07/16 - 08/15";
                    break;
                case "9":
                    _period = "08/16 - 09/15";
                    break;
                case "10":
                    _period = "09/16 - 10/15";
                    break;
                case "11":
                    _period = "10/16 - 11/15";
                    break;
                case "12":
                    _period = "11/16 - 12/15";
                    break;
                default:
                    break;
            }


            var query = await (from x in this.context.RptNoFDPs
                               where x.PYear == year && x.PeriodFixTime == _period && x.CrewId == crew
                               orderby x.Date
                               select x).ToListAsync();

            return query;


        }
        //dali
        internal async Task<object> GetFormAReport(int yf, int yt)
        {
            var query = await (from x in this.context.ViewFormAMonthlies.Where(q => q.Year >= yf && q.Year <= yt)
                               orderby x.Year descending, x.Month descending
                               select x).ToListAsync();
            return query;
        }
        internal async Task<object> GetFormAYearlyReport(int yf, int yt)
        {
            var query = await (from x in this.context.ViewFormAYearlies.Where(q => q.Year >= yf && q.Year <= yt)
                               orderby x.Year descending
                               select x).ToListAsync();
            return query;
        }
        internal async Task<object> GetFormAReportMonth(int year, int month)
        {
            var query = await (from x in this.context.ViewFormAMonthlies.Where(q => q.Year == year && q.Month == month)
                               orderby x.Year descending, x.Month descending
                               select x).ToListAsync();
            return query;
        }
        internal async Task<object> GetFormAReportYear(int year)
        {
            var query = await (from x in this.context.ViewFormAYearlies.Where(q => q.Year == year)
                               orderby x.Year descending
                               select x).ToListAsync();
            return query;
        }

        internal async Task<bool> CreateFixTimeRoute()
        {
            var fxs = await this.context.FixTimeRoutes.ToListAsync();
            var leg2s = fxs.Where(q => q.Route.Length == 11).ToList();
            foreach (var r1 in leg2s)
            {
                foreach (var r2 in leg2s)
                {

                    var m1 = r1.FixTime2.TotalMinutes;
                    var m2 = r2.FixTime2.TotalMinutes;
                    var mn = m1 + m2;
                    var hh = ((int)mn) / 60;
                    var mm = ((int)mn) % 60;
                    var newtime = new TimeSpan(hh, mm, 0);
                    var rt1 = r1.Route;
                    var rt2 = r2.Route.Substring(3);
                    var newroute = rt1 + rt2;
                    var exist = fxs.FirstOrDefault(q => q.Route == newroute);

                    if (exist == null)
                    {
                        var nfx = new FixTimeRoute()
                        {
                            FixTime2 = newtime,
                            FixtTime = (int)mn,
                            Route = newroute,

                        };
                        this.context.FixTimeRoutes.Add(nfx);
                    }

                }
            }

            var saveResult = await context.SaveAsync();
            return true;

        }


        internal async Task<bool> SaveCoord(decimal lat, decimal lng, int uid)
        {
            this.context.Coords.Add(new Coord()
            {
                Lg = lng,
                Lt = lat,
                UserId = uid
            });

            await this.context.SaveAsync();
            return true;

        }



        public async Task<List<RptFuelLeg>> GetRptFuelLegs()
        {
            var records = await this.context.RptFuelLegs.ToListAsync();
            return records;
        }







    }
}