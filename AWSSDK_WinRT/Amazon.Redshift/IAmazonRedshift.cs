/*
 * Copyright 2010-2013 Amazon.com, Inc. or its affiliates. All Rights Reserved.
 * 
 * Licensed under the Apache License, Version 2.0 (the "License").
 * You may not use this file except in compliance with the License.
 * A copy of the License is located at
 * 
 *  http://aws.amazon.com/apache2.0
 * 
 * or in the "license" file accompanying this file. This file is distributed
 * on an "AS IS" BASIS, WITHOUT WARRANTIES OR CONDITIONS OF ANY KIND, either
 * express or implied. See the License for the specific language governing
 * permissions and limitations under the License.
 */
using System;
using System.Threading;
using System.Threading.Tasks;

using Amazon.Redshift.Model;

namespace Amazon.Redshift
{
    /// <summary>
    /// Interface for accessing AmazonRedshift.
    /// 
    /// Amazon Redshift <b>Overview</b> <para> This is an interface reference for Amazon Redshift. It contains documentation for one of the
    /// programming or command line interfaces you can use to manage Amazon Redshift clusters. Note that Amazon Redshift is asynchronous, which
    /// means that some interfaces may require techniques, such as polling or asynchronous callback handlers, to determine when a command has been
    /// applied. In this reference, the parameter descriptions indicate whether a change is applied immediately, on the next instance reboot, or
    /// during the next maintenance window. For a summary of the Amazon Redshift cluster management interfaces, go to <a href="http://docs.aws.amazon.com/redshift/latest/mgmt/using-aws-sdk.html">Using the Amazon Redshift Management Interfaces </a> .</para>
    /// <para> Amazon Redshift manages all the work of setting up, operating, and scaling a data warehouse: provisioning capacity, monitoring and
    /// backing up the cluster, and applying patches and upgrades to the Amazon Redshift engine. You can focus on using your data to acquire new
    /// insights for your business and customers. </para> <para>If you are a first-time user of Amazon Redshift, we recommend that you begin by
    /// reading the The <a href="http://docs.aws.amazon.com/redshift/latest/gsg/getting-started.html">Amazon Redshift Getting Started Guide</a>
    /// </para> <para>If you are a database developer, the <a href="http://docs.aws.amazon.com/redshift/latest/dg/welcome.html">Amazon Redshift
    /// Database Developer Guide</a> explains how to design, build, query, and maintain the databases that make up your data warehouse. </para>
    /// </summary>
	public partial interface IAmazonRedshift : IDisposable
    {
 
        /// <summary>
        /// <para> Adds an inbound (ingress) rule to an Amazon Redshift security group. Depending on whether the application accessing your cluster is
        /// running on the Internet or an EC2 instance, you can authorize inbound access to either a Classless Interdomain Routing (CIDR) IP address
        /// range or an EC2 security group. You can add as many as 20 ingress rules to an Amazon Redshift security group. </para> <para><b>NOTE:</b> The
        /// EC2 security group must be defined in the AWS region where the cluster resides. </para> <para>For an overview of CIDR blocks, see the
        /// Wikipedia article on <a href="http://en.wikipedia.org/wiki/Classless_Inter-Domain_Routing">Classless Inter-Domain Routing</a> .
        /// </para> <para> You must also associate the security group with a cluster so that clients running on these IP addresses or the EC2
        /// instance are authorized to connect to the cluster. For information about managing security groups, go to <a href="http://docs.aws.amazon.com/redshift/latest/mgmt/working-with-security-groups.html">Working with Security Groups</a> in the <i>Amazon
        /// Redshift Management Guide</i> .</para>
        /// </summary>
        /// 
        /// <param name="authorizeClusterSecurityGroupIngressRequest">Container for the necessary parameters to execute the
        /// AuthorizeClusterSecurityGroupIngress service method on AmazonRedshift.</param>
        /// 
        /// <returns>The response from the AuthorizeClusterSecurityGroupIngress service method, as returned by AmazonRedshift.</returns>
        /// 
        /// <exception cref="T:Amazon.Redshift.Model.InvalidClusterSecurityGroupStateException" />
        /// <exception cref="T:Amazon.Redshift.Model.AuthorizationAlreadyExistsException" />
        /// <exception cref="T:Amazon.Redshift.Model.AuthorizationQuotaExceededException" />
        /// <exception cref="T:Amazon.Redshift.Model.ClusterSecurityGroupNotFoundException" />
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
		Task<AuthorizeClusterSecurityGroupIngressResponse> AuthorizeClusterSecurityGroupIngressAsync(AuthorizeClusterSecurityGroupIngressRequest authorizeClusterSecurityGroupIngressRequest, CancellationToken cancellationToken = default(CancellationToken));
 
        /// <summary>
        /// <para> Authorizes the specified AWS customer account to restore the specified snapshot. </para> <para> For more information about working
        /// with snapshots, go to <a href="http://docs.aws.amazon.com/redshift/latest/mgmt/working-with-snapshots.html">Amazon Redshift Snapshots</a>
        /// in the <i>Amazon Redshift Management Guide</i> .
        /// </para>
        /// </summary>
        /// 
        /// <param name="authorizeSnapshotAccessRequest">Container for the necessary parameters to execute the AuthorizeSnapshotAccess service method on
        /// AmazonRedshift.</param>
        /// 
        /// <returns>The response from the AuthorizeSnapshotAccess service method, as returned by AmazonRedshift.</returns>
        /// 
        /// <exception cref="T:Amazon.Redshift.Model.AuthorizationAlreadyExistsException" />
        /// <exception cref="T:Amazon.Redshift.Model.ClusterSnapshotNotFoundException" />
        /// <exception cref="T:Amazon.Redshift.Model.AuthorizationQuotaExceededException" />
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
		Task<AuthorizeSnapshotAccessResponse> AuthorizeSnapshotAccessAsync(AuthorizeSnapshotAccessRequest authorizeSnapshotAccessRequest, CancellationToken cancellationToken = default(CancellationToken));
 
        /// <summary>
        /// <para> Copies the specified automated cluster snapshot to a new manual cluster snapshot. The source must be an automated snapshot and it
        /// must be in the available state. </para> <para> When you delete a cluster, Amazon Redshift deletes any automated snapshots of the cluster.
        /// Also, when the retention period of the snapshot expires, Amazon Redshift automatically deletes it. If you want to keep an automated snapshot
        /// for a longer period, you can make a manual copy of the snapshot. Manual snapshots are retained until you delete them. </para> <para> For
        /// more information about working with snapshots, go to <a href="http://docs.aws.amazon.com/redshift/latest/mgmt/working-with-snapshots.html">Amazon Redshift Snapshots</a> in the <i>Amazon Redshift Management Guide</i> .
        /// </para>
        /// </summary>
        /// 
        /// <param name="copyClusterSnapshotRequest">Container for the necessary parameters to execute the CopyClusterSnapshot service method on
        /// AmazonRedshift.</param>
        /// 
        /// <returns>The response from the CopyClusterSnapshot service method, as returned by AmazonRedshift.</returns>
        /// 
        /// <exception cref="T:Amazon.Redshift.Model.ClusterSnapshotAlreadyExistsException" />
        /// <exception cref="T:Amazon.Redshift.Model.ClusterSnapshotNotFoundException" />
        /// <exception cref="T:Amazon.Redshift.Model.ClusterSnapshotQuotaExceededException" />
        /// <exception cref="T:Amazon.Redshift.Model.InvalidClusterSnapshotStateException" />
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
		Task<CopyClusterSnapshotResponse> CopyClusterSnapshotAsync(CopyClusterSnapshotRequest copyClusterSnapshotRequest, CancellationToken cancellationToken = default(CancellationToken));
 
