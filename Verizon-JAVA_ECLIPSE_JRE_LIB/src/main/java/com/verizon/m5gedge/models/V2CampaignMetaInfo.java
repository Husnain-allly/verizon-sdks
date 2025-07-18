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
import com.fasterxml.jackson.databind.annotation.JsonDeserialize;
import com.fasterxml.jackson.databind.annotation.JsonSerialize;
import com.verizon.m5gedge.DateTimeHelper;
import io.apimatic.core.types.AdditionalProperties;
import io.apimatic.core.utilities.ConversionHelper;
import java.time.LocalDate;
import java.util.List;
import java.util.Map;

/**
 * This is a model class for V2CampaignMetaInfo type.
 */
public class V2CampaignMetaInfo {
    private String accountName;
    private String id;
    private String campaignName;
    private String softwareName;
    private String distributionType;
    private String softwareFrom;
    private String softwareTo;
    private String make;
    private String model;
    private LocalDate startDate;
    private LocalDate endDate;
    private LocalDate downloadAfterDate;
    private List<V2TimeWindow> downloadTimeWindowList;
    private LocalDate installAfterDate;
    private List<V2TimeWindow> installTimeWindowList;
    private String status;
    private AdditionalProperties<Object> additionalProperties = 
            new AdditionalProperties<Object>(this.getClass());

    /**
     * Default constructor.
     */
    public V2CampaignMetaInfo() {
    }

    /**
     * Initialization constructor.
     * @param  accountName  String value for accountName.
     * @param  id  String value for id.
     * @param  softwareName  String value for softwareName.
     * @param  distributionType  String value for distributionType.
     * @param  softwareFrom  String value for softwareFrom.
     * @param  softwareTo  String value for softwareTo.
     * @param  make  String value for make.
     * @param  model  String value for model.
     * @param  startDate  LocalDate value for startDate.
     * @param  endDate  LocalDate value for endDate.
     * @param  status  String value for status.
     * @param  campaignName  String value for campaignName.
     * @param  downloadAfterDate  LocalDate value for downloadAfterDate.
     * @param  downloadTimeWindowList  List of V2TimeWindow value for downloadTimeWindowList.
     * @param  installAfterDate  LocalDate value for installAfterDate.
     * @param  installTimeWindowList  List of V2TimeWindow value for installTimeWindowList.
     */
    public V2CampaignMetaInfo(
            String accountName,
            String id,
            String softwareName,
            String distributionType,
            String softwareFrom,
            String softwareTo,
            String make,
            String model,
            LocalDate startDate,
            LocalDate endDate,
            String status,
            String campaignName,
            LocalDate downloadAfterDate,
            List<V2TimeWindow> downloadTimeWindowList,
            LocalDate installAfterDate,
            List<V2TimeWindow> installTimeWindowList) {
        this.accountName = accountName;
        this.id = id;
        this.campaignName = campaignName;
        this.softwareName = softwareName;
        this.distributionType = distributionType;
        this.softwareFrom = softwareFrom;
        this.softwareTo = softwareTo;
        this.make = make;
        this.model = model;
        this.startDate = startDate;
        this.endDate = endDate;
        this.downloadAfterDate = downloadAfterDate;
        this.downloadTimeWindowList = downloadTimeWindowList;
        this.installAfterDate = installAfterDate;
        this.installTimeWindowList = installTimeWindowList;
        this.status = status;
    }

    /**
     * Getter for AccountName.
     * Account identifier.
     * @return Returns the String
     */
    @JsonGetter("accountName")
    public String getAccountName() {
        return accountName;
    }

    /**
     * Setter for AccountName.
     * Account identifier.
     * @param accountName Value for String
     */
    @JsonSetter("accountName")
    public void setAccountName(String accountName) {
        this.accountName = accountName;
    }

    /**
     * Getter for Id.
     * Campaign identifier.
     * @return Returns the String
     */
    @JsonGetter("id")
    public String getId() {
        return id;
    }

    /**
     * Setter for Id.
     * Campaign identifier.
     * @param id Value for String
     */
    @JsonSetter("id")
    public void setId(String id) {
        this.id = id;
    }

    /**
     * Getter for CampaignName.
     * Campaign name.
     * @return Returns the String
     */
    @JsonGetter("campaignName")
    @JsonInclude(JsonInclude.Include.NON_NULL)
    public String getCampaignName() {
        return campaignName;
    }

    /**
     * Setter for CampaignName.
     * Campaign name.
     * @param campaignName Value for String
     */
    @JsonSetter("campaignName")
    public void setCampaignName(String campaignName) {
        this.campaignName = campaignName;
    }

    /**
     * Getter for SoftwareName.
     * Software name.
     * @return Returns the String
     */
    @JsonGetter("softwareName")
    public String getSoftwareName() {
        return softwareName;
    }

