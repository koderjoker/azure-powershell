// 
// Copyright (c) Microsoft and contributors.  All rights reserved.
// 
// Licensed under the Apache License, Version 2.0 (the "License");
// you may not use this file except in compliance with the License.
// You may obtain a copy of the License at
//   http://www.apache.org/licenses/LICENSE-2.0
// 
// Unless required by applicable law or agreed to in writing, software
// distributed under the License is distributed on an "AS IS" BASIS,
// WITHOUT WARRANTIES OR CONDITIONS OF ANY KIND, either express or implied.
// 
// See the License for the specific language governing permissions and
// limitations under the License.
// 

// Warning: This code was generated by a tool.
// 
// Changes to this file may cause incorrect behavior and will be lost if the
// code is regenerated.

using System;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;
using Microsoft.Azure.Management.Sql.LegacySdk;
using Microsoft.Azure.Management.Sql.LegacySdk.Models;

namespace Microsoft.Azure.Management.Sql.LegacySdk
{
    /// <summary>
    /// The Windows Azure SQL Database management API provides a RESTful set of
    /// web services that interact with Windows Azure SQL Database services to
    /// manage your databases. The API enables users to create, retrieve,
    /// update, and delete databases and servers.
    /// </summary>
    public static partial class DatabaseActivationOperationsExtensions
    {
        /// <summary>
        /// Start an Azure SQL Data Warehouse database pause operation.To
        /// determine the status of the operation call
        /// GetDatabaseActivationOperationStatus.
        /// </summary>
        /// <param name='operations'>
        /// Reference to the
        /// Microsoft.Azure.Management.Sql.LegacySdk.IDatabaseActivationOperations.
        /// </param>
        /// <param name='resourceGroupName'>
        /// Required. The name of the Resource Group to which the Azure SQL
        /// Server belongs.
        /// </param>
        /// <param name='serverName'>
        /// Required. The name of the Azure SQL Server on which the data
        /// warehouse database is hosted.
        /// </param>
        /// <param name='databaseName'>
        /// Required. The name of the Azure SQL Data Warehouse database to
        /// pause.
        /// </param>
        /// <returns>
        /// Response for long running Azure Sql Database operations.
        /// </returns>
        public static DatabaseCreateOrUpdateResponse BeginPause(this IDatabaseActivationOperations operations, string resourceGroupName, string serverName, string databaseName)
        {
            return Task.Factory.StartNew((object s) => 
            {
                return ((IDatabaseActivationOperations)s).BeginPauseAsync(resourceGroupName, serverName, databaseName);
            }
            , operations, CancellationToken.None, TaskCreationOptions.None, TaskScheduler.Default).Unwrap().GetAwaiter().GetResult();
        }
        
        /// <summary>
        /// Start an Azure SQL Data Warehouse database pause operation.To
        /// determine the status of the operation call
        /// GetDatabaseActivationOperationStatus.
        /// </summary>
        /// <param name='operations'>
        /// Reference to the
        /// Microsoft.Azure.Management.Sql.LegacySdk.IDatabaseActivationOperations.
        /// </param>
        /// <param name='resourceGroupName'>
        /// Required. The name of the Resource Group to which the Azure SQL
        /// Server belongs.
        /// </param>
        /// <param name='serverName'>
        /// Required. The name of the Azure SQL Server on which the data
        /// warehouse database is hosted.
        /// </param>
        /// <param name='databaseName'>
        /// Required. The name of the Azure SQL Data Warehouse database to
        /// pause.
        /// </param>
        /// <returns>
        /// Response for long running Azure Sql Database operations.
        /// </returns>
        public static Task<DatabaseCreateOrUpdateResponse> BeginPauseAsync(this IDatabaseActivationOperations operations, string resourceGroupName, string serverName, string databaseName)
        {
            return operations.BeginPauseAsync(resourceGroupName, serverName, databaseName, CancellationToken.None);
        }
        
