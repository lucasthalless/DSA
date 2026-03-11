

/**
 * Leetcode 83 - Remove Duplicates from Sorted List
 * Definition for singly-linked list.
 * class ListNode {
 *     val: number
 *     next: ListNode | null
 *     constructor(val?: number, next?: ListNode | null) {
 *         this.val = (val===undefined ? 0 : val)
 *         this.next = (next===undefined ? null : next)
 *     }
 * }
 */

function deleteDuplicates(head: ListNode | null): ListNode | null {
    let currentNode = head?.next;
    if (head?.next) head.next = currentNode

    while(currentNode) {
        if (head.val == currentNode.val) {
            console.log("currentNode.next", currentNode.next)
            head.next = currentNode.next;
            currentNode = currentNode.next;
        } else if (currentNode.val == currentNode.next?.val) {
            currentNode.next = currentNode.next.next
        } else {
            currentNode = currentNode.next
        }
    }

    return head
};
