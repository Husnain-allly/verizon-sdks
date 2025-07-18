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
 * This is a model class for ResponseToUsageQuery type.
 */
public class ResponseToUsageQuery {
    private Boolean hasmoredata;
    private ReadySimDeviceId deviceId;
    private List<UsageHistory> usageHistory;
    private AdditionalProperties<Object> additionalProperties = 
            new AdditionalProperties<Object>(this.getClass());

    /**
     * Default constructor.
     */
    public ResponseToUsageQuery() {
    }

    /**
     * Initialization constructor.
     * @param  hasmoredata  Boolean value for hasmoredata.
     * @param  deviceId  ReadySimDeviceId value for deviceId.
     * @param  usageHistory  List of UsageHistory value for usageHistory.
     */
    public ResponseToUsageQuery(
            Boolean hasmoredata,
            ReadySimDeviceId deviceId,
            List<UsageHistory> usageHistory) {
        this.hasmoredata = hasmoredata;
        this.deviceId = deviceId;
        this.usageHistory = usageHistory;
    }

    /**
     * Getter for Hasmoredata.
     * @return Returns the Boolean
     */
    @JsonGetter("hasmoredata")
    @JsonInclude(JsonInclude.Include.NON_NULL)
    public Boolean getHasmoredata() {
        return hasmoredata;
    }

    /**
     * Setter for Hasmoredata.
     * @param hasmoredata Value for Boolean
     */
    @JsonSetter("hasmoredata")
    public void setHasmoredata(Boolean hasmoredata) {
        this.hasmoredata = hasmoredata;
    }

    /**
     * Getter for DeviceId.
     * @return Returns the ReadySimDeviceId
     */
    @JsonGetter("deviceId")
    @JsonInclude(JsonInclude.Include.NON_NULL)
    public ReadySimDeviceId getDeviceId() {
        return deviceId;
    }

    /**
     * Setter for DeviceId.
     * @param deviceId Value for ReadySimDeviceId
     */
    @JsonSetter("deviceId")
    public void setDeviceId(ReadySimDeviceId deviceId) {
        this.deviceId = deviceId;
    }

    /**
     * Getter for UsageHistory.
     * @return Returns the List of UsageHistory
     */
    @JsonGetter("usageHistory")
    @JsonInclude(JsonInclude.Include.NON_NULL)
    public List<UsageHistory> getUsageHistory() {
        return usageHistory;
    }

    /**
     * Setter for UsageHistory.
     * @param usageHistory Value for List of UsageHistory
     */
    @JsonSetter("usageHistory")
    public void setUsageHistory(List<UsageHistory> usageHistory) {
        this.usageHistory = usageHistory;
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
     * Converts this ResponseToUsageQuery into string format.
     * @return String representation of this class
     */
    @Override
    public String toString() {
        return "ResponseToUsageQuery [" + "hasmoredata=" + hasmoredata + ", deviceId=" + deviceId
                + ", usageHistory=" + usageHistory + ", additionalProperties="
                + additionalProperties + "]";
    }

    /**
     * Builds a new {@link ResponseToUsageQuery.Builder} object.
     * Creates the instance with the state of the current model.
     * @return a new {@link ResponseToUsageQuery.Builder} object
     */
    public Builder toBuilder() {
        Builder builder = new Builder()
                .hasmoredata(getHasmoredata())
                .deviceId(getDeviceId())
                .usageHistory(getUsageHistory());
        builder.additionalProperties = additionalProperties;
        return builder;
    }

    /**
     * Class to build instances of {@link ResponseToUsageQuery}.
     */
    public static class Builder {
        private Boolean hasmoredata;
        private ReadySimDeviceId deviceId;
        private List<UsageHistory> usageHistory;
        private AdditionalProperties<Object> additionalProperties =
                new AdditionalProperties<Object>();



        /**
         * Setter for hasmoredata.
         * @param  hasmoredata  Boolean value for hasmoredata.
         * @return Builder
         */
        public Builder hasmoredata(Boolean hasmoredata) {
            this.hasmoredata = hasmoredata;
            return this;
        }

        /**
         * Setter for deviceId.
         * @param  deviceId  ReadySimDeviceId value for deviceId.
         * @return Builder
         */
        public Builder deviceId(ReadySimDeviceId deviceId) {
            this.deviceId = deviceId;
            return this;
        }

        /**
         * Setter for usageHistory.
         * @param  usageHistory  List of UsageHistory value for usageHistory.
         * @return Builder
         */
        public Builder usageHistory(List<UsageHistory> usageHistory) {
            this.usageHistory = usageHistory;
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
         * Builds a new {@link ResponseToUsageQuery} object using the set fields.
         * @return {@link ResponseToUsageQuery}
         */
        public ResponseToUsageQuery build() {
            ResponseToUsageQuery model =
                    new ResponseToUsageQuery(hasmoredata, deviceId, usageHistory);
            model.additionalProperties = additionalProperties;
            return model;
        }
    }
}