        /// <summary>
        /// <para> Creates a new cluster. To create the cluster in virtual private cloud (VPC), you must provide cluster subnet group name. If you don't
        /// provide a cluster subnet group name or the cluster security group parameter, Amazon Redshift creates a non-VPC cluster, it associates the
        /// default cluster security group with the cluster. For more information about managing clusters, go to <a href="http://docs.aws.amazon.com/redshift/latest/mgmt/working-with-clusters.html">Amazon Redshift Clusters</a> in the <i>Amazon Redshift
        /// Management Guide</i> .
        /// </para>
        /// </summary>
        /// 
        /// <param name="createClusterRequest">Container for the necessary parameters to execute the CreateCluster service method on
        /// AmazonRedshift.</param>
        /// 
        /// <returns>The response from the CreateCluster service method, as returned by AmazonRedshift.</returns>
        /// 
        /// <exception cref="T:Amazon.Redshift.Model.InvalidElasticIpException" />
        /// <exception cref="T:Amazon.Redshift.Model.InvalidSubnetException" />
        /// <exception cref="T:Amazon.Redshift.Model.HsmConfigurationNotFoundException" />
        /// <exception cref="T:Amazon.Redshift.Model.ClusterSubnetGroupNotFoundException" />
        /// <exception cref="T:Amazon.Redshift.Model.InvalidClusterSubnetGroupStateException" />
        /// <exception cref="T:Amazon.Redshift.Model.ClusterAlreadyExistsException" />
        /// <exception cref="T:Amazon.Redshift.Model.InvalidVPCNetworkStateException" />
        /// <exception cref="T:Amazon.Redshift.Model.ClusterParameterGroupNotFoundException" />
        /// <exception cref="T:Amazon.Redshift.Model.InsufficientClusterCapacityException" />
        /// <exception cref="T:Amazon.Redshift.Model.UnauthorizedOperationException" />
        /// <exception cref="T:Amazon.Redshift.Model.NumberOfNodesQuotaExceededException" />
        /// <exception cref="T:Amazon.Redshift.Model.NumberOfNodesPerClusterLimitExceededException" />
        /// <exception cref="T:Amazon.Redshift.Model.HsmClientCertificateNotFoundException" />
        /// <exception cref="T:Amazon.Redshift.Model.ClusterQuotaExceededException" />
        /// <exception cref="T:Amazon.Redshift.Model.ClusterSecurityGroupNotFoundException" />
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
		Task<CreateClusterResponse> CreateClusterAsync(CreateClusterRequest createClusterRequest, CancellationToken cancellationToken = default(CancellationToken));
 
        /// <summary>
        /// <para> Creates an Amazon Redshift parameter group. </para> <para>Creating parameter groups is independent of creating clusters. You can
        /// associate a cluster with a parameter group when you create the cluster. You can also associate an existing cluster with a parameter group
        /// after the cluster is created by using ModifyCluster. </para> <para> Parameters in the parameter group define specific behavior that applies
        /// to the databases you create on the cluster. For more information about managing parameter groups, go to <a href="http://docs.aws.amazon.com/redshift/latest/mgmt/working-with-parameter-groups.html">Amazon Redshift Parameter Groups</a> in the
        /// <i>Amazon Redshift Management Guide</i> .
        /// </para>
        /// </summary>
        /// 
        /// <param name="createClusterParameterGroupRequest">Container for the necessary parameters to execute the CreateClusterParameterGroup service
        /// method on AmazonRedshift.</param>
        /// 
        /// <returns>The response from the CreateClusterParameterGroup service method, as returned by AmazonRedshift.</returns>
        /// 
        /// <exception cref="T:Amazon.Redshift.Model.ClusterParameterGroupQuotaExceededException" />
        /// <exception cref="T:Amazon.Redshift.Model.ClusterParameterGroupAlreadyExistsException" />
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
		Task<CreateClusterParameterGroupResponse> CreateClusterParameterGroupAsync(CreateClusterParameterGroupRequest createClusterParameterGroupRequest, CancellationToken cancellationToken = default(CancellationToken));
 
        /// <summary>
        /// <para> Creates a new Amazon Redshift security group. You use security groups to control access to non-VPC clusters. </para> <para> For
        /// information about managing security groups, go to <a href="http://docs.aws.amazon.com/redshift/latest/mgmt/working-with-security-groups.html">Amazon Redshift Cluster Security Groups</a> in the
        /// <i>Amazon Redshift Management Guide</i> .
        /// </para>
        /// </summary>
        /// 
        /// <param name="createClusterSecurityGroupRequest">Container for the necessary parameters to execute the CreateClusterSecurityGroup service
        /// method on AmazonRedshift.</param>
        /// 
        /// <returns>The response from the CreateClusterSecurityGroup service method, as returned by AmazonRedshift.</returns>
        /// 
        /// <exception cref="T:Amazon.Redshift.Model.ClusterSecurityGroupQuotaExceededException" />
        /// <exception cref="T:Amazon.Redshift.Model.ClusterSecurityGroupAlreadyExistsException" />
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
		Task<CreateClusterSecurityGroupResponse> CreateClusterSecurityGroupAsync(CreateClusterSecurityGroupRequest createClusterSecurityGroupRequest, CancellationToken cancellationToken = default(CancellationToken));
 
        /// <summary>
        /// <para> Creates a manual snapshot of the specified cluster. The cluster must be in the "available" state. </para> <para> For more information
        /// about working with snapshots, go to <a href="http://docs.aws.amazon.com/redshift/latest/mgmt/working-with-snapshots.html">Amazon Redshift
        /// Snapshots</a> in the <i>Amazon Redshift Management Guide</i> .
        /// </para>
        /// </summary>
        /// 
        /// <param name="createClusterSnapshotRequest">Container for the necessary parameters to execute the CreateClusterSnapshot service method on
        /// AmazonRedshift.</param>
        /// 
        /// <returns>The response from the CreateClusterSnapshot service method, as returned by AmazonRedshift.</returns>
        /// 
        /// <exception cref="T:Amazon.Redshift.Model.ClusterSnapshotAlreadyExistsException" />
        /// <exception cref="T:Amazon.Redshift.Model.InvalidClusterStateException" />
        /// <exception cref="T:Amazon.Redshift.Model.ClusterNotFoundException" />
        /// <exception cref="T:Amazon.Redshift.Model.ClusterSnapshotQuotaExceededException" />
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
		Task<CreateClusterSnapshotResponse> CreateClusterSnapshotAsync(CreateClusterSnapshotRequest createClusterSnapshotRequest, CancellationToken cancellationToken = default(CancellationToken));
 
        /// <summary>
        /// <para> Creates a new Amazon Redshift subnet group. You must provide a list of one or more subnets in your existing Amazon Virtual Private
        /// Cloud (Amazon VPC) when creating Amazon Redshift subnet group. </para> <para> For information about subnet groups, go to <a href="http://docs.aws.amazon.com/redshift/latest/mgmt/working-with-cluster-subnet-groups.html">Amazon Redshift Cluster Subnet Groups</a> in
        /// the <i>Amazon Redshift Management Guide</i> .
        /// </para>
        /// </summary>
        /// 
        /// <param name="createClusterSubnetGroupRequest">Container for the necessary parameters to execute the CreateClusterSubnetGroup service method
        /// on AmazonRedshift.</param>
        /// 
        /// <returns>The response from the CreateClusterSubnetGroup service method, as returned by AmazonRedshift.</returns>
        /// 
        /// <exception cref="T:Amazon.Redshift.Model.InvalidSubnetException" />
        /// <exception cref="T:Amazon.Redshift.Model.UnauthorizedOperationException" />
        /// <exception cref="T:Amazon.Redshift.Model.ClusterSubnetQuotaExceededException" />
        /// <exception cref="T:Amazon.Redshift.Model.ClusterSubnetGroupAlreadyExistsException" />
        /// <exception cref="T:Amazon.Redshift.Model.ClusterSubnetGroupQuotaExceededException" />
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
		Task<CreateClusterSubnetGroupResponse> CreateClusterSubnetGroupAsync(CreateClusterSubnetGroupRequest createClusterSubnetGroupRequest, CancellationToken cancellationToken = default(CancellationToken));
 
        /// <summary>
        /// <para> Creates an Amazon Redshift event notification subscription. This action requires an ARN (Amazon Resource Name) of an Amazon SNS topic
        /// created by either the Amazon Redshift console, the Amazon SNS console, or the Amazon SNS API. To obtain an ARN with Amazon SNS, you must
        /// create a topic in Amazon SNS and subscribe to the topic. The ARN is displayed in the SNS console. </para> <para> You can specify the source
        /// type, and lists of Amazon Redshift source IDs, event categories, and event severities. Notifications will be sent for all events you want
        /// that match those criteria. For example, you can specify source type = cluster, source ID = my-cluster-1 and mycluster2, event categories =
        /// Availability, Backup, and severity = ERROR. The subscription will only send notifications for those ERROR events in the Availability and
        /// Backup categories for the specified clusters. </para> <para> If you specify both the source type and source IDs, such as source type =
        /// cluster and source identifier = my-cluster-1, notifications will be sent for all the cluster events for my-cluster-1. If you specify a
        /// source type but do not specify a source identifier, you will receive notice of the events for the objects of that type in your AWS account.
        /// If you do not specify either the SourceType nor the SourceIdentifier, you will be notified of events generated from all Amazon Redshift
        /// sources belonging to your AWS account. You must specify a source type if you specify a source ID. </para>
        /// </summary>
        /// 
        /// <param name="createEventSubscriptionRequest">Container for the necessary parameters to execute the CreateEventSubscription service method on
        /// AmazonRedshift.</param>
        /// 
        /// <returns>The response from the CreateEventSubscription service method, as returned by AmazonRedshift.</returns>
        /// 
        /// <exception cref="T:Amazon.Redshift.Model.SubscriptionCategoryNotFoundException" />
        /// <exception cref="T:Amazon.Redshift.Model.SubscriptionAlreadyExistException" />
        /// <exception cref="T:Amazon.Redshift.Model.EventSubscriptionQuotaExceededException" />
        /// <exception cref="T:Amazon.Redshift.Model.SubscriptionEventIdNotFoundException" />
        /// <exception cref="T:Amazon.Redshift.Model.SubscriptionSeverityNotFoundException" />
        /// <exception cref="T:Amazon.Redshift.Model.SourceNotFoundException" />
        /// <exception cref="T:Amazon.Redshift.Model.SNSNoAuthorizationException" />
        /// <exception cref="T:Amazon.Redshift.Model.SNSTopicArnNotFoundException" />
        /// <exception cref="T:Amazon.Redshift.Model.SNSInvalidTopicException" />
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
		Task<CreateEventSubscriptionResponse> CreateEventSubscriptionAsync(CreateEventSubscriptionRequest createEventSubscriptionRequest, CancellationToken cancellationToken = default(CancellationToken));
 
