using DatabaseApi.Repositories;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace DatabaseApi.Contexts.Interfaces
{
    public interface IDbContext : IDisposable
    {
        /// <summary>
        /// Gets an instance of <see cref="IRepository"/> for interacting with the database.
        /// </summary>
        IRepository Repository { get; }

        /// <summary>
        /// Saves all changes made in the context to the database.
        /// </summary>
        void SaveChanges();

        /// <summary>
        /// Executes a raw SQL query and returns the results as a collection of specified type <typeparamref name="T"/>.
        /// </summary>
        /// <typeparam name="T">
        /// The type of the objects to be returned.
        /// </typeparam>
        /// <param name="query">
        /// The SQL query to execute.
        /// </param>
        /// <returns>
        /// An <see cref="IEnumerable{T}"/> of objects returned by the query.
        /// </returns>
        IEnumerable<T> SqlQuery<T>(string query);

        /// <summary>
        /// Executes a raw SQL command against the database.
        /// </summary>
        /// <param name="query">
        /// The raw SQL command to execute.
        /// </param>
        /// <param name="args">
        /// The parameters to include in the SQL command, if any.
        /// </param>
        void ExecuteRawSql(string query, params object[] args);

        /// <summary>
        /// Asynchronously executes a raw SQL command against the database.
        /// </summary>
        /// <param name="query">
        /// The raw SQL command to execute.
        /// </param>
        /// <param name="args">
        /// The parameters to include in the SQL command, if any.
        /// </param>
        /// <returns>
        /// A task that represents the asynchronous execution of the SQL command.
        /// </returns>
        Task ExecuteRawSqlAsync(string query, params object[] args);

        /// <summary>
        /// Switches the active database to the specified database name.
        /// </summary>
        /// <param name="databaseName">
        /// The name of the database to switch to.
        /// </param>
        void SwitchDatabase(string databaseName);
    }
}
