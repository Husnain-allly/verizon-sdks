# PWN

```java
PwnApi pwnApi = client.getPwnApi();
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

```java
CompletableFuture<ApiResponse<KpiInfoList>> kpiListAsync(
    final String aname)
```

## Parameters

| Parameter | Type | Tags | Description |
|  --- | --- | --- | --- |
| `aname` | `String` | Template, Required | Account name. |

## Server

`Server.THINGSPACE`

## Response Type

This method returns an [`ApiResponse`](../../doc/api-response.md) instance. The `getResult()` getter of this instance returns the response data which is of type [`KpiInfoList`](../../doc/models/kpi-info-list.md).

## Example Usage

```java
String aname = "0342351414-00001";

pwnApi.kpiListAsync(aname).thenAccept(result -> {
    // TODO success callback handler
    System.out.println(result);
}).exceptionally(exception -> {
    // TODO failure callback handler
    exception.printStackTrace();
    return null;
});
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

```java
CompletableFuture<ApiResponse<PwnProfileList>> getProfileListAsync(
    final String aname)
```

## Parameters

| Parameter | Type | Tags | Description |
|  --- | --- | --- | --- |
| `aname` | `String` | Template, Required | Account name. |

## Server

`Server.THINGSPACE`

## Response Type

This method returns an [`ApiResponse`](../../doc/api-response.md) instance. The `getResult()` getter of this instance returns the response data which is of type [`PwnProfileList`](../../doc/models/pwn-profile-list.md).

## Example Usage

```java
String aname = "0342351414-00001";

pwnApi.getProfileListAsync(aname).thenAccept(result -> {
    // TODO success callback handler
    System.out.println(result);
}).exceptionally(exception -> {
    // TODO failure callback handler
    exception.printStackTrace();
    return null;
});
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

```java
CompletableFuture<ApiResponse<ChangePwnDeviceStateResponse>> changePwnDeviceStateActivateAsync(
    final ChangePwnDeviceStateActivateRequest body)
```

## Parameters

| Parameter | Type | Tags | Description |
|  --- | --- | --- | --- |
| `body` | [`ChangePwnDeviceStateActivateRequest`](../../doc/models/change-pwn-device-state-activate-request.md) | Body, Required | - |

## Server

`Server.THINGSPACE`

## Response Type

This method returns an [`ApiResponse`](../../doc/api-response.md) instance. The `getResult()` getter of this instance returns the response data which is of type [`ChangePwnDeviceStateResponse`](../../doc/models/change-pwn-device-state-response.md).

## Example Usage

```java
ChangePwnDeviceStateActivateRequest body = new ChangePwnDeviceStateActivateRequest.Builder(
    "0342351414-00001",
    Arrays.asList(
        new PwnDeviceList.Builder(
            Arrays.asList(
                new PwnDeviceId.Builder(
                    "99948099913024600001",
                    "iccid"
                )
                .build()
            )
        )
        .build()
    ),
    new Activate.Builder(
        "HSS EsmProfile Enterprise 5G"
    )
    .build()
)
.build();

pwnApi.changePwnDeviceStateActivateAsync(body).thenAccept(result -> {
    // TODO success callback handler
    System.out.println(result);
}).exceptionally(exception -> {
    // TODO failure callback handler
    exception.printStackTrace();
    return null;
});
```

## Example Response *(as JSON)*

```json
{
  "requestId": "c7b45cf2-cab1-4e42-82f8-20350f4c4ea3"
}
```


# Change PWN Device State-Deactivate

```java
CompletableFuture<ApiResponse<ChangePwnDeviceStateResponse>> changePwnDeviceStateDeactivateAsync(
    final ChangePwnDeviceStateDeactivateRequest body)
```

## Parameters

| Parameter | Type | Tags | Description |
|  --- | --- | --- | --- |
| `body` | [`ChangePwnDeviceStateDeactivateRequest`](../../doc/models/change-pwn-device-state-deactivate-request.md) | Body, Required | - |

## Server

`Server.THINGSPACE`

## Response Type

This method returns an [`ApiResponse`](../../doc/api-response.md) instance. The `getResult()` getter of this instance returns the response data which is of type [`ChangePwnDeviceStateResponse`](../../doc/models/change-pwn-device-state-response.md).

## Example Usage

```java
ChangePwnDeviceStateDeactivateRequest body = new ChangePwnDeviceStateDeactivateRequest.Builder(
    "0342351414-00001",
    Arrays.asList(
        new PwnDeviceList.Builder(
            Arrays.asList(
                new PwnDeviceId.Builder(
                    "99948099913031600000",
                    "iccid"
                )
                .build()
            )
        )
        .build(),
        new PwnDeviceList.Builder(
            Arrays.asList(
                new PwnDeviceId.Builder(
                    "99948099913031700000",
                    "iccid"
                )
                .build()
            )
        )
        .build()
    )
)
.build();