        /// <summary>
        /// <para>Creates an HSM client certificate that an Amazon Redshift cluster will use to connect to the client's HSM in order to store and
        /// retrieve the keys used to encrypt the cluster databases.</para> <para>The command returns a public key, which you must store in the HSM. In
        /// addition to creating the HSM certificate, you must create an Amazon Redshift HSM configuration that provides a cluster the information
        /// needed to store and use encryption keys in the HSM. For more information, go to <a href="http://docs.aws.amazon.com/redshift/latest/mgmt/working-with-HSM.html">Hardware Security Modules</a> in the Amazon Redshift
        /// Management Guide.</para>
        /// </summary>
        /// 
        /// <param name="createHsmClientCertificateRequest">Container for the necessary parameters to execute the CreateHsmClientCertificate service
        /// method on AmazonRedshift.</param>
        /// 
        /// <returns>The response from the CreateHsmClientCertificate service method, as returned by AmazonRedshift.</returns>
        /// 
        /// <exception cref="T:Amazon.Redshift.Model.HsmClientCertificateQuotaExceededException" />
        /// <exception cref="T:Amazon.Redshift.Model.HsmClientCertificateAlreadyExistsException" />
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
		Task<CreateHsmClientCertificateResponse> CreateHsmClientCertificateAsync(CreateHsmClientCertificateRequest createHsmClientCertificateRequest, CancellationToken cancellationToken = default(CancellationToken));
 
        /// <summary>
        /// <para>Creates an HSM configuration that contains the information required by an Amazon Redshift cluster to store and use database encryption
        /// keys in a Hardware Security Module (HSM). After creating the HSM configuration, you can specify it as a parameter when creating a cluster.
        /// The cluster will then store its encryption keys in the HSM.</para> <para>In addition to creating an HSM configuration, you must also create
        /// an HSM client certificate. For more information, go to <a href="http://docs.aws.amazon.com/redshift/latest/mgmt/working-with-HSM.html">Hardware Security Modules</a> in the Amazon Redshift Management Guide.</para>
        /// </summary>
        /// 
        /// <param name="createHsmConfigurationRequest">Container for the necessary parameters to execute the CreateHsmConfiguration service method on
        /// AmazonRedshift.</param>
        /// 
        /// <returns>The response from the CreateHsmConfiguration service method, as returned by AmazonRedshift.</returns>
        /// 
        /// <exception cref="T:Amazon.Redshift.Model.HsmConfigurationQuotaExceededException" />
        /// <exception cref="T:Amazon.Redshift.Model.HsmConfigurationAlreadyExistsException" />
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
		Task<CreateHsmConfigurationResponse> CreateHsmConfigurationAsync(CreateHsmConfigurationRequest createHsmConfigurationRequest, CancellationToken cancellationToken = default(CancellationToken));
 
        /// <summary>
        /// <para> Deletes a previously provisioned cluster. A successful response from the web service indicates that the request was received
        /// correctly. If a final cluster snapshot is requested the status of the cluster will be "final-snapshot" while the snapshot is being taken,
        /// then it's "deleting" once Amazon Redshift begins deleting the cluster. Use DescribeClusters to monitor the status of the deletion. The
        /// delete operation cannot be canceled or reverted once submitted. For more information about managing clusters, go to <a href="http://docs.aws.amazon.com/redshift/latest/mgmt/working-with-clusters.html">Amazon Redshift Clusters</a> in the <i>Amazon Redshift
        /// Management Guide</i> .
        /// </para>
        /// </summary>
        /// 
        /// <param name="deleteClusterRequest">Container for the necessary parameters to execute the DeleteCluster service method on
        /// AmazonRedshift.</param>
        /// 
        /// <returns>The response from the DeleteCluster service method, as returned by AmazonRedshift.</returns>
        /// 
        /// <exception cref="T:Amazon.Redshift.Model.ClusterSnapshotAlreadyExistsException" />
        /// <exception cref="T:Amazon.Redshift.Model.InvalidClusterStateException" />
        /// <exception cref="T:Amazon.Redshift.Model.ClusterNotFoundException" />
        /// <exception cref="T:Amazon.Redshift.Model.ClusterSnapshotQuotaExceededException" />
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
		Task<DeleteClusterResponse> DeleteClusterAsync(DeleteClusterRequest deleteClusterRequest, CancellationToken cancellationToken = default(CancellationToken));
 
        /// <summary>
        /// <para> Deletes a specified Amazon Redshift parameter group. <para><b>NOTE:</b>You cannot delete a parameter group if it is associated with a
        /// cluster.</para> </para>
        /// </summary>
        /// 
        /// <param name="deleteClusterParameterGroupRequest">Container for the necessary parameters to execute the DeleteClusterParameterGroup service
        /// method on AmazonRedshift.</param>
        /// 
        /// <exception cref="T:Amazon.Redshift.Model.InvalidClusterParameterGroupStateException" />
        /// <exception cref="T:Amazon.Redshift.Model.ClusterParameterGroupNotFoundException" />
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
		Task<DeleteClusterParameterGroupResponse> DeleteClusterParameterGroupAsync(DeleteClusterParameterGroupRequest deleteClusterParameterGroupRequest, CancellationToken cancellationToken = default(CancellationToken));
 
        /// <summary>
        /// <para> Deletes an Amazon Redshift security group. </para> <para><b>NOTE:</b>You cannot delete a security group that is associated with any
        /// clusters. You cannot delete the default security group.</para> <para> For information about managing security groups, go to <a href="http://docs.aws.amazon.com/redshift/latest/mgmt/working-with-security-groups.html">Amazon Redshift Cluster Security Groups</a> in the
        /// <i>Amazon Redshift Management Guide</i> .
        /// </para>
        /// </summary>
        /// 
        /// <param name="deleteClusterSecurityGroupRequest">Container for the necessary parameters to execute the DeleteClusterSecurityGroup service
        /// method on AmazonRedshift.</param>
        /// 
        /// <exception cref="T:Amazon.Redshift.Model.InvalidClusterSecurityGroupStateException" />
        /// <exception cref="T:Amazon.Redshift.Model.ClusterSecurityGroupNotFoundException" />
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
		Task<DeleteClusterSecurityGroupResponse> DeleteClusterSecurityGroupAsync(DeleteClusterSecurityGroupRequest deleteClusterSecurityGroupRequest, CancellationToken cancellationToken = default(CancellationToken));
 
        /// <summary>
        /// <para> Deletes the specified manual snapshot. The snapshot must be in the "available" state, with no other users authorized to access the
        /// snapshot. </para> <para> Unlike automated snapshots, manual snapshots are retained even after you delete your cluster. Amazon Redshift does
        /// not delete your manual snapshots. You must delete manual snapshot explicitly to avoid getting charged. If other accounts are authorized to
        /// access the snapshot, you must revoke all of the authorizations before you can delete the snapshot. </para>
        /// </summary>
        /// 
        /// <param name="deleteClusterSnapshotRequest">Container for the necessary parameters to execute the DeleteClusterSnapshot service method on
        /// AmazonRedshift.</param>
        /// 
        /// <returns>The response from the DeleteClusterSnapshot service method, as returned by AmazonRedshift.</returns>
        /// 
        /// <exception cref="T:Amazon.Redshift.Model.ClusterSnapshotNotFoundException" />
        /// <exception cref="T:Amazon.Redshift.Model.InvalidClusterSnapshotStateException" />
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
		Task<DeleteClusterSnapshotResponse> DeleteClusterSnapshotAsync(DeleteClusterSnapshotRequest deleteClusterSnapshotRequest, CancellationToken cancellationToken = default(CancellationToken));
 
