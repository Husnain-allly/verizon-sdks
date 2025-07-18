/*
 * VerizonLib
 *
 * This file was automatically generated by APIMATIC v3.0 ( https://www.apimatic.io ).
 */

package com.verizon.m5gedge.models;

import com.fasterxml.jackson.annotation.JsonGetter;
import com.fasterxml.jackson.annotation.JsonInclude;
import com.fasterxml.jackson.annotation.JsonSetter;
import java.util.List;

/**
 * This is a model class for GiosmsSendRequest type.
 */
public class GiosmsSendRequest {
    private String accountName;
    private List<KvPair> customFields;
    private String dataEncoding;
    private String groupName;
    private String servicePlan;
    private String timeToLive;
    private List<GioDeviceId> deviceIds;
    private String smsMessage;

    /**
     * Default constructor.
     */
    public GiosmsSendRequest() {
    }

    /**
     * Initialization constructor.
     * @param  smsMessage  String value for smsMessage.
     * @param  accountName  String value for accountName.
     * @param  customFields  List of KvPair value for customFields.
     * @param  dataEncoding  String value for dataEncoding.
     * @param  groupName  String value for groupName.
     * @param  servicePlan  String value for servicePlan.
     * @param  timeToLive  String value for timeToLive.
     * @param  deviceIds  List of GioDeviceId value for deviceIds.
     */
    public GiosmsSendRequest(
            String smsMessage,
            String accountName,
            List<KvPair> customFields,
            String dataEncoding,
            String groupName,
            String servicePlan,
            String timeToLive,
            List<GioDeviceId> deviceIds) {
        this.accountName = accountName;
        this.customFields = customFields;
        this.dataEncoding = dataEncoding;
        this.groupName = groupName;
        this.servicePlan = servicePlan;
        this.timeToLive = timeToLive;
        this.deviceIds = deviceIds;
        this.smsMessage = smsMessage;
    }

    /**
     * Getter for AccountName.
     * @return Returns the String
     */
    @JsonGetter("accountName")
    @JsonInclude(JsonInclude.Include.NON_NULL)
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
     * Getter for CustomFields.
     * @return Returns the List of KvPair
     */
    @JsonGetter("customFields")
    @JsonInclude(JsonInclude.Include.NON_NULL)
    public List<KvPair> getCustomFields() {
        return customFields;
    }

    /**
     * Setter for CustomFields.
     * @param customFields Value for List of KvPair
     */
    @JsonSetter("customFields")
    public void setCustomFields(List<KvPair> customFields) {
        this.customFields = customFields;
    }

    /**
     * Getter for DataEncoding.
     * @return Returns the String
     */
    @JsonGetter("dataEncoding")
    @JsonInclude(JsonInclude.Include.NON_NULL)
    public String getDataEncoding() {
        return dataEncoding;
    }

    /**
     * Setter for DataEncoding.
     * @param dataEncoding Value for String
     */
    @JsonSetter("dataEncoding")
    public void setDataEncoding(String dataEncoding) {
        this.dataEncoding = dataEncoding;
    }

    /**
     * Getter for GroupName.
     * @return Returns the String
     */
    @JsonGetter("groupName")
    @JsonInclude(JsonInclude.Include.NON_NULL)
    public String getGroupName() {
        return groupName;
    }

    /**
     * Setter for GroupName.
     * @param groupName Value for String
     */
    @JsonSetter("groupName")
    public void setGroupName(String groupName) {
        this.groupName = groupName;
    }

    /**
     * Getter for ServicePlan.
     * @return Returns the String
     */
    @JsonGetter("servicePlan")
    @JsonInclude(JsonInclude.Include.NON_NULL)
    public String getServicePlan() {
        return servicePlan;
    }

    /**
     * Setter for ServicePlan.
     * @param servicePlan Value for String
     */
    @JsonSetter("servicePlan")
    public void setServicePlan(String servicePlan) {
        this.servicePlan = servicePlan;
    }

    /**
     * Getter for TimeToLive.
     * A period of time the message remains valid or an end date for the message. This value would
     * be less than the 5 day default.
     * @return Returns the String
     */
    @JsonGetter("timeToLive")
    @JsonInclude(JsonInclude.Include.NON_NULL)
    public String getTimeToLive() {
        return timeToLive;
    }

