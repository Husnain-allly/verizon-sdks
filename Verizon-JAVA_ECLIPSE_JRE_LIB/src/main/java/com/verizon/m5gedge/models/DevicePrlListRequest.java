/*
 * VerizonLib
 *
 * This file was automatically generated by APIMATIC v3.0 ( https://www.apimatic.io ).
 */

package com.verizon.m5gedge.models;

import com.fasterxml.jackson.annotation.JsonAnyGetter;
import com.fasterxml.jackson.annotation.JsonAnySetter;
import com.fasterxml.jackson.annotation.JsonGetter;
import com.fasterxml.jackson.annotation.JsonInclude;
import com.fasterxml.jackson.annotation.JsonSetter;
import io.apimatic.core.types.AdditionalProperties;
import io.apimatic.core.utilities.ConversionHelper;
import java.util.List;
import java.util.Map;

/**
 * This is a model class for DevicePrlListRequest type.
 */
public class DevicePrlListRequest {
    private List<DeviceId> deviceIds;
    private String accountName;
    private List<CustomFields> customFields;
    private String groupName;
    private String servicePlan;
    private AdditionalProperties<Object> additionalProperties = 
            new AdditionalProperties<Object>(this.getClass());

    /**
     * Default constructor.
     */
    public DevicePrlListRequest() {
    }

    /**
     * Initialization constructor.
     * @param  deviceIds  List of DeviceId value for deviceIds.
     * @param  accountName  String value for accountName.
     * @param  customFields  List of CustomFields value for customFields.
     * @param  groupName  String value for groupName.
     * @param  servicePlan  String value for servicePlan.
     */
    public DevicePrlListRequest(
            List<DeviceId> deviceIds,
            String accountName,
            List<CustomFields> customFields,
            String groupName,
            String servicePlan) {
        this.deviceIds = deviceIds;
        this.accountName = accountName;
        this.customFields = customFields;
        this.groupName = groupName;
        this.servicePlan = servicePlan;
    }

    /**
     * Getter for DeviceIds.
     * The devices for which you want the PRL version, specified by device identifier. You only need
     * to provide one identifier per device. Do not use any of the other parameters if you specify
     * device IDs.
     * @return Returns the List of DeviceId
     */
    @JsonGetter("deviceIds")
    @JsonInclude(JsonInclude.Include.NON_NULL)
    public List<DeviceId> getDeviceIds() {
        return deviceIds;
    }

    /**
     * Setter for DeviceIds.
     * The devices for which you want the PRL version, specified by device identifier. You only need
     * to provide one identifier per device. Do not use any of the other parameters if you specify
     * device IDs.
     * @param deviceIds Value for List of DeviceId
     */
    @JsonSetter("deviceIds")
    public void setDeviceIds(List<DeviceId> deviceIds) {
        this.deviceIds = deviceIds;
    }

    /**
     * Getter for AccountName.
     * The name of a billing account. This parameter is only required if you are passing groupName
     * and the UWS account used for the current API session has access to multiple billing accounts,
     * because the same device group name can exist in multiple accounts.An account name is usually
     * numeric, and must include any leading zeros.
     * @return Returns the String
     */
    @JsonGetter("accountName")
    @JsonInclude(JsonInclude.Include.NON_NULL)
    public String getAccountName() {
        return accountName;
    }

    /**
     * Setter for AccountName.
     * The name of a billing account. This parameter is only required if you are passing groupName
     * and the UWS account used for the current API session has access to multiple billing accounts,
     * because the same device group name can exist in multiple accounts.An account name is usually
     * numeric, and must include any leading zeros.
     * @param accountName Value for String
     */
    @JsonSetter("accountName")
    public void setAccountName(String accountName) {
        this.accountName = accountName;
    }

    /**
     * Getter for CustomFields.
     * The names and values of custom fields, if you want to only include devices that have matching
     * custom fields.
     * @return Returns the List of CustomFields
     */
    @JsonGetter("customFields")
    @JsonInclude(JsonInclude.Include.NON_NULL)
    public List<CustomFields> getCustomFields() {
        return customFields;
    }

    /**
     * Setter for CustomFields.
     * The names and values of custom fields, if you want to only include devices that have matching
     * custom fields.
     * @param customFields Value for List of CustomFields
     */
    @JsonSetter("customFields")
    public void setCustomFields(List<CustomFields> customFields) {
        this.customFields = customFields;
    }

    /**
     * Getter for GroupName.
     * The name of a device group, if you want to only include devices in that group.
     * @return Returns the String
     */
    @JsonGetter("groupName")
    @JsonInclude(JsonInclude.Include.NON_NULL)
    public String getGroupName() {
        return groupName;
    }