        /// <summary>
        /// <para> Deletes the specified cluster subnet group. </para>
        /// </summary>
        /// 
        /// <param name="deleteClusterSubnetGroupRequest">Container for the necessary parameters to execute the DeleteClusterSubnetGroup service method
        /// on AmazonRedshift.</param>
        /// 
        /// <exception cref="T:Amazon.Redshift.Model.InvalidClusterSubnetStateException" />
        /// <exception cref="T:Amazon.Redshift.Model.ClusterSubnetGroupNotFoundException" />
        /// <exception cref="T:Amazon.Redshift.Model.InvalidClusterSubnetGroupStateException" />
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
		Task<DeleteClusterSubnetGroupResponse> DeleteClusterSubnetGroupAsync(DeleteClusterSubnetGroupRequest deleteClusterSubnetGroupRequest, CancellationToken cancellationToken = default(CancellationToken));
 
        /// <summary>
        /// <para> Deletes an Amazon Redshift event notification subscription. </para>
        /// </summary>
        /// 
        /// <param name="deleteEventSubscriptionRequest">Container for the necessary parameters to execute the DeleteEventSubscription service method on
        /// AmazonRedshift.</param>
        /// 
        /// <exception cref="T:Amazon.Redshift.Model.SubscriptionNotFoundException" />
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
		Task<DeleteEventSubscriptionResponse> DeleteEventSubscriptionAsync(DeleteEventSubscriptionRequest deleteEventSubscriptionRequest, CancellationToken cancellationToken = default(CancellationToken));
 
        /// <summary>
        /// <para>Deletes the specified HSM client certificate.</para>
        /// </summary>
        /// 
        /// <param name="deleteHsmClientCertificateRequest">Container for the necessary parameters to execute the DeleteHsmClientCertificate service
        /// method on AmazonRedshift.</param>
        /// 
        /// <exception cref="T:Amazon.Redshift.Model.InvalidHsmClientCertificateStateException" />
        /// <exception cref="T:Amazon.Redshift.Model.HsmClientCertificateNotFoundException" />
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
		Task<DeleteHsmClientCertificateResponse> DeleteHsmClientCertificateAsync(DeleteHsmClientCertificateRequest deleteHsmClientCertificateRequest, CancellationToken cancellationToken = default(CancellationToken));
 
        /// <summary>
        /// <para>Deletes the specified Amazon Redshift HSM configuration.</para>
        /// </summary>
        /// 
        /// <param name="deleteHsmConfigurationRequest">Container for the necessary parameters to execute the DeleteHsmConfiguration service method on
        /// AmazonRedshift.</param>
        /// 
        /// <exception cref="T:Amazon.Redshift.Model.HsmConfigurationNotFoundException" />
        /// <exception cref="T:Amazon.Redshift.Model.InvalidHsmConfigurationStateException" />
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
		Task<DeleteHsmConfigurationResponse> DeleteHsmConfigurationAsync(DeleteHsmConfigurationRequest deleteHsmConfigurationRequest, CancellationToken cancellationToken = default(CancellationToken));
 
        /// <summary>
        /// <para> Returns a list of Amazon Redshift parameter groups, including parameter groups you created and the default parameter group. For each
        /// parameter group, the response includes the parameter group name, description, and parameter group family name. You can optionally specify a
        /// name to retrieve the description of a specific parameter group. </para> <para> For more information about managing parameter groups, go to
        /// <a href="http://docs.aws.amazon.com/redshift/latest/mgmt/working-with-parameter-groups.html">Amazon Redshift Parameter Groups</a> in the
        /// <i>Amazon Redshift Management Guide</i> .
        /// </para>
        /// </summary>
        /// 
        /// <param name="describeClusterParameterGroupsRequest">Container for the necessary parameters to execute the DescribeClusterParameterGroups
        /// service method on AmazonRedshift.</param>
        /// 
        /// <returns>The response from the DescribeClusterParameterGroups service method, as returned by AmazonRedshift.</returns>
        /// 
        /// <exception cref="T:Amazon.Redshift.Model.ClusterParameterGroupNotFoundException" />
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
		Task<DescribeClusterParameterGroupsResponse> DescribeClusterParameterGroupsAsync(DescribeClusterParameterGroupsRequest describeClusterParameterGroupsRequest, CancellationToken cancellationToken = default(CancellationToken));
 
        /// <summary>
        /// <para> Returns a detailed list of parameters contained within the specified Amazon Redshift parameter group. For each parameter the response
        /// includes information such as parameter name, description, data type, value, whether the parameter value is modifiable, and so on. </para>
        /// <para>You can specify <i>source</i> filter to retrieve parameters of only specific type. For example, to retrieve parameters that were
        /// modified by a user action such as from ModifyClusterParameterGroup, you can specify <i>source</i> equal to <i>user</i> .</para> <para> For
        /// more information about managing parameter groups, go to <a href="http://docs.aws.amazon.com/redshift/latest/mgmt/working-with-parameter-groups.html">Amazon Redshift Parameter Groups</a> in the
        /// <i>Amazon Redshift Management Guide</i> .
        /// </para>
        /// </summary>
        /// 
        /// <param name="describeClusterParametersRequest">Container for the necessary parameters to execute the DescribeClusterParameters service
        /// method on AmazonRedshift.</param>
        /// 
        /// <returns>The response from the DescribeClusterParameters service method, as returned by AmazonRedshift.</returns>
        /// 
        /// <exception cref="T:Amazon.Redshift.Model.ClusterParameterGroupNotFoundException" />
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
		Task<DescribeClusterParametersResponse> DescribeClusterParametersAsync(DescribeClusterParametersRequest describeClusterParametersRequest, CancellationToken cancellationToken = default(CancellationToken));
 
        /// <summary>
        /// <para> Returns properties of provisioned clusters including general cluster properties, cluster database properties, maintenance and backup
        /// properties, and security and access properties. This operation supports pagination. For more information about managing clusters, go to <a href="http://docs.aws.amazon.com/redshift/latest/mgmt/working-with-clusters.html">Amazon Redshift Clusters</a> in the <i>Amazon Redshift
        /// Management Guide</i> .
        /// </para>
        /// </summary>
        /// 
        /// <param name="describeClustersRequest">Container for the necessary parameters to execute the DescribeClusters service method on
        /// AmazonRedshift.</param>
        /// 
        /// <returns>The response from the DescribeClusters service method, as returned by AmazonRedshift.</returns>
        /// 
        /// <exception cref="T:Amazon.Redshift.Model.ClusterNotFoundException" />
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
		Task<DescribeClustersResponse> DescribeClustersAsync(DescribeClustersRequest describeClustersRequest, CancellationToken cancellationToken = default(CancellationToken));
 
        /// <summary>
        /// <para> Returns information about Amazon Redshift security groups. If the name of a security group is specified, the response will contain
        /// only information about only that security group. </para> <para> For information about managing security groups, go to <a href="http://docs.aws.amazon.com/redshift/latest/mgmt/working-with-security-groups.html">Amazon Redshift Cluster Security Groups</a> in the
        /// <i>Amazon Redshift Management Guide</i> .
        /// </para>
        /// </summary>
        /// 
        /// <param name="describeClusterSecurityGroupsRequest">Container for the necessary parameters to execute the DescribeClusterSecurityGroups
        /// service method on AmazonRedshift.</param>
        /// 
        /// <returns>The response from the DescribeClusterSecurityGroups service method, as returned by AmazonRedshift.</returns>
        /// 
        /// <exception cref="T:Amazon.Redshift.Model.ClusterSecurityGroupNotFoundException" />
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
		Task<DescribeClusterSecurityGroupsResponse> DescribeClusterSecurityGroupsAsync(DescribeClusterSecurityGroupsRequest describeClusterSecurityGroupsRequest, CancellationToken cancellationToken = default(CancellationToken));
 
        /// <summary>
        /// <para> Returns one or more snapshot objects, which contain metadata about your cluster snapshots. By default, this operation returns
        /// information about all snapshots of all clusters that are owned by you AWS customer account. No information is returned for snapshots owned
        /// by inactive AWS customer accounts. </para>
        /// </summary>
        /// 
        /// <param name="describeClusterSnapshotsRequest">Container for the necessary parameters to execute the DescribeClusterSnapshots service method
        /// on AmazonRedshift.</param>
        /// 
        /// <returns>The response from the DescribeClusterSnapshots service method, as returned by AmazonRedshift.</returns>
        /// 
        /// <exception cref="T:Amazon.Redshift.Model.ClusterSnapshotNotFoundException" />
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
		Task<DescribeClusterSnapshotsResponse> DescribeClusterSnapshotsAsync(DescribeClusterSnapshotsRequest describeClusterSnapshotsRequest, CancellationToken cancellationToken = default(CancellationToken));
 
