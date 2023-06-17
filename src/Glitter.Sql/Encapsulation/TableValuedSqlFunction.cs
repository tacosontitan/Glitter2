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

namespace Glitter.Sql.Encapsulation;

/// <summary>
/// Represents a table-valued function within SQL.
/// </summary>
public class TableValuedSqlFunction :
    SqlFunction
{
    /// <summary>
    /// Creates a new <see cref="TableValuedSqlFunction"/> instance.
    /// </summary>
    /// <param name="name">The name of the function being invoked.</param>
    /// <exception cref="ArgumentException"><paramref name="name"/> is null or whitespace.</exception>
    protected TableValuedSqlFunction(string name) :
        base(name)
    { }

    /// <summary>
    /// Creates a new <see cref="TableValuedSqlFunction"/> instance.
    /// </summary>
    /// <param name="schema">The schema for the function.</param>
    /// <param name="functionName">The name of the function being invoked.</param>
    /// <exception cref="ArgumentException"><paramref name="name"/> or <paramref name="name"/> is null or whitespace.</exception>
    protected TableValuedSqlFunction(string schema, string name) :
        base(schema, name)
    { }
}