    /**
     * Setter for SoftwareName.
     * Software name.
     * @param softwareName Value for String
     */
    @JsonSetter("softwareName")
    public void setSoftwareName(String softwareName) {
        this.softwareName = softwareName;
    }

    /**
     * Getter for DistributionType.
     * LWM2M, OMD-DM or HTTP.
     * @return Returns the String
     */
    @JsonGetter("distributionType")
    public String getDistributionType() {
        return distributionType;
    }

    /**
     * Setter for DistributionType.
     * LWM2M, OMD-DM or HTTP.
     * @param distributionType Value for String
     */
    @JsonSetter("distributionType")
    public void setDistributionType(String distributionType) {
        this.distributionType = distributionType;
    }

    /**
     * Getter for SoftwareFrom.
     * Old software name.
     * @return Returns the String
     */
    @JsonGetter("softwareFrom")
    public String getSoftwareFrom() {
        return softwareFrom;
    }

    /**
     * Setter for SoftwareFrom.
     * Old software name.
     * @param softwareFrom Value for String
     */
    @JsonSetter("softwareFrom")
    public void setSoftwareFrom(String softwareFrom) {
        this.softwareFrom = softwareFrom;
    }

    /**
     * Getter for SoftwareTo.
     * New software name.
     * @return Returns the String
     */
    @JsonGetter("softwareTo")
    public String getSoftwareTo() {
        return softwareTo;
    }

    /**
     * Setter for SoftwareTo.
     * New software name.
     * @param softwareTo Value for String
     */
    @JsonSetter("softwareTo")
    public void setSoftwareTo(String softwareTo) {
        this.softwareTo = softwareTo;
    }

    /**
     * Getter for Make.
     * Applicable make.
     * @return Returns the String
     */
    @JsonGetter("make")
    public String getMake() {
        return make;
    }

    /**
     * Setter for Make.
     * Applicable make.
     * @param make Value for String
     */
    @JsonSetter("make")
    public void setMake(String make) {
        this.make = make;
    }

    /**
     * Getter for Model.
     * Applicable model.
     * @return Returns the String
     */
    @JsonGetter("model")
    public String getModel() {
        return model;
    }

    /**
     * Setter for Model.
     * Applicable model.
     * @param model Value for String
     */
    @JsonSetter("model")
    public void setModel(String model) {
        this.model = model;
    }

    /**
     * Getter for StartDate.
     * Campaign start date.
     * @return Returns the LocalDate
     */
    @JsonGetter("startDate")
    @JsonSerialize(using = DateTimeHelper.SimpleDateSerializer.class)
    public LocalDate getStartDate() {
        return startDate;
    }

    /**
     * Setter for StartDate.
     * Campaign start date.
     * @param startDate Value for LocalDate
     */
    @JsonSetter("startDate")
    @JsonDeserialize(using = DateTimeHelper.SimpleDateDeserializer.class)
    public void setStartDate(LocalDate startDate) {
        this.startDate = startDate;
    }

    /**
     * Getter for EndDate.
     * Campaign end date.
     * @return Returns the LocalDate
     */
    @JsonGetter("endDate")
    @JsonSerialize(using = DateTimeHelper.SimpleDateSerializer.class)
    public LocalDate getEndDate() {
        return endDate;
    }

    /**
     * Setter for EndDate.
     * Campaign end date.
     * @param endDate Value for LocalDate
     */
    @JsonSetter("endDate")
    @JsonDeserialize(using = DateTimeHelper.SimpleDateDeserializer.class)
    public void setEndDate(LocalDate endDate) {
        this.endDate = endDate;
    }

    /**
     * Getter for DownloadAfterDate.
     * Specifies starting date client should download package. If null, client will download as soon
     * as possible.
     * @return Returns the LocalDate
     */
    @JsonGetter("downloadAfterDate")
    @JsonInclude(JsonInclude.Include.NON_NULL)
    @JsonSerialize(using = DateTimeHelper.SimpleDateSerializer.class)
    public LocalDate getDownloadAfterDate() {
        return downloadAfterDate;
    }

    /**
     * Setter for DownloadAfterDate.
     * Specifies starting date client should download package. If null, client will download as soon
     * as possible.
     * @param downloadAfterDate Value for LocalDate
     */
    @JsonSetter("downloadAfterDate")
    @JsonDeserialize(using = DateTimeHelper.SimpleDateDeserializer.class)
    public void setDownloadAfterDate(LocalDate downloadAfterDate) {
        this.downloadAfterDate = downloadAfterDate;
    }

    /**
     * Getter for DownloadTimeWindowList.
     * List of allowed download time windows.
     * @return Returns the List of V2TimeWindow
     */
    @JsonGetter("downloadTimeWindowList")
    @JsonInclude(JsonInclude.Include.NON_NULL)
    public List<V2TimeWindow> getDownloadTimeWindowList() {
        return downloadTimeWindowList;
    }

