namespace Glitter.Data.Sql;

/// <summary>
/// Defines a handler for a SQL query that returns a scalar value.
/// </summary>
/// <typeparam name="TRequest">Specifies the type of the request.</typeparam>
/// <typeparam name="TResponse">Specifies the type of the response.</typeparam>
public interface ISqlScalarQueryHandler<in TRequest, TResponse>
    : IDataRequestHandler<ISqlProvider, TRequest, TResponse>
    where TRequest : IRequest<TResponse>;
    
/// <summary>
/// Defines a handler for a SQL query that returns a scalar value.
/// </summary>
/// <typeparam name="TProvider">Specifies the type of the provider.</typeparam>
/// <typeparam name="TRequest">Specifies the type of the request.</typeparam>
/// <typeparam name="TResponse">Specifies the type of the response.</typeparam>
public interface ISqlScalarQueryHandler<in TProvider, in TRequest, TResponse>
    : IDataRequestHandler<TProvider, TRequest, TResponse>
    where TProvider : ISqlProvider
    where TRequest : IRequest<TResponse>;