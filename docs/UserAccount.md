# Itofinity.Appveyor.Rest.Refit.Model.UserAccount
## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Created** | **DateTime?** |  | [optional] 
**Updated** | **DateTime?** |  | [optional] 
**SuccessfulBuildNotification** | [**BuildNotificationFrequency**](BuildNotificationFrequency.md) |  | 
**FailedBuildNotification** | [**BuildNotificationFrequency**](BuildNotificationFrequency.md) |  | 
**NotifyWhenBuildStatusChangedOnly** | **bool?** | Note that this value is &#x60;true&#x60; on user creation, but behaves as &#x60;false&#x60; when not specified on update.  | [optional] [default to false]
**SuccessfulDeploymentNotification** | [**DeploymentNotificationFrequency**](DeploymentNotificationFrequency.md) |  | 
**FailedDeploymentNotification** | [**DeploymentNotificationFrequency**](DeploymentNotificationFrequency.md) |  | 
**NotifyWhenDeploymentStatusChangedOnly** | **bool?** | Note that this value is &#x60;true&#x60; on user creation, but behaves as &#x60;false&#x60; when not specified on update.  | [optional] [default to false]
**AccountId** | **int?** |  | [optional] 
**AccountName** | **string** |  | [optional] 
**IsOwner** | **bool?** |  | [optional] 
**IsCollaborator** | **bool?** |  | [optional] 
**UserId** | **int?** |  | [optional] 
**FullName** | **string** |  | 
**Email** | **string** |  | 
**Password** | **string** |  | [optional] 
**RoleId** | **int?** |  | [optional] 
**RoleName** | **string** |  | [optional] 
**PageSize** | **int?** |  | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