    /**
     * Setter for GroupName.
     * The name of a device group, if you want to only include devices in that group.
     * @param groupName Value for String
     */
    @JsonSetter("groupName")
    public void setGroupName(String groupName) {
        this.groupName = groupName;
    }

    /**
     * Getter for ServicePlan.
     * The name of a service plan, if you want to only include devices that have that service plan.
     * @return Returns the String
     */
    @JsonGetter("servicePlan")
    @JsonInclude(JsonInclude.Include.NON_NULL)
    public String getServicePlan() {
        return servicePlan;
    }

    /**
     * Setter for ServicePlan.
     * The name of a service plan, if you want to only include devices that have that service plan.
     * @param servicePlan Value for String
     */
    @JsonSetter("servicePlan")
    public void setServicePlan(String servicePlan) {
        this.servicePlan = servicePlan;
    }

    /**
     * Hidden method for the serialization of additional properties.
     * @return The map of additionally set properties.
     */
    @JsonAnyGetter
    private Map<String, Object> getAdditionalProperties() {
        return additionalProperties.getAdditionalProperties();
    }

    /**
     * Hidden method for the de-serialization of additional properties.
     * @param name The name of the additional property.
     * @param value The Object value of the additional property.
     */
    @JsonAnySetter
    private void setAdditionalProperties(String name, Object value) {
        additionalProperties.setAdditionalProperty(name,
                ConversionHelper.convertToSimpleType(value,
                        x -> x),
                true);
    }

    /**
     * Getter for the value of additional properties based on provided property name.
     * @param name The name of the additional property.
     * @return Either the Object property value or null if not exist.
     */
    
    public Object getAdditionalProperty(String name) {
        return additionalProperties.getAdditionalProperty(name);
    }

    /**
     * Converts this DevicePrlListRequest into string format.
     * @return String representation of this class
     */
    @Override
    public String toString() {
        return "DevicePrlListRequest [" + "deviceIds=" + deviceIds + ", accountName=" + accountName
                + ", customFields=" + customFields + ", groupName=" + groupName + ", servicePlan="
                + servicePlan + ", additionalProperties=" + additionalProperties + "]";
    }

    /**
     * Builds a new {@link DevicePrlListRequest.Builder} object.
     * Creates the instance with the state of the current model.
     * @return a new {@link DevicePrlListRequest.Builder} object
     */
    public Builder toBuilder() {
        Builder builder = new Builder()
                .deviceIds(getDeviceIds())
                .accountName(getAccountName())
                .customFields(getCustomFields())
                .groupName(getGroupName())
                .servicePlan(getServicePlan());
        builder.additionalProperties = additionalProperties;
        return builder;
    }

    /**
     * Class to build instances of {@link DevicePrlListRequest}.
     */
    public static class Builder {
        private List<DeviceId> deviceIds;
        private String accountName;
        private List<CustomFields> customFields;
        private String groupName;
        private String servicePlan;
        private AdditionalProperties<Object> additionalProperties =
                new AdditionalProperties<Object>();



        /**
         * Setter for deviceIds.
         * @param  deviceIds  List of DeviceId value for deviceIds.
         * @return Builder
         */
        public Builder deviceIds(List<DeviceId> deviceIds) {
            this.deviceIds = deviceIds;
            return this;
        }

        /**
         * Setter for accountName.
         * @param  accountName  String value for accountName.
         * @return Builder
         */
        public Builder accountName(String accountName) {
            this.accountName = accountName;
            return this;
        }

        /**
         * Setter for customFields.
         * @param  customFields  List of CustomFields value for customFields.
         * @return Builder
         */
        public Builder customFields(List<CustomFields> customFields) {
            this.customFields = customFields;
            return this;
        }

        /**
         * Setter for groupName.
         * @param  groupName  String value for groupName.
         * @return Builder
         */
        public Builder groupName(String groupName) {
            this.groupName = groupName;
            return this;
        }

        /**
         * Setter for servicePlan.
         * @param  servicePlan  String value for servicePlan.
         * @return Builder
         */
        public Builder servicePlan(String servicePlan) {
            this.servicePlan = servicePlan;
            return this;
        }

        /**
         * Setter for additional property that are not in model fields.
         * @param name The name of the additional property.
         * @param value The Object value of the additional property.
         * @return Builder.
         */
        public Builder additionalProperty(String name, Object value) {
            this.additionalProperties.setAdditionalProperty(name, value);
            return this;
        }

        /**
         * Builds a new {@link DevicePrlListRequest} object using the set fields.
         * @return {@link DevicePrlListRequest}
         */
        public DevicePrlListRequest build() {
            DevicePrlListRequest model =
                    new DevicePrlListRequest(deviceIds, accountName, customFields, groupName,
                            servicePlan);
            model.additionalProperties = additionalProperties;
            return model;
        }
    }
}
