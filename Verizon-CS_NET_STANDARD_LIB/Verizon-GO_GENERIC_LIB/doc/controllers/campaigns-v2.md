# Campaigns V2

```go
campaignsV2Api := client.CampaignsV2Api()
```

## Class Name

`CampaignsV2Api`

## Methods

* [Schedule Campaign Firmware Upgrade](../../doc/controllers/campaigns-v2.md#schedule-campaign-firmware-upgrade)
* [Get Campaign Information](../../doc/controllers/campaigns-v2.md#get-campaign-information)
* [Update Campaign Firmware Devices](../../doc/controllers/campaigns-v2.md#update-campaign-firmware-devices)
* [Cancel Campaign](../../doc/controllers/campaigns-v2.md#cancel-campaign)
* [Update Campaign Dates](../../doc/controllers/campaigns-v2.md#update-campaign-dates)
* [Schedule File Upgrade](../../doc/controllers/campaigns-v2.md#schedule-file-upgrade)
* [Schedule SW Upgrade Http Devices](../../doc/controllers/campaigns-v2.md#schedule-sw-upgrade-http-devices)


# Schedule Campaign Firmware Upgrade

This endpoint allows user to schedule a software upgrade.

```go
ScheduleCampaignFirmwareUpgrade(
    ctx context.Context,
    account string,
    body models.CampaignSoftwareUpgrade) (
    models.ApiResponse[models.CampaignSoftware],
    error)
```

## Parameters

| Parameter | Type | Tags | Description |
|  --- | --- | --- | --- |
| `account` | `string` | Template, Required | Account identifier. |
| `body` | [`models.CampaignSoftwareUpgrade`](../../doc/models/campaign-software-upgrade.md) | Body, Required | Software upgrade information. |

## Response Type

This method returns an [`ApiResponse`](../../doc/api-response.md) instance. The `Data` property of this instance returns the response data which is of type [models.CampaignSoftware](../../doc/models/campaign-software.md).

## Example Usage

```go
ctx := context.Background()

account := "0000123456-00001"

body := models.CampaignSoftwareUpgrade{
    CampaignName:           models.ToPointer("FOTA_Verizon_Upgrade"),
    SoftwareName:           "FOTA_Verizon_Model-A_02To03_HF",
    SoftwareFrom:           "FOTA_Verizon_Model-A_00To01_HF",
    SoftwareTo:             "FOTA_Verizon_Model-A_02To03_HF",
    DistributionType:       "HTTP",
    StartDate:              parseTime(models.DEFAULT_DATE, "2020-08-21", func(err error) { log.Fatalln(err) }),
    EndDate:                parseTime(models.DEFAULT_DATE, "2020-08-22", func(err error) { log.Fatalln(err) }),
    DownloadAfterDate:      models.ToPointer(parseTime(models.DEFAULT_DATE, "2020-08-21", func(err error) { log.Fatalln(err) })),
    DownloadTimeWindowList: []models.V2TimeWindow{
        models.V2TimeWindow{
            StartTime:             20,
            EndTime:               21,
        },
    },
    InstallAfterDate:       models.ToPointer(parseTime(models.DEFAULT_DATE, "2020-08-21", func(err error) { log.Fatalln(err) })),
    InstallTimeWindowList:  []models.V2TimeWindow{
        models.V2TimeWindow{
            StartTime:             22,
            EndTime:               23,
        },
    },
    DeviceList:             []string{
        "990013907835573",
        "990013907884259",
    },
}

apiResponse, err := campaignsV2Api.ScheduleCampaignFirmwareUpgrade(ctx, account, body)
if err != nil {
    log.Fatalln(err)
} else {
    // Printing the result and response
    fmt.Println(apiResponse.Data)
    fmt.Println(apiResponse.Response.StatusCode)
}
```

## Example Response *(as JSON)*

```json
{
  "id": "60b5d639-ccdc-4db8-8824-069bd94c95bf",
  "accountName": "0402196254-00001",
  "campaignName": "FOTA_Verizon_Upgrade",
  "softwareName": "FOTA_Verizon_Model-A_02To03_HF",
  "distributionType": "HTTP",
  "make": "Verizon",
  "model": "Model-A",
  "softwareFrom": "FOTA_Verizon_Model-A_00To01_HF",
  "softwareTo": "FOTA_Verizon_Model-A_02To03_HF",
  "startDate": "2020-08-21",
  "endDate": "2020-08-22",
  "downloadAfterDate": "2020-08-21",
  "downloadTimeWindowList": [
    {
      "startTime": 20,
      "endTime": 21
    }
  ],
  "installAfterDate": "2020-08-21",
  "installTimeWindowList": [
    {
      "startTime": 22,
      "endTime": 23
    }
  ],
  "status": "CampaignRequestPending"
}
```

## Errors

| HTTP Status Code | Error Description | Exception Class |
|  --- | --- | --- |
| 400 | Unexpected error. | [`FotaV2ResultException`](../../doc/models/fota-v2-result-exception.md) |


# Get Campaign Information

This endpoint allows user to get information of a software upgrade.

```go
GetCampaignInformation(
    ctx context.Context,
    account string,
    campaignId string) (
    models.ApiResponse[models.CampaignSoftware],
    error)
```

## Parameters

| Parameter | Type | Tags | Description |
|  --- | --- | --- | --- |
| `account` | `string` | Template, Required | Account identifier. |
| `campaignId` | `string` | Template, Required | Software upgrade identifier. |

## Response Type

This method returns an [`ApiResponse`](../../doc/api-response.md) instance. The `Data` property of this instance returns the response data which is of type [models.CampaignSoftware](../../doc/models/campaign-software.md).

## Example Usage

```go
ctx := context.Background()

account := "0000123456-00001"

campaignId := "60b5d639-ccdc-4db8-8824-069bd94c95bf"

apiResponse, err := campaignsV2Api.GetCampaignInformation(ctx, account, campaignId)
if err != nil {
    log.Fatalln(err)
} else {
    // Printing the result and response
    fmt.Println(apiResponse.Data)
    fmt.Println(apiResponse.Response.StatusCode)
}
```

## Example Response *(as JSON)*

```json
{
  "id": "60b5d639-ccdc-4db8-8824-069bd94c95bf",
  "accountName": "0402196254-00001",
  "campaignName": "FOTA_Verizon_Upgrade",
  "softwareName": "FOTA_Verizon_Model-A_02To03_HF",
  "distributionType": "HTTP",
  "make": "Verizon",
  "model": "Model-A",
  "softwareFrom": "FOTA_Verizon_Model-A_00To01_HF",
  "softwareTo": "FOTA_Verizon_Model-A_02To03_HF",
  "startDate": "2020-08-21",
  "endDate": "2020-08-22",
  "downloadAfterDate": "2020-08-21",
  "downloadTimeWindowList": [
    {
      "startTime": 20,
      "endTime": 21
    }
  ],
  "installAfterDate": "2020-08-21",
  "installTimeWindowList": [
    {
      "startTime": 22,
      "endTime": 23
    }
  ],
  "status": "CampaignEnded"
}
```

## Errors

| HTTP Status Code | Error Description | Exception Class |
|  --- | --- | --- |
| 400 | Unexpected error. | [`FotaV2ResultException`](../../doc/models/fota-v2-result-exception.md) |


# Update Campaign Firmware Devices

This endpoint allows user to Add or Remove devices to an existing software upgrade.

```go
UpdateCampaignFirmwareDevices(
    ctx context.Context,
    account string,
    campaignId string,
    body models.V2AddOrRemoveDeviceRequest) (
    models.ApiResponse[models.V2AddOrRemoveDeviceResult],
    error)
```

## Parameters

| Parameter | Type | Tags | Description |
|  --- | --- | --- | --- |
| `account` | `string` | Template, Required | Account identifier. |
| `campaignId` | `string` | Template, Required | Software upgrade information. |
| `body` | [`models.V2AddOrRemoveDeviceRequest`](../../doc/models/v2-add-or-remove-device-request.md) | Body, Required | Request to add or remove device to existing software upgrade information. |

## Response Type

This method returns an [`ApiResponse`](../../doc/api-response.md) instance. The `Data` property of this instance returns the response data which is of type [models.V2AddOrRemoveDeviceResult](../../doc/models/v2-add-or-remove-device-result.md).

## Example Usage

```go
ctx := context.Background()

account := "0000123456-00001"

campaignId := "60b5d639-ccdc-4db8-8824-069bd94c95bf"

body := models.V2AddOrRemoveDeviceRequest{
    Type:                  "remove",
    DeviceList:            []string{
        "990013907884259",
        "990013907835573",
        "990013907833575",
    },
}

apiResponse, err := campaignsV2Api.UpdateCampaignFirmwareDevices(ctx, account, campaignId, body)
if err != nil {
    log.Fatalln(err)
} else {
    // Printing the result and response
    fmt.Println(apiResponse.Data)
    fmt.Println(apiResponse.Response.StatusCode)
}
```

## Errors

| HTTP Status Code | Error Description | Exception Class |
|  --- | --- | --- |
| 400 | Unexpected error. | [`FotaV2ResultException`](../../doc/models/fota-v2-result-exception.md) |


# Cancel Campaign

This endpoint allows user to cancel software upgrade. A software upgrade already started can not be cancelled.

```go
CancelCampaign(
    ctx context.Context,
    account string,
    campaignId string) (
    models.ApiResponse[models.FotaV2SuccessResult],
    error)
```

## Parameters

| Parameter | Type | Tags | Description |
|  --- | --- | --- | --- |
| `account` | `string` | Template, Required | Account identifier. |
| `campaignId` | `string` | Template, Required | Unique identifier of campaign. |

## Response Type

This method returns an [`ApiResponse`](../../doc/api-response.md) instance. The `Data` property of this instance returns the response data which is of type [models.FotaV2SuccessResult](../../doc/models/fota-v2-success-result.md).

## Example Usage

```go
ctx := context.Background()

account := "0000123456-00001"

campaignId := "60b5d639-ccdc-4db8-8824-069bd94c95bf"

apiResponse, err := campaignsV2Api.CancelCampaign(ctx, account, campaignId)
if err != nil {
    log.Fatalln(err)
} else {
    // Printing the result and response
    fmt.Println(apiResponse.Data)
    fmt.Println(apiResponse.Response.StatusCode)
}
```

## Example Response *(as JSON)*

```json
{
  "success": true
}
```

## Errors

| HTTP Status Code | Error Description | Exception Class |
|  --- | --- | --- |
| 400 | Unexpected error. | [`FotaV2ResultException`](../../doc/models/fota-v2-result-exception.md) |


# Update Campaign Dates

This endpoint allows user to change campaign dates and time windows. Fields which need to remain unchanged should be also provided.

```go
UpdateCampaignDates(
    ctx context.Context,
    account string,
    campaignId string,
    body models.V2ChangeCampaignDatesRequest) (
    models.ApiResponse[models.CampaignSoftware],
    error)
```

## Parameters

| Parameter | Type | Tags | Description |
|  --- | --- | --- | --- |
| `account` | `string` | Template, Required | Account identifier. |
| `campaignId` | `string` | Template, Required | Software upgrade information. |
| `body` | [`models.V2ChangeCampaignDatesRequest`](../../doc/models/v2-change-campaign-dates-request.md) | Body, Required | New dates and time windows. |

## Response Type

This method returns an [`ApiResponse`](../../doc/api-response.md) instance. The `Data` property of this instance returns the response data which is of type [models.CampaignSoftware](../../doc/models/campaign-software.md).

## Example Usage

```go
ctx := context.Background()

account := "0000123456-00001"

campaignId := "60b5d639-ccdc-4db8-8824-069bd94c95bf"

body := models.V2ChangeCampaignDatesRequest{
    StartDate:              parseTime(models.DEFAULT_DATE, "2020-08-21", func(err error) { log.Fatalln(err) }),
    EndDate:                parseTime(models.DEFAULT_DATE, "2020-08-22", func(err error) { log.Fatalln(err) }),
    DownloadAfterDate:      models.ToPointer(parseTime(models.DEFAULT_DATE, "2020-08-21", func(err error) { log.Fatalln(err) })),
    DownloadTimeWindowList: []models.V2TimeWindow{
        models.V2TimeWindow{
            StartTime:             3,
            EndTime:               4,
        },
    },
    InstallAfterDate:       models.ToPointer(parseTime(models.DEFAULT_DATE, "2020-08-21", func(err error) { log.Fatalln(err) })),
    InstallTimeWindowList:  []models.V2TimeWindow{
        models.V2TimeWindow{
            StartTime:             5,
            EndTime:               6,
        },
    },
}

apiResponse, err := campaignsV2Api.UpdateCampaignDates(ctx, account, campaignId, body)
if err != nil {
    log.Fatalln(err)
} else {
    // Printing the result and response
    fmt.Println(apiResponse.Data)
    fmt.Println(apiResponse.Response.StatusCode)
}
```

## Example Response *(as JSON)*

```json
{
  "id": "60b5d639-ccdc-4db8-8824-069bd94c95bf",
  "accountName": "0402196254-00001",
  "campaignName": "FOTA_Verizon_Upgrade",
  "softwareName": "FOTA_Verizon_Model-A_02To03_HF",
  "distributionType": "HTTP",
  "make": "Verizon",
  "model": "Model-A",
  "softwareFrom": "FOTA_Verizon_Model-A_00To01_HF",
  "softwareTo": "FOTA_Verizon_Model-A_02To03_HF",
  "startDate": "2020-08-21",
  "endDate": "2020-08-22",
  "downloadAfterDate": "2020-08-21",
  "downloadTimeWindowList": [
    {
      "startTime": 3,
      "endTime": 4
    },
    {
      "startTime": 5,
      "endTime": 6
    }
  ],
  "installAfterDate": "2020-08-21",
  "installTimeWindowList": [
    {
      "startTime": 5,
      "endTime": 6
    },
    {
      "startTime": 6,
      "endTime": 7
    }
  ],
  "status": "RequestPending"
}
```

## Errors

| HTTP Status Code | Error Description | Exception Class |
|  --- | --- | --- |
| 400 | Unexpected error. | [`FotaV2ResultException`](../../doc/models/fota-v2-result-exception.md) |


# Schedule File Upgrade

You can upload configuration files and schedule them in a campaign to devices.

```go
ScheduleFileUpgrade(
    ctx context.Context,
    acc string,
    body models.UploadAndScheduleFileRequest) (
    models.ApiResponse[models.UploadAndScheduleFileResponse],
    error)
```

## Parameters

| Parameter | Type | Tags | Description |
|  --- | --- | --- | --- |
| `acc` | `string` | Template, Required | Account identifier. |
| `body` | [`models.UploadAndScheduleFileRequest`](../../doc/models/upload-and-schedule-file-request.md) | Body, Required | Device logging information. |

## Response Type

This method returns an [`ApiResponse`](../../doc/api-response.md) instance. The `Data` property of this instance returns the response data which is of type [models.UploadAndScheduleFileResponse](../../doc/models/upload-and-schedule-file-response.md).

## Example Usage

```go
ctx := context.Background()

acc := "0402196254-00001"

body := models.UploadAndScheduleFileRequest{
    CampaignName:           models.ToPointer("FOTA_Verizon_Upgrade"),
    FileName:               models.ToPointer("configfile-Verizon_VZW1_hello-world.txt"),
    FileVersion:            models.ToPointer("1.0"),
    DistributionType:       models.ToPointer("HTTP"),
    StartDate:              models.ToPointer("2021-02-08"),
    EndDate:                models.ToPointer("2021-02-08"),
    DownloadAfterDate:      models.ToPointer("2021-02-08"),
}

apiResponse, err := campaignsV2Api.ScheduleFileUpgrade(ctx, acc, body)
if err != nil {
    log.Fatalln(err)
} else {
    // Printing the result and response
    fmt.Println(apiResponse.Data)
    fmt.Println(apiResponse.Response.StatusCode)
}
```

## Errors

| HTTP Status Code | Error Description | Exception Class |
|  --- | --- | --- |
| 400 | Unexpected error. | [`FotaV2ResultException`](../../doc/models/fota-v2-result-exception.md) |


# Schedule SW Upgrade Http Devices

Campaign time windows for downloading and installing software are available as long as the device OEM supports this.

```go
ScheduleSwUpgradeHttpDevices(
    ctx context.Context,
    acc string,
    body models.SchedulesSoftwareUpgradeRequest) (
    models.ApiResponse[models.UploadAndScheduleFileResponse],
    error)
```

## Parameters

| Parameter | Type | Tags | Description |
|  --- | --- | --- | --- |
| `acc` | `string` | Template, Required | Account identifier. |
| `body` | [`models.SchedulesSoftwareUpgradeRequest`](../../doc/models/schedules-software-upgrade-request.md) | Body, Required | Device logging information. |

## Response Type

This method returns an [`ApiResponse`](../../doc/api-response.md) instance. The `Data` property of this instance returns the response data which is of type [models.UploadAndScheduleFileResponse](../../doc/models/upload-and-schedule-file-response.md).

## Example Usage

```go
ctx := context.Background()

acc := "0402196254-00001"

body := models.SchedulesSoftwareUpgradeRequest{
    CampaignName:           models.ToPointer("FOTA_Verizon_Upgrade"),
    SoftwareName:           models.ToPointer("FOTA_Verizon_Model-A_02To03_HF"),
    SoftwareFrom:           models.ToPointer("FOTA_Verizon_Model-A_00To01_HF"),
    SoftwareTo:             models.ToPointer("FOTA_Verizon_Model-A_02To03_HF"),
    DistributionType:       models.ToPointer("HTTP"),
    StartDate:              models.ToPointer("2020-08-21"),
    EndDate:                models.ToPointer("2020-08-22"),
    DownloadAfterDate:      models.ToPointer("2020-08-21"),
    DownloadTimeWindowList: []models.DownloadTimeWindow{
        models.DownloadTimeWindow{
            StartTime:             models.ToPointer("20"),
            EndTime:               models.ToPointer("21"),
        },
    },
    InstallAfterDate:       models.ToPointer("2020-08-21"),
    InstallTimeWindowList:  []models.DownloadTimeWindow{
        models.DownloadTimeWindow{
            StartTime:             models.ToPointer("22"),
            EndTime:               models.ToPointer("23"),
        },
    },
    DeviceList:             []string{
        "990013907835573",
        "990013907884259",
    },
}

apiResponse, err := campaignsV2Api.ScheduleSwUpgradeHttpDevices(ctx, acc, body)
if err != nil {
    log.Fatalln(err)
} else {
    // Printing the result and response
    fmt.Println(apiResponse.Data)
    fmt.Println(apiResponse.Response.StatusCode)
}
```

## Example Response *(as JSON)*

```json
{
  "id": "60b5d639-ccdc-4db8-8824-069bd94c95bf",
  "accountName": "0402196254-00001",
  "campaignName": "FOTA_Verizon_Upgrade",
  "softwareName": "FOTA_Verizon_Model-A_02To03_HF",
  "distributionType": "HTTP",
  "make": "Verizon",
  "model": "Model-A",
  "softwareFrom": "FOTA_Verizon_Model-A_00To01_HF",
  "softwareTo": "FOTA_Verizon_Model-A_02To03_HF",
  "startDate": "2020-08-21",
  "endDate": "2020-08-22",
  "downloadAfterDate": "2020-08-21",
  "downloadTimeWindowList": [
    {
      "startTime": "20",
      "endTime": "21"
    }
  ],
  "installAfterDate": "2020-08-21",
  "installTimeWindowList": [
    {
      "startTime": "22",
      "endTime": "23"
    }
  ],
  "status": "CampaignRequestPending"
}
```

## Errors

| HTTP Status Code | Error Description | Exception Class |
|  --- | --- | --- |
| 400 | Unexpected error. | [`FotaV2ResultException`](../../doc/models/fota-v2-result-exception.md) |

