using System;

namespace Paramore.Darker.Builder
{
    public interface INeedHandlers
    {
        INeedAQueryContext Handlers(IHandlerConfiguration handlerConfiguration);
        INeedAQueryContext Handlers(IQueryHandlerRegistry handlerRegistry, IQueryHandlerFactory handlerFactory, IQueryHandlerDecoratorFactory decoratorFactory);
        INeedAQueryContext Handlers(IQueryHandlerRegistry handlerRegistry, Func<Type, IQueryHandler> handlerFactory, Func<Type, IQueryHandlerDecorator> decoratorFactory);
    }
}