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
 * This is a model class for SubscribeRequest type.
 */
public class SubscribeRequest {
    private String accountName;
    private List<QosDeviceInfo> deviceInfo;
    private AdditionalProperties<Object> additionalProperties = 
            new AdditionalProperties<Object>(this.getClass());

    /**
     * Default constructor.
     */
    public SubscribeRequest() {
    }

    /**
     * Initialization constructor.
     * @param  accountName  String value for accountName.
     * @param  deviceInfo  List of QosDeviceInfo value for deviceInfo.
     */
    public SubscribeRequest(
            String accountName,
            List<QosDeviceInfo> deviceInfo) {
        this.accountName = accountName;
        this.deviceInfo = deviceInfo;
    }

    /**
     * Getter for AccountName.
     * @return Returns the String
     */
    @JsonGetter("accountName")
    public String getAccountName() {
        return accountName;
    }

    /**
     * Setter for AccountName.
     * @param accountName Value for String
     */
    @JsonSetter("accountName")
    public void setAccountName(String accountName) {
        this.accountName = accountName;
    }

    /**
     * Getter for DeviceInfo.
     * @return Returns the List of QosDeviceInfo
     */
    @JsonGetter("deviceInfo")
    public List<QosDeviceInfo> getDeviceInfo() {
        return deviceInfo;
    }

    /**
     * Setter for DeviceInfo.
     * @param deviceInfo Value for List of QosDeviceInfo
     */
    @JsonSetter("deviceInfo")
    public void setDeviceInfo(List<QosDeviceInfo> deviceInfo) {
        this.deviceInfo = deviceInfo;
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
     * Converts this SubscribeRequest into string format.
     * @return String representation of this class
     */
    @Override
    public String toString() {
        return "SubscribeRequest [" + "accountName=" + accountName + ", deviceInfo=" + deviceInfo
                + ", additionalProperties=" + additionalProperties + "]";
    }

    /**
     * Builds a new {@link SubscribeRequest.Builder} object.
     * Creates the instance with the state of the current model.
     * @return a new {@link SubscribeRequest.Builder} object
     */
    public Builder toBuilder() {
        Builder builder = new Builder(accountName, deviceInfo);
        builder.additionalProperties = additionalProperties;
        return builder;
    }

    /**
     * Class to build instances of {@link SubscribeRequest}.
     */
    public static class Builder {
        private String accountName;
        private List<QosDeviceInfo> deviceInfo;
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
         * @param  deviceInfo  List of QosDeviceInfo value for deviceInfo.
         */
        public Builder(String accountName, List<QosDeviceInfo> deviceInfo) {
            this.accountName = accountName;
            this.deviceInfo = deviceInfo;
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
         * Setter for deviceInfo.
         * @param  deviceInfo  List of QosDeviceInfo value for deviceInfo.
         * @return Builder
         */
        public Builder deviceInfo(List<QosDeviceInfo> deviceInfo) {
            this.deviceInfo = deviceInfo;
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
         * Builds a new {@link SubscribeRequest} object using the set fields.
         * @return {@link SubscribeRequest}
         */
        public SubscribeRequest build() {
            SubscribeRequest model =
                    new SubscribeRequest(accountName, deviceInfo);
            model.additionalProperties = additionalProperties;
            return model;
        }
    }
}
