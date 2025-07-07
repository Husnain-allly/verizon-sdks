# Service Plans

```java
ServicePlansApi servicePlansApi = client.getServicePlansApi();
```

## Class Name

`ServicePlansApi`


# List Account Service Plans

Returns a list of all data service plans that are associated with a specified billing account. When you send a request to /devices/actions/activate to activate a line of service you must specify the code for one of the service plans associated with your account.

```java
CompletableFuture<ApiResponse<List<ServicePlan>>> listAccountServicePlansAsync(
    final String aname)
```

## Parameters

| Parameter | Type | Tags | Description |
|  --- | --- | --- | --- |
| `aname` | `String` | Template, Required | Account name. |

## Server

`Server.THINGSPACE`

## Response Type

This method returns an [`ApiResponse`](../../doc/api-response.md) instance. The `getResult()` getter of this instance returns the response data which is of type [`List<ServicePlan>`](../../doc/models/service-plan.md).

## Example Usage

```java
String aname = "0252012345-00001";

servicePlansApi.listAccountServicePlansAsync(aname).thenAccept(result -> {
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
[
  {
    "name": "2MSHR5GB",
    "code": "M2MSHR5GB",
    "sizeKb": 0,
    "carrierServicePlanCode": "84638"
  },
  {
    "name": "TNTL200TALK",
    "code": "NTL200TALK",
    "sizeKb": 0,
    "carrierServicePlanCode": "74644"
  }
]
```

## Errors

| HTTP Status Code | Error Description | Exception Class |
|  --- | --- | --- |
| 400 | Error response. | [`ConnectivityManagementResultException`](../../doc/models/connectivity-management-result-exception.md) |