        /// <summary>
        /// <para> Returns one or more cluster subnet group objects, which contain metadata about your cluster subnet groups. By default, this
        /// operation returns information about all cluster subnet groups that are defined in you AWS account. </para>
        /// </summary>
        /// 
        /// <param name="describeClusterSubnetGroupsRequest">Container for the necessary parameters to execute the DescribeClusterSubnetGroups service
        /// method on AmazonRedshift.</param>
        /// 
        /// <returns>The response from the DescribeClusterSubnetGroups service method, as returned by AmazonRedshift.</returns>
        /// 
        /// <exception cref="T:Amazon.Redshift.Model.ClusterSubnetGroupNotFoundException" />
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
		Task<DescribeClusterSubnetGroupsResponse> DescribeClusterSubnetGroupsAsync(DescribeClusterSubnetGroupsRequest describeClusterSubnetGroupsRequest, CancellationToken cancellationToken = default(CancellationToken));
 
        /// <summary>
        /// <para> Returns descriptions of the available Amazon Redshift cluster versions. You can call this operation even before creating any
        /// clusters to learn more about the Amazon Redshift versions. For more information about managing clusters, go to <a href="http://docs.aws.amazon.com/redshift/latest/mgmt/working-with-clusters.html">Amazon Redshift Clusters</a> in the <i>Amazon Redshift
        /// Management Guide</i> </para>
        /// </summary>
        /// 
        /// <param name="describeClusterVersionsRequest">Container for the necessary parameters to execute the DescribeClusterVersions service method on
        /// AmazonRedshift.</param>
        /// 
        /// <returns>The response from the DescribeClusterVersions service method, as returned by AmazonRedshift.</returns>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
		Task<DescribeClusterVersionsResponse> DescribeClusterVersionsAsync(DescribeClusterVersionsRequest describeClusterVersionsRequest, CancellationToken cancellationToken = default(CancellationToken));
 
        /// <summary>
        /// <para> Returns a list of parameter settings for the specified parameter group family. </para> <para> For more information about managing
        /// parameter groups, go to <a href="http://docs.aws.amazon.com/redshift/latest/mgmt/working-with-parameter-groups.html">Amazon Redshift
        /// Parameter Groups</a> in the <i>Amazon Redshift Management Guide</i> .
        /// </para>
        /// </summary>
        /// 
        /// <param name="describeDefaultClusterParametersRequest">Container for the necessary parameters to execute the DescribeDefaultClusterParameters
        /// service method on AmazonRedshift.</param>
        /// 
        /// <returns>The response from the DescribeDefaultClusterParameters service method, as returned by AmazonRedshift.</returns>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
		Task<DescribeDefaultClusterParametersResponse> DescribeDefaultClusterParametersAsync(DescribeDefaultClusterParametersRequest describeDefaultClusterParametersRequest, CancellationToken cancellationToken = default(CancellationToken));
 
        /// <summary>
        /// <para>Displays a list of event categories for all event source types, or for a specified source type. For a list of the event categories and
        /// source types, go to <a href="http://docs.aws.amazon.com/redshift/latest/mgmt/working-with-event-notifications.html">Amazon Redshift Event
        /// Notifications</a> .</para>
        /// </summary>
        /// 
        /// <param name="describeEventCategoriesRequest">Container for the necessary parameters to execute the DescribeEventCategories service method on
        /// AmazonRedshift.</param>
        /// 
        /// <returns>The response from the DescribeEventCategories service method, as returned by AmazonRedshift.</returns>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
		Task<DescribeEventCategoriesResponse> DescribeEventCategoriesAsync(DescribeEventCategoriesRequest describeEventCategoriesRequest, CancellationToken cancellationToken = default(CancellationToken));
 
        /// <summary>
        /// <para> Returns events related to clusters, security groups, snapshots, and parameter groups for the past 14 days. Events specific to a
        /// particular cluster, security group, snapshot or parameter group can be obtained by providing the name as a parameter. By default, the past
        /// hour of events are returned. </para>
        /// </summary>
        /// 
        /// <param name="describeEventsRequest">Container for the necessary parameters to execute the DescribeEvents service method on
        /// AmazonRedshift.</param>
        /// 
        /// <returns>The response from the DescribeEvents service method, as returned by AmazonRedshift.</returns>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
		Task<DescribeEventsResponse> DescribeEventsAsync(DescribeEventsRequest describeEventsRequest, CancellationToken cancellationToken = default(CancellationToken));
 
        /// <summary>
        /// <para> Lists descriptions of all the Amazon Redshift event notifications subscription for a customer account. If you specify a subscription
        /// name, lists the description for that subscription. </para>
        /// </summary>
        /// 
        /// <param name="describeEventSubscriptionsRequest">Container for the necessary parameters to execute the DescribeEventSubscriptions service
        /// method on AmazonRedshift.</param>
        /// 
        /// <returns>The response from the DescribeEventSubscriptions service method, as returned by AmazonRedshift.</returns>
        /// 
        /// <exception cref="T:Amazon.Redshift.Model.SubscriptionNotFoundException" />
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
		Task<DescribeEventSubscriptionsResponse> DescribeEventSubscriptionsAsync(DescribeEventSubscriptionsRequest describeEventSubscriptionsRequest, CancellationToken cancellationToken = default(CancellationToken));
 
        /// <summary>
        /// <para>Returns information about the specified HSM client certificate. If no certificate ID is specified, returns information about all the
        /// HSM certificates owned by your AWS customer account.</para>
        /// </summary>
        /// 
        /// <param name="describeHsmClientCertificatesRequest">Container for the necessary parameters to execute the DescribeHsmClientCertificates
        /// service method on AmazonRedshift.</param>
        /// 
        /// <returns>The response from the DescribeHsmClientCertificates service method, as returned by AmazonRedshift.</returns>
        /// 
        /// <exception cref="T:Amazon.Redshift.Model.HsmClientCertificateNotFoundException" />
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
		Task<DescribeHsmClientCertificatesResponse> DescribeHsmClientCertificatesAsync(DescribeHsmClientCertificatesRequest describeHsmClientCertificatesRequest, CancellationToken cancellationToken = default(CancellationToken));
 
        /// <summary>
        /// <para>Returns information about the specified Amazon Redshift HSM configuration. If no configuration ID is specified, returns information
        /// about all the HSM configurations owned by your AWS customer account.</para>
        /// </summary>
        /// 
        /// <param name="describeHsmConfigurationsRequest">Container for the necessary parameters to execute the DescribeHsmConfigurations service
        /// method on AmazonRedshift.</param>
        /// 
        /// <returns>The response from the DescribeHsmConfigurations service method, as returned by AmazonRedshift.</returns>
        /// 
        /// <exception cref="T:Amazon.Redshift.Model.HsmConfigurationNotFoundException" />
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
		Task<DescribeHsmConfigurationsResponse> DescribeHsmConfigurationsAsync(DescribeHsmConfigurationsRequest describeHsmConfigurationsRequest, CancellationToken cancellationToken = default(CancellationToken));
 
        /// <summary>
        /// <para>Describes whether information, such as queries and connection attempts, is being logged for the specified Amazon Redshift
        /// cluster.</para>
        /// </summary>
        /// 
        /// <param name="describeLoggingStatusRequest">Container for the necessary parameters to execute the DescribeLoggingStatus service method on
        /// AmazonRedshift.</param>
        /// 
        /// <returns>The response from the DescribeLoggingStatus service method, as returned by AmazonRedshift.</returns>
        /// 
        /// <exception cref="T:Amazon.Redshift.Model.ClusterNotFoundException" />
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
		Task<DescribeLoggingStatusResponse> DescribeLoggingStatusAsync(DescribeLoggingStatusRequest describeLoggingStatusRequest, CancellationToken cancellationToken = default(CancellationToken));
 
        /// <summary>
        /// <para> Returns a list of orderable cluster options. Before you create a new cluster you can use this operation to find what options are
        /// available, such as the EC2 Availability Zones (AZ) in the specific AWS region that you can specify, and the node types you can request. The
        /// node types differ by available storage, memory, CPU and price. With the cost involved you might want to obtain a list of cluster options in
        /// the specific region and specify values when creating a cluster. For more information about managing clusters, go to <a href="http://docs.aws.amazon.com/redshift/latest/mgmt/working-with-clusters.html">Amazon Redshift Clusters</a> in the <i>Amazon Redshift
        /// Management Guide</i> </para>
        /// </summary>
        /// 
        /// <param name="describeOrderableClusterOptionsRequest">Container for the necessary parameters to execute the DescribeOrderableClusterOptions
        /// service method on AmazonRedshift.</param>
        /// 
        /// <returns>The response from the DescribeOrderableClusterOptions service method, as returned by AmazonRedshift.</returns>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
		Task<DescribeOrderableClusterOptionsResponse> DescribeOrderableClusterOptionsAsync(DescribeOrderableClusterOptionsRequest describeOrderableClusterOptionsRequest, CancellationToken cancellationToken = default(CancellationToken));
 