        /// <summary>
        /// Start an Azure SQL Data Warehouse database resume operation. To
        /// determine the status of the operation call
        /// GetDatabaseActivationOperationStatus.
        /// </summary>
        /// <param name='operations'>
        /// Reference to the
        /// Microsoft.Azure.Management.Sql.LegacySdk.IDatabaseActivationOperations.
        /// </param>
        /// <param name='resourceGroupName'>
        /// Required. The name of the Resource Group to which the Azure SQL
        /// Server belongs.
        /// </param>
        /// <param name='serverName'>
        /// Required. The name of the Azure SQL Server on which the data
        /// warehouse database is hosted.
        /// </param>
        /// <param name='databaseName'>
        /// Required. The name of the Azure SQL Data Warehouse database to
        /// resume.
        /// </param>
        /// <returns>
        /// Response for long running Azure Sql Database operations.
        /// </returns>
        public static DatabaseCreateOrUpdateResponse BeginResume(this IDatabaseActivationOperations operations, string resourceGroupName, string serverName, string databaseName)
        {
            return Task.Factory.StartNew((object s) => 
            {
                return ((IDatabaseActivationOperations)s).BeginResumeAsync(resourceGroupName, serverName, databaseName);
            }
            , operations, CancellationToken.None, TaskCreationOptions.None, TaskScheduler.Default).Unwrap().GetAwaiter().GetResult();
        }
        
        /// <summary>
        /// Start an Azure SQL Data Warehouse database resume operation. To
        /// determine the status of the operation call
        /// GetDatabaseActivationOperationStatus.
        /// </summary>
        /// <param name='operations'>
        /// Reference to the
        /// Microsoft.Azure.Management.Sql.LegacySdk.IDatabaseActivationOperations.
        /// </param>
        /// <param name='resourceGroupName'>
        /// Required. The name of the Resource Group to which the Azure SQL
        /// Server belongs.
        /// </param>
        /// <param name='serverName'>
        /// Required. The name of the Azure SQL Server on which the data
        /// warehouse database is hosted.
        /// </param>
        /// <param name='databaseName'>
        /// Required. The name of the Azure SQL Data Warehouse database to
        /// resume.
        /// </param>
        /// <returns>
        /// Response for long running Azure Sql Database operations.
        /// </returns>
        public static Task<DatabaseCreateOrUpdateResponse> BeginResumeAsync(this IDatabaseActivationOperations operations, string resourceGroupName, string serverName, string databaseName)
        {
            return operations.BeginResumeAsync(resourceGroupName, serverName, databaseName, CancellationToken.None);
        }
        
        /// <summary>
        /// Gets the status of an Azure SQL Data Warehouse Database pause or
        /// resume operation.
        /// </summary>
        /// <param name='operations'>
        /// Reference to the
        /// Microsoft.Azure.Management.Sql.LegacySdk.IDatabaseActivationOperations.
        /// </param>
        /// <param name='operationStatusLink'>
        /// Required. Location value returned by the Begin operation
        /// </param>
        /// <returns>
        /// Response for long running Azure Sql Database operations.
        /// </returns>
        public static DatabaseCreateOrUpdateResponse GetDatabaseActivationOperationStatus(this IDatabaseActivationOperations operations, string operationStatusLink)
        {
            return Task.Factory.StartNew((object s) => 
            {
                return ((IDatabaseActivationOperations)s).GetDatabaseActivationOperationStatusAsync(operationStatusLink);
            }
            , operations, CancellationToken.None, TaskCreationOptions.None, TaskScheduler.Default).Unwrap().GetAwaiter().GetResult();
        }
        
        /// <summary>
        /// Gets the status of an Azure SQL Data Warehouse Database pause or
        /// resume operation.
        /// </summary>
        /// <param name='operations'>
        /// Reference to the
        /// Microsoft.Azure.Management.Sql.LegacySdk.IDatabaseActivationOperations.
        /// </param>
        /// <param name='operationStatusLink'>
        /// Required. Location value returned by the Begin operation
        /// </param>
        /// <returns>
        /// Response for long running Azure Sql Database operations.
        /// </returns>
        public static Task<DatabaseCreateOrUpdateResponse> GetDatabaseActivationOperationStatusAsync(this IDatabaseActivationOperations operations, string operationStatusLink)
        {
            return operations.GetDatabaseActivationOperationStatusAsync(operationStatusLink, CancellationToken.None);
        }
        
