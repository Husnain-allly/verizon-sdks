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
 * This is a model class for SessionReport type.
 */
public class SessionReport {
    private List<DailyUsageItem> sessions;
    private String id;
    private String txid;
    private AdditionalProperties<Object> additionalProperties = 
            new AdditionalProperties<Object>(this.getClass());

    /**
     * Default constructor.
     */
    public SessionReport() {
    }

    /**
     * Initialization constructor.
     * @param  id  String value for id.
     * @param  txid  String value for txid.
     * @param  sessions  List of DailyUsageItem value for sessions.
     */
    public SessionReport(
            String id,
            String txid,
            List<DailyUsageItem> sessions) {
        this.sessions = sessions;
        this.id = id;
        this.txid = txid;
    }

    /**
     * Getter for Sessions.
     * An object containing the start and end time of the session with the amount of data
     * transferred.
     * @return Returns the List of DailyUsageItem
     */
    @JsonGetter("sessions")
    @JsonInclude(JsonInclude.Include.NON_NULL)
    public List<DailyUsageItem> getSessions() {
        return sessions;
    }

    /**
     * Setter for Sessions.
     * An object containing the start and end time of the session with the amount of data
     * transferred.
     * @param sessions Value for List of DailyUsageItem
     */
    @JsonSetter("sessions")
    public void setSessions(List<DailyUsageItem> sessions) {
        this.sessions = sessions;
    }

    /**
     * Getter for Id.
     * The 10-digit ID of the device.
     * @return Returns the String
     */
    @JsonGetter("id")
    public String getId() {
        return id;
    }

    /**
     * Setter for Id.
     * The 10-digit ID of the device.
     * @param id Value for String
     */
    @JsonSetter("id")
    public void setId(String id) {
        this.id = id;
    }

    /**
     * Getter for Txid.
     * A unique string that associates the request with the location report information that is sent
     * in asynchronous callback message.ThingSpace will send a separate callback message for each
     * device that was in the request. All of the callback messages will have the same txid.
     * @return Returns the String
     */
    @JsonGetter("txid")
    public String getTxid() {
        return txid;
    }

    /**
     * Setter for Txid.
     * A unique string that associates the request with the location report information that is sent
     * in asynchronous callback message.ThingSpace will send a separate callback message for each
     * device that was in the request. All of the callback messages will have the same txid.
     * @param txid Value for String
     */
    @JsonSetter("txid")
    public void setTxid(String txid) {
        this.txid = txid;
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
     * Converts this SessionReport into string format.
     * @return String representation of this class
     */
    @Override
    public String toString() {
        return "SessionReport [" + "id=" + id + ", txid=" + txid + ", sessions=" + sessions
                + ", additionalProperties=" + additionalProperties + "]";
    }

    /**
     * Builds a new {@link SessionReport.Builder} object.
     * Creates the instance with the state of the current model.
     * @return a new {@link SessionReport.Builder} object
     */
    public Builder toBuilder() {
        Builder builder = new Builder(id, txid)
                .sessions(getSessions());
        builder.additionalProperties = additionalProperties;
        return builder;
    }

    /**
     * Class to build instances of {@link SessionReport}.
     */
    public static class Builder {
        private String id;
        private String txid;
        private List<DailyUsageItem> sessions;
        private AdditionalProperties<Object> additionalProperties =
                new AdditionalProperties<Object>();

        /**
         * Initialization constructor.
         */
        public Builder() {
        }

        /**
         * Initialization constructor.
         * @param  id  String value for id.
         * @param  txid  String value for txid.
         */
        public Builder(String id, String txid) {
            this.id = id;
            this.txid = txid;
        }

        /**
         * Setter for id.
         * @param  id  String value for id.
         * @return Builder
         */
        public Builder id(String id) {
            this.id = id;
            return this;
        }

        /**
         * Setter for txid.
         * @param  txid  String value for txid.
         * @return Builder
         */
        public Builder txid(String txid) {
            this.txid = txid;
            return this;
        }

        /**
         * Setter for sessions.
         * @param  sessions  List of DailyUsageItem value for sessions.
         * @return Builder
         */
        public Builder sessions(List<DailyUsageItem> sessions) {
            this.sessions = sessions;
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
         * Builds a new {@link SessionReport} object using the set fields.
         * @return {@link SessionReport}
         */
        public SessionReport build() {
            SessionReport model =
                    new SessionReport(id, txid, sessions);
            model.additionalProperties = additionalProperties;
            return model;
        }
    }
}