        /// <summary>
        /// <para> Returns a list of the available reserved node offerings by Amazon Redshift with their descriptions including the node type, the fixed
        /// and recurring costs of reserving the node and duration the node will be reserved for you. These descriptions help you determine which
        /// reserve node offering you want to purchase. You then use the unique offering ID in you call to PurchaseReservedNodeOffering to reserve one
        /// or more nodes for your Amazon Redshift cluster. </para> <para> For more information about managing parameter groups, go to <a href="http://docs.aws.amazon.com/redshift/latest/mgmt/purchase-reserved-node-instance.html">Purchasing Reserved Nodes</a> in the <i>Amazon
        /// Redshift Management Guide</i> .
        /// 
        /// </para>
        /// </summary>
        /// 
        /// <param name="describeReservedNodeOfferingsRequest">Container for the necessary parameters to execute the DescribeReservedNodeOfferings
        /// service method on AmazonRedshift.</param>
        /// 
        /// <returns>The response from the DescribeReservedNodeOfferings service method, as returned by AmazonRedshift.</returns>
        /// 
        /// <exception cref="T:Amazon.Redshift.Model.ReservedNodeOfferingNotFoundException" />
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
		Task<DescribeReservedNodeOfferingsResponse> DescribeReservedNodeOfferingsAsync(DescribeReservedNodeOfferingsRequest describeReservedNodeOfferingsRequest, CancellationToken cancellationToken = default(CancellationToken));
 
        /// <summary>
        /// <para> Returns the descriptions of the reserved nodes. </para>
        /// </summary>
        /// 
        /// <param name="describeReservedNodesRequest">Container for the necessary parameters to execute the DescribeReservedNodes service method on
        /// AmazonRedshift.</param>
        /// 
        /// <returns>The response from the DescribeReservedNodes service method, as returned by AmazonRedshift.</returns>
        /// 
        /// <exception cref="T:Amazon.Redshift.Model.ReservedNodeNotFoundException" />
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
		Task<DescribeReservedNodesResponse> DescribeReservedNodesAsync(DescribeReservedNodesRequest describeReservedNodesRequest, CancellationToken cancellationToken = default(CancellationToken));
 
        /// <summary>
        /// <para> Returns information about the last resize operation for the specified cluster. If no resize operation has ever been initiated for the
        /// specified cluster, a <c>HTTP 404</c> error is returned. If a resize operation was initiated and completed, the status of the resize remains
        /// as <c>SUCCEEDED</c> until the next resize. </para> <para> A resize operation can be requested using ModifyCluster and specifying a different
        /// number or type of nodes for the cluster. </para>
        /// </summary>
        /// 
        /// <param name="describeResizeRequest">Container for the necessary parameters to execute the DescribeResize service method on
        /// AmazonRedshift.</param>
        /// 
        /// <returns>The response from the DescribeResize service method, as returned by AmazonRedshift.</returns>
        /// 
        /// <exception cref="T:Amazon.Redshift.Model.ClusterNotFoundException" />
        /// <exception cref="T:Amazon.Redshift.Model.ResizeNotFoundException" />
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
		Task<DescribeResizeResponse> DescribeResizeAsync(DescribeResizeRequest describeResizeRequest, CancellationToken cancellationToken = default(CancellationToken));
 
        /// <summary>
        /// <para>Stops logging information, such as queries and connection attempts, for the specified Amazon Redshift cluster.</para>
        /// </summary>
        /// 
        /// <param name="disableLoggingRequest">Container for the necessary parameters to execute the DisableLogging service method on
        /// AmazonRedshift.</param>
        /// 
        /// <returns>The response from the DisableLogging service method, as returned by AmazonRedshift.</returns>
        /// 
        /// <exception cref="T:Amazon.Redshift.Model.ClusterNotFoundException" />
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
		Task<DisableLoggingResponse> DisableLoggingAsync(DisableLoggingRequest disableLoggingRequest, CancellationToken cancellationToken = default(CancellationToken));
 
        /// <summary>
        /// <para>Disables the automatic copying of snapshots from one region to another region for a specified cluster.</para>
        /// </summary>
        /// 
        /// <param name="disableSnapshotCopyRequest">Container for the necessary parameters to execute the DisableSnapshotCopy service method on
        /// AmazonRedshift.</param>
        /// 
        /// <returns>The response from the DisableSnapshotCopy service method, as returned by AmazonRedshift.</returns>
        /// 
        /// <exception cref="T:Amazon.Redshift.Model.SnapshotCopyAlreadyDisabledException" />
        /// <exception cref="T:Amazon.Redshift.Model.UnauthorizedOperationException" />
        /// <exception cref="T:Amazon.Redshift.Model.InvalidClusterStateException" />
        /// <exception cref="T:Amazon.Redshift.Model.ClusterNotFoundException" />
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
		Task<DisableSnapshotCopyResponse> DisableSnapshotCopyAsync(DisableSnapshotCopyRequest disableSnapshotCopyRequest, CancellationToken cancellationToken = default(CancellationToken));
 
        /// <summary>
        /// <para>Starts logging information, such as queries and connection attempts, for the specified Amazon Redshift cluster.</para>
        /// </summary>
        /// 
        /// <param name="enableLoggingRequest">Container for the necessary parameters to execute the EnableLogging service method on
        /// AmazonRedshift.</param>
        /// 
        /// <returns>The response from the EnableLogging service method, as returned by AmazonRedshift.</returns>
        /// 
        /// <exception cref="T:Amazon.Redshift.Model.InvalidS3KeyPrefixException" />
        /// <exception cref="T:Amazon.Redshift.Model.InvalidS3BucketNameException" />
        /// <exception cref="T:Amazon.Redshift.Model.BucketNotFoundException" />
        /// <exception cref="T:Amazon.Redshift.Model.ClusterNotFoundException" />
        /// <exception cref="T:Amazon.Redshift.Model.InsufficientS3BucketPolicyException" />
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
		Task<EnableLoggingResponse> EnableLoggingAsync(EnableLoggingRequest enableLoggingRequest, CancellationToken cancellationToken = default(CancellationToken));
 
        /// <summary>
        /// <para>Enables the automatic copy of snapshots from one region to another region for a specified cluster.</para>
        /// </summary>
        /// 
        /// <param name="enableSnapshotCopyRequest">Container for the necessary parameters to execute the EnableSnapshotCopy service method on
        /// AmazonRedshift.</param>
        /// 
        /// <returns>The response from the EnableSnapshotCopy service method, as returned by AmazonRedshift.</returns>
        /// 
        /// <exception cref="T:Amazon.Redshift.Model.CopyToRegionDisabledException" />
        /// <exception cref="T:Amazon.Redshift.Model.UnauthorizedOperationException" />
        /// <exception cref="T:Amazon.Redshift.Model.InvalidClusterStateException" />
        /// <exception cref="T:Amazon.Redshift.Model.ClusterNotFoundException" />
        /// <exception cref="T:Amazon.Redshift.Model.IncompatibleOrderableOptionsException" />
        /// <exception cref="T:Amazon.Redshift.Model.SnapshotCopyAlreadyEnabledException" />
        /// <exception cref="T:Amazon.Redshift.Model.UnknownSnapshotCopyRegionException" />
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
		Task<EnableSnapshotCopyResponse> EnableSnapshotCopyAsync(EnableSnapshotCopyRequest enableSnapshotCopyRequest, CancellationToken cancellationToken = default(CancellationToken));
 