        /// <summary>
        /// Start an Azure SQL Data Warehouse database pause operation.
        /// </summary>
        /// <param name='operations'>
        /// Reference to the
        /// Microsoft.Azure.Management.Sql.LegacySdk.IDatabaseActivationOperations.
        /// </param>
        /// <param name='resourceGroupName'>
        /// Required. The name of the Resource Group to which the Azure SQL
        /// Server belongs.
        /// </param>
        /// <param name='serverName'>
        /// Required. The name of the Azure SQL Server on which the data
        /// warehouse database is hosted.
        /// </param>
        /// <param name='databaseName'>
        /// Required. The name of the Azure SQL Data Warehouse database to
        /// pause.
        /// </param>
        /// <returns>
        /// Response for long running Azure Sql Database operations.
        /// </returns>
        public static DatabaseCreateOrUpdateResponse Pause(this IDatabaseActivationOperations operations, string resourceGroupName, string serverName, string databaseName)
        {
            return Task.Factory.StartNew((object s) => 
            {
                return ((IDatabaseActivationOperations)s).PauseAsync(resourceGroupName, serverName, databaseName);
            }
            , operations, CancellationToken.None, TaskCreationOptions.None, TaskScheduler.Default).Unwrap().GetAwaiter().GetResult();
        }
        
        /// <summary>
        /// Start an Azure SQL Data Warehouse database pause operation.
        /// </summary>
        /// <param name='operations'>
        /// Reference to the
        /// Microsoft.Azure.Management.Sql.LegacySdk.IDatabaseActivationOperations.
        /// </param>
        /// <param name='resourceGroupName'>
        /// Required. The name of the Resource Group to which the Azure SQL
        /// Server belongs.
        /// </param>
        /// <param name='serverName'>
        /// Required. The name of the Azure SQL Server on which the data
        /// warehouse database is hosted.
        /// </param>
        /// <param name='databaseName'>
        /// Required. The name of the Azure SQL Data Warehouse database to
        /// pause.
        /// </param>
        /// <returns>
        /// Response for long running Azure Sql Database operations.
        /// </returns>
        public static Task<DatabaseCreateOrUpdateResponse> PauseAsync(this IDatabaseActivationOperations operations, string resourceGroupName, string serverName, string databaseName)
        {
            return operations.PauseAsync(resourceGroupName, serverName, databaseName, CancellationToken.None);
        }
        
        /// <summary>
        /// Start an Azure SQL Data Warehouse database resume operation.
        /// </summary>
        /// <param name='operations'>
        /// Reference to the
        /// Microsoft.Azure.Management.Sql.LegacySdk.IDatabaseActivationOperations.
        /// </param>
        /// <param name='resourceGroupName'>
        /// Required. The name of the Resource Group to which the Azure SQL
        /// Server belongs.
        /// </param>
        /// <param name='serverName'>
        /// Required. The name of the Azure SQL Server on which the data
        /// warehouse database is hosted.
        /// </param>
        /// <param name='databaseName'>
        /// Required. The name of the Azure SQL Data Warehouse database to
        /// resume.
        /// </param>
        /// <returns>
        /// Response for long running Azure Sql Database operations.
        /// </returns>
        public static DatabaseCreateOrUpdateResponse Resume(this IDatabaseActivationOperations operations, string resourceGroupName, string serverName, string databaseName)
        {
            return Task.Factory.StartNew((object s) => 
            {
                return ((IDatabaseActivationOperations)s).ResumeAsync(resourceGroupName, serverName, databaseName);
            }
            , operations, CancellationToken.None, TaskCreationOptions.None, TaskScheduler.Default).Unwrap().GetAwaiter().GetResult();
        }
        
        /// <summary>
        /// Start an Azure SQL Data Warehouse database resume operation.
        /// </summary>
        /// <param name='operations'>
        /// Reference to the
        /// Microsoft.Azure.Management.Sql.LegacySdk.IDatabaseActivationOperations.
        /// </param>
        /// <param name='resourceGroupName'>
        /// Required. The name of the Resource Group to which the Azure SQL
        /// Server belongs.
        /// </param>
        /// <param name='serverName'>
        /// Required. The name of the Azure SQL Server on which the data
        /// warehouse database is hosted.
        /// </param>
        /// <param name='databaseName'>
        /// Required. The name of the Azure SQL Data Warehouse database to
        /// resume.
        /// </param>
        /// <returns>
        /// Response for long running Azure Sql Database operations.
        /// </returns>
        public static Task<DatabaseCreateOrUpdateResponse> ResumeAsync(this IDatabaseActivationOperations operations, string resourceGroupName, string serverName, string databaseName)
        {
            return operations.ResumeAsync(resourceGroupName, serverName, databaseName, CancellationToken.None);
        }
    }
}
