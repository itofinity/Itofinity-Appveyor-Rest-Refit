# Itofinity.Appveyor.Rest.Refit.Model.ProjectWithConfiguration
## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**ProjectId** | **int?** |  | 
**AccountName** | **string** |  | [optional] 
**Name** | **string** |  | [optional] 
**Slug** | **string** |  | [optional] 
**Created** | **DateTime?** |  | [optional] 
**Updated** | **DateTime?** |  | [optional] 
**AccountId** | **int?** |  | [optional] 
**Builds** | [**List&lt;Build&gt;**](Build.md) | Only non-empty for response from getProjects. | [optional] 
**RepositoryType** | [**RepositoryProvider**](RepositoryProvider.md) |  | [optional] 
**RepositoryScm** | [**RepositoryScm**](RepositoryScm.md) |  | [optional] 
**RepositoryName** | **string** |  | 
**RepositoryBranch** | **string** | Not present in response from addProject. | [optional] 
**IsPrivate** | **bool?** |  | [optional] 
**SkipBranchesWithoutAppveyorYml** | **bool?** |  | [optional] 
**EnableSecureVariablesInPullRequests** | **bool?** |  | [optional] 
**EnableSecureVariablesInPullRequestsFromSameRepo** | **bool?** |  | [optional] 
**EnableDeploymentInPullRequests** | **bool?** |  | [optional] 
**RollingBuilds** | **bool?** |  | [optional] 
**RollingBuildsDoNotCancelRunningBuilds** | **bool?** |  | [optional] 
**AlwaysBuildClosedPullRequests** | **bool?** |  | [optional] 
**Tags** | **string** |  | [optional] 
**NuGetFeed** | [**NuGetFeed**](NuGetFeed.md) | Not present in response from addProject. | [optional] 
**SecurityDescriptor** | [**SecurityDescriptor**](SecurityDescriptor.md) | Not present in response from addProject. Not always present in response from getProjects (only after updateProject or startBuild?). | [optional] 
**VersionFormat** | **string** |  | 
**NextBuildNumber** | **int?** |  | [optional] 
**ScheduleCrontabExpression** | **string** | Build schedule as an NCrontab Expression.  See https://github.com/atifaziz/NCrontab/wiki/Crontab-Expression | [optional] 
**RepositoryAuthentication** | [**RepositoryAuthenticationType**](RepositoryAuthenticationType.md) |  | [optional] 
**RepositoryUsername** | **string** |  | [optional] 
**SshPublicKey** | **string** |  | [optional] 
**WebhookId** | **string** |  | [optional] 
**WebhookUrl** | **string** |  | [optional] 
**StatusBadgeId** | **string** |  | [optional] 
**BuildPriority** | **int?** |  | [optional] 
**IgnoreAppveyorYml** | **bool?** |  | [optional] 
**CustomYmlName** | **string** |  | [optional] 
**Configuration** | [**ProjectConfiguration**](ProjectConfiguration.md) |  | 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

