using AutoMapper;
using LevelUpCenter.Coaching.Domain.Models;
using LevelUpCenter.Coaching.Resources;
using LevelUpCenter.Coaching.Resources.Coach;
using LevelUpCenter.Coaching.Resources.Course;
using LevelUpCenter.Coaching.Resources.Game;

namespace LevelUpCenter.Coaching.Mapping;

public class ModelToResourceProfile : Profile
{
    public ModelToResourceProfile()
    {
        CreateMap<Publication, PublicationResource>();
        // Games
        CreateMap<Game, SaveGameResource>();
        CreateMap<Game, UpdateGameResource>();
        CreateMap<Game, GameResource>();

        CreateMap<Course, CourseResource>();

        // Coaches
        CreateMap<Coach, SaveCoachResource>();
        CreateMap<Coach, CoachResource>();
    }
}
