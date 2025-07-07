# PWN

```go
pwnApi := client.PwnApi()
```

## Class Name

`PwnApi`

## Methods

* [KPI List](../../doc/controllers/pwn.md#kpi-list)
* [Get Profile List](../../doc/controllers/pwn.md#get-profile-list)
* [Change PWN Device State-Activate](../../doc/controllers/pwn.md#change-pwn-device-state-activate)
* [Change PWN Device State-Deactivate](../../doc/controllers/pwn.md#change-pwn-device-state-deactivate)
* [Change PWN Device Profile](../../doc/controllers/pwn.md#change-pwn-device-profile)
* [Change PWN Device IPaddress](../../doc/controllers/pwn.md#change-pwn-device-ipaddress)
* [Get PWN Performance Consent](../../doc/controllers/pwn.md#get-pwn-performance-consent)


# KPI List

```go
KpiList(
    ctx context.Context,
    aname string) (
    models.ApiResponse[models.KpiInfoList],
    error)
```

## Parameters

| Parameter | Type | Tags | Description |
|  --- | --- | --- | --- |
| `aname` | `string` | Template, Required | Account name. |

## Response Type

This method returns an [`ApiResponse`](../../doc/api-response.md) instance. The `Data` property of this instance returns the response data which is of type [models.KpiInfoList](../../doc/models/kpi-info-list.md).

## Example Usage

```go
ctx := context.Background()

aname := "0342351414-00001"

apiResponse, err := pwnApi.KpiList(ctx, aname)
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
  "KpiInfoList": [
    {
      "name": "DOWNLINK_THROUGHPUT",
      "value": "23.2",
      "nodeName": "132924_ENB_VZ_EULESS_OLTE_RD-01",
      "nodeType": "BASEBAND",
      "description": "Downlink throughput (4G)",
      "unit": "Mbps",
      "category": "Network Performance Radio",
      "timeOfLastUpdate": "2022-12-07T08:39:59.228Z"
    }
  ]
}
```


# Get Profile List

```go
GetProfileList(
    ctx context.Context,
    aname string) (
    models.ApiResponse[models.PwnProfileList],
    error)
```

## Parameters

| Parameter | Type | Tags | Description |
|  --- | --- | --- | --- |
| `aname` | `string` | Template, Required | Account name. |

## Response Type

This method returns an [`ApiResponse`](../../doc/api-response.md) instance. The `Data` property of this instance returns the response data which is of type [models.PwnProfileList](../../doc/models/pwn-profile-list.md).

## Example Usage

```go
ctx := context.Background()

aname := "0342351414-00001"

apiResponse, err := pwnApi.GetProfileList(ctx, aname)
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
  "profiles": [
    {
      "profileId": "HSS-EsmProfile_Enterprise",
      "profileName": "HSS EsmProfile Enterprise"
    }
  ]
}
```


# Change PWN Device State-Activate

```go
ChangePwnDeviceStateActivate(
    ctx context.Context,
    body models.ChangePwnDeviceStateActivateRequest) (
    models.ApiResponse[models.ChangePwnDeviceStateResponse],
    error)
```

## Parameters

| Parameter | Type | Tags | Description |
|  --- | --- | --- | --- |
| `body` | [`models.ChangePwnDeviceStateActivateRequest`](../../doc/models/change-pwn-device-state-activate-request.md) | Body, Required | - |

## Response Type

This method returns an [`ApiResponse`](../../doc/api-response.md) instance. The `Data` property of this instance returns the response data which is of type [models.ChangePwnDeviceStateResponse](../../doc/models/change-pwn-device-state-response.md).

## Example Usage

```go
ctx := context.Background()

body := models.ChangePwnDeviceStateActivateRequest{
    AccountName:           "0342351414-00001",
    DeviceList:            []models.PwnDeviceList{
        models.PwnDeviceList{
            DeviceIds:             []models.PwnDeviceId{
                models.PwnDeviceId{
                    Id:                    "99948099913024600001",
                    Kind:                  "iccid",
                },
            },
        },
    },
    Activate:              models.Activate{
        Profile:               "HSS EsmProfile Enterprise 5G",
    },
}

apiResponse, err := pwnApi.ChangePwnDeviceStateActivate(ctx, body)
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
  "requestId": "c7b45cf2-cab1-4e42-82f8-20350f4c4ea3"
}
```


# Change PWN Device State-Deactivate

```go
ChangePwnDeviceStateDeactivate(
    ctx context.Context,
    body models.ChangePwnDeviceStateDeactivateRequest) (
    models.ApiResponse[models.ChangePwnDeviceStateResponse],
    error)
```

## Parameters

| Parameter | Type | Tags | Description |
|  --- | --- | --- | --- |
| `body` | [`models.ChangePwnDeviceStateDeactivateRequest`](../../doc/models/change-pwn-device-state-deactivate-request.md) | Body, Required | - |

## Response Type

This method returns an [`ApiResponse`](../../doc/api-response.md) instance. The `Data` property of this instance returns the response data which is of type [models.ChangePwnDeviceStateResponse](../../doc/models/change-pwn-device-state-response.md).

## Example Usage

```go
ctx := context.Background()

body := models.ChangePwnDeviceStateDeactivateRequest{
    AccountName:           "0342351414-00001",
    DeviceList:            []models.PwnDeviceList{
        models.PwnDeviceList{
            DeviceIds:             []models.PwnDeviceId{
                models.PwnDeviceId{
                    Id:                    "99948099913031600000",
                    Kind:                  "iccid",
                },
            },
        },
        models.PwnDeviceList{
            DeviceIds:             []models.PwnDeviceId{
                models.PwnDeviceId{
                    Id:                    "99948099913031700000",
                    Kind:                  "iccid",
                },
            },
        },
    },
}

apiResponse, err := pwnApi.ChangePwnDeviceStateDeactivate(ctx, body)
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
  "requestId": "c7b45cf2-cab1-4e42-82f8-20350f4c4ea3"
}
```


# Change PWN Device Profile

```go
ChangePwnDeviceProfile(
    ctx context.Context,
    body models.ChangePwnDeviceProfileRequest) (
    models.ApiResponse[models.ChangePwnDeviceProfileResponse],
    error)
```

## Parameters

| Parameter | Type | Tags | Description |
|  --- | --- | --- | --- |
| `body` | [`models.ChangePwnDeviceProfileRequest`](../../doc/models/change-pwn-device-profile-request.md) | Body, Required | - |

## Response Type

This method returns an [`ApiResponse`](../../doc/api-response.md) instance. The `Data` property of this instance returns the response data which is of type [models.ChangePwnDeviceProfileResponse](../../doc/models/change-pwn-device-profile-response.md).

## Example Usage

```go
ctx := context.Background()

body := models.ChangePwnDeviceProfileRequest{
    AccountName:           "0342351414-00001",
    DeviceList:            []models.PwnDeviceList{
        models.PwnDeviceList{
            DeviceIds:             []models.PwnDeviceId{
                models.PwnDeviceId{
                    Id:                    "99948099913024600000",
                    Kind:                  "iccid",
                },
            },
        },
    },
    NewProfile:            "HSS EsmProfile Enterprise 5G internet",
}

apiResponse, err := pwnApi.ChangePwnDeviceProfile(ctx, body)
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
  "requestId": "c7b45cf2-cab1-4e42-82f8-20350f4c4ea3"
}
```


# Change PWN Device IPaddress

```go
ChangePwnDeviceIpaddress(
    ctx context.Context,
    body models.ChangePwnDeviceIpaddressRequest) (
    models.ApiResponse[models.ChangePwnDeviceIpaddressResponse],
    error)
```

## Parameters

| Parameter | Type | Tags | Description |
|  --- | --- | --- | --- |
| `body` | [`models.ChangePwnDeviceIpaddressRequest`](../../doc/models/change-pwn-device-ipaddress-request.md) | Body, Required | - |

## Response Type

This method returns an [`ApiResponse`](../../doc/api-response.md) instance. The `Data` property of this instance returns the response data which is of type [models.ChangePwnDeviceIpaddressResponse](../../doc/models/change-pwn-device-ipaddress-response.md).

## Example Usage

```go
ctx := context.Background()

body := models.ChangePwnDeviceIpaddressRequest{
    AccountName:           "0342351414-00001",
    DeviceList:            []models.DeviceListIp{
        models.DeviceListIp{
            DeviceIds:             []models.PwnDeviceId{
                models.PwnDeviceId{
                    Id:                    "99948099913024600000",
                    Kind:                  "iccid",
                },
            },
            Ipaddress:             "10.3.4.5",
        },
        models.DeviceListIp{
            DeviceIds:             []models.PwnDeviceId{
                models.PwnDeviceId{
                    Id:                    "999480500019111000001",
                    Kind:                  "iccid",
                },
            },
            Ipaddress:             "10.4.5.7",
        },
    },
}

apiResponse, err := pwnApi.ChangePwnDeviceIpaddress(ctx, body)
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
  "requestId": "c7b45cf2-cab1-4e42-82f8-20350f4c4ea3"
}
```


# Get PWN Performance Consent

```go
GetPwnPerformanceConsent(
    ctx context.Context,
    aname string) (
    models.ApiResponse[models.GetPwnPerformanceConsentResponse],
    error)
```

## Parameters

| Parameter | Type | Tags | Description |
|  --- | --- | --- | --- |
| `aname` | `string` | Template, Required | Account name. |

## Response Type

This method returns an [`ApiResponse`](../../doc/api-response.md) instance. The `Data` property of this instance returns the response data which is of type [models.GetPwnPerformanceConsentResponse](../../doc/models/get-pwn-performance-consent-response.md).

## Example Usage

```go
ctx := context.Background()

aname := "1533445500-00088"

apiResponse, err := pwnApi.GetPwnPerformanceConsent(ctx, aname)
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
  "consent": "false"
}
```