    /**
     * Setter for DownloadTimeWindowList.
     * List of allowed download time windows.
     * @param downloadTimeWindowList Value for List of V2TimeWindow
     */
    @JsonSetter("downloadTimeWindowList")
    public void setDownloadTimeWindowList(List<V2TimeWindow> downloadTimeWindowList) {
        this.downloadTimeWindowList = downloadTimeWindowList;
    }

    /**
     * Getter for InstallAfterDate.
     * Client will install package after date. If null, client will install as soon as possible.
     * @return Returns the LocalDate
     */
    @JsonGetter("installAfterDate")
    @JsonInclude(JsonInclude.Include.NON_NULL)
    @JsonSerialize(using = DateTimeHelper.SimpleDateSerializer.class)
    public LocalDate getInstallAfterDate() {
        return installAfterDate;
    }

    /**
     * Setter for InstallAfterDate.
     * Client will install package after date. If null, client will install as soon as possible.
     * @param installAfterDate Value for LocalDate
     */
    @JsonSetter("installAfterDate")
    @JsonDeserialize(using = DateTimeHelper.SimpleDateDeserializer.class)
    public void setInstallAfterDate(LocalDate installAfterDate) {
        this.installAfterDate = installAfterDate;
    }

    /**
     * Getter for InstallTimeWindowList.
     * List of allowed install time windows.
     * @return Returns the List of V2TimeWindow
     */
    @JsonGetter("installTimeWindowList")
    @JsonInclude(JsonInclude.Include.NON_NULL)
    public List<V2TimeWindow> getInstallTimeWindowList() {
        return installTimeWindowList;
    }

    /**
     * Setter for InstallTimeWindowList.
     * List of allowed install time windows.
     * @param installTimeWindowList Value for List of V2TimeWindow
     */
    @JsonSetter("installTimeWindowList")
    public void setInstallTimeWindowList(List<V2TimeWindow> installTimeWindowList) {
        this.installTimeWindowList = installTimeWindowList;
    }

    /**
     * Getter for Status.
     * Software upgrade status.
     * @return Returns the String
     */
    @JsonGetter("status")
    public String getStatus() {
        return status;
    }