pwnApi.changePwnDeviceStateDeactivateAsync(body).thenAccept(result -> {
    // TODO success callback handler
    System.out.println(result);
}).exceptionally(exception -> {
    // TODO failure callback handler
    exception.printStackTrace();
    return null;
});
```

## Example Response *(as JSON)*

```json
{
  "requestId": "c7b45cf2-cab1-4e42-82f8-20350f4c4ea3"
}
```


# Change PWN Device Profile

```java
CompletableFuture<ApiResponse<ChangePwnDeviceProfileResponse>> changePwnDeviceProfileAsync(
    final ChangePwnDeviceProfileRequest body)
```

## Parameters

| Parameter | Type | Tags | Description |
|  --- | --- | --- | --- |
| `body` | [`ChangePwnDeviceProfileRequest`](../../doc/models/change-pwn-device-profile-request.md) | Body, Required | - |

## Server

`Server.THINGSPACE`

## Response Type

This method returns an [`ApiResponse`](../../doc/api-response.md) instance. The `getResult()` getter of this instance returns the response data which is of type [`ChangePwnDeviceProfileResponse`](../../doc/models/change-pwn-device-profile-response.md).

## Example Usage

```java
ChangePwnDeviceProfileRequest body = new ChangePwnDeviceProfileRequest.Builder(
    "0342351414-00001",
    Arrays.asList(
        new PwnDeviceList.Builder(
            Arrays.asList(
                new PwnDeviceId.Builder(
                    "99948099913024600000",
                    "iccid"
                )
                .build()
            )
        )
        .build()
    ),
    "HSS EsmProfile Enterprise 5G internet"
)
.build();

pwnApi.changePwnDeviceProfileAsync(body).thenAccept(result -> {
    // TODO success callback handler
    System.out.println(result);
}).exceptionally(exception -> {
    // TODO failure callback handler
    exception.printStackTrace();
    return null;
});
```

## Example Response *(as JSON)*

```json
{
  "requestId": "c7b45cf2-cab1-4e42-82f8-20350f4c4ea3"
}
```


# Change PWN Device IPaddress

```java
CompletableFuture<ApiResponse<ChangePwnDeviceIpaddressResponse>> changePwnDeviceIpaddressAsync(
    final ChangePwnDeviceIpaddressRequest body)
```

## Parameters

| Parameter | Type | Tags | Description |
|  --- | --- | --- | --- |
| `body` | [`ChangePwnDeviceIpaddressRequest`](../../doc/models/change-pwn-device-ipaddress-request.md) | Body, Required | - |

## Server

`Server.THINGSPACE`

## Response Type

This method returns an [`ApiResponse`](../../doc/api-response.md) instance. The `getResult()` getter of this instance returns the response data which is of type [`ChangePwnDeviceIpaddressResponse`](../../doc/models/change-pwn-device-ipaddress-response.md).

## Example Usage

```java
ChangePwnDeviceIpaddressRequest body = new ChangePwnDeviceIpaddressRequest.Builder(
    "0342351414-00001",
    Arrays.asList(
        new DeviceListIp.Builder(
            Arrays.asList(
                new PwnDeviceId.Builder(
                    "99948099913024600000",
                    "iccid"
                )
                .build()
            ),
            "10.3.4.5"
        )
        .build(),
        new DeviceListIp.Builder(
            Arrays.asList(
                new PwnDeviceId.Builder(
                    "999480500019111000001",
                    "iccid"
                )
                .build()
            ),
            "10.4.5.7"
        )
        .build()
    )
)
.build();

pwnApi.changePwnDeviceIpaddressAsync(body).thenAccept(result -> {
    // TODO success callback handler
    System.out.println(result);
}).exceptionally(exception -> {
    // TODO failure callback handler
    exception.printStackTrace();
    return null;
});
```

## Example Response *(as JSON)*

```json
{
  "requestId": "c7b45cf2-cab1-4e42-82f8-20350f4c4ea3"
}
```


# Get PWN Performance Consent

```java
CompletableFuture<ApiResponse<GetPwnPerformanceConsentResponse>> getPwnPerformanceConsentAsync(
    final String aname)
```

## Parameters

| Parameter | Type | Tags | Description |
|  --- | --- | --- | --- |
| `aname` | `String` | Template, Required | Account name. |

## Server

`Server.THINGSPACE`

## Response Type

This method returns an [`ApiResponse`](../../doc/api-response.md) instance. The `getResult()` getter of this instance returns the response data which is of type [`GetPwnPerformanceConsentResponse`](../../doc/models/get-pwn-performance-consent-response.md).

## Example Usage

```java
String aname = "1533445500-00088";

pwnApi.getPwnPerformanceConsentAsync(aname).thenAccept(result -> {
    // TODO success callback handler
    System.out.println(result);
}).exceptionally(exception -> {
    // TODO failure callback handler
    exception.printStackTrace();
    return null;
});
```

## Example Response *(as JSON)*

```json
{
  "consent": "false"
}
```