        /// <summary>
        /// <para> Modifies the settings for a cluster. For example, you can add another security or parameter group, update the preferred maintenance
        /// window, or change the master user password. Resetting a cluster password or modifying the security groups associated with a cluster do not
        /// need a reboot. However, modifying parameter group requires a reboot for parameters to take effect. For more information about managing
        /// clusters, go to <a href="http://docs.aws.amazon.com/redshift/latest/mgmt/working-with-clusters.html">Amazon Redshift Clusters</a> in the
        /// <i>Amazon Redshift Management Guide</i> </para> <para>You can also change node type and the number of nodes to scale up or down the cluster.
        /// When resizing a cluster, you must specify both the number of nodes and the node type even if one of the parameters does not change. If you
        /// specify the same number of nodes and node type that are already configured for the cluster, an error is returned.</para>
        /// </summary>
        /// 
        /// <param name="modifyClusterRequest">Container for the necessary parameters to execute the ModifyCluster service method on
        /// AmazonRedshift.</param>
        /// 
        /// <returns>The response from the ModifyCluster service method, as returned by AmazonRedshift.</returns>
        /// 
        /// <exception cref="T:Amazon.Redshift.Model.InvalidClusterSecurityGroupStateException" />
        /// <exception cref="T:Amazon.Redshift.Model.HsmConfigurationNotFoundException" />
        /// <exception cref="T:Amazon.Redshift.Model.InsufficientClusterCapacityException" />
        /// <exception cref="T:Amazon.Redshift.Model.UnauthorizedOperationException" />
        /// <exception cref="T:Amazon.Redshift.Model.InvalidClusterStateException" />
        /// <exception cref="T:Amazon.Redshift.Model.NumberOfNodesQuotaExceededException" />
        /// <exception cref="T:Amazon.Redshift.Model.ClusterNotFoundException" />
        /// <exception cref="T:Amazon.Redshift.Model.UnsupportedOptionException" />
        /// <exception cref="T:Amazon.Redshift.Model.ClusterSecurityGroupNotFoundException" />
        /// <exception cref="T:Amazon.Redshift.Model.HsmClientCertificateNotFoundException" />
        /// <exception cref="T:Amazon.Redshift.Model.ClusterParameterGroupNotFoundException" />
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
		Task<ModifyClusterResponse> ModifyClusterAsync(ModifyClusterRequest modifyClusterRequest, CancellationToken cancellationToken = default(CancellationToken));
 
        /// <summary>
        /// <para> Modifies the parameters of a parameter group. </para> <para> For more information about managing parameter groups, go to <a href="http://docs.aws.amazon.com/redshift/latest/mgmt/working-with-parameter-groups.html">Amazon Redshift Parameter Groups</a> in the
        /// <i>Amazon Redshift Management Guide</i> .
        /// </para>
        /// </summary>
        /// 
        /// <param name="modifyClusterParameterGroupRequest">Container for the necessary parameters to execute the ModifyClusterParameterGroup service
        /// method on AmazonRedshift.</param>
        /// 
        /// <returns>The response from the ModifyClusterParameterGroup service method, as returned by AmazonRedshift.</returns>
        /// 
        /// <exception cref="T:Amazon.Redshift.Model.InvalidClusterParameterGroupStateException" />
        /// <exception cref="T:Amazon.Redshift.Model.ClusterParameterGroupNotFoundException" />
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
		Task<ModifyClusterParameterGroupResponse> ModifyClusterParameterGroupAsync(ModifyClusterParameterGroupRequest modifyClusterParameterGroupRequest, CancellationToken cancellationToken = default(CancellationToken));
 
        /// <summary>
        /// <para> Modifies a cluster subnet group to include the specified list of VPC subnets. The operation replaces the existing list of subnets
        /// with the new list of subnets. </para>
        /// </summary>
        /// 
        /// <param name="modifyClusterSubnetGroupRequest">Container for the necessary parameters to execute the ModifyClusterSubnetGroup service method
        /// on AmazonRedshift.</param>
        /// 
        /// <returns>The response from the ModifyClusterSubnetGroup service method, as returned by AmazonRedshift.</returns>
        /// 
        /// <exception cref="T:Amazon.Redshift.Model.SubnetAlreadyInUseException" />
        /// <exception cref="T:Amazon.Redshift.Model.InvalidSubnetException" />
        /// <exception cref="T:Amazon.Redshift.Model.UnauthorizedOperationException" />
        /// <exception cref="T:Amazon.Redshift.Model.ClusterSubnetQuotaExceededException" />
        /// <exception cref="T:Amazon.Redshift.Model.ClusterSubnetGroupNotFoundException" />
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
		Task<ModifyClusterSubnetGroupResponse> ModifyClusterSubnetGroupAsync(ModifyClusterSubnetGroupRequest modifyClusterSubnetGroupRequest, CancellationToken cancellationToken = default(CancellationToken));
 
        /// <summary>
        /// <para> Modifies an existing Amazon Redshift event notification subscription. </para>
        /// </summary>
        /// 
        /// <param name="modifyEventSubscriptionRequest">Container for the necessary parameters to execute the ModifyEventSubscription service method on
        /// AmazonRedshift.</param>
        /// 
        /// <returns>The response from the ModifyEventSubscription service method, as returned by AmazonRedshift.</returns>
        /// 
        /// <exception cref="T:Amazon.Redshift.Model.SubscriptionCategoryNotFoundException" />
        /// <exception cref="T:Amazon.Redshift.Model.SubscriptionEventIdNotFoundException" />
        /// <exception cref="T:Amazon.Redshift.Model.SubscriptionSeverityNotFoundException" />
        /// <exception cref="T:Amazon.Redshift.Model.SourceNotFoundException" />
        /// <exception cref="T:Amazon.Redshift.Model.SNSNoAuthorizationException" />
        /// <exception cref="T:Amazon.Redshift.Model.SNSTopicArnNotFoundException" />
        /// <exception cref="T:Amazon.Redshift.Model.SubscriptionNotFoundException" />
        /// <exception cref="T:Amazon.Redshift.Model.SNSInvalidTopicException" />
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
		Task<ModifyEventSubscriptionResponse> ModifyEventSubscriptionAsync(ModifyEventSubscriptionRequest modifyEventSubscriptionRequest, CancellationToken cancellationToken = default(CancellationToken));
 
        /// <summary>
        /// <para> Modifies the number of days to retain automated snapshots in the destination region after they are copied from the source region.
        /// </para>
        /// </summary>
        /// 
        /// <param name="modifySnapshotCopyRetentionPeriodRequest">Container for the necessary parameters to execute the
        /// ModifySnapshotCopyRetentionPeriod service method on AmazonRedshift.</param>
        /// 
        /// <returns>The response from the ModifySnapshotCopyRetentionPeriod service method, as returned by AmazonRedshift.</returns>
        /// 
        /// <exception cref="T:Amazon.Redshift.Model.SnapshotCopyDisabledException" />
        /// <exception cref="T:Amazon.Redshift.Model.UnauthorizedOperationException" />
        /// <exception cref="T:Amazon.Redshift.Model.InvalidClusterStateException" />
        /// <exception cref="T:Amazon.Redshift.Model.ClusterNotFoundException" />
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
		Task<ModifySnapshotCopyRetentionPeriodResponse> ModifySnapshotCopyRetentionPeriodAsync(ModifySnapshotCopyRetentionPeriodRequest modifySnapshotCopyRetentionPeriodRequest, CancellationToken cancellationToken = default(CancellationToken));
 
        /// <summary>
        /// <para> Allows you to purchase reserved nodes. Amazon Redshift offers a predefined set of reserved node offerings. You can purchase one of
        /// the offerings. You can call the DescribeReservedNodeOfferings API to obtain the available reserved node offerings. You can call this API by
        /// providing a specific reserved node offering and the number of nodes you want to reserve. </para> <para> For more information about managing
        /// parameter groups, go to <a href="http://docs.aws.amazon.com/redshift/latest/mgmt/purchase-reserved-node-instance.html">Purchasing Reserved
        /// Nodes</a> in the <i>Amazon Redshift Management Guide</i> .
        /// 
        /// </para>
        /// </summary>
        /// 
        /// <param name="purchaseReservedNodeOfferingRequest">Container for the necessary parameters to execute the PurchaseReservedNodeOffering service
        /// method on AmazonRedshift.</param>
        /// 
        /// <returns>The response from the PurchaseReservedNodeOffering service method, as returned by AmazonRedshift.</returns>
        /// 
        /// <exception cref="T:Amazon.Redshift.Model.ReservedNodeAlreadyExistsException" />
        /// <exception cref="T:Amazon.Redshift.Model.ReservedNodeOfferingNotFoundException" />
        /// <exception cref="T:Amazon.Redshift.Model.ReservedNodeQuotaExceededException" />
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
		Task<PurchaseReservedNodeOfferingResponse> PurchaseReservedNodeOfferingAsync(PurchaseReservedNodeOfferingRequest purchaseReservedNodeOfferingRequest, CancellationToken cancellationToken = default(CancellationToken));
 