    /**
     * Setter for TimeToLive.
     * A period of time the message remains valid or an end date for the message. This value would
     * be less than the 5 day default.
     * @param timeToLive Value for String
     */
    @JsonSetter("timeToLive")
    public void setTimeToLive(String timeToLive) {
        this.timeToLive = timeToLive;
    }

    /**
     * Getter for DeviceIds.
     * @return Returns the List of GioDeviceId
     */
    @JsonGetter("deviceIds")
    @JsonInclude(JsonInclude.Include.NON_NULL)
    public List<GioDeviceId> getDeviceIds() {
        return deviceIds;
    }

    /**
     * Setter for DeviceIds.
     * @param deviceIds Value for List of GioDeviceId
     */
    @JsonSetter("deviceIds")
    public void setDeviceIds(List<GioDeviceId> deviceIds) {
        this.deviceIds = deviceIds;
    }

    /**
     * Getter for SmsMessage.
     * @return Returns the String
     */
    @JsonGetter("smsMessage")
    public String getSmsMessage() {
        return smsMessage;
    }

    /**
     * Setter for SmsMessage.
     * @param smsMessage Value for String
     */
    @JsonSetter("smsMessage")
    public void setSmsMessage(String smsMessage) {
        this.smsMessage = smsMessage;
    }

    /**
     * Converts this GiosmsSendRequest into string format.
     * @return String representation of this class
     */
    @Override
    public String toString() {
        return "GiosmsSendRequest [" + "smsMessage=" + smsMessage + ", accountName=" + accountName
                + ", customFields=" + customFields + ", dataEncoding=" + dataEncoding
                + ", groupName=" + groupName + ", servicePlan=" + servicePlan + ", timeToLive="
                + timeToLive + ", deviceIds=" + deviceIds + "]";
    }

    /**
     * Builds a new {@link GiosmsSendRequest.Builder} object.
     * Creates the instance with the state of the current model.
     * @return a new {@link GiosmsSendRequest.Builder} object
     */
    public Builder toBuilder() {
        Builder builder = new Builder(smsMessage)
                .accountName(getAccountName())
                .customFields(getCustomFields())
                .dataEncoding(getDataEncoding())
                .groupName(getGroupName())
                .servicePlan(getServicePlan())
                .timeToLive(getTimeToLive())
                .deviceIds(getDeviceIds());
        return builder;
    }

    /**
     * Class to build instances of {@link GiosmsSendRequest}.
     */
    public static class Builder {
        private String smsMessage;
        private String accountName;
        private List<KvPair> customFields;
        private String dataEncoding;
        private String groupName;
        private String servicePlan;
        private String timeToLive;
        private List<GioDeviceId> deviceIds;

        /**
         * Initialization constructor.
         */
        public Builder() {
        }

        /**
         * Initialization constructor.
         * @param  smsMessage  String value for smsMessage.
         */
        public Builder(String smsMessage) {
            this.smsMessage = smsMessage;
        }

        /**
         * Setter for smsMessage.
         * @param  smsMessage  String value for smsMessage.
         * @return Builder
         */
        public Builder smsMessage(String smsMessage) {
            this.smsMessage = smsMessage;
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
         * @param  customFields  List of KvPair value for customFields.
         * @return Builder
         */
        public Builder customFields(List<KvPair> customFields) {
            this.customFields = customFields;
            return this;
        }

        /**
         * Setter for dataEncoding.
         * @param  dataEncoding  String value for dataEncoding.
         * @return Builder
         */
        public Builder dataEncoding(String dataEncoding) {
            this.dataEncoding = dataEncoding;
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
         * Setter for timeToLive.
         * @param  timeToLive  String value for timeToLive.
         * @return Builder
         */
        public Builder timeToLive(String timeToLive) {
            this.timeToLive = timeToLive;
            return this;
        }

        /**
         * Setter for deviceIds.
         * @param  deviceIds  List of GioDeviceId value for deviceIds.
         * @return Builder
         */
        public Builder deviceIds(List<GioDeviceId> deviceIds) {
            this.deviceIds = deviceIds;
            return this;
        }

        /**
         * Builds a new {@link GiosmsSendRequest} object using the set fields.
         * @return {@link GiosmsSendRequest}
         */
        public GiosmsSendRequest build() {
            return new GiosmsSendRequest(smsMessage, accountName, customFields, dataEncoding,
                    groupName, servicePlan, timeToLive, deviceIds);
        }
    }
}
