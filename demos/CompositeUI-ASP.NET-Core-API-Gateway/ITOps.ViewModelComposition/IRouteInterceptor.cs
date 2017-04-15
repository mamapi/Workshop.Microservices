﻿using Microsoft.AspNetCore.Routing;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;

namespace ITOps.ViewModelComposition
{
    public interface IRouteInterceptor
    {
        bool Matches(RouteData routeData, string httpVerb);
    }

    public interface ISubscribeToCompositionEvents : IRouteInterceptor
    {
        void Subscribe(ISubscriptionStorage subscriptionStorage, RouteData routeData, IQueryCollection query);
    }

    public interface IViewModelAppender : IRouteInterceptor
    {
        Task Append(dynamic vm, RouteData routeData, IQueryCollection query);
    }
}
