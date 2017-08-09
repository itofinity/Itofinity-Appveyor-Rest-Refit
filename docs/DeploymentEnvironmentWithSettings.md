# Itofinity.Appveyor.Rest.Refit.Model.DeploymentEnvironmentWithSettings
## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**DeploymentEnvironmentId** | **int?** |  | [optional] 
**Name** | **string** |  | [optional] 
**Provider** | [**DeploymentProviderType**](DeploymentProviderType.md) |  | [optional] 
**Created** | **DateTime?** |  | [optional] 
**Updated** | **DateTime?** |  | [optional] 
**AccountId** | **int?** |  | [optional] 
**ProjectsMode** | **int?** | 0 is \&quot;Any project can be deployed to the environment\&quot; 1 is \&quot;Only selected projects can be deployed to the environment\&quot; 2 is \&quot;All except selected projects can be deployed to the environment\&quot; | [optional] 
**SecurityDescriptor** | [**SecurityDescriptor**](SecurityDescriptor.md) |  | [optional] 
**EnvironmentAccessKey** | **string** |  | [optional] 
**Settings** | [**DeploymentEnvironmentSettings**](DeploymentEnvironmentSettings.md) |  | [optional] 
**SelectedProjects** | **List&lt;int?&gt;** | Project IDs of selected projects | [optional] 
**Projects** | [**List&lt;DeploymentEnvironmentProject&gt;**](DeploymentEnvironmentProject.md) | Projects available for selection in UI. Only present in response from getEnvironmentSettings.  | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

