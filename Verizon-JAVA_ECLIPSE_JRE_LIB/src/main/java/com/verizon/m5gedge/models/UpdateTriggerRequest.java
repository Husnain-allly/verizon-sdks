/*
 * VerizonLib
 *
 * This file was automatically generated by APIMATIC v3.0 ( https://www.apimatic.io ).
 */

package com.verizon.m5gedge.models;

import com.fasterxml.jackson.annotation.JsonGetter;
import com.fasterxml.jackson.annotation.JsonInclude;
import com.fasterxml.jackson.annotation.JsonSetter;

/**
 * This is a model class for UpdateTriggerRequest type.
 */
public class UpdateTriggerRequest {
    private String accountName;
    private Boolean active;
    private AnomalyTriggerRequest anomalyTriggerRequest;
    private CycleType cycleType;
    private DataTriggerRequest dataTriggerRequest;
    private String groupName;
    private PromoAlertTriggerRequest promoAlertTriggerRequest;
    private SessionTriggerRequest sessionTriggerRequest;
    private SmsTriggerRequest smsTriggerRequest;
    private String triggerCategory;
    private String triggerId;
    private String triggerName;

    /**
     * Default constructor.
     */
    public UpdateTriggerRequest() {
    }

    /**
     * Initialization constructor.
     * @param  accountName  String value for accountName.
     * @param  active  Boolean value for active.
     * @param  anomalyTriggerRequest  AnomalyTriggerRequest value for anomalyTriggerRequest.
     * @param  cycleType  CycleType value for cycleType.
     * @param  dataTriggerRequest  DataTriggerRequest value for dataTriggerRequest.
     * @param  groupName  String value for groupName.
     * @param  promoAlertTriggerRequest  PromoAlertTriggerRequest value for
     *         promoAlertTriggerRequest.
     * @param  sessionTriggerRequest  SessionTriggerRequest value for sessionTriggerRequest.
     * @param  smsTriggerRequest  SmsTriggerRequest value for smsTriggerRequest.
     * @param  triggerCategory  String value for triggerCategory.
     * @param  triggerId  String value for triggerId.
     * @param  triggerName  String value for triggerName.
     */
    public UpdateTriggerRequest(
            String accountName,
            Boolean active,
            AnomalyTriggerRequest anomalyTriggerRequest,
            CycleType cycleType,
            DataTriggerRequest dataTriggerRequest,
            String groupName,
            PromoAlertTriggerRequest promoAlertTriggerRequest,
            SessionTriggerRequest sessionTriggerRequest,
            SmsTriggerRequest smsTriggerRequest,
            String triggerCategory,
            String triggerId,
            String triggerName) {
        this.accountName = accountName;
        this.active = active;
        this.anomalyTriggerRequest = anomalyTriggerRequest;
        this.cycleType = cycleType;
        this.dataTriggerRequest = dataTriggerRequest;
        this.groupName = groupName;
        this.promoAlertTriggerRequest = promoAlertTriggerRequest;
        this.sessionTriggerRequest = sessionTriggerRequest;
        this.smsTriggerRequest = smsTriggerRequest;
        this.triggerCategory = triggerCategory;
        this.triggerId = triggerId;
        this.triggerName = triggerName;
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
     * Getter for Active.
     * @return Returns the Boolean
     */
    @JsonGetter("active")
    @JsonInclude(JsonInclude.Include.NON_NULL)
    public Boolean getActive() {
        return active;
    }

    /**
     * Setter for Active.
     * @param active Value for Boolean
     */
    @JsonSetter("active")
    public void setActive(Boolean active) {
        this.active = active;
    }

    /**
     * Getter for AnomalyTriggerRequest.
     * The details of the UsageAnomaly trigger.
     * @return Returns the AnomalyTriggerRequest
     */
    @JsonGetter("anomalyTriggerRequest")
    @JsonInclude(JsonInclude.Include.NON_NULL)
    public AnomalyTriggerRequest getAnomalyTriggerRequest() {
        return anomalyTriggerRequest;
    }

    /**
     * Setter for AnomalyTriggerRequest.
     * The details of the UsageAnomaly trigger.
     * @param anomalyTriggerRequest Value for AnomalyTriggerRequest
     */
    @JsonSetter("anomalyTriggerRequest")
    public void setAnomalyTriggerRequest(AnomalyTriggerRequest anomalyTriggerRequest) {
        this.anomalyTriggerRequest = anomalyTriggerRequest;
    }

    /**
     * Getter for CycleType.
     * @return Returns the CycleType
     */
    @JsonGetter("cycleType")
    @JsonInclude(JsonInclude.Include.NON_NULL)
    public CycleType getCycleType() {
        return cycleType;
    }

    /**
     * Setter for CycleType.
     * @param cycleType Value for CycleType
     */
    @JsonSetter("cycleType")
    public void setCycleType(CycleType cycleType) {
        this.cycleType = cycleType;
    }

    /**
     * Getter for DataTriggerRequest.
     * @return Returns the DataTriggerRequest
     */
    @JsonGetter("dataTriggerRequest")
    @JsonInclude(JsonInclude.Include.NON_NULL)
    public DataTriggerRequest getDataTriggerRequest() {
        return dataTriggerRequest;
    }

    /**
     * Setter for DataTriggerRequest.
     * @param dataTriggerRequest Value for DataTriggerRequest
     */
    @JsonSetter("dataTriggerRequest")
    public void setDataTriggerRequest(DataTriggerRequest dataTriggerRequest) {
        this.dataTriggerRequest = dataTriggerRequest;
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
     * Getter for PromoAlertTriggerRequest.
     * @return Returns the PromoAlertTriggerRequest
     */
    @JsonGetter("promoAlertTriggerRequest")
    @JsonInclude(JsonInclude.Include.NON_NULL)
    public PromoAlertTriggerRequest getPromoAlertTriggerRequest() {
        return promoAlertTriggerRequest;
    }

    /**
     * Setter for PromoAlertTriggerRequest.
     * @param promoAlertTriggerRequest Value for PromoAlertTriggerRequest
     */
    @JsonSetter("promoAlertTriggerRequest")
    public void setPromoAlertTriggerRequest(PromoAlertTriggerRequest promoAlertTriggerRequest) {
        this.promoAlertTriggerRequest = promoAlertTriggerRequest;
    }

    /**
     * Getter for SessionTriggerRequest.
     * @return Returns the SessionTriggerRequest
     */
    @JsonGetter("sessionTriggerRequest")
    @JsonInclude(JsonInclude.Include.NON_NULL)
    public SessionTriggerRequest getSessionTriggerRequest() {
        return sessionTriggerRequest;
    }

    /**
     * Setter for SessionTriggerRequest.
     * @param sessionTriggerRequest Value for SessionTriggerRequest
     */
    @JsonSetter("sessionTriggerRequest")
    public void setSessionTriggerRequest(SessionTriggerRequest sessionTriggerRequest) {
        this.sessionTriggerRequest = sessionTriggerRequest;
    }

    /**
     * Getter for SmsTriggerRequest.
     * @return Returns the SmsTriggerRequest
     */
    @JsonGetter("smsTriggerRequest")
    @JsonInclude(JsonInclude.Include.NON_NULL)
    public SmsTriggerRequest getSmsTriggerRequest() {
        return smsTriggerRequest;
    }

    /**
     * Setter for SmsTriggerRequest.
     * @param smsTriggerRequest Value for SmsTriggerRequest
     */
    @JsonSetter("smsTriggerRequest")
    public void setSmsTriggerRequest(SmsTriggerRequest smsTriggerRequest) {
        this.smsTriggerRequest = smsTriggerRequest;
    }

    /**
     * Getter for TriggerCategory.
     * @return Returns the String
     */
    @JsonGetter("triggerCategory")
    @JsonInclude(JsonInclude.Include.NON_NULL)
    public String getTriggerCategory() {
        return triggerCategory;
    }

    /**
     * Setter for TriggerCategory.
     * @param triggerCategory Value for String
     */
    @JsonSetter("triggerCategory")
    public void setTriggerCategory(String triggerCategory) {
        this.triggerCategory = triggerCategory;
    }

    /**
     * Getter for TriggerId.
     * @return Returns the String
     */
    @JsonGetter("triggerId")
    @JsonInclude(JsonInclude.Include.NON_NULL)
    public String getTriggerId() {
        return triggerId;
    }

    /**
     * Setter for TriggerId.
     * @param triggerId Value for String
     */
    @JsonSetter("triggerId")
    public void setTriggerId(String triggerId) {
        this.triggerId = triggerId;
    }

    /**
     * Getter for TriggerName.
     * @return Returns the String
     */
    @JsonGetter("triggerName")
    @JsonInclude(JsonInclude.Include.NON_NULL)
    public String getTriggerName() {
        return triggerName;
    }

    /**
     * Setter for TriggerName.
     * @param triggerName Value for String
     */
    @JsonSetter("triggerName")
    public void setTriggerName(String triggerName) {
        this.triggerName = triggerName;
    }

    /**
     * Converts this UpdateTriggerRequest into string format.
     * @return String representation of this class
     */
    @Override
    public String toString() {
        return "UpdateTriggerRequest [" + "accountName=" + accountName + ", active=" + active
                + ", anomalyTriggerRequest=" + anomalyTriggerRequest + ", cycleType=" + cycleType
                + ", dataTriggerRequest=" + dataTriggerRequest + ", groupName=" + groupName
                + ", promoAlertTriggerRequest=" + promoAlertTriggerRequest
                + ", sessionTriggerRequest=" + sessionTriggerRequest + ", smsTriggerRequest="
                + smsTriggerRequest + ", triggerCategory=" + triggerCategory + ", triggerId="
                + triggerId + ", triggerName=" + triggerName + "]";
    }

    /**
     * Builds a new {@link UpdateTriggerRequest.Builder} object.
     * Creates the instance with the state of the current model.
     * @return a new {@link UpdateTriggerRequest.Builder} object
     */
    public Builder toBuilder() {
        Builder builder = new Builder()
                .accountName(getAccountName())
                .active(getActive())
                .anomalyTriggerRequest(getAnomalyTriggerRequest())
                .cycleType(getCycleType())
                .dataTriggerRequest(getDataTriggerRequest())
                .groupName(getGroupName())
                .promoAlertTriggerRequest(getPromoAlertTriggerRequest())
                .sessionTriggerRequest(getSessionTriggerRequest())
                .smsTriggerRequest(getSmsTriggerRequest())
                .triggerCategory(getTriggerCategory())
                .triggerId(getTriggerId())
                .triggerName(getTriggerName());
        return builder;
    }

    /**
     * Class to build instances of {@link UpdateTriggerRequest}.
     */
    public static class Builder {
        private String accountName;
        private Boolean active;
        private AnomalyTriggerRequest anomalyTriggerRequest;
        private CycleType cycleType;
        private DataTriggerRequest dataTriggerRequest;
        private String groupName;
        private PromoAlertTriggerRequest promoAlertTriggerRequest;
        private SessionTriggerRequest sessionTriggerRequest;
        private SmsTriggerRequest smsTriggerRequest;
        private String triggerCategory;
        private String triggerId;
        private String triggerName;



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
         * Setter for active.
         * @param  active  Boolean value for active.
         * @return Builder
         */
        public Builder active(Boolean active) {
            this.active = active;
            return this;
        }

        /**
         * Setter for anomalyTriggerRequest.
         * @param  anomalyTriggerRequest  AnomalyTriggerRequest value for anomalyTriggerRequest.
         * @return Builder
         */
        public Builder anomalyTriggerRequest(AnomalyTriggerRequest anomalyTriggerRequest) {
            this.anomalyTriggerRequest = anomalyTriggerRequest;
            return this;
        }

        /**
         * Setter for cycleType.
         * @param  cycleType  CycleType value for cycleType.
         * @return Builder
         */
        public Builder cycleType(CycleType cycleType) {
            this.cycleType = cycleType;
            return this;
        }

        /**
         * Setter for dataTriggerRequest.
         * @param  dataTriggerRequest  DataTriggerRequest value for dataTriggerRequest.
         * @return Builder
         */
        public Builder dataTriggerRequest(DataTriggerRequest dataTriggerRequest) {
            this.dataTriggerRequest = dataTriggerRequest;
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
         * Setter for promoAlertTriggerRequest.
         * @param  promoAlertTriggerRequest  PromoAlertTriggerRequest value for
         *         promoAlertTriggerRequest.
         * @return Builder
         */
        public Builder promoAlertTriggerRequest(
                PromoAlertTriggerRequest promoAlertTriggerRequest) {
            this.promoAlertTriggerRequest = promoAlertTriggerRequest;
            return this;
        }

        /**
         * Setter for sessionTriggerRequest.
         * @param  sessionTriggerRequest  SessionTriggerRequest value for sessionTriggerRequest.
         * @return Builder
         */
        public Builder sessionTriggerRequest(SessionTriggerRequest sessionTriggerRequest) {
            this.sessionTriggerRequest = sessionTriggerRequest;
            return this;
        }

        /**
         * Setter for smsTriggerRequest.
         * @param  smsTriggerRequest  SmsTriggerRequest value for smsTriggerRequest.
         * @return Builder
         */
        public Builder smsTriggerRequest(SmsTriggerRequest smsTriggerRequest) {
            this.smsTriggerRequest = smsTriggerRequest;
            return this;
        }

        /**
         * Setter for triggerCategory.
         * @param  triggerCategory  String value for triggerCategory.
         * @return Builder
         */
        public Builder triggerCategory(String triggerCategory) {
            this.triggerCategory = triggerCategory;
            return this;
        }

        /**
         * Setter for triggerId.
         * @param  triggerId  String value for triggerId.
         * @return Builder
         */
        public Builder triggerId(String triggerId) {
            this.triggerId = triggerId;
            return this;
        }

        /**
         * Setter for triggerName.
         * @param  triggerName  String value for triggerName.
         * @return Builder
         */
        public Builder triggerName(String triggerName) {
            this.triggerName = triggerName;
            return this;
        }

        /**
         * Builds a new {@link UpdateTriggerRequest} object using the set fields.
         * @return {@link UpdateTriggerRequest}
         */
        public UpdateTriggerRequest build() {
            return new UpdateTriggerRequest(accountName, active, anomalyTriggerRequest, cycleType,
                    dataTriggerRequest, groupName, promoAlertTriggerRequest, sessionTriggerRequest,
                    smsTriggerRequest, triggerCategory, triggerId, triggerName);
        }
    }
}
