/*
   Copyright 2023 tacosontitan and contributors

   Licensed under the Apache License, Version 2.0 (the "License");
   you may not use this file except in compliance with the License.
   You may obtain a copy of the License at

       http://www.apache.org/licenses/LICENSE-2.0

   Unless required by applicable law or agreed to in writing, software
   distributed under the License is distributed on an "AS IS" BASIS,
   WITHOUT WARRANTIES OR CONDITIONS OF ANY KIND, either express or implied.
   See the License for the specific language governing permissions and
   limitations under the License.
*/

namespace Glitter.Sql;

/// <summary>
/// Represents information about a connection to a SQL database.
/// </summary>
public interface IConnectionInformation
{
    /// <summary>
    /// Should the connection use integrated security?
    /// </summary>
    bool IntegratedSecurity { get; set; }

    /// <summary>
    /// The server to connect to.
    /// </summary>
    string? Server { get; set; }

    /// <summary>
    /// The database to connect to.
    /// </summary>
    string? Database { get; set; }

    /// <summary>
    /// The username to use when connecting.
    /// </summary>
    string? Username { get; set; }

    /// <summary>
    /// The password to use when connecting.
    /// </summary>
    string? Password { get; set; }

    /// <summary>
    /// The amount of time to wait for a connection to be established.
    /// </summary>
    /// <value></value>
    TimeSpan? ConnectionTimeout { get; set; }

    /// <summary>
    /// The amount of time to wait for a command to execute.
    /// </summary>
    /// <value></value>
    TimeSpan? CommandTimeout { get; set; }
}
