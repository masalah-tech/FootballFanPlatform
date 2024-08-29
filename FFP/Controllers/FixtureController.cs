using FFP.Data;
using FFP.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace FFP.Controllers
{
    public class FixtureController : Controller
    {
        private readonly AppDbContext _context;

        public FixtureController(AppDbContext context)
        {
            _context = context;
        }

        public IActionResult Index()
        {
            var futureMatches =
                _context.Matches
                .Where(m => m.DateTime > DateTime.Now)
                .Include(m => m.League)
                .Include(m => m.Club1)
                .Include(m => m.Club2)
                .ToList();

            var leaguesHasPredictions = new List<League>();

            var matchesPredictionPercentages = new Dictionary<int, List<double>>();

            foreach (var futureMatch in futureMatches)
            {
                var allPredictions =
                    _context.Predictions
                    .Where(p => p.MatchId == futureMatch.Id && p.Match.DateTime > DateTime.Now)
                    .ToList();

                var drawPredictions = allPredictions.Where(p => p.PredictedWinnerClub == 0).ToList();
                var club1Predictions = allPredictions.Where(p => p.PredictedWinnerClub == 1).ToList();
                var club2Predictions = allPredictions.Where(p => p.PredictedWinnerClub == 2).ToList();

                var drawPredPercent = 0.00;
                var club1PredPercent = 0.00;
                var club2PredPercent = 0.00;

                if (allPredictions.Count > 0)
                {
                    drawPredPercent =
                        drawPredictions.Count * 1.0 / allPredictions.Count * 100.0;
                    club1PredPercent =
                        club1Predictions.Count * 1.0 / allPredictions.Count * 100.0;
                    club2PredPercent =
                        club2Predictions.Count * 1.0 / allPredictions.Count * 100.0;

                    if (!leaguesHasPredictions.Any(l => l.Id == futureMatch.LeagueId))
                        leaguesHasPredictions.Add(futureMatch.League);
                }

                var matchPredictionPercentages = new List<double>
                {
                    drawPredPercent,
                    club1PredPercent,
                    club2PredPercent
                };
                matchesPredictionPercentages.Add(futureMatch.Id, matchPredictionPercentages);
            }

            ViewBag.FutureMatches = futureMatches;
            ViewBag.LeaguesHasPredictions = leaguesHasPredictions;
            ViewBag.MatchesPredictionPercentages = matchesPredictionPercentages;

            return View();
        }
    }
}
