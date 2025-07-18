/*
 * VerizonLib
 *
 * This file was automatically generated by APIMATIC v3.0 ( https://www.apimatic.io ).
 */

package com.verizon.m5gedge.models;

import com.fasterxml.jackson.annotation.JsonAnyGetter;
import com.fasterxml.jackson.annotation.JsonAnySetter;
import com.fasterxml.jackson.annotation.JsonGetter;
import com.fasterxml.jackson.annotation.JsonSetter;
import io.apimatic.core.types.AdditionalProperties;
import io.apimatic.core.utilities.ConversionHelper;
import java.util.List;
import java.util.Map;

/**
 * This is a model class for DeviceExtendedDiagnosticsRequest type.
 */
public class DeviceExtendedDiagnosticsRequest {
    private String accountName;
    private List<DeviceId> deviceList;
    private AdditionalProperties<Object> additionalProperties = 
            new AdditionalProperties<Object>(this.getClass());

    /**
     * Default constructor.
     */
    public DeviceExtendedDiagnosticsRequest() {
    }

    /**
     * Initialization constructor.
     * @param  accountName  String value for accountName.
     * @param  deviceList  List of DeviceId value for deviceList.
     */
    public DeviceExtendedDiagnosticsRequest(
            String accountName,
            List<DeviceId> deviceList) {
        this.accountName = accountName;
        this.deviceList = deviceList;
    }

    /**
     * Getter for AccountName.
     * The Verizon billing account that the device belongs to. An account name is usually numeric,
     * and must include any leading zeros.
     * @return Returns the String
     */
    @JsonGetter("accountName")
    public String getAccountName() {
        return accountName;
    }

    /**
     * Setter for AccountName.
     * The Verizon billing account that the device belongs to. An account name is usually numeric,
     * and must include any leading zeros.
     * @param accountName Value for String
     */
    @JsonSetter("accountName")
    public void setAccountName(String accountName) {
        this.accountName = accountName;
    }

    /**
     * Getter for DeviceList.
     * The device for which you want diagnostic information, specified by the device's MDN.
     * @return Returns the List of DeviceId
     */
    @JsonGetter("deviceList")
    public List<DeviceId> getDeviceList() {
        return deviceList;
    }

    /**
     * Setter for DeviceList.
     * The device for which you want diagnostic information, specified by the device's MDN.
     * @param deviceList Value for List of DeviceId
     */
    @JsonSetter("deviceList")
    public void setDeviceList(List<DeviceId> deviceList) {
        this.deviceList = deviceList;
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
     * Converts this DeviceExtendedDiagnosticsRequest into string format.
     * @return String representation of this class
     */
    @Override
    public String toString() {
        return "DeviceExtendedDiagnosticsRequest [" + "accountName=" + accountName + ", deviceList="
                + deviceList + ", additionalProperties=" + additionalProperties + "]";
    }

    /**
     * Builds a new {@link DeviceExtendedDiagnosticsRequest.Builder} object.
     * Creates the instance with the state of the current model.
     * @return a new {@link DeviceExtendedDiagnosticsRequest.Builder} object
     */
    public Builder toBuilder() {
        Builder builder = new Builder(accountName, deviceList);
        builder.additionalProperties = additionalProperties;
        return builder;
    }

    /**
     * Class to build instances of {@link DeviceExtendedDiagnosticsRequest}.
     */
    public static class Builder {
        private String accountName;
        private List<DeviceId> deviceList;
        private AdditionalProperties<Object> additionalProperties =
                new AdditionalProperties<Object>();

        /**
         * Initialization constructor.
         */
        public Builder() {
        }

        /**
         * Initialization constructor.
         * @param  accountName  String value for accountName.
         * @param  deviceList  List of DeviceId value for deviceList.
         */
        public Builder(String accountName, List<DeviceId> deviceList) {
            this.accountName = accountName;
            this.deviceList = deviceList;
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
         * Setter for deviceList.
         * @param  deviceList  List of DeviceId value for deviceList.
         * @return Builder
         */
        public Builder deviceList(List<DeviceId> deviceList) {
            this.deviceList = deviceList;
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
         * Builds a new {@link DeviceExtendedDiagnosticsRequest} object using the set fields.
         * @return {@link DeviceExtendedDiagnosticsRequest}
         */
        public DeviceExtendedDiagnosticsRequest build() {
            DeviceExtendedDiagnosticsRequest model =
                    new DeviceExtendedDiagnosticsRequest(accountName, deviceList);
            model.additionalProperties = additionalProperties;
            return model;
        }
    }
}
