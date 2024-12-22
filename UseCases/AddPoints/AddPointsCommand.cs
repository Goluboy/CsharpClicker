using CSharpClicker.Web.UseCases.Common;
using MediatR;

namespace CSharpClicker.Web.UseCases.AddPoints;

public record AddPointsCommand(int Clicks) : IRequest<ScoreDto>;
