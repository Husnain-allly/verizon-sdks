# Thing Space Qualityof Service API Actions

```python
thing_space_qualityof_service_api_actions_api = client.thing_space_qualityof_service_api_actions
```

## Class Name

`ThingSpaceQualityofServiceApiActionsApi`

## Methods

* [Create a Thing Space Quality of Service API Subscription](../../doc/controllers/thing-space-qualityof-service-api-actions.md#create-a-thing-space-quality-of-service-api-subscription)
* [Stop a Thing Space Quality of Service API Subscription](../../doc/controllers/thing-space-qualityof-service-api-actions.md#stop-a-thing-space-quality-of-service-api-subscription)


# Create a Thing Space Quality of Service API Subscription

Creates a QoS elevation subscription ID and activates the subscription.

```python
def create_a_thing_space_quality_of_service_api_subscription(self,
                                                            body)
```

## Parameters

| Parameter | Type | Tags | Description |
|  --- | --- | --- | --- |
| `body` | [`SubscribeRequest`](../../doc/models/subscribe-request.md) | Body, Required | The request details to create a ThingSpace Quality of Service API subscription. |

## Response Type

This method returns an [`ApiResponse`](../../doc/api-response.md) instance. The `body` property of this instance returns the response data which is of type [`M201Success`](../../doc/models/m201-success.md).

## Example Usage

```python
body = SubscribeRequest(
    account_name='0000123456-00001',
    device_info=[
        QosDeviceInfo(
            device_id=QosDeviceId(
                additional_properties=None,
                id='10-digit phone number',
                kind='mdn'
            ),
            flow_info=[
                FlowInfo(
                    additional_properties=None,
                    flow_server='[IPv6 address]:port',
                    flow_device='[IPv6 address]:port',
                    flow_direction='UPLINK',
                    flow_protocol='UDP',
                    qci_option='Premium'
                )
            ],
            additional_properties=None,
            device_i_pv_6_addr='IPv6 address'
        )
    ],
    additional_properties=None
)

result = thing_space_quality_of_service_api_actions_api.create_a_thing_space_quality_of_service_api_subscription(body)

if result.is_success():
    print(result.body)
elif result.is_error():
    print(result.errors)
```

## Errors

| HTTP Status Code | Error Description | Exception Class |
|  --- | --- | --- |
| Default | Error Response | [`DefaultResponseException`](../../doc/models/default-response-exception.md) |


# Stop a Thing Space Quality of Service API Subscription

Stops an active ThingSpace Quality of Service API subscription using the account name and the subscription ID.

```python
def stop_a_thing_space_quality_of_service_api_subscription(self,
                                                          account_name,
                                                          qos_subscription_id)
```

## Parameters

| Parameter | Type | Tags | Description |
|  --- | --- | --- | --- |
| `account_name` | `str` | Query, Required | - |
| `qos_subscription_id` | `str` | Query, Required | - |

## Response Type

This method returns an [`ApiResponse`](../../doc/api-response.md) instance. The `body` property of this instance returns the response data which is of type [`M201Success`](../../doc/models/m201-success.md).

## Example Usage

```python
account_name = '0000123456-00001'

qos_subscription_id = 'QoS subscription ID'

result = thing_space_quality_of_service_api_actions_api.stop_a_thing_space_quality_of_service_api_subscription(
    account_name,
    qos_subscription_id
)

if result.is_success():
    print(result.body)
elif result.is_error():
    print(result.errors)
```

## Errors

| HTTP Status Code | Error Description | Exception Class |
|  --- | --- | --- |
| Default | Error Response | [`DefaultResponseException`](../../doc/models/default-response-exception.md) |