        /// <summary>
        /// <para> Reboots a cluster. This action is taken as soon as possible. It results in a momentary outage to the cluster, during which the
        /// cluster status is set to <c>rebooting</c> . A cluster event is created when the reboot is completed. Any pending cluster modifications (see
        /// ModifyCluster) are applied at this reboot. For more information about managing clusters, go to <a href="http://docs.aws.amazon.com/redshift/latest/mgmt/working-with-clusters.html">Amazon Redshift Clusters</a> in the <i>Amazon Redshift
        /// Management Guide</i> </para>
        /// </summary>
        /// 
        /// <param name="rebootClusterRequest">Container for the necessary parameters to execute the RebootCluster service method on
        /// AmazonRedshift.</param>
        /// 
        /// <returns>The response from the RebootCluster service method, as returned by AmazonRedshift.</returns>
        /// 
        /// <exception cref="T:Amazon.Redshift.Model.InvalidClusterStateException" />
        /// <exception cref="T:Amazon.Redshift.Model.ClusterNotFoundException" />
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
		Task<RebootClusterResponse> RebootClusterAsync(RebootClusterRequest rebootClusterRequest, CancellationToken cancellationToken = default(CancellationToken));
 
        /// <summary>
        /// <para> Sets one or more parameters of the specified parameter group to their default values and sets the source values of the parameters to
        /// "engine-default". To reset the entire parameter group specify the <i>ResetAllParameters</i> parameter. For parameter changes to take effect
        /// you must reboot any associated clusters. </para>
        /// </summary>
        /// 
        /// <param name="resetClusterParameterGroupRequest">Container for the necessary parameters to execute the ResetClusterParameterGroup service
        /// method on AmazonRedshift.</param>
        /// 
        /// <returns>The response from the ResetClusterParameterGroup service method, as returned by AmazonRedshift.</returns>
        /// 
        /// <exception cref="T:Amazon.Redshift.Model.InvalidClusterParameterGroupStateException" />
        /// <exception cref="T:Amazon.Redshift.Model.ClusterParameterGroupNotFoundException" />
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
		Task<ResetClusterParameterGroupResponse> ResetClusterParameterGroupAsync(ResetClusterParameterGroupRequest resetClusterParameterGroupRequest, CancellationToken cancellationToken = default(CancellationToken));
 
        /// <summary>
        /// <para> Creates a new cluster from a snapshot. Amazon Redshift creates the resulting cluster with the same configuration as the original
        /// cluster from which the snapshot was created, except that the new cluster is created with the default cluster security and parameter group.
        /// After Amazon Redshift creates the cluster you can use the ModifyCluster API to associate a different security group and different parameter
        /// group with the restored cluster. </para> <para> If a snapshot is taken of a cluster in VPC, you can restore it only in VPC. In this case,
        /// you must provide a cluster subnet group where you want the cluster restored. If snapshot is taken of a cluster outside VPC, then you can
        /// restore it only outside VPC.</para> <para> For more information about working with snapshots, go to <a href="http://docs.aws.amazon.com/redshift/latest/mgmt/working-with-snapshots.html">Amazon Redshift Snapshots</a> in the <i>Amazon Redshift
        /// Management Guide</i> .
        /// </para>
        /// </summary>
        /// 
        /// <param name="restoreFromClusterSnapshotRequest">Container for the necessary parameters to execute the RestoreFromClusterSnapshot service
        /// method on AmazonRedshift.</param>
        /// 
        /// <returns>The response from the RestoreFromClusterSnapshot service method, as returned by AmazonRedshift.</returns>
        /// 
        /// <exception cref="T:Amazon.Redshift.Model.InvalidElasticIpException" />
        /// <exception cref="T:Amazon.Redshift.Model.InvalidSubnetException" />
        /// <exception cref="T:Amazon.Redshift.Model.HsmConfigurationNotFoundException" />
        /// <exception cref="T:Amazon.Redshift.Model.ClusterSubnetGroupNotFoundException" />
        /// <exception cref="T:Amazon.Redshift.Model.InvalidClusterSubnetGroupStateException" />
        /// <exception cref="T:Amazon.Redshift.Model.ClusterAlreadyExistsException" />
        /// <exception cref="T:Amazon.Redshift.Model.InvalidVPCNetworkStateException" />
        /// <exception cref="T:Amazon.Redshift.Model.InvalidClusterSnapshotStateException" />
        /// <exception cref="T:Amazon.Redshift.Model.AccessToSnapshotDeniedException" />
        /// <exception cref="T:Amazon.Redshift.Model.InvalidRestoreException" />
        /// <exception cref="T:Amazon.Redshift.Model.UnauthorizedOperationException" />
        /// <exception cref="T:Amazon.Redshift.Model.InsufficientClusterCapacityException" />
        /// <exception cref="T:Amazon.Redshift.Model.NumberOfNodesQuotaExceededException" />
        /// <exception cref="T:Amazon.Redshift.Model.NumberOfNodesPerClusterLimitExceededException" />
        /// <exception cref="T:Amazon.Redshift.Model.ClusterSnapshotNotFoundException" />
        /// <exception cref="T:Amazon.Redshift.Model.ClusterQuotaExceededException" />
        /// <exception cref="T:Amazon.Redshift.Model.HsmClientCertificateNotFoundException" />
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
		Task<RestoreFromClusterSnapshotResponse> RestoreFromClusterSnapshotAsync(RestoreFromClusterSnapshotRequest restoreFromClusterSnapshotRequest, CancellationToken cancellationToken = default(CancellationToken));
 
        /// <summary>
        /// <para> Revokes an ingress rule in an Amazon Redshift security group for a previously authorized IP range or Amazon EC2 security group. To
        /// add an ingress rule, see AuthorizeClusterSecurityGroupIngress. For information about managing security groups, go to <a href="http://docs.aws.amazon.com/redshift/latest/mgmt/working-with-security-groups.html">Amazon Redshift Cluster Security Groups</a> in the
        /// <i>Amazon Redshift Management Guide</i> .
        /// </para>
        /// </summary>
        /// 
        /// <param name="revokeClusterSecurityGroupIngressRequest">Container for the necessary parameters to execute the
        /// RevokeClusterSecurityGroupIngress service method on AmazonRedshift.</param>
        /// 
        /// <returns>The response from the RevokeClusterSecurityGroupIngress service method, as returned by AmazonRedshift.</returns>
        /// 
        /// <exception cref="T:Amazon.Redshift.Model.InvalidClusterSecurityGroupStateException" />
        /// <exception cref="T:Amazon.Redshift.Model.AuthorizationNotFoundException" />
        /// <exception cref="T:Amazon.Redshift.Model.ClusterSecurityGroupNotFoundException" />
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
		Task<RevokeClusterSecurityGroupIngressResponse> RevokeClusterSecurityGroupIngressAsync(RevokeClusterSecurityGroupIngressRequest revokeClusterSecurityGroupIngressRequest, CancellationToken cancellationToken = default(CancellationToken));
 
        /// <summary>
        /// <para> Removes the ability of the specified AWS customer account to restore the specified snapshot. If the account is currently restoring
        /// the snapshot, the restore will run to completion. </para> <para> For more information about working with snapshots, go to <a href="http://docs.aws.amazon.com/redshift/latest/mgmt/working-with-snapshots.html">Amazon Redshift Snapshots</a> in the <i>Amazon Redshift
        /// Management Guide</i> .
        /// </para>
        /// </summary>
        /// 
        /// <param name="revokeSnapshotAccessRequest">Container for the necessary parameters to execute the RevokeSnapshotAccess service method on
        /// AmazonRedshift.</param>
        /// 
        /// <returns>The response from the RevokeSnapshotAccess service method, as returned by AmazonRedshift.</returns>
        /// 
        /// <exception cref="T:Amazon.Redshift.Model.AccessToSnapshotDeniedException" />
        /// <exception cref="T:Amazon.Redshift.Model.ClusterSnapshotNotFoundException" />
        /// <exception cref="T:Amazon.Redshift.Model.AuthorizationNotFoundException" />
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
		Task<RevokeSnapshotAccessResponse> RevokeSnapshotAccessAsync(RevokeSnapshotAccessRequest revokeSnapshotAccessRequest, CancellationToken cancellationToken = default(CancellationToken));
 
        /// <summary>
        /// <para> Rotates the encryption keys for a cluster. </para>
        /// </summary>
        /// 
        /// <param name="rotateEncryptionKeyRequest">Container for the necessary parameters to execute the RotateEncryptionKey service method on
        /// AmazonRedshift.</param>
        /// 
        /// <returns>The response from the RotateEncryptionKey service method, as returned by AmazonRedshift.</returns>
        /// 
        /// <exception cref="T:Amazon.Redshift.Model.InvalidClusterStateException" />
        /// <exception cref="T:Amazon.Redshift.Model.ClusterNotFoundException" />
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
		Task<RotateEncryptionKeyResponse> RotateEncryptionKeyAsync(RotateEncryptionKeyRequest rotateEncryptionKeyRequest, CancellationToken cancellationToken = default(CancellationToken));
    }
}
