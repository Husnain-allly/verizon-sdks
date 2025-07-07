# Device Location Callbacks

```python
device_location_callbacks_api = client.device_location_callbacks
```

## Class Name

`DeviceLocationCallbacksApi`

## Methods

* [Cancel Async Report](../../doc/controllers/device-location-callbacks.md#cancel-async-report)
* [List Registered Callbacks](../../doc/controllers/device-location-callbacks.md#list-registered-callbacks)
* [Register Callback](../../doc/controllers/device-location-callbacks.md#register-callback)
* [Deregister Callback](../../doc/controllers/device-location-callbacks.md#deregister-callback)


# Cancel Async Report

Cancel an asynchronous report request.

```python
def cancel_async_report(self,
                       account_name,
                       txid)
```

## Parameters

| Parameter | Type | Tags | Description |
|  --- | --- | --- | --- |
| `account_name` | `str` | Query, Required | Account identifier in "##########-#####". |
| `txid` | `str` | Template, Required | The `transactionId` value. |

## Response Type

This method returns an [`ApiResponse`](../../doc/api-response.md) instance. The `body` property of this instance returns the response data which is of type [`TransactionId`](../../doc/models/transaction-id.md).

## Example Usage

```python
account_name = '0000123456-00001'

txid = '2c90bd28-eeee-ffff-gggg-7e3bd4fbff33'

result = device_location_callbacks_api.cancel_async_report(
    account_name,
    txid
)

if result.is_success():
    print(result.body)
elif result.is_error():
    print(result.errors)
```

## Example Response *(as JSON)*

```json
{
  "txid": "2c90bd28-eeee-ffff-gggg-7e3bd4fbff33"
}
```

## Errors

| HTTP Status Code | Error Description | Exception Class |
|  --- | --- | --- |
| Default | Unexpected error. | [`DeviceLocationResultException`](../../doc/models/device-location-result-exception.md) |


# List Registered Callbacks

Returns a list of all registered callback URLs for the account.

```python
def list_registered_callbacks(self,
                             account_name)
```

## Parameters

| Parameter | Type | Tags | Description |
|  --- | --- | --- | --- |
| `account_name` | `str` | Template, Required | Account number. |

## Response Type

This method returns an [`ApiResponse`](../../doc/api-response.md) instance. The `body` property of this instance returns the response data which is of type [`List[DeviceLocationCallback]`](../../doc/models/device-location-callback.md).

## Example Usage

```python
account_name = '0000123456-00001'

result = device_location_callbacks_api.list_registered_callbacks(account_name)

if result.is_success():
    print(result.body)
elif result.is_error():
    print(result.errors)
```

## Example Response *(as JSON)*

```json
[
  {
    "name": "Location",
    "url": "http://10.120.102.147:50569/CallbackListener/Location.asmx"
  },
  {
    "name": "Location",
    "url": "http://10.120.102.147:50569/CallbackListener/DeviceLocation.asmx"
  }
]
```

## Errors

| HTTP Status Code | Error Description | Exception Class |
|  --- | --- | --- |
| 400 | Error response. | [`DeviceLocationResultException`](../../doc/models/device-location-result-exception.md) |


# Register Callback

Provide a URL to receive messages from a ThingSpace callback service.

```python
def register_callback(self,
                     account_name,
                     body)
```

## Parameters

| Parameter | Type | Tags | Description |
|  --- | --- | --- | --- |
| `account_name` | `str` | Template, Required | Account number. |
| `body` | [`DeviceLocationCallback`](../../doc/models/device-location-callback.md) | Body, Required | Request to register a callback. |

## Response Type

This method returns an [`ApiResponse`](../../doc/api-response.md) instance. The `body` property of this instance returns the response data which is of type [`CallbackRegistrationResult`](../../doc/models/callback-registration-result.md).

## Example Usage

```python
account_name = '0000123456-00001'

body = DeviceLocationCallback(
    name=CallbackServiceName.LOCATION,
    url='http://10.120.102.183:50559/CallbackListener/LocationServiceMessages.asmx',
    additional_properties=None
)

result = device_location_callbacks_api.register_callback(
    account_name,
    body
)

if result.is_success():
    print(result.body)
elif result.is_error():
    print(result.errors)
```

## Example Response *(as JSON)*

```json
{
  "account": "0212312345-00001",
  "name": "Location"
}
```

## Errors

| HTTP Status Code | Error Description | Exception Class |
|  --- | --- | --- |
| 400 | Error response. | [`DeviceLocationResultException`](../../doc/models/device-location-result-exception.md) |


# Deregister Callback

Deregister a URL to stop receiving callback messages.

```python
def deregister_callback(self,
                       account_name,
                       service)
```

## Parameters

| Parameter | Type | Tags | Description |
|  --- | --- | --- | --- |
| `account_name` | `str` | Template, Required | Account number. |
| `service` | [`CallbackServiceName`](../../doc/models/callback-service-name.md) | Template, Required | Callback service name. |

## Response Type

This method returns an [`ApiResponse`](../../doc/api-response.md) instance. The `body` property of this instance returns the response data which is of type [`DeviceLocationSuccessResult`](../../doc/models/device-location-success-result.md).

## Example Usage

```python
account_name = '0000123456-00001'

service = CallbackServiceName.LOCATION

result = device_location_callbacks_api.deregister_callback(
    account_name,
    service
)

if result.is_success():
    print(result.body)
elif result.is_error():
    print(result.errors)
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
| 400 | Error response. | [`DeviceLocationResultException`](../../doc/models/device-location-result-exception.md) |

