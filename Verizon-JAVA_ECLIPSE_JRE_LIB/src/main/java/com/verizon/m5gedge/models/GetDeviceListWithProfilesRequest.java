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
 * This is a model class for GetDeviceListWithProfilesRequest type.
 */
public class GetDeviceListWithProfilesRequest {
    private String accountName;
    private String provisioningStatusFilter;
    private String profileStatusFilter;
    private String carrierNameFilter;
    private List<GioDeviceId> deviceFilter;

    /**
     * Default constructor.
     */
    public GetDeviceListWithProfilesRequest() {
    }

    /**
     * Initialization constructor.
     * @param  accountName  String value for accountName.
     * @param  provisioningStatusFilter  String value for provisioningStatusFilter.
     * @param  profileStatusFilter  String value for profileStatusFilter.
     * @param  carrierNameFilter  String value for carrierNameFilter.
     * @param  deviceFilter  List of GioDeviceId value for deviceFilter.
     */
    public GetDeviceListWithProfilesRequest(
            String accountName,
            String provisioningStatusFilter,
            String profileStatusFilter,
            String carrierNameFilter,
            List<GioDeviceId> deviceFilter) {
        this.accountName = accountName;
        this.provisioningStatusFilter = provisioningStatusFilter;
        this.profileStatusFilter = profileStatusFilter;
        this.carrierNameFilter = carrierNameFilter;
        this.deviceFilter = deviceFilter;
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
     * Getter for ProvisioningStatusFilter.
     * @return Returns the String
     */
    @JsonGetter("provisioningStatusFilter")
    @JsonInclude(JsonInclude.Include.NON_NULL)
    public String getProvisioningStatusFilter() {
        return provisioningStatusFilter;
    }

    /**
     * Setter for ProvisioningStatusFilter.
     * @param provisioningStatusFilter Value for String
     */
    @JsonSetter("provisioningStatusFilter")
    public void setProvisioningStatusFilter(String provisioningStatusFilter) {
        this.provisioningStatusFilter = provisioningStatusFilter;
    }

    /**
     * Getter for ProfileStatusFilter.
     * @return Returns the String
     */
    @JsonGetter("profileStatusFilter")
    @JsonInclude(JsonInclude.Include.NON_NULL)
    public String getProfileStatusFilter() {
        return profileStatusFilter;
    }

    /**
     * Setter for ProfileStatusFilter.
     * @param profileStatusFilter Value for String
     */
    @JsonSetter("profileStatusFilter")
    public void setProfileStatusFilter(String profileStatusFilter) {
        this.profileStatusFilter = profileStatusFilter;
    }

    /**
     * Getter for CarrierNameFilter.
     * @return Returns the String
     */
    @JsonGetter("carrierNameFilter")
    @JsonInclude(JsonInclude.Include.NON_NULL)
    public String getCarrierNameFilter() {
        return carrierNameFilter;
    }

    /**
     * Setter for CarrierNameFilter.
     * @param carrierNameFilter Value for String
     */
    @JsonSetter("carrierNameFilter")
    public void setCarrierNameFilter(String carrierNameFilter) {
        this.carrierNameFilter = carrierNameFilter;
    }

    /**
     * Getter for DeviceFilter.
     * @return Returns the List of GioDeviceId
     */
    @JsonGetter("deviceFilter")
    @JsonInclude(JsonInclude.Include.NON_NULL)
    public List<GioDeviceId> getDeviceFilter() {
        return deviceFilter;
    }

    /**
     * Setter for DeviceFilter.
     * @param deviceFilter Value for List of GioDeviceId
     */
    @JsonSetter("deviceFilter")
    public void setDeviceFilter(List<GioDeviceId> deviceFilter) {
        this.deviceFilter = deviceFilter;
    }

    /**
     * Converts this GetDeviceListWithProfilesRequest into string format.
     * @return String representation of this class
     */
    @Override
    public String toString() {
        return "GetDeviceListWithProfilesRequest [" + "accountName=" + accountName
                + ", provisioningStatusFilter=" + provisioningStatusFilter
                + ", profileStatusFilter=" + profileStatusFilter + ", carrierNameFilter="
                + carrierNameFilter + ", deviceFilter=" + deviceFilter + "]";
    }

    /**
     * Builds a new {@link GetDeviceListWithProfilesRequest.Builder} object.
     * Creates the instance with the state of the current model.
     * @return a new {@link GetDeviceListWithProfilesRequest.Builder} object
     */
    public Builder toBuilder() {
        Builder builder = new Builder(accountName)
                .provisioningStatusFilter(getProvisioningStatusFilter())
                .profileStatusFilter(getProfileStatusFilter())
                .carrierNameFilter(getCarrierNameFilter())
                .deviceFilter(getDeviceFilter());
        return builder;
    }

    /**
     * Class to build instances of {@link GetDeviceListWithProfilesRequest}.
     */
    public static class Builder {
        private String accountName;
        private String provisioningStatusFilter;
        private String profileStatusFilter;
        private String carrierNameFilter;
        private List<GioDeviceId> deviceFilter;

        /**
         * Initialization constructor.
         */
        public Builder() {
        }

        /**
         * Initialization constructor.
         * @param  accountName  String value for accountName.
         */
        public Builder(String accountName) {
            this.accountName = accountName;
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
         * Setter for provisioningStatusFilter.
         * @param  provisioningStatusFilter  String value for provisioningStatusFilter.
         * @return Builder
         */
        public Builder provisioningStatusFilter(String provisioningStatusFilter) {
            this.provisioningStatusFilter = provisioningStatusFilter;
            return this;
        }

        /**
         * Setter for profileStatusFilter.
         * @param  profileStatusFilter  String value for profileStatusFilter.
         * @return Builder
         */
        public Builder profileStatusFilter(String profileStatusFilter) {
            this.profileStatusFilter = profileStatusFilter;
            return this;
        }

        /**
         * Setter for carrierNameFilter.
         * @param  carrierNameFilter  String value for carrierNameFilter.
         * @return Builder
         */
        public Builder carrierNameFilter(String carrierNameFilter) {
            this.carrierNameFilter = carrierNameFilter;
            return this;
        }

        /**
         * Setter for deviceFilter.
         * @param  deviceFilter  List of GioDeviceId value for deviceFilter.
         * @return Builder
         */
        public Builder deviceFilter(List<GioDeviceId> deviceFilter) {
            this.deviceFilter = deviceFilter;
            return this;
        }

        /**
         * Builds a new {@link GetDeviceListWithProfilesRequest} object using the set fields.
         * @return {@link GetDeviceListWithProfilesRequest}
         */
        public GetDeviceListWithProfilesRequest build() {
            return new GetDeviceListWithProfilesRequest(accountName, provisioningStatusFilter,
                    profileStatusFilter, carrierNameFilter, deviceFilter);
        }
    }
}
