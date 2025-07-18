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
 * This is a model class for GetAccountDeviceConsent type.
 */
public class GetAccountDeviceConsent {
    private List<Object> deviceList;
    private String accountName;
    private Integer allDeviceConsent;
    private AdditionalProperties<Object> additionalProperties = 
            new AdditionalProperties<Object>(this.getClass());

    /**
     * Default constructor.
     */
    public GetAccountDeviceConsent() {
    }

    /**
     * Initialization constructor.
     * @param  deviceList  List of Object value for deviceList.
     * @param  accountName  String value for accountName.
     * @param  allDeviceConsent  Integer value for allDeviceConsent.
     */
    public GetAccountDeviceConsent(
            List<Object> deviceList,
            String accountName,
            Integer allDeviceConsent) {
        this.deviceList = deviceList;
        this.accountName = accountName;
        this.allDeviceConsent = allDeviceConsent;
    }

    /**
     * Getter for DeviceList.
     * An array of device identifiers
     * @return Returns the List of Object
     */
    @JsonGetter("deviceList")
    @JsonInclude(JsonInclude.Include.NON_NULL)
    public List<Object> getDeviceList() {
        return deviceList;
    }

    /**
     * Setter for DeviceList.
     * An array of device identifiers
     * @param deviceList Value for List of Object
     */
    @JsonSetter("deviceList")
    public void setDeviceList(List<Object> deviceList) {
        this.deviceList = deviceList;
    }

    /**
     * Getter for AccountName.
     * The numeric name of the account, including leading zeros.
     * @return Returns the String
     */
    @JsonGetter("accountName")
    @JsonInclude(JsonInclude.Include.NON_NULL)
    public String getAccountName() {
        return accountName;
    }

    /**
     * Setter for AccountName.
     * The numeric name of the account, including leading zeros.
     * @param accountName Value for String
     */
    @JsonSetter("accountName")
    public void setAccountName(String accountName) {
        this.accountName = accountName;
    }

    /**
     * Getter for AllDeviceConsent.
     * If consent is set at the account level, this value will show the consent level.
     * @return Returns the Integer
     */
    @JsonGetter("allDeviceConsent")
    @JsonInclude(JsonInclude.Include.NON_NULL)
    public Integer getAllDeviceConsent() {
        return allDeviceConsent;
    }

    /**
     * Setter for AllDeviceConsent.
     * If consent is set at the account level, this value will show the consent level.
     * @param allDeviceConsent Value for Integer
     */
    @JsonSetter("allDeviceConsent")
    public void setAllDeviceConsent(Integer allDeviceConsent) {
        this.allDeviceConsent = allDeviceConsent;
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
     * Converts this GetAccountDeviceConsent into string format.
     * @return String representation of this class
     */
    @Override
    public String toString() {
        return "GetAccountDeviceConsent [" + "deviceList=" + deviceList + ", accountName="
                + accountName + ", allDeviceConsent=" + allDeviceConsent + ", additionalProperties="
                + additionalProperties + "]";
    }

    /**
     * Builds a new {@link GetAccountDeviceConsent.Builder} object.
     * Creates the instance with the state of the current model.
     * @return a new {@link GetAccountDeviceConsent.Builder} object
     */
    public Builder toBuilder() {
        Builder builder = new Builder()
                .deviceList(getDeviceList())
                .accountName(getAccountName())
                .allDeviceConsent(getAllDeviceConsent());
        builder.additionalProperties = additionalProperties;
        return builder;
    }

    /**
     * Class to build instances of {@link GetAccountDeviceConsent}.
     */
    public static class Builder {
        private List<Object> deviceList;
        private String accountName;
        private Integer allDeviceConsent;
        private AdditionalProperties<Object> additionalProperties =
                new AdditionalProperties<Object>();



        /**
         * Setter for deviceList.
         * @param  deviceList  List of Object value for deviceList.
         * @return Builder
         */
        public Builder deviceList(List<Object> deviceList) {
            this.deviceList = deviceList;
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
         * Setter for allDeviceConsent.
         * @param  allDeviceConsent  Integer value for allDeviceConsent.
         * @return Builder
         */
        public Builder allDeviceConsent(Integer allDeviceConsent) {
            this.allDeviceConsent = allDeviceConsent;
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
         * Builds a new {@link GetAccountDeviceConsent} object using the set fields.
         * @return {@link GetAccountDeviceConsent}
         */
        public GetAccountDeviceConsent build() {
            GetAccountDeviceConsent model =
                    new GetAccountDeviceConsent(deviceList, accountName, allDeviceConsent);
            model.additionalProperties = additionalProperties;
            return model;
        }
    }
}