    /**
     * Setter for Status.
     * Software upgrade status.
     * @param status Value for String
     */
    @JsonSetter("status")
    public void setStatus(String status) {
        this.status = status;
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
     * Converts this V2CampaignMetaInfo into string format.
     * @return String representation of this class
     */
    @Override
    public String toString() {
        return "V2CampaignMetaInfo [" + "accountName=" + accountName + ", id=" + id
                + ", softwareName=" + softwareName + ", distributionType=" + distributionType
                + ", softwareFrom=" + softwareFrom + ", softwareTo=" + softwareTo + ", make=" + make
                + ", model=" + model + ", startDate=" + startDate + ", endDate=" + endDate
                + ", status=" + status + ", campaignName=" + campaignName + ", downloadAfterDate="
                + downloadAfterDate + ", downloadTimeWindowList=" + downloadTimeWindowList
                + ", installAfterDate=" + installAfterDate + ", installTimeWindowList="
                + installTimeWindowList + ", additionalProperties=" + additionalProperties + "]";
    }

    /**
     * Builds a new {@link V2CampaignMetaInfo.Builder} object.
     * Creates the instance with the state of the current model.
     * @return a new {@link V2CampaignMetaInfo.Builder} object
     */
    public Builder toBuilder() {
        Builder builder = new Builder(accountName, id, softwareName, distributionType, softwareFrom,
                softwareTo, make, model, startDate, endDate, status)
                .campaignName(getCampaignName())
                .downloadAfterDate(getDownloadAfterDate())
                .downloadTimeWindowList(getDownloadTimeWindowList())
                .installAfterDate(getInstallAfterDate())
                .installTimeWindowList(getInstallTimeWindowList());
        builder.additionalProperties = additionalProperties;
        return builder;
    }

    /**
     * Class to build instances of {@link V2CampaignMetaInfo}.
     */
    public static class Builder {
        private String accountName;
        private String id;
        private String softwareName;
        private String distributionType;
        private String softwareFrom;
        private String softwareTo;
        private String make;
        private String model;
        private LocalDate startDate;
        private LocalDate endDate;
        private String status;
        private String campaignName;
        private LocalDate downloadAfterDate;
        private List<V2TimeWindow> downloadTimeWindowList;
        private LocalDate installAfterDate;
        private List<V2TimeWindow> installTimeWindowList;
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
         * @param  id  String value for id.
         * @param  softwareName  String value for softwareName.
         * @param  distributionType  String value for distributionType.
         * @param  softwareFrom  String value for softwareFrom.
         * @param  softwareTo  String value for softwareTo.
         * @param  make  String value for make.
         * @param  model  String value for model.
         * @param  startDate  LocalDate value for startDate.
         * @param  endDate  LocalDate value for endDate.
         * @param  status  String value for status.
         */
        public Builder(String accountName, String id, String softwareName, String distributionType,
                String softwareFrom, String softwareTo, String make, String model,
                LocalDate startDate, LocalDate endDate, String status) {
            this.accountName = accountName;
            this.id = id;
            this.softwareName = softwareName;
            this.distributionType = distributionType;
            this.softwareFrom = softwareFrom;
            this.softwareTo = softwareTo;
            this.make = make;
            this.model = model;
            this.startDate = startDate;
            this.endDate = endDate;
            this.status = status;
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
         * Setter for id.
         * @param  id  String value for id.
         * @return Builder
         */
        public Builder id(String id) {
            this.id = id;
            return this;
        }

        /**
         * Setter for softwareName.
         * @param  softwareName  String value for softwareName.
         * @return Builder
         */
        public Builder softwareName(String softwareName) {
            this.softwareName = softwareName;
            return this;
        }

        /**
         * Setter for distributionType.
         * @param  distributionType  String value for distributionType.
         * @return Builder
         */
        public Builder distributionType(String distributionType) {
            this.distributionType = distributionType;
            return this;
        }

        /**
         * Setter for softwareFrom.
         * @param  softwareFrom  String value for softwareFrom.
         * @return Builder
         */
        public Builder softwareFrom(String softwareFrom) {
            this.softwareFrom = softwareFrom;
            return this;
        }

        /**
         * Setter for softwareTo.
         * @param  softwareTo  String value for softwareTo.
         * @return Builder
         */
        public Builder softwareTo(String softwareTo) {
            this.softwareTo = softwareTo;
            return this;
        }

        /**
         * Setter for make.
         * @param  make  String value for make.
         * @return Builder
         */
        public Builder make(String make) {
            this.make = make;
            return this;
        }

        /**
         * Setter for model.
         * @param  model  String value for model.
         * @return Builder
         */
        public Builder model(String model) {
            this.model = model;
            return this;
        }

        /**
         * Setter for startDate.
         * @param  startDate  LocalDate value for startDate.
         * @return Builder
         */
        public Builder startDate(LocalDate startDate) {
            this.startDate = startDate;
            return this;
        }

        /**
         * Setter for endDate.
         * @param  endDate  LocalDate value for endDate.
         * @return Builder
         */
        public Builder endDate(LocalDate endDate) {
            this.endDate = endDate;
            return this;
        }

        /**
         * Setter for status.
         * @param  status  String value for status.
         * @return Builder
         */
        public Builder status(String status) {
            this.status = status;
            return this;
        }

        /**
         * Setter for campaignName.
         * @param  campaignName  String value for campaignName.
         * @return Builder
         */
        public Builder campaignName(String campaignName) {
            this.campaignName = campaignName;
            return this;
        }

        /**
         * Setter for downloadAfterDate.
         * @param  downloadAfterDate  LocalDate value for downloadAfterDate.
         * @return Builder
         */
        public Builder downloadAfterDate(LocalDate downloadAfterDate) {
            this.downloadAfterDate = downloadAfterDate;
            return this;
        }

        /**
         * Setter for downloadTimeWindowList.
         * @param  downloadTimeWindowList  List of V2TimeWindow value for downloadTimeWindowList.
         * @return Builder
         */
        public Builder downloadTimeWindowList(List<V2TimeWindow> downloadTimeWindowList) {
            this.downloadTimeWindowList = downloadTimeWindowList;
            return this;
        }

        /**
         * Setter for installAfterDate.
         * @param  installAfterDate  LocalDate value for installAfterDate.
         * @return Builder
         */
        public Builder installAfterDate(LocalDate installAfterDate) {
            this.installAfterDate = installAfterDate;
            return this;
        }

        /**
         * Setter for installTimeWindowList.
         * @param  installTimeWindowList  List of V2TimeWindow value for installTimeWindowList.
         * @return Builder
         */
        public Builder installTimeWindowList(List<V2TimeWindow> installTimeWindowList) {
            this.installTimeWindowList = installTimeWindowList;
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
         * Builds a new {@link V2CampaignMetaInfo} object using the set fields.
         * @return {@link V2CampaignMetaInfo}
         */
        public V2CampaignMetaInfo build() {
            V2CampaignMetaInfo model2 =
                    new V2CampaignMetaInfo(accountName, id, softwareName, distributionType,
                            softwareFrom, softwareTo, make, model, startDate, endDate, status,
                            campaignName, downloadAfterDate, downloadTimeWindowList,
                            installAfterDate, installTimeWindowList);
            model2.additionalProperties = additionalProperties;
            return model2;
        }
    }
}
